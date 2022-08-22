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

	// RVA: 0x1A723D0 Offset: 0x1A709D0 VA: 0x181A723D0
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x1A724A0 Offset: 0x1A70AA0 VA: 0x181A724A0
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF680 Offset: 0xCEA80 VA: 0x1800CF680
	// RVA: 0x1A73450 Offset: 0x1A71A50 VA: 0x181A73450
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x1A71320 Offset: 0x1A6F920 VA: 0x181A71320
	internal static void Begin(int instanceID) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF870 Offset: 0xCEC70 VA: 0x1800CF870
	// RVA: 0x1A70730 Offset: 0x1A6ED30 VA: 0x181A70730
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x1A70F60 Offset: 0x1A6F560 VA: 0x181A70F60
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A73150 Offset: 0x1A71750 VA: 0x181A73150
	internal static void Layout() { }

	// RVA: 0x1A72BC0 Offset: 0x1A711C0 VA: 0x181A72BC0
	internal static void LayoutFromEditorWindow() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCFA60 Offset: 0xCEE60 VA: 0x1800CFA60
	// RVA: 0x1A729E0 Offset: 0x1A70FE0 VA: 0x181A729E0
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x1A72520 Offset: 0x1A70B20 VA: 0x181A72520
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x1A72E10 Offset: 0x1A71410 VA: 0x181A72E10
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x1A715D0 Offset: 0x1A6FBD0 VA: 0x181A715D0
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x1A70C10 Offset: 0x1A6F210 VA: 0x181A70C10
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x1A71F80 Offset: 0x1A70580 VA: 0x181A71F80
	internal static void EndLayoutGroup() { }

	// RVA: 0x1A70910 Offset: 0x1A6EF10 VA: 0x181A70910
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x1A72230 Offset: 0x1A70830 VA: 0x181A72230
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A716F0 Offset: 0x1A6FCF0 VA: 0x181A716F0
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A722D0 Offset: 0x1A708D0 VA: 0x181A722D0
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A71D20 Offset: 0x1A70320 VA: 0x181A71D20
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A73740 Offset: 0x1A71D40 VA: 0x181A73740
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x1A73620 Offset: 0x1A71C20 VA: 0x181A73620
	private static void .cctor() { }

	// RVA: 0x1A72390 Offset: 0x1A70990 VA: 0x181A72390
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x1A72460 Offset: 0x1A70A60 VA: 0x181A72460
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
	// RVA: 0x1A85700 Offset: 0x1A83D00 VA: 0x181A85700
	internal void .ctor() { }

}

