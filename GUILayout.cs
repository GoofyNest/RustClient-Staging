public class GUILayout // TypeDefIndex: 4038
{	// Methods

	// RVA: 0x1A75F10 Offset: 0x1A74510 VA: 0x181A75F10
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A74C70 Offset: 0x1A73270 VA: 0x181A74C70
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A744E0 Offset: 0x1A72AE0 VA: 0x181A744E0
	public static void Box(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A74880 Offset: 0x1A72E80 VA: 0x181A74880
	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A746B0 Offset: 0x1A72CB0 VA: 0x181A746B0
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A74990 Offset: 0x1A72F90 VA: 0x181A74990
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A76200 Offset: 0x1A74800 VA: 0x181A76200
	public static string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A76120 Offset: 0x1A74720 VA: 0x181A76120
	public static string TextArea(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A74DC0 Offset: 0x1A733C0 VA: 0x181A74DC0
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A76380 Offset: 0x1A74980 VA: 0x181A76380
	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	// RVA: 0x1A762E0 Offset: 0x1A748E0 VA: 0x181A762E0
	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A75100 Offset: 0x1A73700 VA: 0x181A75100
	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A75C10 Offset: 0x1A74210 VA: 0x181A75C10
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x1A74AA0 Offset: 0x1A730A0 VA: 0x181A74AA0
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x1A75700 Offset: 0x1A73D00 VA: 0x181A75700
	public static void FlexibleSpace() { }

	// RVA: 0x1A74070 Offset: 0x1A72670 VA: 0x181A74070
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x1A73F00 Offset: 0x1A72500 VA: 0x181A73F00
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A75560 Offset: 0x1A73B60 VA: 0x181A75560
	public static void EndHorizontal() { }

	// RVA: 0x1A74250 Offset: 0x1A72850 VA: 0x181A74250
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x1A74460 Offset: 0x1A72A60 VA: 0x181A74460
	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A742F0 Offset: 0x1A728F0 VA: 0x181A742F0
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A755B0 Offset: 0x1A73BB0 VA: 0x181A755B0
	public static void EndVertical() { }

	// RVA: 0x1A73E50 Offset: 0x1A72450 VA: 0x181A73E50
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x1A73B30 Offset: 0x1A72130 VA: 0x181A73B30
	public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }

	// RVA: 0x1A73BC0 Offset: 0x1A721C0 VA: 0x181A73BC0
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A75380 Offset: 0x1A73980 VA: 0x181A75380
	public static void EndArea() { }

	// RVA: 0x1A76490 Offset: 0x1A74A90 VA: 0x181A76490
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x1A75B80 Offset: 0x1A74180 VA: 0x181A75B80
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x1A75680 Offset: 0x1A73C80 VA: 0x181A75680
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x1A75600 Offset: 0x1A73C00 VA: 0x181A75600
	public static GUILayoutOption ExpandHeight(bool expand) { }

}

