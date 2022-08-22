public class GUI // TypeDefIndex: 4030
{	// Fields
	private static int s_HotTextField; // 0x0
	private static readonly int s_BoxHash; // 0x4
	private static readonly int s_ButonHash; // 0x8
	private static readonly int s_RepeatButtonHash; // 0xC
	private static readonly int s_ToggleHash; // 0x10
	private static readonly int s_ButtonGridHash; // 0x14
	private static readonly int s_SliderHash; // 0x18
	private static readonly int s_BeginGroupHash; // 0x1C
	private static readonly int s_ScrollviewHash; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static int <scrollTroughSide>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x28
	private static GUISkin s_Skin; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static GenericStack <scrollViewStates>k__BackingField; // 0x38

	// Properties
	public static Color color { get; set; }
	public static Color backgroundColor { get; set; }
	public static Color contentColor { get; set; }
	public static bool changed { get; set; }
	public static bool enabled { get; set; }
	internal static bool usePageScrollbars { get; }
	internal static Material blendMaterial { get; }
	internal static Material blitMaterial { get; }
	internal static Material roundedRectMaterial { get; }
	internal static Material roundedRectWithColorPerBorderMaterial { get; }
	internal static int scrollTroughSide { get; set; }
	internal static DateTime nextScrollStepTime { get; set; }
	public static GUISkin skin { get; set; }
	public static Matrix4x4 matrix { get; set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0x1A84EF0 Offset: 0x1A834F0 VA: 0x181A84EF0
	public static Color get_color() { }

	// RVA: 0x1A85490 Offset: 0x1A83A90 VA: 0x181A85490
	public static void set_color(Color value) { }

	// RVA: 0x1A84DA0 Offset: 0x1A833A0 VA: 0x181A84DA0
	public static Color get_backgroundColor() { }

	// RVA: 0x1A853A0 Offset: 0x1A839A0 VA: 0x181A853A0
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x1A84FB0 Offset: 0x1A835B0 VA: 0x181A84FB0
	public static Color get_contentColor() { }

	// RVA: 0x1A85540 Offset: 0x1A83B40 VA: 0x181A85540
	public static void set_contentColor(Color value) { }

	// RVA: 0x1A84E80 Offset: 0x1A83480 VA: 0x181A84E80
	public static bool get_changed() { }

	// RVA: 0x1A85410 Offset: 0x1A83A10 VA: 0x181A85410
	public static void set_changed(bool value) { }

	// RVA: 0x1A85030 Offset: 0x1A83630 VA: 0x181A85030
	public static bool get_enabled() { }

	// RVA: 0x1A855B0 Offset: 0x1A83BB0 VA: 0x181A855B0
	public static void set_enabled(bool value) { }

	// RVA: 0x1A85330 Offset: 0x1A83930 VA: 0x181A85330
	internal static bool get_usePageScrollbars() { }

	[FreeFunctionAttribute] // RVA: 0xCA9A0 Offset: 0xC9DA0 VA: 0x1800CA9A0
	// RVA: 0x1A84E20 Offset: 0x1A83420 VA: 0x181A84E20
	internal static Material get_blendMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCAA00 Offset: 0xC9E00 VA: 0x1800CAA00
	// RVA: 0x1A84E50 Offset: 0x1A83450 VA: 0x181A84E50
	internal static Material get_blitMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCAA70 Offset: 0xC9E70 VA: 0x1800CAA70
	// RVA: 0x1A85150 Offset: 0x1A83750 VA: 0x181A85150
	internal static Material get_roundedRectMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCACC0 Offset: 0xCA0C0 VA: 0x1800CACC0
	// RVA: 0x1A85180 Offset: 0x1A83780 VA: 0x181A85180
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x1A82EF0 Offset: 0x1A814F0 VA: 0x181A82EF0
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x1A83CE0 Offset: 0x1A822E0 VA: 0x181A83CE0
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x1A843F0 Offset: 0x1A829F0 VA: 0x181A843F0
	internal static void ReleaseMouseControl() { }

	[FreeFunctionAttribute] // RVA: 0xCAE40 Offset: 0xCA240 VA: 0x1800CAE40
	// RVA: 0x1A84680 Offset: 0x1A82C80 VA: 0x181A84680
	public static void SetNextControlName(string name) { }

	// RVA: 0x1A84000 Offset: 0x1A82600 VA: 0x181A84000
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x1A84AE0 Offset: 0x1A830E0 VA: 0x181A84AE0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A851B0 Offset: 0x1A837B0 VA: 0x181A851B0
	internal static int get_scrollTroughSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A85710 Offset: 0x1A83D10 VA: 0x181A85710
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A850F0 Offset: 0x1A836F0 VA: 0x181A850F0
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A85650 Offset: 0x1A83C50 VA: 0x181A85650
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x1A857D0 Offset: 0x1A83DD0 VA: 0x181A857D0
	public static void set_skin(GUISkin value) { }

	// RVA: 0x1A852D0 Offset: 0x1A838D0 VA: 0x181A852D0
	public static GUISkin get_skin() { }

	// RVA: 0x1A81370 Offset: 0x1A7F970 VA: 0x181A81370
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x1A85060 Offset: 0x1A83660 VA: 0x181A85060
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1A855F0 Offset: 0x1A83BF0 VA: 0x181A855F0
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1A84120 Offset: 0x1A82720 VA: 0x181A84120
	public static void Label(Rect position, string text) { }

	// RVA: 0x1A84030 Offset: 0x1A82630 VA: 0x181A84030
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x1A84230 Offset: 0x1A82830 VA: 0x181A84230
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A82500 Offset: 0x1A80B00 VA: 0x181A82500
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x1A820A0 Offset: 0x1A806A0 VA: 0x181A820A0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x1A82BB0 Offset: 0x1A811B0 VA: 0x181A82BB0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x1A82A70 Offset: 0x1A81070 VA: 0x181A82A70
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x1A82240 Offset: 0x1A80840 VA: 0x181A82240
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x1A82840 Offset: 0x1A80E40 VA: 0x181A82840
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x1A82D20 Offset: 0x1A81320 VA: 0x181A82D20
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x1A826E0 Offset: 0x1A80CE0 VA: 0x181A826E0
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A81AF0 Offset: 0x1A800F0 VA: 0x181A81AF0
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A7F6C0 Offset: 0x1A7DCC0 VA: 0x181A7F6C0
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x1A7EAB0 Offset: 0x1A7D0B0 VA: 0x181A7EAB0
	public static void Box(Rect position, string text) { }

	// RVA: 0x1A7E8B0 Offset: 0x1A7CEB0 VA: 0x181A7E8B0
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7EB70 Offset: 0x1A7D170 VA: 0x181A7EB70
	public static bool Button(Rect position, string text) { }

	// RVA: 0x1A7EDA0 Offset: 0x1A7D3A0 VA: 0x181A7EDA0
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7EC30 Offset: 0x1A7D230 VA: 0x181A7EC30
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A842C0 Offset: 0x1A828C0 VA: 0x181A842C0
	internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

	// RVA: 0x1A817F0 Offset: 0x1A7FDF0 VA: 0x181A817F0
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x1A818F0 Offset: 0x1A7FEF0 VA: 0x181A818F0
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x1A81520 Offset: 0x1A7FB20 VA: 0x181A81520
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

	// RVA: 0x1A83720 Offset: 0x1A81D20 VA: 0x181A83720
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

	// RVA: 0x1A82F30 Offset: 0x1A81530 VA: 0x181A82F30
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x1A84920 Offset: 0x1A82F20 VA: 0x181A84920
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A84520 Offset: 0x1A82B20 VA: 0x181A84520
	public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount) { }

	// RVA: 0x1A84420 Offset: 0x1A82A20 VA: 0x181A84420
	public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { }

	// RVA: 0x1A7F4B0 Offset: 0x1A7DAB0 VA: 0x181A7F4B0
	internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

	// RVA: 0x1A80CA0 Offset: 0x1A7F2A0 VA: 0x181A80CA0
	private static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A810E0 Offset: 0x1A7F6E0 VA: 0x181A810E0
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A819B0 Offset: 0x1A7FFB0 VA: 0x181A819B0
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A80B70 Offset: 0x1A7F170 VA: 0x181A80B70
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7FE80 Offset: 0x1A7E480 VA: 0x181A7FE80
	private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

	// RVA: 0x1A7EF90 Offset: 0x1A7D590 VA: 0x181A7EF90
	private static Rect[] CalcMouseRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders, GUI.ToolbarButtonSize buttonSize) { }

	// RVA: 0x1A83DF0 Offset: 0x1A823F0 VA: 0x181A83DF0
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue) { }

	// RVA: 0x1A83D20 Offset: 0x1A82320 VA: 0x181A83D20
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x1A846C0 Offset: 0x1A82CC0 VA: 0x181A846C0
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x1A7E490 Offset: 0x1A7CA90 VA: 0x181A7E490
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7E550 Offset: 0x1A7CB50 VA: 0x181A7E550
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x1A82EB0 Offset: 0x1A814B0 VA: 0x181A82EB0
	public static void EndGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A85270 Offset: 0x1A83870 VA: 0x181A85270
	internal static GenericStack get_scrollViewStates() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7F9F0 Offset: 0x1A7DFF0 VA: 0x181A7F9F0
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x1A84EB0 Offset: 0x1A834B0 VA: 0x181A84EB0
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x1A85450 Offset: 0x1A83A50 VA: 0x181A85450
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x1A84D60 Offset: 0x1A83360 VA: 0x181A84D60
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x1A85360 Offset: 0x1A83960 VA: 0x181A85360
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x1A84F70 Offset: 0x1A83570 VA: 0x181A84F70
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x1A85500 Offset: 0x1A83B00 VA: 0x181A85500
	private static void set_contentColor_Injected(ref Color value) { }

}

public enum GUI.ToolbarButtonSize // TypeDefIndex: 4031
{	// Fields
	public int value__; // 0x0
	public const GUI.ToolbarButtonSize Fixed = 0;
	public const GUI.ToolbarButtonSize FitToContents = 1;

}

public sealed class GUI.WindowFunction : MulticastDelegate // TypeDefIndex: 4032
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A466A0 Offset: 0x1A44CA0 VA: 0x181A466A0 Slot: 12
	public virtual void Invoke(int id) { }

	// RVA: 0x1A87FA0 Offset: 0x1A865A0 VA: 0x181A87FA0 Slot: 13
	public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

