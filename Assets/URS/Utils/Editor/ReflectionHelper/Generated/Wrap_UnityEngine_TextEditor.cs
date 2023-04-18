//This file was automatically generated by kuroneko.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NinjaBeats.ReflectionHelper
{
	public partial struct UnityEngine_TextEditor
	{
		
		/// <summary>
		/// <see cref="UnityEngine.TextEditor"/>
		/// </summary>
		public static Type __type__ { get; } = EditorUtils.GetTypeByFullName("UnityEngine.TextEditor");
		
		
		public UnityEngine.Rect localPosition
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (UnityEngine.Rect)(__localPosition?.GetValue(__self__));
		}
		
		public bool m_HasFocus
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (bool)(__m_HasFocus?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_HasFocus?.SetValue(__self__, value);
		}
		
		public UnityEngine.GUIContent m_Content
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (UnityEngine.GUIContent)(__m_Content?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_Content?.SetValue(__self__, value);
		}
		
		public UnityEngine.Rect m_Position
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (UnityEngine.Rect)(__m_Position?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_Position?.SetValue(__self__, value);
		}
		
		public int m_CursorIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (int)(__m_CursorIndex?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_CursorIndex?.SetValue(__self__, value);
		}
		
		public int m_SelectIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (int)(__m_SelectIndex?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_SelectIndex?.SetValue(__self__, value);
		}
		
		public bool m_RevealCursor
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (bool)(__m_RevealCursor?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_RevealCursor?.SetValue(__self__, value);
		}
		
		public bool m_MouseDragSelectsWholeWords
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (bool)(__m_MouseDragSelectsWholeWords?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_MouseDragSelectsWholeWords?.SetValue(__self__, value);
		}
		
		public int m_DblClickInitPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (int)(__m_DblClickInitPos?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_DblClickInitPos?.SetValue(__self__, value);
		}
		
		public UnityEngine.TextEditor.DblClickSnapping m_DblClickSnap
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (UnityEngine.TextEditor.DblClickSnapping)(__m_DblClickSnap?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_DblClickSnap?.SetValue(__self__, value);
		}
		
		public bool m_bJustSelected
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (bool)(__m_bJustSelected?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_bJustSelected?.SetValue(__self__, value);
		}
		
		public int m_iAltCursorPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (int)(__m_iAltCursorPos?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __m_iAltCursorPos?.SetValue(__self__, value);
		}
		
		public string oldText
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (string)(__oldText?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __oldText?.SetValue(__self__, value);
		}
		
		public int oldPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (int)(__oldPos?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __oldPos?.SetValue(__self__, value);
		}
		
		public int oldSelectPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (int)(__oldSelectPos?.GetValue(__self__));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __oldSelectPos?.SetValue(__self__, value);
		}
		
		public static System.Collections.IDictionary s_Keyactions
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (System.Collections.IDictionary)(__s_Keyactions?.GetValue(null));
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => __s_Keyactions?.SetValue(null, value);
		}
		
		public void ClearCursorPos()
		{
			__ClearCursorPos?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public void GrabGraphicalCursorPos()
		{
			__GrabGraphicalCursorPos?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public bool HandleKeyEvent(UnityEngine.Event e, bool textIsReadOnly)
		{
			var __pool__ = FixedArrayPool<object>.Shared(2);
			var __params__ = __pool__.Rent();
			__params__[0] = e;
			__params__[1] = textIsReadOnly;
			var __result__ = __HandleKeyEvent?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (bool)(__result__) : default;
		}
		
		public int IndexOfEndOfLine(int startIndex)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = startIndex;
			var __result__ = __IndexOfEndOfLine?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift)
		{
			var __pool__ = FixedArrayPool<object>.Shared(2);
			var __params__ = __pool__.Rent();
			__params__[0] = cursorPosition;
			__params__[1] = shift;
			__MoveCursorToPosition_Internal?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
		}
		
		public int GetGraphicalLineStart(int p)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = p;
			var __result__ = __GetGraphicalLineStart?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public int GetGraphicalLineEnd(int p)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = p;
			var __result__ = __GetGraphicalLineEnd?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public int FindNextSeperator(int startPos)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = startPos;
			var __result__ = __FindNextSeperator?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public int FindPrevSeperator(int startPos)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = startPos;
			var __result__ = __FindPrevSeperator?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public object ClassifyChar(int index)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = index;
			var __result__ = __ClassifyChar?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (object)(__result__) : default;
		}
		
		public int FindEndOfPreviousWord(int p)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = p;
			var __result__ = __FindEndOfPreviousWord?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public int FindEndOfClassification(int p, object dir)
		{
			var __pool__ = FixedArrayPool<object>.Shared(2);
			var __params__ = __pool__.Rent();
			__params__[0] = p;
			__params__[1] = dir;
			var __result__ = __FindEndOfClassification?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public void UpdateScrollOffset()
		{
			__UpdateScrollOffset?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public bool PerformOperation(object operation, bool textIsReadOnly)
		{
			var __pool__ = FixedArrayPool<object>.Shared(2);
			var __params__ = __pool__.Rent();
			__params__[0] = operation;
			__params__[1] = textIsReadOnly;
			var __result__ = __PerformOperation?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (bool)(__result__) : default;
		}
		
		public UnityEngine.Rect[] GetHyperlinksRect()
		{
			var __result__ = __GetHyperlinksRect?.Invoke(__self__, System.Array.Empty<object>());
			return __result__ != null ? (UnityEngine.Rect[])(__result__) : default;
		}
		
		public static string ReplaceNewlinesWithSpaces(string value)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = value;
			var __result__ = __ReplaceNewlinesWithSpaces?.Invoke(null, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (string)(__result__) : default;
		}
		
		public static void MapKey(string key, object action)
		{
			var __pool__ = FixedArrayPool<object>.Shared(2);
			var __params__ = __pool__.Rent();
			__params__[0] = key;
			__params__[1] = action;
			__MapKey?.Invoke(null, __params__);
			__pool__.Return(__params__);
		}
		
		public void InitKeyActions()
		{
			__InitKeyActions?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public void OnDetectFocusChange()
		{
			__OnDetectFocusChange?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public void OnCursorIndexChange()
		{
			__OnCursorIndexChange?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public void OnSelectIndexChange()
		{
			__OnSelectIndexChange?.Invoke(__self__, System.Array.Empty<object>());
		}
		
		public void ClampTextIndex(ref int index)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = index;
			__ClampTextIndex?.Invoke(__self__, __params__);
			index = (int)(__params__[0]);
			__pool__.Return(__params__);
		}
		
		public void EnsureValidCodePointIndex(ref int index)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = index;
			__EnsureValidCodePointIndex?.Invoke(__self__, __params__);
			index = (int)(__params__[0]);
			__pool__.Return(__params__);
		}
		
		public bool IsValidCodePointIndex(int index)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = index;
			var __result__ = __IsValidCodePointIndex?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (bool)(__result__) : default;
		}
		
		public int PreviousCodePointIndex(int index)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = index;
			var __result__ = __PreviousCodePointIndex?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public int NextCodePointIndex(int index)
		{
			var __pool__ = FixedArrayPool<object>.Shared(1);
			var __params__ = __pool__.Rent();
			__params__[0] = index;
			var __result__ = __NextCodePointIndex?.Invoke(__self__, __params__);
			__pool__.Return(__params__);
			return __result__ != null ? (int)(__result__) : default;
		}
		
		public UnityEngine_TextEditor(object __self__) => this.__self__ = __self__ as object;
		public object __self__;
		public bool __valid__
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => __self__ != null && __type__ != null;
		}
		public UnityEngine.TextEditor __super__
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (UnityEngine.TextEditor)(__self__);
		}
		
		private static FieldInfo ___m_HasFocus;
		private static FieldInfo __m_HasFocus
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_HasFocus ??= __type__?.GetField("m_HasFocus", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_Content;
		private static FieldInfo __m_Content
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_Content ??= __type__?.GetField("m_Content", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_Position;
		private static FieldInfo __m_Position
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_Position ??= __type__?.GetField("m_Position", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_CursorIndex;
		private static FieldInfo __m_CursorIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_CursorIndex ??= __type__?.GetField("m_CursorIndex", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_SelectIndex;
		private static FieldInfo __m_SelectIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_SelectIndex ??= __type__?.GetField("m_SelectIndex", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_RevealCursor;
		private static FieldInfo __m_RevealCursor
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_RevealCursor ??= __type__?.GetField("m_RevealCursor", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_MouseDragSelectsWholeWords;
		private static FieldInfo __m_MouseDragSelectsWholeWords
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_MouseDragSelectsWholeWords ??= __type__?.GetField("m_MouseDragSelectsWholeWords", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_DblClickInitPos;
		private static FieldInfo __m_DblClickInitPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_DblClickInitPos ??= __type__?.GetField("m_DblClickInitPos", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_DblClickSnap;
		private static FieldInfo __m_DblClickSnap
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_DblClickSnap ??= __type__?.GetField("m_DblClickSnap", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_bJustSelected;
		private static FieldInfo __m_bJustSelected
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_bJustSelected ??= __type__?.GetField("m_bJustSelected", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___m_iAltCursorPos;
		private static FieldInfo __m_iAltCursorPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___m_iAltCursorPos ??= __type__?.GetField("m_iAltCursorPos", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___oldText;
		private static FieldInfo __oldText
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___oldText ??= __type__?.GetField("oldText", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___oldPos;
		private static FieldInfo __oldPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___oldPos ??= __type__?.GetField("oldPos", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___oldSelectPos;
		private static FieldInfo __oldSelectPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___oldSelectPos ??= __type__?.GetField("oldSelectPos", (BindingFlags)(-1));
		}
		
		private static FieldInfo ___s_Keyactions;
		private static FieldInfo __s_Keyactions
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___s_Keyactions ??= __type__?.GetField("s_Keyactions", (BindingFlags)(-1));
		}
		
		private static PropertyInfo ___localPosition;
		private static PropertyInfo __localPosition
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___localPosition ??= __type__?.GetProperty("localPosition", (BindingFlags)(-1));
		}
		
		private static MethodInfo ___ClearCursorPos;
		private static MethodInfo __ClearCursorPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___ClearCursorPos ??= __type__?.GetMethodInfoByParameterTypeNames("ClearCursorPos");
		}
		
		private static MethodInfo ___GrabGraphicalCursorPos;
		private static MethodInfo __GrabGraphicalCursorPos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___GrabGraphicalCursorPos ??= __type__?.GetMethodInfoByParameterTypeNames("GrabGraphicalCursorPos");
		}
		
		private static MethodInfo ___HandleKeyEvent;
		private static MethodInfo __HandleKeyEvent
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___HandleKeyEvent ??= __type__?.GetMethodInfoByParameterTypeNames("HandleKeyEvent", "UnityEngine.Event", "System.Boolean");
		}
		
		private static MethodInfo ___IndexOfEndOfLine;
		private static MethodInfo __IndexOfEndOfLine
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___IndexOfEndOfLine ??= __type__?.GetMethodInfoByParameterTypeNames("IndexOfEndOfLine", "System.Int32");
		}
		
		private static MethodInfo ___MoveCursorToPosition_Internal;
		private static MethodInfo __MoveCursorToPosition_Internal
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___MoveCursorToPosition_Internal ??= __type__?.GetMethodInfoByParameterTypeNames("MoveCursorToPosition_Internal", "UnityEngine.Vector2", "System.Boolean");
		}
		
		private static MethodInfo ___GetGraphicalLineStart;
		private static MethodInfo __GetGraphicalLineStart
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___GetGraphicalLineStart ??= __type__?.GetMethodInfoByParameterTypeNames("GetGraphicalLineStart", "System.Int32");
		}
		
		private static MethodInfo ___GetGraphicalLineEnd;
		private static MethodInfo __GetGraphicalLineEnd
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___GetGraphicalLineEnd ??= __type__?.GetMethodInfoByParameterTypeNames("GetGraphicalLineEnd", "System.Int32");
		}
		
		private static MethodInfo ___FindNextSeperator;
		private static MethodInfo __FindNextSeperator
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___FindNextSeperator ??= __type__?.GetMethodInfoByParameterTypeNames("FindNextSeperator", "System.Int32");
		}
		
		private static MethodInfo ___FindPrevSeperator;
		private static MethodInfo __FindPrevSeperator
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___FindPrevSeperator ??= __type__?.GetMethodInfoByParameterTypeNames("FindPrevSeperator", "System.Int32");
		}
		
		private static MethodInfo ___ClassifyChar;
		private static MethodInfo __ClassifyChar
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___ClassifyChar ??= __type__?.GetMethodInfoByParameterTypeNames("ClassifyChar", "System.Int32");
		}
		
		private static MethodInfo ___FindEndOfPreviousWord;
		private static MethodInfo __FindEndOfPreviousWord
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___FindEndOfPreviousWord ??= __type__?.GetMethodInfoByParameterTypeNames("FindEndOfPreviousWord", "System.Int32");
		}
		
		private static MethodInfo ___FindEndOfClassification;
		private static MethodInfo __FindEndOfClassification
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___FindEndOfClassification ??= __type__?.GetMethodInfoByParameterTypeNames("FindEndOfClassification", "System.Int32", "UnityEngine.TextEditor+Direction");
		}
		
		private static MethodInfo ___UpdateScrollOffset;
		private static MethodInfo __UpdateScrollOffset
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___UpdateScrollOffset ??= __type__?.GetMethodInfoByParameterTypeNames("UpdateScrollOffset");
		}
		
		private static MethodInfo ___PerformOperation;
		private static MethodInfo __PerformOperation
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___PerformOperation ??= __type__?.GetMethodInfoByParameterTypeNames("PerformOperation", "UnityEngine.TextEditor+TextEditOp", "System.Boolean");
		}
		
		private static MethodInfo ___GetHyperlinksRect;
		private static MethodInfo __GetHyperlinksRect
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___GetHyperlinksRect ??= __type__?.GetMethodInfoByParameterTypeNames("GetHyperlinksRect");
		}
		
		private static MethodInfo ___ReplaceNewlinesWithSpaces;
		private static MethodInfo __ReplaceNewlinesWithSpaces
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___ReplaceNewlinesWithSpaces ??= __type__?.GetMethodInfoByParameterTypeNames("ReplaceNewlinesWithSpaces", "System.String");
		}
		
		private static MethodInfo ___MapKey;
		private static MethodInfo __MapKey
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___MapKey ??= __type__?.GetMethodInfoByParameterTypeNames("MapKey", "System.String", "UnityEngine.TextEditor+TextEditOp");
		}
		
		private static MethodInfo ___InitKeyActions;
		private static MethodInfo __InitKeyActions
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___InitKeyActions ??= __type__?.GetMethodInfoByParameterTypeNames("InitKeyActions");
		}
		
		private static MethodInfo ___OnDetectFocusChange;
		private static MethodInfo __OnDetectFocusChange
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___OnDetectFocusChange ??= __type__?.GetMethodInfoByParameterTypeNames("OnDetectFocusChange");
		}
		
		private static MethodInfo ___OnCursorIndexChange;
		private static MethodInfo __OnCursorIndexChange
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___OnCursorIndexChange ??= __type__?.GetMethodInfoByParameterTypeNames("OnCursorIndexChange");
		}
		
		private static MethodInfo ___OnSelectIndexChange;
		private static MethodInfo __OnSelectIndexChange
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___OnSelectIndexChange ??= __type__?.GetMethodInfoByParameterTypeNames("OnSelectIndexChange");
		}
		
		private static MethodInfo ___ClampTextIndex;
		private static MethodInfo __ClampTextIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___ClampTextIndex ??= __type__?.GetMethodInfoByParameterTypeNames("ClampTextIndex", "System.Int32&");
		}
		
		private static MethodInfo ___EnsureValidCodePointIndex;
		private static MethodInfo __EnsureValidCodePointIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___EnsureValidCodePointIndex ??= __type__?.GetMethodInfoByParameterTypeNames("EnsureValidCodePointIndex", "System.Int32&");
		}
		
		private static MethodInfo ___IsValidCodePointIndex;
		private static MethodInfo __IsValidCodePointIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___IsValidCodePointIndex ??= __type__?.GetMethodInfoByParameterTypeNames("IsValidCodePointIndex", "System.Int32");
		}
		
		private static MethodInfo ___PreviousCodePointIndex;
		private static MethodInfo __PreviousCodePointIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___PreviousCodePointIndex ??= __type__?.GetMethodInfoByParameterTypeNames("PreviousCodePointIndex", "System.Int32");
		}
		
		private static MethodInfo ___NextCodePointIndex;
		private static MethodInfo __NextCodePointIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ___NextCodePointIndex ??= __type__?.GetMethodInfoByParameterTypeNames("NextCodePointIndex", "System.Int32");
		}
	}
	public static class UnityEngine_TextEditor_Extension
	{
		public static UnityEngine_TextEditor ReflectionHelper(this UnityEngine.TextEditor self) => new(self);
	}
}