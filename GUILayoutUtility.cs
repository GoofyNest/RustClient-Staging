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

	// RVA: 0x1A72410 Offset: 0x1A70A10 VA: 0x181A72410
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x1A724E0 Offset: 0x1A70AE0 VA: 0x181A724E0
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF5F0 Offset: 0xCE9F0 VA: 0x1800CF5F0
	// RVA: 0x1A73490 Offset: 0x1A71A90 VA: 0x181A73490
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x1A71360 Offset: 0x1A6F960 VA: 0x181A71360
	internal static void Begin(int instanceID) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF7E0 Offset: 0xCEBE0 VA: 0x1800CF7E0
	// RVA: 0x1A70770 Offset: 0x1A6ED70 VA: 0x181A70770
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x1A70FA0 Offset: 0x1A6F5A0 VA: 0x181A70FA0
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A73190 Offset: 0x1A71790 VA: 0x181A73190
	internal static void Layout() { }

	// RVA: 0x1A72C00 Offset: 0x1A71200 VA: 0x181A72C00
	internal static void LayoutFromEditorWindow() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF9D0 Offset: 0xCEDD0 VA: 0x1800CF9D0
	// RVA: 0x1A72A20 Offset: 0x1A71020 VA: 0x181A72A20
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x1A72560 Offset: 0x1A70B60 VA: 0x181A72560
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x1A72E50 Offset: 0x1A71450 VA: 0x181A72E50
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x1A71610 Offset: 0x1A6FC10 VA: 0x181A71610
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x1A70C50 Offset: 0x1A6F250 VA: 0x181A70C50
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x1A71FC0 Offset: 0x1A705C0 VA: 0x181A71FC0
	internal static void EndLayoutGroup() { }

	// RVA: 0x1A70950 Offset: 0x1A6EF50 VA: 0x181A70950
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x1A72270 Offset: 0x1A70870 VA: 0x181A72270
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A71730 Offset: 0x1A6FD30 VA: 0x181A71730
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A72310 Offset: 0x1A70910 VA: 0x181A72310
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A71D60 Offset: 0x1A70360 VA: 0x181A71D60
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A73780 Offset: 0x1A71D80 VA: 0x181A73780
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x1A73660 Offset: 0x1A71C60 VA: 0x181A73660
	private static void .cctor() { }

	// RVA: 0x1A723D0 Offset: 0x1A709D0 VA: 0x181A723D0
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x1A724A0 Offset: 0x1A70AA0 VA: 0x181A724A0
	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }

}

internal sealed class GUILayoutUtility.LayoutCache // TypeDefIndex: 4042
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0xCFF60 Offset: 0xCF360 VA: 0x1800CFF60
	internal GUILayoutGroup topLevel; // 0x10
	internal GenericStack layoutGroups; // 0x18
	internal GUILayoutGroup windows; // 0x20

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0xD0080 Offset: 0xCF480 VA: 0x1800D0080
	// RVA: 0x1A85740 Offset: 0x1A83D40 VA: 0x181A85740
	internal void .ctor() { }

}

