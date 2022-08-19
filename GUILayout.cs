public class GUILayout // TypeDefIndex: 4038
{	// Methods

	// RVA: 0x1A75C90 Offset: 0x1A74290 VA: 0x181A75C90
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A749F0 Offset: 0x1A72FF0 VA: 0x181A749F0
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A74260 Offset: 0x1A72860 VA: 0x181A74260
	public static void Box(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A74600 Offset: 0x1A72C00 VA: 0x181A74600
	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A74430 Offset: 0x1A72A30 VA: 0x181A74430
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A74710 Offset: 0x1A72D10 VA: 0x181A74710
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A75F80 Offset: 0x1A74580 VA: 0x181A75F80
	public static string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A75EA0 Offset: 0x1A744A0 VA: 0x181A75EA0
	public static string TextArea(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A74B40 Offset: 0x1A73140 VA: 0x181A74B40
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A76100 Offset: 0x1A74700 VA: 0x181A76100
	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	// RVA: 0x1A76060 Offset: 0x1A74660 VA: 0x181A76060
	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A74E80 Offset: 0x1A73480 VA: 0x181A74E80
	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A75990 Offset: 0x1A73F90 VA: 0x181A75990
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x1A74820 Offset: 0x1A72E20 VA: 0x181A74820
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x1A75480 Offset: 0x1A73A80 VA: 0x181A75480
	public static void FlexibleSpace() { }

	// RVA: 0x1A73DF0 Offset: 0x1A723F0 VA: 0x181A73DF0
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x1A73C80 Offset: 0x1A72280 VA: 0x181A73C80
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A752E0 Offset: 0x1A738E0 VA: 0x181A752E0
	public static void EndHorizontal() { }

	// RVA: 0x1A73FD0 Offset: 0x1A725D0 VA: 0x181A73FD0
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x1A741E0 Offset: 0x1A727E0 VA: 0x181A741E0
	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A74070 Offset: 0x1A72670 VA: 0x181A74070
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A75330 Offset: 0x1A73930 VA: 0x181A75330
	public static void EndVertical() { }

	// RVA: 0x1A73BD0 Offset: 0x1A721D0 VA: 0x181A73BD0
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x1A738B0 Offset: 0x1A71EB0 VA: 0x181A738B0
	public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }

	// RVA: 0x1A73940 Offset: 0x1A71F40 VA: 0x181A73940
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A75100 Offset: 0x1A73700 VA: 0x181A75100
	public static void EndArea() { }

	// RVA: 0x1A76210 Offset: 0x1A74810 VA: 0x181A76210
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x1A75900 Offset: 0x1A73F00 VA: 0x181A75900
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x1A75400 Offset: 0x1A73A00 VA: 0x181A75400
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x1A75380 Offset: 0x1A73980 VA: 0x181A75380
	public static GUILayoutOption ExpandHeight(bool expand) { }

}

