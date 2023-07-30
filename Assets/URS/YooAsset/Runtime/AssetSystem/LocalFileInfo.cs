using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YooAsset;

namespace URS
{
   
    public class UpdateEntry
    {
        public FileMeta RemoteFileMeta { get; private set; }

        public string _remoteDownloadURL;

        public PatchItemVersion PatchItemVersion { get; private set; }
        private EnumHardiskDirectoryType _patchDirectoryType = EnumHardiskDirectoryType.Invalid;
        private FileMeta _patchFileMetaCandidate = null;

        private string _targetSaveFilePath;
        private string _downloadTempSavePath;

        public bool IsPatch()
        {
            return PatchItemVersion != null;
        }

        public bool NeedUnzip() 
        {
            return _patchDirectoryType == EnumHardiskDirectoryType.BuildIn;
        }

        public string GetRemoteDownloadURL()
        {
            return _remoteDownloadURL;
        }

        public string GetFinalPersistentDownloadSavePath() 
        {
            return _targetSaveFilePath;
        }

        public string GetPatchTemp()
        {
            var pathRelativePath = $"{GetRelativePath()}---{PatchItemVersion.FromHashCode}---{PatchItemVersion.ToHashCode}.patch.temp";
            return URSFileSystem.GetDownloadFolderPath(pathRelativePath);
        }

        public uint GetRemoteDownloadFileHash() 
        {
            if (PatchItemVersion != null)
            {
                return PatchItemVersion.Hash;
            }
            else
            {
                return RemoteFileMeta.Hash;
            }
        }

        public long GetRemoteDownloadFileSize()
        {
            if (PatchItemVersion != null) 
            { 
                return PatchItemVersion.SizeBytes;
            }
            else
            {
                return RemoteFileMeta.SizeBytes;
            }
        }
        public string GetRelativePath() 
        {
            return RemoteFileMeta.RelativePath;
        }
        public string GetDownloadTempSaveFilePath() 
        {
           return _downloadTempSavePath;
        }

        public FileMeta GetPatchFileMetaCandidate()
        {
            return _patchFileMetaCandidate;
        }

        public UpdateEntry(FileMeta remoteFileMeta, string remoteVersionRoot, PatchItemVersion patchItem =null,string remotePatchRoot=null,FileMeta patchFileMetaCandidate=null, EnumHardiskDirectoryType patchDirectoryType= EnumHardiskDirectoryType.Invalid
            ) 
        {
            RemoteFileMeta = remoteFileMeta;
            PatchItemVersion = patchItem;
            _patchDirectoryType = patchDirectoryType;
            _targetSaveFilePath = URSFileSystem.GetDownloadFolderPath(GetRelativePath());
            _patchFileMetaCandidate = patchFileMetaCandidate;
            if (PatchItemVersion != null)
            {
                var pathRelativePath = $"{GetRelativePath()}---{PatchItemVersion.FromHashCode}---{PatchItemVersion.ToHashCode}.patch";
                _downloadTempSavePath = URSFileSystem.GetDownloadTempPath(pathRelativePath);
                _remoteDownloadURL = $"{remotePatchRoot}/{pathRelativePath}";
            }
            else 
            {
                _downloadTempSavePath = URSFileSystem.GetDownloadTempPath(GetRelativePath());
                _remoteDownloadURL = $"{remoteVersionRoot}/{GetRelativePath()}"; 
            }
        }
    }

    public class UnzipEntry
    {
        public string HardiskSavePath;

        public string HardiskSourcePath;

        public FileMeta StreamFileMeta;

        public uint Hash 
        {
            get
            {
                return StreamFileMeta.Hash;
            }
        }
        /// <summary>
        /// 文件大小
        /// </summary>
        public long SizeBytes
        {
            get
            {
                return StreamFileMeta.SizeBytes;

            }
        }

        public string GetRelativePath()
        {
            return StreamFileMeta.RelativePath;
        }

        public UnzipEntry(FileMeta streamFileMeta) 
        {
            StreamFileMeta = streamFileMeta;
            HardiskSavePath = URSFileSystem.PersistentDownloadFolder.GetFileHardiskPath(StreamFileMeta.RelativePath);
            HardiskSourcePath = URSFileSystem.BuildInFolder.GetFileHardiskPath(StreamFileMeta.RelativePath);
            HardiskSourcePath = AssetPathHelper.ConvertToWWWPath(HardiskSourcePath);
        }

