public class GUILayout // TypeDefIndex: 4038
{	// Methods

	// RVA: 0x1A75C50 Offset: 0x1A74250 VA: 0x181A75C50
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A749B0 Offset: 0x1A72FB0 VA: 0x181A749B0
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A74220 Offset: 0x1A72820 VA: 0x181A74220
	public static void Box(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A745C0 Offset: 0x1A72BC0 VA: 0x181A745C0
	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A743F0 Offset: 0x1A729F0 VA: 0x181A743F0
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A746D0 Offset: 0x1A72CD0 VA: 0x181A746D0
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A75F40 Offset: 0x1A74540 VA: 0x181A75F40
	public static string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A75E60 Offset: 0x1A74460 VA: 0x181A75E60
	public static string TextArea(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A74B00 Offset: 0x1A73100 VA: 0x181A74B00
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A760C0 Offset: 0x1A746C0 VA: 0x181A760C0
	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	// RVA: 0x1A76020 Offset: 0x1A74620 VA: 0x181A76020
	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A74E40 Offset: 0x1A73440 VA: 0x181A74E40
	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A75950 Offset: 0x1A73F50 VA: 0x181A75950
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x1A747E0 Offset: 0x1A72DE0 VA: 0x181A747E0
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x1A75440 Offset: 0x1A73A40 VA: 0x181A75440
	public static void FlexibleSpace() { }

	// RVA: 0x1A73DB0 Offset: 0x1A723B0 VA: 0x181A73DB0
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x1A73C40 Offset: 0x1A72240 VA: 0x181A73C40
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A752A0 Offset: 0x1A738A0 VA: 0x181A752A0
	public static void EndHorizontal() { }

	// RVA: 0x1A73F90 Offset: 0x1A72590 VA: 0x181A73F90
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x1A741A0 Offset: 0x1A727A0 VA: 0x181A741A0
	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A74030 Offset: 0x1A72630 VA: 0x181A74030
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A752F0 Offset: 0x1A738F0 VA: 0x181A752F0
	public static void EndVertical() { }

	// RVA: 0x1A73B90 Offset: 0x1A72190 VA: 0x181A73B90
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x1A73870 Offset: 0x1A71E70 VA: 0x181A73870
	public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }

	// RVA: 0x1A73900 Offset: 0x1A71F00 VA: 0x181A73900
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A750C0 Offset: 0x1A736C0 VA: 0x181A750C0
	public static void EndArea() { }

	// RVA: 0x1A761D0 Offset: 0x1A747D0 VA: 0x181A761D0
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x1A758C0 Offset: 0x1A73EC0 VA: 0x181A758C0
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x1A753C0 Offset: 0x1A739C0 VA: 0x181A753C0
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x1A75340 Offset: 0x1A73940 VA: 0x181A75340
	public static GUILayoutOption ExpandHeight(bool expand) { }

}

