using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Bewildered.SmartLibrary;
using System.IO;
using System;
using UnityEditor.Build.Pipeline;
using UnityEditor.Build.Pipeline.Injector;
using UnityEditor.Build.Pipeline.Interfaces;
using UnityEditor.Build.Pipeline.Tasks;
using UnityEditor.Build.Pipeline.Utilities;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using TagInfo = System.Collections.Generic.Dictionary<Bewildered.SmartLibrary.TagRule.TagRuleType, string>;
using URS;
using YooAsset.Utility;
using System.Linq;
using YooAsset;
using UnityEditor.Build.Content;
using BuildCompression = UnityEngine.BuildCompression;
using UnityEditor.Search;
using Context = System.Collections.Generic.Dictionary<string, object>;
using MHLab.Patch.Core.Utilities;

public class URSBundleBuildParameters : BundleBuildParameters
{

    public URSBundleBuildParameters(BuildTarget target, BuildTargetGroup group, string outputFolder) : base(target, group, outputFolder)
    {
        UseCache = true;

        ContiguousBundles = true;

        DisableVisibleSubAssetRepresentations = false;

        BundleCompression = BuildCompression.LZ4Runtime;

        ContentBuildFlags = ContentBuildFlags.None;

        this.WriteLinkXML = true;
    }


    public override BuildCompression GetCompressionForIdentifier(string identifier)
    {
        return base.GetCompressionForIdentifier(identifier);
    }
}

public class BundleInfo
{
    public string bundleName;
    public List<string> paths;
    public bool isShareBundle = false;

    public BundleInfo(string bundleName,List<string> paths,bool isShareBundle)
    {
        this.bundleName = bundleName;
        this.paths = paths;
        this.isShareBundle = isShareBundle;
    }
    //public HashSet<string> tags = new HashSet<string>();
}
public class GlobalBundleExtraAsset 
{
    public Dictionary<string, HashSet<string>> extraAssets = new Dictionary<string, HashSet<string>>();

    public void AddBundleExtraAsset(string bundleName, string assetPath) 
    {
        HashSet<string> assetSets = null;
        if (extraAssets.ContainsKey(bundleName))
        {
            assetSets = extraAssets[bundleName];
        }
        else 
        { 
            assetSets= new HashSet<string>();
            extraAssets[bundleName]= assetSets;
        }
        assetSets.Add(assetPath);
    }

    public void TryMergeExtraAssets(BundleInfo bundleInfo) 
    {
        if (extraAssets.TryGetValue(bundleInfo.bundleName, out var sets))
        {
            foreach (var assetPath in sets)
            {
                if (!bundleInfo.paths.Contains(assetPath))
                {
                    bundleInfo.paths.Add(assetPath);    
                }
            }
        }
    }
}

public class AssetWithBundle
{
    public AssetMeta asset;
    public string mainBundleName;
    public List<string> dependencyBundleNames;
}


public class AssetInfo
{
    public string assetPath;
    public HashSet<string> customTag; // 
                                      //  public string resourceGroup;
    public bool isMain = false;
    public int refrenceCount = 0;

    public List<string> shareReferencedMainAssets = null; 
    public List<string> mainAssetDependencys = null;
    public HashSet<string> assetBundleNames = null;

    public string shareCombineAssetBundleName = null;

    public string optimizedShareAssetBundleName = null;

    private  bool forceNoBundleName = false;


    public void AddShareReferencedMainAssets(string path) 
    {

        if (shareReferencedMainAssets == null) {
            shareReferencedMainAssets= new List<string>();
        }
        shareReferencedMainAssets.Add(path);
    }
    public bool HasAssetBundleName()
    {
        if (forceNoBundleName)
        {
            return false;
        }
        if (isMain)
        {
            return true;
        }
        else
        {
            return refrenceCount > 1;
        }
    }

    public void CancelBundleName(GlobalBundleExtraAsset globalBundleExtraAsset)
    {
        if (IsShareAsset()) 
        {
            forceNoBundleName = true;
            foreach (var mainAbName in assetBundleNames)
            {
               // Debug.Log($"取消{assetPath}的包名,进入到 bundle {mainAbName}" );
                globalBundleExtraAsset.AddBundleExtraAsset(mainAbName, assetPath);
            }
        }
    }

    public static string FormatBundleName(string orign) 
    { 
        return orign.ToLower().Replace(" ", "_").Replace('\\', '_').Replace('/', '_').Replace('(', '_').Replace(')', '_');
    }
    public string GetAssetBundleName()
    {

        if (isMain)
        {
            return assetBundleNames.ToArray()[0];
        }
        else
        {
            if (!string.IsNullOrEmpty(optimizedShareAssetBundleName))
            {
                return optimizedShareAssetBundleName;
            }
            if (!string.IsNullOrEmpty(shareCombineAssetBundleName))
            {
               return shareCombineAssetBundleName;
            }
            var abNames = assetBundleNames.ToList();
            abNames.Sort();
            string combineAbNames = string.Join("@@", abNames);
            var hash = HashUtility.StringSHA1(combineAbNames);
           //Debug.LogError("assetPath "+ assetPath +"  hash "+hash + " name " + combineAbNames);
            return $"share_{hash}.bundle";
           // return $"share_{combineAbNames}.bundle";
        }
    }