        public Action<Unziper> OnFinish = null;
    
    }

    /// <summary>
    ///  优化：结构体
    /// </summary>
    public class HardiskFileSearchResult
    {
        // <summary>
        /// 本地存储的路径。永远不为空，当RemoteDownloadURL 为null时，HardiskPath 为资源保存的实际路径，否则HardiskPath 为下载之后的保存路径
        /// </summary>
        public string HardiskPath;

        public string OrignRelativePath;

        //  public string RemoteDownloadURL;

        //  public string RemoteFallBackDownloadURL;

        public UpdateEntry UpdateEntry; // 远端下在信息
        /// <summary>
        /// 用于查询的fileMeta
        /// </summary>
        public FileMeta FileMeta;

        /// <summary>
        /// 快捷快捷，记录HardiskPath字段所属的文件夹类型
        /// </summary>
        public EnumHardiskDirectoryType HardiskDirectoryType = EnumHardiskDirectoryType.Invalid;


        public static HardiskFileSearchResult EMPTY;

        static HardiskFileSearchResult()
        {
            EMPTY = new HardiskFileSearchResult(string.Empty);
        }
        /// <summary>
        /// 文件哈希值
        /// </summary>
        public uint Hash
        {
            get
            {
                if (FileMeta == null)
                    return 0;
                else
                    return FileMeta.Hash;
            }
        }

       ///// <summary>
       ///// 校验的CRC
       ///// </summary>
       //public string CRC
       //{
       //    get
       //    {
       //        if (FileMeta == null)
       //            return string.Empty;
       //        else
       //            return FileMeta.CRC;
       //    }
       //}


        /// <summary>
        /// 文件大小
        /// </summary>
        public long SizeBytes
        {
            get
            {
                if (FileMeta == null)
                    return 0;
                else
                    return FileMeta.SizeBytes;
            }
        }
        /// <summary>
		/// 是否为加密文件
		/// </summary>
		public bool IsEncrypted
        {
            get
            {
                if (FileMeta == null)
                    return false;
                else
                    return FileMeta.IsEncrypted;
            }
        }

        /// <summary>
        /// 是否为原生文件
        /// </summary>
        public bool IsUnityBundle
        {
            get
            {
                if (FileMeta == null)
                    return false;
                else
                    return FileMeta.IsUnityBundle;
            }
        }
        public bool IsLocalFileExist()
        {
            return UpdateEntry==null; 
        }

        public bool IsValidFile()
        {
            return this.FileMeta != null;
        }

        public string GetHardDiskSavePath()
        {
            return HardiskPath;
        }
        /// <summary>
        /// 需要远程下载
        /// </summary>
        /// <param name="fileMeta"></param>
        /// <param name="hardiskPath"></param>
        /// <param name="updateEntry"></param>
        /// <param name="hardiskDirectoryType"></param>
        public HardiskFileSearchResult(
            FileMeta fileMeta,
            UpdateEntry updateEntry
            )
        {
            this.FileMeta = fileMeta;
            OrignRelativePath = fileMeta.RelativePath;
            HardiskPath = URSFileSystem.GetDownloadFolderPath(OrignRelativePath);
            UpdateEntry=  updateEntry;
            HardiskDirectoryType = EnumHardiskDirectoryType.Invalid;
        }
        /// <summary>
        /// 不需要远程下载的本地合法文件
        /// </summary>
        /// <param name="fileMeta"></param>
        /// <param name="hardiskPath"></param>
        /// <param name="hardiskDirectoryType"></param>
        public HardiskFileSearchResult(
           FileMeta fileMeta,
           string hardiskPath,
           EnumHardiskDirectoryType hardiskDirectoryType
            )
        {
            this.FileMeta = fileMeta;
            OrignRelativePath = fileMeta.RelativePath;
            HardiskPath = hardiskPath;
            UpdateEntry = null;
            HardiskDirectoryType = hardiskDirectoryType;
        }
        /// <summary>
        /// 不合法的文件
        /// </summary>
        /// <param name="orignRelativePath"></param>
        /// <param name="hardiskPath"></param>
        /// <param name="hardiskDirectoryType"></param>
        public HardiskFileSearchResult(
          string orignRelativePath
           )
        {
            OrignRelativePath = orignRelativePath;
            HardiskPath = null;
            this.FileMeta = null;
            UpdateEntry = null;
            HardiskDirectoryType = EnumHardiskDirectoryType.Invalid;
        }
    }
}

