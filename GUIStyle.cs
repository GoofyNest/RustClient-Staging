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

	// RVA: 0x1A7BFF0 Offset: 0x1A7A5F0 VA: 0x181A7BFF0
	internal string get_rawName() { }

	// RVA: 0x1A7C3C0 Offset: 0x1A7A9C0 VA: 0x181A7C3C0
	internal void set_rawName(string value) { }

	// RVA: 0x1A7BAE0 Offset: 0x1A7A0E0 VA: 0x181A7BAE0
	public Font get_font() { }

	// RVA: 0x1A7BB20 Offset: 0x1A7A120 VA: 0x181A7BB20
	public ImagePosition get_imagePosition() { }

	// RVA: 0x1A7C260 Offset: 0x1A7A860 VA: 0x181A7C260
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1A7C0B0 Offset: 0x1A7A6B0 VA: 0x181A7C0B0
	public bool get_wordWrap() { }

	// RVA: 0x1A7BA10 Offset: 0x1A7A010 VA: 0x181A7BA10
	public Vector2 get_contentOffset() { }

	// RVA: 0x1A7C2F0 Offset: 0x1A7A8F0 VA: 0x181A7C2F0
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x1A7BAA0 Offset: 0x1A7A0A0 VA: 0x181A7BAA0
	public float get_fixedWidth() { }

	// RVA: 0x1A7BA60 Offset: 0x1A7A060 VA: 0x181A7BA60
	public float get_fixedHeight() { }

	// RVA: 0x1A7C070 Offset: 0x1A7A670 VA: 0x181A7C070
	public bool get_stretchWidth() { }

	// RVA: 0x1A7C460 Offset: 0x1A7AA60 VA: 0x181A7C460
	public void set_stretchWidth(bool value) { }

	// RVA: 0x1A7C030 Offset: 0x1A7A630 VA: 0x181A7C030
	public bool get_stretchHeight() { }

	// RVA: 0x1A7C410 Offset: 0x1A7AA10 VA: 0x181A7C410
	public void set_stretchHeight(bool value) { }

	// RVA: 0x1A7C330 Offset: 0x1A7A930 VA: 0x181A7C330
	public void set_fontSize(int value) { }

	// RVA: 0x1A7C220 Offset: 0x1A7A820 VA: 0x181A7C220
	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xD2250 Offset: 0xD1650 VA: 0x1800D2250
	// RVA: 0x1A7AE20 Offset: 0x1A79420 VA: 0x181A7AE20
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0xD2370 Offset: 0xD1770 VA: 0x1800D2370
	// RVA: 0x1A7ADD0 Offset: 0x1A793D0 VA: 0x181A7ADD0
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] // RVA: 0xD2430 Offset: 0xD1830 VA: 0x1800D2430
	// RVA: 0x1A7AE60 Offset: 0x1A79460 VA: 0x181A7AE60
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0xD25F0 Offset: 0xD19F0 VA: 0x1800D25F0
	// RVA: 0x1A7AC00 Offset: 0x1A79200 VA: 0x181A7AC00
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD26E0 Offset: 0xD1AE0 VA: 0x1800D26E0
	// RVA: 0x1A7ABC0 Offset: 0x1A791C0 VA: 0x181A7ABC0
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD27D0 Offset: 0xD1BD0 VA: 0x1800D27D0
	// RVA: 0x1A7B4F0 Offset: 0x1A79AF0 VA: 0x181A7B4F0
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] // RVA: 0xD29D0 Offset: 0xD1DD0 VA: 0x1800D29D0
	// RVA: 0x1A7B270 Offset: 0x1A79870 VA: 0x181A7B270
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0xD3DC0 Offset: 0xD31C0 VA: 0x1800D3DC0
	// RVA: 0x1A7AF10 Offset: 0x1A79510 VA: 0x181A7AF10
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0xD3E90 Offset: 0xD3290 VA: 0x1800D3E90
	// RVA: 0x1A7AFF0 Offset: 0x1A795F0 VA: 0x181A7AFF0
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] // RVA: 0xD3FB0 Offset: 0xD33B0 VA: 0x1800D3FB0
	// RVA: 0x1A7B110 Offset: 0x1A79710 VA: 0x181A7B110
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] // RVA: 0xD53F0 Offset: 0xD47F0 VA: 0x1800D53F0
	// RVA: 0x1A7B3A0 Offset: 0x1A799A0 VA: 0x181A7B3A0
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5510 Offset: 0xD4910 VA: 0x1800D5510
	// RVA: 0x1A7B490 Offset: 0x1A79A90 VA: 0x181A7B490
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD55A0 Offset: 0xD49A0 VA: 0x1800D55A0
	// RVA: 0x1A7B5A0 Offset: 0x1A79BA0 VA: 0x181A7B5A0
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5620 Offset: 0xD4A20 VA: 0x1800D5620
	// RVA: 0x1A79B10 Offset: 0x1A78110 VA: 0x181A79B10
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5790 Offset: 0xD4B90 VA: 0x1800D5790
	// RVA: 0x1A79AB0 Offset: 0x1A780B0 VA: 0x181A79AB0
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0xD5820 Offset: 0xD4C20 VA: 0x1800D5820
	// RVA: 0x1A799D0 Offset: 0x1A77FD0 VA: 0x181A799D0
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0xD5860 Offset: 0xD4C60 VA: 0x1800D5860
	// RVA: 0x1A7ACA0 Offset: 0x1A792A0 VA: 0x181A7ACA0
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5A00 Offset: 0xD4E00 VA: 0x1800D5A00
	// RVA: 0x1A7B6A0 Offset: 0x1A79CA0 VA: 0x181A7B6A0
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0xD5AD0 Offset: 0xD4ED0 VA: 0x1800D5AD0
	// RVA: 0x1A7B300 Offset: 0x1A79900 VA: 0x181A7B300
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] // RVA: 0xD5BD0 Offset: 0xD4FD0 VA: 0x1800D5BD0
	// RVA: 0x1A7B610 Offset: 0x1A79C10 VA: 0x181A7B610
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x1A7B940 Offset: 0x1A79F40 VA: 0x181A7B940
	public void .ctor() { }

	// RVA: 0x1A7B870 Offset: 0x1A79E70 VA: 0x181A7B870
	public void .ctor(GUIStyle other) { }

	// RVA: 0x1A7A9E0 Offset: 0x1A78FE0 VA: 0x181A7A9E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A7BD60 Offset: 0x1A7A360 VA: 0x181A7BD60
	public string get_name() { }

	// RVA: 0x1A7C370 Offset: 0x1A7A970 VA: 0x181A7C370
	public void set_name(string value) { }

	// RVA: 0x1A7BE80 Offset: 0x1A7A480 VA: 0x181A7BE80
	public GUIStyleState get_normal() { }

	// RVA: 0x1A7BCB0 Offset: 0x1A7A2B0 VA: 0x181A7BCB0
	public RectOffset get_margin() { }

	// RVA: 0x1A7BF40 Offset: 0x1A7A540 VA: 0x181A7BF40
	public RectOffset get_padding() { }

	// RVA: 0x1A7BC00 Offset: 0x1A7A200 VA: 0x181A7BC00
	public float get_lineHeight() { }

	// RVA: 0x1A7A7B0 Offset: 0x1A78DB0 VA: 0x181A7A7B0
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A7A920 Offset: 0x1A78F20 VA: 0x181A7A920
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x1A7A6E0 Offset: 0x1A78CE0 VA: 0x181A7A6E0
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A7A5C0 Offset: 0x1A78BC0 VA: 0x181A7A5C0
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x1A7A840 Offset: 0x1A78E40 VA: 0x181A7A840
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A79B70 Offset: 0x1A78170 VA: 0x181A79B70
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x1A7A030 Offset: 0x1A78630 VA: 0x181A7A030
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x1A79E50 Offset: 0x1A78450 VA: 0x181A79E50
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x1A7A3F0 Offset: 0x1A789F0 VA: 0x181A7A3F0
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x1A7C0F0 Offset: 0x1A7A6F0 VA: 0x181A7C0F0
	public static GUIStyle op_Implicit(string str) { }

	// RVA: 0x1A7BDC0 Offset: 0x1A7A3C0 VA: 0x181A7BDC0
	public static GUIStyle get_none() { }

	// RVA: 0x1A7AAE0 Offset: 0x1A790E0 VA: 0x181A7AAE0
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x1A7AB60 Offset: 0x1A79160 VA: 0x181A7AB60
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x1A79B10 Offset: 0x1A78110 VA: 0x181A79B10
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x1A79AB0 Offset: 0x1A780B0 VA: 0x181A79AB0
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x1A799D0 Offset: 0x1A77FD0 VA: 0x181A799D0
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x1A7BB60 Offset: 0x1A7A160 VA: 0x181A7BB60
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x1A79A30 Offset: 0x1A78030 VA: 0x181A79A30
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x1A7B720 Offset: 0x1A79D20 VA: 0x181A7B720 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A7B830 Offset: 0x1A79E30 VA: 0x181A7B830
	private static void .cctor() { }

	// RVA: 0x1A7B9C0 Offset: 0x1A79FC0 VA: 0x181A7B9C0
	private void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0x1A7C2A0 Offset: 0x1A7A8A0 VA: 0x181A7C2A0
	private void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A7C1D0 Offset: 0x1A7A7D0 VA: 0x181A7C1D0
	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A7B1E0 Offset: 0x1A797E0 VA: 0x181A7B1E0
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A7AEA0 Offset: 0x1A794A0 VA: 0x181A7AEA0
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A7AF80 Offset: 0x1A79580 VA: 0x181A7AF80
	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	// RVA: 0x1A7B060 Offset: 0x1A79660 VA: 0x181A7B060
	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0x1A7B330 Offset: 0x1A79930 VA: 0x181A7B330
	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	// RVA: 0x1A7B420 Offset: 0x1A79A20 VA: 0x181A7B420
	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0x1A7B530 Offset: 0x1A79B30 VA: 0x181A7B530
	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x1A7AD70 Offset: 0x1A79370 VA: 0x181A7AD70
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A7AD00 Offset: 0x1A79300 VA: 0x181A7AD00
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x1A7AC40 Offset: 0x1A79240 VA: 0x181A7AC40
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A7B650 Offset: 0x1A79C50 VA: 0x181A7B650
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

}

