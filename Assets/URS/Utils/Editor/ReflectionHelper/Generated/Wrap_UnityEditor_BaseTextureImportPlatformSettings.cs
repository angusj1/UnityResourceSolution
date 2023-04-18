//This file was automatically generated by kuroneko.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NinjaBeats.ReflectionHelper
{
	public partial struct UnityEditor_BaseTextureImportPlatformSettings
	{
		
		/// <summary>
		/// <see cref="UnityEditor.BaseTextureImportPlatformSettings"/>
		/// </summary>
		public static Type __type__ { get; } = EditorUtils.GetTypeByFullName("UnityEditor.BaseTextureImportPlatformSettings");
		
		
		public bool textureTypeHasMultipleDifferentValues
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (bool)(__textureTypeHasMultipleDifferentValues?.GetValue(__self__));
		}
		
		public UnityEditor.TextureImporterType textureType
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (UnityEditor.TextureImporterType)(__textureType?.GetValue(__self__));
		}
		
		public UnityEditor.SpriteImportMode spriteImportMode
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (UnityEditor.SpriteImportMode)(__spriteImportMode?.GetValue(__self__));
		}
		
		public UnityEditor_TextureImportPlatformSettingsData model
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => new UnityEditor_TextureImportPlatformSettingsData(__model?.GetValue(__self__));
		}
		
		public int GetTargetCount()
		{
			var __result__ = __GetTargetCount?.Invoke(__self__, System.Array.Empty<object>());
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public bool ShowPresetSettings()
		{
			var __result__ = __ShowPresetSettings?.Invoke(__self__, System.Array.Empty<object>());
			return __result__ != null ? (bool)(__result__) : default;
		}
		
		public UnityEditor.TextureImporterSettings GetImporterSettings(int i)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = i;
			var __result__ = __GetImporterSettings?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (UnityEditor.TextureImporterSettings)(__result__) : default;
		}
		
		public bool IsSourceTextureHDR(int i)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = i;
			var __result__ = __IsSourceTextureHDR?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (bool)(__result__) : default;
		}
		
		public bool DoesSourceTextureHaveAlpha(int i)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = i;
			var __result__ = __DoesSourceTextureHaveAlpha?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (bool)(__result__) : default;
		}
		
		public UnityEditor.TextureImporterPlatformSettings GetPlatformTextureSettings(int i, string name)
		{
			var __pool__ = FixedArrayPool<object>.Shared(2);
			var __params__ = __pool__.Rent();
			__params__[0] = i;
			__params__[1] = name;
			var __result__ = __GetPlatformTextureSettings?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (UnityEditor.TextureImporterPlatformSettings)(__result__) : default;
		}
		
		public UnityEditor_BaseTextureImportPlatformSettings GetDefaultImportSettings()
		{
			var __result__ = __GetDefaultImportSettings?.Invoke(__self__, System.Array.Empty<object>());
			return __result__ != null ? new UnityEditor_BaseTextureImportPlatformSettings(__result__) : default;
		}
		
		public void SetPlatformTextureSettings(int i, UnityEditor.TextureImporterPlatformSettings platformSettings)
		{
			var __pool__ = FixedArrayPool<object>.Shared(2);
			var __params__ = __pool__.Rent();
			__params__[0] = i;
			__params__[1] = platformSettings;
			__SetPlatformTextureSettings?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
		}
		
		public void Init()
		{
			__Init?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public void Sync()
		{
			__Sync?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public void Apply()
		{
			__Apply?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public static Array GetBuildPlayerValidPlatforms()
		{
			var __result__ = __GetBuildPlayerValidPlatforms?.Invoke(null, System.Array.Empty<object>());
			return __result__ != null ? (Array)(__result__) : default;
		}
		
		public static void ShowPlatformSpecificSettings(System.Collections.IList platformSettings)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = platformSettings;
			__ShowPlatformSpecificSettings?.Invoke(null, __params__);
			__pool__.Return(__params__);
		}
		
		public static void ShowPlatformSpecificSettings(System.Collections.IList platformSettings, int selected)
		{
			var __pool__ = FixedArrayPool<object>.Shared(2);
			var __params__ = __pool__.Rent();
			__params__[0] = platformSettings;
			__params__[1] = selected;
			__ShowPlatformSpecificSettings__2?.Invoke(null, __params__);
			__pool__.Return(__params__);
		}
		
		public static void SyncPlatformSettings(System.Collections.IList platformSettings)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = platformSettings;
			__SyncPlatformSettings?.Invoke(null, __params__);
			__pool__.Return(__params__);
		}
		
		public static void InitPlatformSettings(System.Collections.IList platformSettings)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = platformSettings;
			__InitPlatformSettings?.Invoke(null, __params__);
			__pool__.Return(__params__);
		}
		
		public static void ApplyPlatformSettings(System.Collections.IList platformSettings)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = platformSettings;
			__ApplyPlatformSettings?.Invoke(null, __params__);
			__pool__.Return(__params__);
		}
		
		public UnityEditor_BaseTextureImportPlatformSettings(object __self__) => this.__self__ = __self__ as object;
		public object __self__;
		public bool __valid__
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => __self__ != null && __type__ != null;
		}
		
		private static PropertyInfo ___textureTypeHasMultipleDifferentValues;
		private static PropertyInfo __textureTypeHasMultipleDifferentValues
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___textureTypeHasMultipleDifferentValues ??= __type__?.GetProperty("textureTypeHasMultipleDifferentValues", (BindingFlags)(-1));
		}
		
		private static PropertyInfo ___textureType;
		private static PropertyInfo __textureType
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___textureType ??= __type__?.GetProperty("textureType", (BindingFlags)(-1));
		}
		
		private static PropertyInfo ___spriteImportMode;
		private static PropertyInfo __spriteImportMode
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___spriteImportMode ??= __type__?.GetProperty("spriteImportMode", (BindingFlags)(-1));
		}
		
		private static PropertyInfo ___model;
		private static PropertyInfo __model
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___model ??= __type__?.GetProperty("model", (BindingFlags)(-1));
		}
		
		private static MethodInfo ___GetTargetCount;
		private static MethodInfo __GetTargetCount
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___GetTargetCount ??= __type__?.GetMethodInfoByParameterTypeNames("GetTargetCount");
		}
		
		private static MethodInfo ___ShowPresetSettings;
		private static MethodInfo __ShowPresetSettings
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___ShowPresetSettings ??= __type__?.GetMethodInfoByParameterTypeNames("ShowPresetSettings");
		}
		
		private static MethodInfo ___GetImporterSettings;
		private static MethodInfo __GetImporterSettings
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___GetImporterSettings ??= __type__?.GetMethodInfoByParameterTypeNames("GetImporterSettings", "System.Int32");
		}
		
		private static MethodInfo ___IsSourceTextureHDR;
		private static MethodInfo __IsSourceTextureHDR
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___IsSourceTextureHDR ??= __type__?.GetMethodInfoByParameterTypeNames("IsSourceTextureHDR", "System.Int32");
		}
		
		private static MethodInfo ___DoesSourceTextureHaveAlpha;
		private static MethodInfo __DoesSourceTextureHaveAlpha
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___DoesSourceTextureHaveAlpha ??= __type__?.GetMethodInfoByParameterTypeNames("DoesSourceTextureHaveAlpha", "System.Int32");
		}
		
		private static MethodInfo ___GetPlatformTextureSettings;
		private static MethodInfo __GetPlatformTextureSettings
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___GetPlatformTextureSettings ??= __type__?.GetMethodInfoByParameterTypeNames("GetPlatformTextureSettings", "System.Int32", "System.String");
		}
		
		private static MethodInfo ___GetDefaultImportSettings;
		private static MethodInfo __GetDefaultImportSettings
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___GetDefaultImportSettings ??= __type__?.GetMethodInfoByParameterTypeNames("GetDefaultImportSettings");
		}
		
		private static MethodInfo ___SetPlatformTextureSettings;
		private static MethodInfo __SetPlatformTextureSettings
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___SetPlatformTextureSettings ??= __type__?.GetMethodInfoByParameterTypeNames("SetPlatformTextureSettings", "System.Int32", "UnityEditor.TextureImporterPlatformSettings");
		}
		
		private static MethodInfo ___Init;
		private static MethodInfo __Init
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___Init ??= __type__?.GetMethodInfoByParameterTypeNames("Init");
		}
		
		private static MethodInfo ___Sync;
		private static MethodInfo __Sync
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___Sync ??= __type__?.GetMethodInfoByParameterTypeNames("Sync");
		}
		
		private static MethodInfo ___Apply;
		private static MethodInfo __Apply
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___Apply ??= __type__?.GetMethodInfoByParameterTypeNames("Apply");
		}
		
		private static MethodInfo ___GetBuildPlayerValidPlatforms;
		private static MethodInfo __GetBuildPlayerValidPlatforms
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___GetBuildPlayerValidPlatforms ??= __type__?.GetMethodInfoByParameterTypeNames("GetBuildPlayerValidPlatforms");
		}
		
		private static MethodInfo ___ShowPlatformSpecificSettings;
		private static MethodInfo __ShowPlatformSpecificSettings
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___ShowPlatformSpecificSettings ??= __type__?.GetMethodInfoByParameterTypeNames("ShowPlatformSpecificSettings", "System.Collections.Generic.List`1[[UnityEditor.BaseTextureImportPlatformSettings, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]");
		}
		
		private static MethodInfo ___ShowPlatformSpecificSettings__2;
		private static MethodInfo __ShowPlatformSpecificSettings__2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___ShowPlatformSpecificSettings__2 ??= __type__?.GetMethodInfoByParameterTypeNames("ShowPlatformSpecificSettings", "System.Collections.Generic.List`1[[UnityEditor.BaseTextureImportPlatformSettings, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]", "System.Int32");
		}
		
		private static MethodInfo ___SyncPlatformSettings;
		private static MethodInfo __SyncPlatformSettings
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___SyncPlatformSettings ??= __type__?.GetMethodInfoByParameterTypeNames("SyncPlatformSettings", "System.Collections.Generic.List`1[[UnityEditor.BaseTextureImportPlatformSettings, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]");
		}
		
		private static MethodInfo ___InitPlatformSettings;
		private static MethodInfo __InitPlatformSettings
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___InitPlatformSettings ??= __type__?.GetMethodInfoByParameterTypeNames("InitPlatformSettings", "System.Collections.Generic.List`1[[UnityEditor.BaseTextureImportPlatformSettings, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]");
		}
		
		private static MethodInfo ___ApplyPlatformSettings;
		private static MethodInfo __ApplyPlatformSettings
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___ApplyPlatformSettings ??= __type__?.GetMethodInfoByParameterTypeNames("ApplyPlatformSettings", "System.Collections.Generic.List`1[[UnityEditor.BaseTextureImportPlatformSettings, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]");
		}
	}
}