    public bool IsShareAsset() 
    {
        if (isMain)
        {
            return false;
        }
        else 
        {
            return refrenceCount > 1;
        }
    }
}
    public class BuildTaskBuidBundle : BuildTask
{
    public override void BeginTask()
    {
        base.BeginTask();
        BuildBundleResource();
        this.FinishTask();
    }
    
    public  ReturnCode BuildBundleResource()
    {
        #region check save scenes
        var dirtyScenes = new List<Scene>();

        for (int i = 0; i < SceneManager.sceneCount; ++i)
        {
            var scene = SceneManager.GetSceneAt(i);
            if (scene.isDirty)
            {
                dirtyScenes.Add(scene);
            }
        }

        if (dirtyScenes.Count > 0)
        {
            if (EditorUtility.DisplayDialog(
                "Unsaved Scenes", "Modified Scenes must be saved to continue.",
                "Save and Continue", "Cancel"))
            {
                EditorSceneManager.SaveScenes(dirtyScenes.ToArray());
            }
            else
            {
                return ReturnCode.UnsavedChanges;
            }
        }
        #endregion check save scenes


        var buildTasks = new List<IBuildTask>();

        // Setup
        //  buildTasks.Add(new SwitchToBuildPlatform());
        buildTasks.Add(new RebuildSpriteAtlasCache());

        buildTasks.Add(new BuildPlayerScripts());
        buildTasks.Add(new PostScriptsCallback());
        // Dependency
        buildTasks.Add(new CalculateSceneDependencyData());
        buildTasks.Add(new CalculateAssetDependencyData());
#if SPRITE_STRIP
        buildTasks.Add(new BuildTaskStripSpriteInAtlas());
#endif
        buildTasks.Add(new StripUnusedSpriteSources());
        buildTasks.Add(new CreateBuiltInShadersBundle("unity_buildin_shader.bundle"));
        buildTasks.Add(new CreateMonoScriptBundle("unity_monoscript.bundle"));

        buildTasks.Add(new PostDependencyCallback());

        // Packing
        buildTasks.Add(new GenerateBundlePacking());
        buildTasks.Add(new UpdateBundleObjectLayout());
        buildTasks.Add(new GenerateBundleCommands());
        buildTasks.Add(new GenerateSubAssetPathMaps());
        buildTasks.Add(new GenerateBundleMaps());
        buildTasks.Add(new PostPackingCallback());

        // Writing
        buildTasks.Add(new WriteSerializedFiles());
        buildTasks.Add(new ArchiveAndCompressBundles());
        //var bundleDependencyTask = new GenerateBundleDependencyTask();
       // buildTasks.Add(bundleDependencyTask);
        buildTasks.Add(new GenerateLinkXml());
        buildTasks.Add(new PostWritingCallback());

        var extractData = new ExtractDataTask();
        buildTasks.Add(extractData);
        var generation = new BuildLayoutGenerationTask();
        buildTasks.Add(generation);
        var checkHash = new BuidTaskCheckBundleHash();
        buildTasks.Add(checkHash);
        var targetGroup = BuildPipeline.GetBuildTargetGroup(UnityEditor.EditorUserBuildSettings.activeBuildTarget);
        var target = UnityEditor.EditorUserBuildSettings.activeBuildTarget;
        var outFolder = Build.GetTempBundleOutDirectoryPath();
        var buildParams = new URSBundleBuildParameters(
               target,
               targetGroup,
               outFolder
         );
        var bundleInfo = GetData<Dictionary<string, BundleInfo>>(CONTEXT_BUNDLE_INFO);
        var assetBundleBuilds = new List<AssetBundleBuild>();
        foreach (var kv in bundleInfo)
        {
            var assetsInputDef = new AssetBundleBuild();
            assetsInputDef.assetBundleName = kv.Key;
            kv.Value.paths.Sort();
            assetsInputDef.assetNames = kv.Value.paths.ToArray();
            assetBundleBuilds.Add(assetsInputDef);
        }
        var exitCode = ContentPipeline.BuildAssetBundles(buildParams, new BundleBuildContent(assetBundleBuilds), out var results, buildTasks);
        if (exitCode < ReturnCode.Success)
        {
            Debug.LogError("extir code" + exitCode);
            return ReturnCode.Error;
        }

        var manifest = ScriptableObject.CreateInstance<UnityEngine.Build.Pipeline.CompatibilityAssetBundleManifest>();
        manifest.SetResults(results.BundleInfos);
        var manifestFileName = outFolder + "/all.manifest";
        if (File.Exists(manifestFileName))
        {
            File.Delete(manifestFileName);
        }
        File.WriteAllText(manifestFileName, manifest.ToString());
        SetData(CONTEXT_BUNDLE_RESULT, results);
        SetData(CONTEXT_BUNDLE_LAYOUT, generation.LayoutLookupTables);
        SetData(CONTEXT_VERSION_BUNDLE_HASH, checkHash.BundleHash);
        return ReturnCode.Success;
    }
  
}
