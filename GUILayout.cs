public class GUILayout // TypeDefIndex: 4038
{	// Methods

	// RVA: 0x1A62440 Offset: 0x1A60A40 VA: 0x181A62440
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A611A0 Offset: 0x1A5F7A0 VA: 0x181A611A0
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A60A10 Offset: 0x1A5F010 VA: 0x181A60A10
	public static void Box(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A60DB0 Offset: 0x1A5F3B0 VA: 0x181A60DB0
	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A60BE0 Offset: 0x1A5F1E0 VA: 0x181A60BE0
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A60EC0 Offset: 0x1A5F4C0 VA: 0x181A60EC0
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A62730 Offset: 0x1A60D30 VA: 0x181A62730
	public static string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A62650 Offset: 0x1A60C50 VA: 0x181A62650
	public static string TextArea(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A612F0 Offset: 0x1A5F8F0 VA: 0x181A612F0
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A628B0 Offset: 0x1A60EB0 VA: 0x181A628B0
	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	// RVA: 0x1A62810 Offset: 0x1A60E10 VA: 0x181A62810
	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A61630 Offset: 0x1A5FC30 VA: 0x181A61630
	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A62140 Offset: 0x1A60740 VA: 0x181A62140
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x1A60FD0 Offset: 0x1A5F5D0 VA: 0x181A60FD0
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x1A61C30 Offset: 0x1A60230 VA: 0x181A61C30
	public static void FlexibleSpace() { }

	// RVA: 0x1A605A0 Offset: 0x1A5EBA0 VA: 0x181A605A0
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x1A60430 Offset: 0x1A5EA30 VA: 0x181A60430
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A61A90 Offset: 0x1A60090 VA: 0x181A61A90
	public static void EndHorizontal() { }

	// RVA: 0x1A60780 Offset: 0x1A5ED80 VA: 0x181A60780
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x1A60990 Offset: 0x1A5EF90 VA: 0x181A60990
	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A60820 Offset: 0x1A5EE20 VA: 0x181A60820
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A61AE0 Offset: 0x1A600E0 VA: 0x181A61AE0
	public static void EndVertical() { }

	// RVA: 0x1A60380 Offset: 0x1A5E980 VA: 0x181A60380
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x1A60060 Offset: 0x1A5E660 VA: 0x181A60060
	public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }

	// RVA: 0x1A600F0 Offset: 0x1A5E6F0 VA: 0x181A600F0
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A618B0 Offset: 0x1A5FEB0 VA: 0x181A618B0
	public static void EndArea() { }

	// RVA: 0x1A629C0 Offset: 0x1A60FC0 VA: 0x181A629C0
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x1A620B0 Offset: 0x1A606B0 VA: 0x181A620B0
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x1A61BB0 Offset: 0x1A601B0 VA: 0x181A61BB0
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x1A61B30 Offset: 0x1A60130 VA: 0x181A61B30
	public static GUILayoutOption ExpandHeight(bool expand) { }

}

