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

	// RVA: 0x1A84C30 Offset: 0x1A83230 VA: 0x181A84C30
	public static Color get_color() { }

	// RVA: 0x1A851D0 Offset: 0x1A837D0 VA: 0x181A851D0
	public static void set_color(Color value) { }

	// RVA: 0x1A84AE0 Offset: 0x1A830E0 VA: 0x181A84AE0
	public static Color get_backgroundColor() { }

	// RVA: 0x1A850E0 Offset: 0x1A836E0 VA: 0x181A850E0
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x1A84CF0 Offset: 0x1A832F0 VA: 0x181A84CF0
	public static Color get_contentColor() { }

	// RVA: 0x1A85280 Offset: 0x1A83880 VA: 0x181A85280
	public static void set_contentColor(Color value) { }

	// RVA: 0x1A84BC0 Offset: 0x1A831C0 VA: 0x181A84BC0
	public static bool get_changed() { }

	// RVA: 0x1A85150 Offset: 0x1A83750 VA: 0x181A85150
	public static void set_changed(bool value) { }

	// RVA: 0x1A84D70 Offset: 0x1A83370 VA: 0x181A84D70
	public static bool get_enabled() { }

	// RVA: 0x1A852F0 Offset: 0x1A838F0 VA: 0x181A852F0
	public static void set_enabled(bool value) { }

	// RVA: 0x1A85070 Offset: 0x1A83670 VA: 0x181A85070
	internal static bool get_usePageScrollbars() { }

	[FreeFunctionAttribute] // RVA: 0xCA9A0 Offset: 0xC9DA0 VA: 0x1800CA9A0
	// RVA: 0x1A84B60 Offset: 0x1A83160 VA: 0x181A84B60
	internal static Material get_blendMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCAA00 Offset: 0xC9E00 VA: 0x1800CAA00
	// RVA: 0x1A84B90 Offset: 0x1A83190 VA: 0x181A84B90
	internal static Material get_blitMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCAA70 Offset: 0xC9E70 VA: 0x1800CAA70
	// RVA: 0x1A84E90 Offset: 0x1A83490 VA: 0x181A84E90
	internal static Material get_roundedRectMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCACC0 Offset: 0xCA0C0 VA: 0x1800CACC0
	// RVA: 0x1A84EC0 Offset: 0x1A834C0 VA: 0x181A84EC0
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x1A82C30 Offset: 0x1A81230 VA: 0x181A82C30
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x1A83A20 Offset: 0x1A82020 VA: 0x181A83A20
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x1A84130 Offset: 0x1A82730 VA: 0x181A84130
	internal static void ReleaseMouseControl() { }

	[FreeFunctionAttribute] // RVA: 0xCAE40 Offset: 0xCA240 VA: 0x1800CAE40
	// RVA: 0x1A843C0 Offset: 0x1A829C0 VA: 0x181A843C0
	public static void SetNextControlName(string name) { }

	// RVA: 0x1A83D40 Offset: 0x1A82340 VA: 0x181A83D40
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x1A84820 Offset: 0x1A82E20 VA: 0x181A84820
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A84EF0 Offset: 0x1A834F0 VA: 0x181A84EF0
	internal static int get_scrollTroughSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A85450 Offset: 0x1A83A50 VA: 0x181A85450
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A84E30 Offset: 0x1A83430 VA: 0x181A84E30
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A85390 Offset: 0x1A83990 VA: 0x181A85390
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x1A85510 Offset: 0x1A83B10 VA: 0x181A85510
	public static void set_skin(GUISkin value) { }

	// RVA: 0x1A85010 Offset: 0x1A83610 VA: 0x181A85010
	public static GUISkin get_skin() { }

	// RVA: 0x1A810B0 Offset: 0x1A7F6B0 VA: 0x181A810B0
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x1A84DA0 Offset: 0x1A833A0 VA: 0x181A84DA0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1A85330 Offset: 0x1A83930 VA: 0x181A85330
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1A83E60 Offset: 0x1A82460 VA: 0x181A83E60
	public static void Label(Rect position, string text) { }

	// RVA: 0x1A83D70 Offset: 0x1A82370 VA: 0x181A83D70
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x1A83F70 Offset: 0x1A82570 VA: 0x181A83F70
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A82240 Offset: 0x1A80840 VA: 0x181A82240
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x1A81DE0 Offset: 0x1A803E0 VA: 0x181A81DE0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x1A828F0 Offset: 0x1A80EF0 VA: 0x181A828F0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x1A827B0 Offset: 0x1A80DB0 VA: 0x181A827B0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x1A81F80 Offset: 0x1A80580 VA: 0x181A81F80
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x1A82580 Offset: 0x1A80B80 VA: 0x181A82580
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x1A82A60 Offset: 0x1A81060 VA: 0x181A82A60
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x1A82420 Offset: 0x1A80A20 VA: 0x181A82420
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A81830 Offset: 0x1A7FE30 VA: 0x181A81830
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A7F400 Offset: 0x1A7DA00 VA: 0x181A7F400
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x1A7E7F0 Offset: 0x1A7CDF0 VA: 0x181A7E7F0
	public static void Box(Rect position, string text) { }

	// RVA: 0x1A7E5F0 Offset: 0x1A7CBF0 VA: 0x181A7E5F0
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7E8B0 Offset: 0x1A7CEB0 VA: 0x181A7E8B0
	public static bool Button(Rect position, string text) { }

	// RVA: 0x1A7EAE0 Offset: 0x1A7D0E0 VA: 0x181A7EAE0
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7E970 Offset: 0x1A7CF70 VA: 0x181A7E970
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A84000 Offset: 0x1A82600 VA: 0x181A84000
	internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

	// RVA: 0x1A81530 Offset: 0x1A7FB30 VA: 0x181A81530
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x1A81630 Offset: 0x1A7FC30 VA: 0x181A81630
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x1A81260 Offset: 0x1A7F860 VA: 0x181A81260
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

	// RVA: 0x1A83460 Offset: 0x1A81A60 VA: 0x181A83460
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

	// RVA: 0x1A82C70 Offset: 0x1A81270 VA: 0x181A82C70
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x1A84660 Offset: 0x1A82C60 VA: 0x181A84660
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A84260 Offset: 0x1A82860 VA: 0x181A84260
	public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount) { }

	// RVA: 0x1A84160 Offset: 0x1A82760 VA: 0x181A84160
	public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { }

	// RVA: 0x1A7F1F0 Offset: 0x1A7D7F0 VA: 0x181A7F1F0
	internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

	// RVA: 0x1A809E0 Offset: 0x1A7EFE0 VA: 0x181A809E0
	private static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A80E20 Offset: 0x1A7F420 VA: 0x181A80E20
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A816F0 Offset: 0x1A7FCF0 VA: 0x181A816F0
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A808B0 Offset: 0x1A7EEB0 VA: 0x181A808B0
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7FBC0 Offset: 0x1A7E1C0 VA: 0x181A7FBC0
	private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

	// RVA: 0x1A7ECD0 Offset: 0x1A7D2D0 VA: 0x181A7ECD0
	private static Rect[] CalcMouseRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders, GUI.ToolbarButtonSize buttonSize) { }

	// RVA: 0x1A83B30 Offset: 0x1A82130 VA: 0x181A83B30
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue) { }

	// RVA: 0x1A83A60 Offset: 0x1A82060 VA: 0x181A83A60
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x1A84400 Offset: 0x1A82A00 VA: 0x181A84400
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x1A7E1D0 Offset: 0x1A7C7D0 VA: 0x181A7E1D0
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A7E290 Offset: 0x1A7C890 VA: 0x181A7E290
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x1A82BF0 Offset: 0x1A811F0 VA: 0x181A82BF0
	public static void EndGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A84FB0 Offset: 0x1A835B0 VA: 0x181A84FB0
	internal static GenericStack get_scrollViewStates() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7F730 Offset: 0x1A7DD30 VA: 0x181A7F730
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x1A84BF0 Offset: 0x1A831F0 VA: 0x181A84BF0
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x1A85190 Offset: 0x1A83790 VA: 0x181A85190
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x1A84AA0 Offset: 0x1A830A0 VA: 0x181A84AA0
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x1A850A0 Offset: 0x1A836A0 VA: 0x181A850A0
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x1A84CB0 Offset: 0x1A832B0 VA: 0x181A84CB0
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x1A85240 Offset: 0x1A83840 VA: 0x181A85240
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

	// RVA: 0x1A463E0 Offset: 0x1A449E0 VA: 0x181A463E0 Slot: 12
	public virtual void Invoke(int id) { }

	// RVA: 0x1A87CE0 Offset: 0x1A862E0 VA: 0x181A87CE0 Slot: 13
	public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

