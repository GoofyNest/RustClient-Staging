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

	// RVA: 0x1A72690 Offset: 0x1A70C90 VA: 0x181A72690
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x1A72760 Offset: 0x1A70D60 VA: 0x181A72760
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF680 Offset: 0xCEA80 VA: 0x1800CF680
	// RVA: 0x1A73710 Offset: 0x1A71D10 VA: 0x181A73710
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x1A715E0 Offset: 0x1A6FBE0 VA: 0x181A715E0
	internal static void Begin(int instanceID) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF870 Offset: 0xCEC70 VA: 0x1800CF870
	// RVA: 0x1A709F0 Offset: 0x1A6EFF0 VA: 0x181A709F0
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x1A71220 Offset: 0x1A6F820 VA: 0x181A71220
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A73410 Offset: 0x1A71A10 VA: 0x181A73410
	internal static void Layout() { }

	// RVA: 0x1A72E80 Offset: 0x1A71480 VA: 0x181A72E80
	internal static void LayoutFromEditorWindow() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCFA60 Offset: 0xCEE60 VA: 0x1800CFA60
	// RVA: 0x1A72CA0 Offset: 0x1A712A0 VA: 0x181A72CA0
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x1A727E0 Offset: 0x1A70DE0 VA: 0x181A727E0
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x1A730D0 Offset: 0x1A716D0 VA: 0x181A730D0
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x1A71890 Offset: 0x1A6FE90 VA: 0x181A71890
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x1A70ED0 Offset: 0x1A6F4D0 VA: 0x181A70ED0
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x1A72240 Offset: 0x1A70840 VA: 0x181A72240
	internal static void EndLayoutGroup() { }

	// RVA: 0x1A70BD0 Offset: 0x1A6F1D0 VA: 0x181A70BD0
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x1A724F0 Offset: 0x1A70AF0 VA: 0x181A724F0
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A719B0 Offset: 0x1A6FFB0 VA: 0x181A719B0
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A72590 Offset: 0x1A70B90 VA: 0x181A72590
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A71FE0 Offset: 0x1A705E0 VA: 0x181A71FE0
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A73A00 Offset: 0x1A72000 VA: 0x181A73A00
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x1A738E0 Offset: 0x1A71EE0 VA: 0x181A738E0
	private static void .cctor() { }

	// RVA: 0x1A72650 Offset: 0x1A70C50 VA: 0x181A72650
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x1A72720 Offset: 0x1A70D20 VA: 0x181A72720
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
	// RVA: 0x1A859C0 Offset: 0x1A83FC0 VA: 0x181A859C0
	internal void .ctor() { }

}

