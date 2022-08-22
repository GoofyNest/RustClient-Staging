public class GUILayoutUtility // TypeDefIndex: 4041
{	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	private static GUIStyle s_SpaceStyle; // 0x28

	// Properties
	internal static GUIStyle spaceStyle { get; }

	// Methods

	// RVA: 0x1A5EBC0 Offset: 0x1A5D1C0 VA: 0x181A5EBC0
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x1A5EC90 Offset: 0x1A5D290 VA: 0x181A5EC90
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF680 Offset: 0xCEA80 VA: 0x1800CF680
	// RVA: 0x1A5FC40 Offset: 0x1A5E240 VA: 0x181A5FC40
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x1A5DB10 Offset: 0x1A5C110 VA: 0x181A5DB10
	internal static void Begin(int instanceID) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF870 Offset: 0xCEC70 VA: 0x1800CF870
	// RVA: 0x1A5CF20 Offset: 0x1A5B520 VA: 0x181A5CF20
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x1A5D750 Offset: 0x1A5BD50 VA: 0x181A5D750
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A5F940 Offset: 0x1A5DF40 VA: 0x181A5F940
	internal static void Layout() { }

	// RVA: 0x1A5F3B0 Offset: 0x1A5D9B0 VA: 0x181A5F3B0
	internal static void LayoutFromEditorWindow() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCFA60 Offset: 0xCEE60 VA: 0x1800CFA60
	// RVA: 0x1A5F1D0 Offset: 0x1A5D7D0 VA: 0x181A5F1D0
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x1A5ED10 Offset: 0x1A5D310 VA: 0x181A5ED10
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x1A5F600 Offset: 0x1A5DC00 VA: 0x181A5F600
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x1A5DDC0 Offset: 0x1A5C3C0 VA: 0x181A5DDC0
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x1A5D400 Offset: 0x1A5BA00 VA: 0x181A5D400
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x1A5E770 Offset: 0x1A5CD70 VA: 0x181A5E770
	internal static void EndLayoutGroup() { }

	// RVA: 0x1A5D100 Offset: 0x1A5B700 VA: 0x181A5D100
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x1A5EA20 Offset: 0x1A5D020 VA: 0x181A5EA20
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A5DEE0 Offset: 0x1A5C4E0 VA: 0x181A5DEE0
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A5EAC0 Offset: 0x1A5D0C0 VA: 0x181A5EAC0
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A5E510 Offset: 0x1A5CB10 VA: 0x181A5E510
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A5FF30 Offset: 0x1A5E530 VA: 0x181A5FF30
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x1A5FE10 Offset: 0x1A5E410 VA: 0x181A5FE10
	private static void .cctor() { }

	// RVA: 0x1A5EB80 Offset: 0x1A5D180 VA: 0x181A5EB80
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x1A5EC50 Offset: 0x1A5D250 VA: 0x181A5EC50
	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }

}

internal sealed class GUILayoutUtility.LayoutCache // TypeDefIndex: 4042
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0xCFFC0 Offset: 0xCF3C0 VA: 0x1800CFFC0
	internal GUILayoutGroup topLevel; // 0x10
	internal GenericStack layoutGroups; // 0x18
	internal GUILayoutGroup windows; // 0x20

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0xD0110 Offset: 0xCF510 VA: 0x1800D0110
	// RVA: 0x1A71EF0 Offset: 0x1A704F0 VA: 0x181A71EF0
	internal void .ctor() { }

}

