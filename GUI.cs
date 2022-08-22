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

	// RVA: 0x1A71420 Offset: 0x1A6FA20 VA: 0x181A71420
	public static Color get_color() { }

	// RVA: 0x1A719C0 Offset: 0x1A6FFC0 VA: 0x181A719C0
	public static void set_color(Color value) { }

	// RVA: 0x1A712D0 Offset: 0x1A6F8D0 VA: 0x181A712D0
	public static Color get_backgroundColor() { }

	// RVA: 0x1A718D0 Offset: 0x1A6FED0 VA: 0x181A718D0
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x1A714E0 Offset: 0x1A6FAE0 VA: 0x181A714E0
	public static Color get_contentColor() { }

	// RVA: 0x1A71A70 Offset: 0x1A70070 VA: 0x181A71A70
	public static void set_contentColor(Color value) { }

	// RVA: 0x1A713B0 Offset: 0x1A6F9B0 VA: 0x181A713B0
	public static bool get_changed() { }

	// RVA: 0x1A71940 Offset: 0x1A6FF40 VA: 0x181A71940
	public static void set_changed(bool value) { }

	// RVA: 0x1A71560 Offset: 0x1A6FB60 VA: 0x181A71560
	public static bool get_enabled() { }

	// RVA: 0x1A71AE0 Offset: 0x1A700E0 VA: 0x181A71AE0
	public static void set_enabled(bool value) { }

	// RVA: 0x1A71860 Offset: 0x1A6FE60 VA: 0x181A71860
	internal static bool get_usePageScrollbars() { }

	[FreeFunctionAttribute] // RVA: 0xCA9A0 Offset: 0xC9DA0 VA: 0x1800CA9A0
	// RVA: 0x1A71350 Offset: 0x1A6F950 VA: 0x181A71350
	internal static Material get_blendMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCAA00 Offset: 0xC9E00 VA: 0x1800CAA00
	// RVA: 0x1A71380 Offset: 0x1A6F980 VA: 0x181A71380
	internal static Material get_blitMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCAA70 Offset: 0xC9E70 VA: 0x1800CAA70
	// RVA: 0x1A71680 Offset: 0x1A6FC80 VA: 0x181A71680
	internal static Material get_roundedRectMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCACC0 Offset: 0xCA0C0 VA: 0x1800CACC0
	// RVA: 0x1A716B0 Offset: 0x1A6FCB0 VA: 0x181A716B0
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x1A6F420 Offset: 0x1A6DA20 VA: 0x181A6F420
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x1A70210 Offset: 0x1A6E810 VA: 0x181A70210
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x1A70920 Offset: 0x1A6EF20 VA: 0x181A70920
	internal static void ReleaseMouseControl() { }

	[FreeFunctionAttribute] // RVA: 0xCAE40 Offset: 0xCA240 VA: 0x1800CAE40
	// RVA: 0x1A70BB0 Offset: 0x1A6F1B0 VA: 0x181A70BB0
	public static void SetNextControlName(string name) { }

	// RVA: 0x1A70530 Offset: 0x1A6EB30 VA: 0x181A70530
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x1A71010 Offset: 0x1A6F610 VA: 0x181A71010
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A716E0 Offset: 0x1A6FCE0 VA: 0x181A716E0
	internal static int get_scrollTroughSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A71C40 Offset: 0x1A70240 VA: 0x181A71C40
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A71620 Offset: 0x1A6FC20 VA: 0x181A71620
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A71B80 Offset: 0x1A70180 VA: 0x181A71B80
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x1A71D00 Offset: 0x1A70300 VA: 0x181A71D00
	public static void set_skin(GUISkin value) { }

	// RVA: 0x1A71800 Offset: 0x1A6FE00 VA: 0x181A71800
	public static GUISkin get_skin() { }

	// RVA: 0x1A6D8A0 Offset: 0x1A6BEA0 VA: 0x181A6D8A0
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x1A71590 Offset: 0x1A6FB90 VA: 0x181A71590
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1A71B20 Offset: 0x1A70120 VA: 0x181A71B20
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1A70650 Offset: 0x1A6EC50 VA: 0x181A70650
	public static void Label(Rect position, string text) { }

	// RVA: 0x1A70560 Offset: 0x1A6EB60 VA: 0x181A70560
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x1A70760 Offset: 0x1A6ED60 VA: 0x181A70760
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6EA30 Offset: 0x1A6D030 VA: 0x181A6EA30
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x1A6E5D0 Offset: 0x1A6CBD0 VA: 0x181A6E5D0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x1A6F0E0 Offset: 0x1A6D6E0 VA: 0x181A6F0E0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x1A6EFA0 Offset: 0x1A6D5A0 VA: 0x181A6EFA0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x1A6E770 Offset: 0x1A6CD70 VA: 0x181A6E770
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x1A6ED70 Offset: 0x1A6D370 VA: 0x181A6ED70
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x1A6F250 Offset: 0x1A6D850 VA: 0x181A6F250
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x1A6EC10 Offset: 0x1A6D210 VA: 0x181A6EC10
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A6E020 Offset: 0x1A6C620 VA: 0x181A6E020
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A6BBF0 Offset: 0x1A6A1F0 VA: 0x181A6BBF0
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x1A6AFE0 Offset: 0x1A695E0 VA: 0x181A6AFE0
	public static void Box(Rect position, string text) { }

	// RVA: 0x1A6ADE0 Offset: 0x1A693E0 VA: 0x181A6ADE0
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6B0A0 Offset: 0x1A696A0 VA: 0x181A6B0A0
	public static bool Button(Rect position, string text) { }

	// RVA: 0x1A6B2D0 Offset: 0x1A698D0 VA: 0x181A6B2D0
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6B160 Offset: 0x1A69760 VA: 0x181A6B160
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A707F0 Offset: 0x1A6EDF0 VA: 0x181A707F0
	internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

	// RVA: 0x1A6DD20 Offset: 0x1A6C320 VA: 0x181A6DD20
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x1A6DE20 Offset: 0x1A6C420 VA: 0x181A6DE20
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x1A6DA50 Offset: 0x1A6C050 VA: 0x181A6DA50
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

	// RVA: 0x1A6FC50 Offset: 0x1A6E250 VA: 0x181A6FC50
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

	// RVA: 0x1A6F460 Offset: 0x1A6DA60 VA: 0x181A6F460
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x1A70E50 Offset: 0x1A6F450 VA: 0x181A70E50
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A70A50 Offset: 0x1A6F050 VA: 0x181A70A50
	public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount) { }

	// RVA: 0x1A70950 Offset: 0x1A6EF50 VA: 0x181A70950
	public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { }

	// RVA: 0x1A6B9E0 Offset: 0x1A69FE0 VA: 0x181A6B9E0
	internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

	// RVA: 0x1A6D1D0 Offset: 0x1A6B7D0 VA: 0x181A6D1D0
	private static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6D610 Offset: 0x1A6BC10 VA: 0x181A6D610
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6DEE0 Offset: 0x1A6C4E0 VA: 0x181A6DEE0
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6D0A0 Offset: 0x1A6B6A0 VA: 0x181A6D0A0
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6C3B0 Offset: 0x1A6A9B0 VA: 0x181A6C3B0
	private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

	// RVA: 0x1A6B4C0 Offset: 0x1A69AC0 VA: 0x181A6B4C0
	private static Rect[] CalcMouseRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders, GUI.ToolbarButtonSize buttonSize) { }

	// RVA: 0x1A70320 Offset: 0x1A6E920 VA: 0x181A70320
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue) { }

	// RVA: 0x1A70250 Offset: 0x1A6E850 VA: 0x181A70250
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x1A70BF0 Offset: 0x1A6F1F0 VA: 0x181A70BF0
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x1A6A9C0 Offset: 0x1A68FC0 VA: 0x181A6A9C0
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6AA80 Offset: 0x1A69080 VA: 0x181A6AA80
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x1A6F3E0 Offset: 0x1A6D9E0 VA: 0x181A6F3E0
	public static void EndGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A717A0 Offset: 0x1A6FDA0 VA: 0x181A717A0
	internal static GenericStack get_scrollViewStates() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A6BF20 Offset: 0x1A6A520 VA: 0x181A6BF20
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x1A713E0 Offset: 0x1A6F9E0 VA: 0x181A713E0
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x1A71980 Offset: 0x1A6FF80 VA: 0x181A71980
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x1A71290 Offset: 0x1A6F890 VA: 0x181A71290
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x1A71890 Offset: 0x1A6FE90 VA: 0x181A71890
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x1A714A0 Offset: 0x1A6FAA0 VA: 0x181A714A0
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x1A71A30 Offset: 0x1A70030 VA: 0x181A71A30
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

	// RVA: 0x1A74550 Offset: 0x1A72B50 VA: 0x181A74550 Slot: 12
	public virtual void Invoke(int id) { }

	// RVA: 0x1A744D0 Offset: 0x1A72AD0 VA: 0x181A744D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

