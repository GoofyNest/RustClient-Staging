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
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static int <scrollTroughSide>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x28
	private static GUISkin s_Skin; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
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

	// RVA: 0x1A84C70 Offset: 0x1A83270 VA: 0x181A84C70
	public static Color get_color() { }

	// RVA: 0x1A85210 Offset: 0x1A83810 VA: 0x181A85210
	public static void set_color(Color value) { }

	// RVA: 0x1A84B20 Offset: 0x1A83120 VA: 0x181A84B20
	public static Color get_backgroundColor() { }

	// RVA: 0x1A85120 Offset: 0x1A83720 VA: 0x181A85120
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x1A84D30 Offset: 0x1A83330 VA: 0x181A84D30
	public static Color get_contentColor() { }

	// RVA: 0x1A852C0 Offset: 0x1A838C0 VA: 0x181A852C0
	public static void set_contentColor(Color value) { }

	// RVA: 0x1A84C00 Offset: 0x1A83200 VA: 0x181A84C00
	public static bool get_changed() { }

	// RVA: 0x1A85190 Offset: 0x1A83790 VA: 0x181A85190
	public static void set_changed(bool value) { }

	// RVA: 0x1A84DB0 Offset: 0x1A833B0 VA: 0x181A84DB0
	public static bool get_enabled() { }

	// RVA: 0x1A85330 Offset: 0x1A83930 VA: 0x181A85330
	public static void set_enabled(bool value) { }

	// RVA: 0x1A850B0 Offset: 0x1A836B0 VA: 0x181A850B0
	internal static bool get_usePageScrollbars() { }

	[FreeFunctionAttribute] // RVA: 0xCA910 Offset: 0xC9D10 VA: 0x1800CA910
	// RVA: 0x1A84BA0 Offset: 0x1A831A0 VA: 0x181A84BA0
	internal static Material get_blendMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCA970 Offset: 0xC9D70 VA: 0x1800CA970
	// RVA: 0x1A84BD0 Offset: 0x1A831D0 VA: 0x181A84BD0
	internal static Material get_blitMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCAA20 Offset: 0xC9E20 VA: 0x1800CAA20
	// RVA: 0x1A84ED0 Offset: 0x1A834D0 VA: 0x181A84ED0
	internal static Material get_roundedRectMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCAC70 Offset: 0xCA070 VA: 0x1800CAC70
	// RVA: 0x1A84F00 Offset: 0x1A83500 VA: 0x181A84F00
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x1A82C70 Offset: 0x1A81270 VA: 0x181A82C70
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x1A83A60 Offset: 0x1A82060 VA: 0x181A83A60
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x1A84170 Offset: 0x1A82770 VA: 0x181A84170
	internal static void ReleaseMouseControl() { }

	[FreeFunctionAttribute] // RVA: 0xCAE00 Offset: 0xCA200 VA: 0x1800CAE00
	// RVA: 0x1A84400 Offset: 0x1A82A00 VA: 0x181A84400
	public static void SetNextControlName(string name) { }

	// RVA: 0x1A83D80 Offset: 0x1A82380 VA: 0x181A83D80
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x1A84860 Offset: 0x1A82E60 VA: 0x181A84860
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A84F30 Offset: 0x1A83530 VA: 0x181A84F30
	internal static int get_scrollTroughSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A85490 Offset: 0x1A83A90 VA: 0x181A85490
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A84E70 Offset: 0x1A83470 VA: 0x181A84E70
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A853D0 Offset: 0x1A839D0 VA: 0x181A853D0
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x1A85550 Offset: 0x1A83B50 VA: 0x181A85550
	public static void set_skin(GUISkin value) { }

	// RVA: 0x1A85050 Offset: 0x1A83650 VA: 0x181A85050
	public static GUISkin get_skin() { }

	// RVA: 0x1A810F0 Offset: 0x1A7F6F0 VA: 0x181A810F0
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x1A84DE0 Offset: 0x1A833E0 VA: 0x181A84DE0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1A85370 Offset: 0x1A83970 VA: 0x181A85370
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1A83EA0 Offset: 0x1A824A0 VA: 0x181A83EA0
	public static void Label(Rect position, string text) { }

	// RVA: 0x1A83DB0 Offset: 0x1A823B0 VA: 0x181A83DB0
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x1A83FB0 Offset: 0x1A825B0 VA: 0x181A83FB0
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A82280 Offset: 0x1A80880 VA: 0x181A82280
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x1A81E20 Offset: 0x1A80420 VA: 0x181A81E20
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x1A82930 Offset: 0x1A80F30 VA: 0x181A82930
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x1A827F0 Offset: 0x1A80DF0 VA: 0x181A827F0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x1A81FC0 Offset: 0x1A805C0 VA: 0x181A81FC0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x1A825C0 Offset: 0x1A80BC0 VA: 0x181A825C0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x1A82AA0 Offset: 0x1A810A0 VA: 0x181A82AA0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x1A82460 Offset: 0x1A80A60 VA: 0x181A82460
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A81870 Offset: 0x1A7FE70 VA: 0x181A81870
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A7F440 Offset: 0x1A7DA40 VA: 0x181A7F440
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x1A7E830 Offset: 0x1A7CE30 VA: 0x181A7E830
	public static void Box(Rect position, string text) { }

	// RVA: 0x1A7E630 Offset: 0x1A7CC30 VA: 0x181A7E630
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7E8F0 Offset: 0x1A7CEF0 VA: 0x181A7E8F0
	public static bool Button(Rect position, string text) { }

	// RVA: 0x1A7EB20 Offset: 0x1A7D120 VA: 0x181A7EB20
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7E9B0 Offset: 0x1A7CFB0 VA: 0x181A7E9B0
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A84040 Offset: 0x1A82640 VA: 0x181A84040
	internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

	// RVA: 0x1A81570 Offset: 0x1A7FB70 VA: 0x181A81570
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x1A81670 Offset: 0x1A7FC70 VA: 0x181A81670
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x1A812A0 Offset: 0x1A7F8A0 VA: 0x181A812A0
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

	// RVA: 0x1A834A0 Offset: 0x1A81AA0 VA: 0x181A834A0
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

	// RVA: 0x1A82CB0 Offset: 0x1A812B0 VA: 0x181A82CB0
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x1A846A0 Offset: 0x1A82CA0 VA: 0x181A846A0
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A842A0 Offset: 0x1A828A0 VA: 0x181A842A0
	public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount) { }

	// RVA: 0x1A841A0 Offset: 0x1A827A0 VA: 0x181A841A0
	public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { }

	// RVA: 0x1A7F230 Offset: 0x1A7D830 VA: 0x181A7F230
	internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

	// RVA: 0x1A80A20 Offset: 0x1A7F020 VA: 0x181A80A20
	private static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A80E60 Offset: 0x1A7F460 VA: 0x181A80E60
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A81730 Offset: 0x1A7FD30 VA: 0x181A81730
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A808F0 Offset: 0x1A7EEF0 VA: 0x181A808F0
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7FC00 Offset: 0x1A7E200 VA: 0x181A7FC00
	private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

	// RVA: 0x1A7ED10 Offset: 0x1A7D310 VA: 0x181A7ED10
	private static Rect[] CalcMouseRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders, GUI.ToolbarButtonSize buttonSize) { }

	// RVA: 0x1A83B70 Offset: 0x1A82170 VA: 0x181A83B70
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue) { }

	// RVA: 0x1A83AA0 Offset: 0x1A820A0 VA: 0x181A83AA0
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x1A84440 Offset: 0x1A82A40 VA: 0x181A84440
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x1A7E210 Offset: 0x1A7C810 VA: 0x181A7E210
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7E2D0 Offset: 0x1A7C8D0 VA: 0x181A7E2D0
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x1A82C30 Offset: 0x1A81230 VA: 0x181A82C30
	public static void EndGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A84FF0 Offset: 0x1A835F0 VA: 0x181A84FF0
	internal static GenericStack get_scrollViewStates() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7F770 Offset: 0x1A7DD70 VA: 0x181A7F770
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x1A84C30 Offset: 0x1A83230 VA: 0x181A84C30
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x1A851D0 Offset: 0x1A837D0 VA: 0x181A851D0
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x1A84AE0 Offset: 0x1A830E0 VA: 0x181A84AE0
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x1A850E0 Offset: 0x1A836E0 VA: 0x181A850E0
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x1A84CF0 Offset: 0x1A832F0 VA: 0x181A84CF0
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x1A85280 Offset: 0x1A83880 VA: 0x181A85280
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

	// RVA: 0x1A46420 Offset: 0x1A44A20 VA: 0x181A46420 Slot: 12
	public virtual void Invoke(int id) { }

	// RVA: 0x1A87D20 Offset: 0x1A86320 VA: 0x181A87D20 Slot: 13
	public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

