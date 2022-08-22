public sealed class GUIStyle // TypeDefIndex: 4048
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	[NativePropertyAttribute] // RVA: 0xD5C50 Offset: 0xD5050 VA: 0x1800D5C50
	internal string rawName { get; set; }
	[NativePropertyAttribute] // RVA: 0xD5C90 Offset: 0xD5090 VA: 0x1800D5C90
	public Font font { get; }
	[NativePropertyAttribute] // RVA: 0xD5CD0 Offset: 0xD50D0 VA: 0x1800D5CD0
	public ImagePosition imagePosition { get; }
	[NativePropertyAttribute] // RVA: 0xD5E00 Offset: 0xD5200 VA: 0x1800D5E00
	public TextAnchor alignment { set; }
	[NativePropertyAttribute] // RVA: 0xD5F20 Offset: 0xD5320 VA: 0x1800D5F20
	public bool wordWrap { get; }
	[NativePropertyAttribute] // RVA: 0xD5FB0 Offset: 0xD53B0 VA: 0x1800D5FB0
	public Vector2 contentOffset { get; set; }
	[NativePropertyAttribute] // RVA: 0xD5FF0 Offset: 0xD53F0 VA: 0x1800D5FF0
	public float fixedWidth { get; }
	[NativePropertyAttribute] // RVA: 0xD60C0 Offset: 0xD54C0 VA: 0x1800D60C0
	public float fixedHeight { get; }
	[NativePropertyAttribute] // RVA: 0xD6220 Offset: 0xD5620 VA: 0x1800D6220
	public bool stretchWidth { get; set; }
	[NativePropertyAttribute] // RVA: 0xD6330 Offset: 0xD5730 VA: 0x1800D6330
	public bool stretchHeight { get; set; }
	[NativePropertyAttribute] // RVA: 0xD6370 Offset: 0xD5770 VA: 0x1800D6370
	public int fontSize { set; }
	[NativePropertyAttribute] // RVA: 0xD6400 Offset: 0xD5800 VA: 0x1800D6400
	internal Vector2 Internal_clipOffset { set; }
	public string name { get; set; }
	public GUIStyleState normal { get; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public float lineHeight { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0x1A7BD30 Offset: 0x1A7A330 VA: 0x181A7BD30
	internal string get_rawName() { }

	// RVA: 0x1A7C100 Offset: 0x1A7A700 VA: 0x181A7C100
	internal void set_rawName(string value) { }

	// RVA: 0x1A7B820 Offset: 0x1A79E20 VA: 0x181A7B820
	public Font get_font() { }

	// RVA: 0x1A7B860 Offset: 0x1A79E60 VA: 0x181A7B860
	public ImagePosition get_imagePosition() { }

	// RVA: 0x1A7BFA0 Offset: 0x1A7A5A0 VA: 0x181A7BFA0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1A7BDF0 Offset: 0x1A7A3F0 VA: 0x181A7BDF0
	public bool get_wordWrap() { }

	// RVA: 0x1A7B750 Offset: 0x1A79D50 VA: 0x181A7B750
	public Vector2 get_contentOffset() { }

	// RVA: 0x1A7C030 Offset: 0x1A7A630 VA: 0x181A7C030
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x1A7B7E0 Offset: 0x1A79DE0 VA: 0x181A7B7E0
	public float get_fixedWidth() { }

	// RVA: 0x1A7B7A0 Offset: 0x1A79DA0 VA: 0x181A7B7A0
	public float get_fixedHeight() { }

	// RVA: 0x1A7BDB0 Offset: 0x1A7A3B0 VA: 0x181A7BDB0
	public bool get_stretchWidth() { }

	// RVA: 0x1A7C1A0 Offset: 0x1A7A7A0 VA: 0x181A7C1A0
	public void set_stretchWidth(bool value) { }

	// RVA: 0x1A7BD70 Offset: 0x1A7A370 VA: 0x181A7BD70
	public bool get_stretchHeight() { }

	// RVA: 0x1A7C150 Offset: 0x1A7A750 VA: 0x181A7C150
	public void set_stretchHeight(bool value) { }

	// RVA: 0x1A7C070 Offset: 0x1A7A670 VA: 0x181A7C070
	public void set_fontSize(int value) { }

	// RVA: 0x1A7BF60 Offset: 0x1A7A560 VA: 0x181A7BF60
	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xD2250 Offset: 0xD1650 VA: 0x1800D2250
	// RVA: 0x1A7AB60 Offset: 0x1A79160 VA: 0x181A7AB60
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0xD2370 Offset: 0xD1770 VA: 0x1800D2370
	// RVA: 0x1A7AB10 Offset: 0x1A79110 VA: 0x181A7AB10
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] // RVA: 0xD2430 Offset: 0xD1830 VA: 0x1800D2430
	// RVA: 0x1A7ABA0 Offset: 0x1A791A0 VA: 0x181A7ABA0
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0xD25F0 Offset: 0xD19F0 VA: 0x1800D25F0
	// RVA: 0x1A7A940 Offset: 0x1A78F40 VA: 0x181A7A940
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD26E0 Offset: 0xD1AE0 VA: 0x1800D26E0
	// RVA: 0x1A7A900 Offset: 0x1A78F00 VA: 0x181A7A900
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD27D0 Offset: 0xD1BD0 VA: 0x1800D27D0
	// RVA: 0x1A7B230 Offset: 0x1A79830 VA: 0x181A7B230
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] // RVA: 0xD29D0 Offset: 0xD1DD0 VA: 0x1800D29D0
	// RVA: 0x1A7AFB0 Offset: 0x1A795B0 VA: 0x181A7AFB0
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0xD3DC0 Offset: 0xD31C0 VA: 0x1800D3DC0
	// RVA: 0x1A7AC50 Offset: 0x1A79250 VA: 0x181A7AC50
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0xD3E90 Offset: 0xD3290 VA: 0x1800D3E90
	// RVA: 0x1A7AD30 Offset: 0x1A79330 VA: 0x181A7AD30
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] // RVA: 0xD3FB0 Offset: 0xD33B0 VA: 0x1800D3FB0
	// RVA: 0x1A7AE50 Offset: 0x1A79450 VA: 0x181A7AE50
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] // RVA: 0xD53F0 Offset: 0xD47F0 VA: 0x1800D53F0
	// RVA: 0x1A7B0E0 Offset: 0x1A796E0 VA: 0x181A7B0E0
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5510 Offset: 0xD4910 VA: 0x1800D5510
	// RVA: 0x1A7B1D0 Offset: 0x1A797D0 VA: 0x181A7B1D0
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD55A0 Offset: 0xD49A0 VA: 0x1800D55A0
	// RVA: 0x1A7B2E0 Offset: 0x1A798E0 VA: 0x181A7B2E0
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5620 Offset: 0xD4A20 VA: 0x1800D5620
	// RVA: 0x1A79850 Offset: 0x1A77E50 VA: 0x181A79850
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5790 Offset: 0xD4B90 VA: 0x1800D5790
	// RVA: 0x1A797F0 Offset: 0x1A77DF0 VA: 0x181A797F0
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0xD5820 Offset: 0xD4C20 VA: 0x1800D5820
	// RVA: 0x1A79710 Offset: 0x1A77D10 VA: 0x181A79710
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0xD5860 Offset: 0xD4C60 VA: 0x1800D5860
	// RVA: 0x1A7A9E0 Offset: 0x1A78FE0 VA: 0x181A7A9E0
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5A00 Offset: 0xD4E00 VA: 0x1800D5A00
	// RVA: 0x1A7B3E0 Offset: 0x1A799E0 VA: 0x181A7B3E0
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0xD5AD0 Offset: 0xD4ED0 VA: 0x1800D5AD0
	// RVA: 0x1A7B040 Offset: 0x1A79640 VA: 0x181A7B040
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] // RVA: 0xD5BD0 Offset: 0xD4FD0 VA: 0x1800D5BD0
	// RVA: 0x1A7B350 Offset: 0x1A79950 VA: 0x181A7B350
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x1A7B680 Offset: 0x1A79C80 VA: 0x181A7B680
	public void .ctor() { }

	// RVA: 0x1A7B5B0 Offset: 0x1A79BB0 VA: 0x181A7B5B0
	public void .ctor(GUIStyle other) { }

	// RVA: 0x1A7A720 Offset: 0x1A78D20 VA: 0x181A7A720 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A7BAA0 Offset: 0x1A7A0A0 VA: 0x181A7BAA0
	public string get_name() { }

	// RVA: 0x1A7C0B0 Offset: 0x1A7A6B0 VA: 0x181A7C0B0
	public void set_name(string value) { }

	// RVA: 0x1A7BBC0 Offset: 0x1A7A1C0 VA: 0x181A7BBC0
	public GUIStyleState get_normal() { }

	// RVA: 0x1A7B9F0 Offset: 0x1A79FF0 VA: 0x181A7B9F0
	public RectOffset get_margin() { }

	// RVA: 0x1A7BC80 Offset: 0x1A7A280 VA: 0x181A7BC80
	public RectOffset get_padding() { }

	// RVA: 0x1A7B940 Offset: 0x1A79F40 VA: 0x181A7B940
	public float get_lineHeight() { }

	// RVA: 0x1A7A4F0 Offset: 0x1A78AF0 VA: 0x181A7A4F0
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A7A660 Offset: 0x1A78C60 VA: 0x181A7A660
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x1A7A420 Offset: 0x1A78A20 VA: 0x181A7A420
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A7A300 Offset: 0x1A78900 VA: 0x181A7A300
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x1A7A580 Offset: 0x1A78B80 VA: 0x181A7A580
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A798B0 Offset: 0x1A77EB0 VA: 0x181A798B0
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x1A79D70 Offset: 0x1A78370 VA: 0x181A79D70
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x1A79B90 Offset: 0x1A78190 VA: 0x181A79B90
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x1A7A130 Offset: 0x1A78730 VA: 0x181A7A130
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x1A7BE30 Offset: 0x1A7A430 VA: 0x181A7BE30
	public static GUIStyle op_Implicit(string str) { }

	// RVA: 0x1A7BB00 Offset: 0x1A7A100 VA: 0x181A7BB00
	public static GUIStyle get_none() { }

	// RVA: 0x1A7A820 Offset: 0x1A78E20 VA: 0x181A7A820
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x1A7A8A0 Offset: 0x1A78EA0 VA: 0x181A7A8A0
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x1A79850 Offset: 0x1A77E50 VA: 0x181A79850
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x1A797F0 Offset: 0x1A77DF0 VA: 0x181A797F0
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x1A79710 Offset: 0x1A77D10 VA: 0x181A79710
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x1A7B8A0 Offset: 0x1A79EA0 VA: 0x181A7B8A0
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x1A79770 Offset: 0x1A77D70 VA: 0x181A79770
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x1A7B460 Offset: 0x1A79A60 VA: 0x181A7B460 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A7B570 Offset: 0x1A79B70 VA: 0x181A7B570
	private static void .cctor() { }

	// RVA: 0x1A7B700 Offset: 0x1A79D00 VA: 0x181A7B700
	private void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0x1A7BFE0 Offset: 0x1A7A5E0 VA: 0x181A7BFE0
	private void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A7BF10 Offset: 0x1A7A510 VA: 0x181A7BF10
	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A7AF20 Offset: 0x1A79520 VA: 0x181A7AF20
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A7ABE0 Offset: 0x1A791E0 VA: 0x181A7ABE0
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A7ACC0 Offset: 0x1A792C0 VA: 0x181A7ACC0
	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	// RVA: 0x1A7ADA0 Offset: 0x1A793A0 VA: 0x181A7ADA0
	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0x1A7B070 Offset: 0x1A79670 VA: 0x181A7B070
	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	// RVA: 0x1A7B160 Offset: 0x1A79760 VA: 0x181A7B160
	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0x1A7B270 Offset: 0x1A79870 VA: 0x181A7B270
	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x1A7AAB0 Offset: 0x1A790B0 VA: 0x181A7AAB0
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A7AA40 Offset: 0x1A79040 VA: 0x181A7AA40
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x1A7A980 Offset: 0x1A78F80 VA: 0x181A7A980
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A7B390 Offset: 0x1A79990 VA: 0x181A7B390
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

}

