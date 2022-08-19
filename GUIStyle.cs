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
	[NativePropertyAttribute] // RVA: 0xD5BA0 Offset: 0xD4FA0 VA: 0x1800D5BA0
	internal string rawName { get; set; }
	[NativePropertyAttribute] // RVA: 0xD5C20 Offset: 0xD5020 VA: 0x1800D5C20
	public Font font { get; }
	[NativePropertyAttribute] // RVA: 0xD5C60 Offset: 0xD5060 VA: 0x1800D5C60
	public ImagePosition imagePosition { get; }
	[NativePropertyAttribute] // RVA: 0xD5D90 Offset: 0xD5190 VA: 0x1800D5D90
	public TextAnchor alignment { set; }
	[NativePropertyAttribute] // RVA: 0xD5EB0 Offset: 0xD52B0 VA: 0x1800D5EB0
	public bool wordWrap { get; }
	[NativePropertyAttribute] // RVA: 0xD5F40 Offset: 0xD5340 VA: 0x1800D5F40
	public Vector2 contentOffset { get; set; }
	[NativePropertyAttribute] // RVA: 0xD5F80 Offset: 0xD5380 VA: 0x1800D5F80
	public float fixedWidth { get; }
	[NativePropertyAttribute] // RVA: 0xD6050 Offset: 0xD5450 VA: 0x1800D6050
	public float fixedHeight { get; }
	[NativePropertyAttribute] // RVA: 0xD61B0 Offset: 0xD55B0 VA: 0x1800D61B0
	public bool stretchWidth { get; set; }
	[NativePropertyAttribute] // RVA: 0xD62C0 Offset: 0xD56C0 VA: 0x1800D62C0
	public bool stretchHeight { get; set; }
	[NativePropertyAttribute] // RVA: 0xD6300 Offset: 0xD5700 VA: 0x1800D6300
	public int fontSize { set; }
	[NativePropertyAttribute] // RVA: 0xD6390 Offset: 0xD5790 VA: 0x1800D6390
	internal Vector2 Internal_clipOffset { set; }
	public string name { get; set; }
	public GUIStyleState normal { get; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public float lineHeight { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0x1A7BD70 Offset: 0x1A7A370 VA: 0x181A7BD70
	internal string get_rawName() { }

	// RVA: 0x1A7C140 Offset: 0x1A7A740 VA: 0x181A7C140
	internal void set_rawName(string value) { }

	// RVA: 0x1A7B860 Offset: 0x1A79E60 VA: 0x181A7B860
	public Font get_font() { }

	// RVA: 0x1A7B8A0 Offset: 0x1A79EA0 VA: 0x181A7B8A0
	public ImagePosition get_imagePosition() { }

	// RVA: 0x1A7BFE0 Offset: 0x1A7A5E0 VA: 0x181A7BFE0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1A7BE30 Offset: 0x1A7A430 VA: 0x181A7BE30
	public bool get_wordWrap() { }

	// RVA: 0x1A7B790 Offset: 0x1A79D90 VA: 0x181A7B790
	public Vector2 get_contentOffset() { }

	// RVA: 0x1A7C070 Offset: 0x1A7A670 VA: 0x181A7C070
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x1A7B820 Offset: 0x1A79E20 VA: 0x181A7B820
	public float get_fixedWidth() { }

	// RVA: 0x1A7B7E0 Offset: 0x1A79DE0 VA: 0x181A7B7E0
	public float get_fixedHeight() { }

	// RVA: 0x1A7BDF0 Offset: 0x1A7A3F0 VA: 0x181A7BDF0
	public bool get_stretchWidth() { }

	// RVA: 0x1A7C1E0 Offset: 0x1A7A7E0 VA: 0x181A7C1E0
	public void set_stretchWidth(bool value) { }

	// RVA: 0x1A7BDB0 Offset: 0x1A7A3B0 VA: 0x181A7BDB0
	public bool get_stretchHeight() { }

	// RVA: 0x1A7C190 Offset: 0x1A7A790 VA: 0x181A7C190
	public void set_stretchHeight(bool value) { }

	// RVA: 0x1A7C0B0 Offset: 0x1A7A6B0 VA: 0x181A7C0B0
	public void set_fontSize(int value) { }

	// RVA: 0x1A7BFA0 Offset: 0x1A7A5A0 VA: 0x181A7BFA0
	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xD2170 Offset: 0xD1570 VA: 0x1800D2170
	// RVA: 0x1A7ABA0 Offset: 0x1A791A0 VA: 0x181A7ABA0
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0xD22E0 Offset: 0xD16E0 VA: 0x1800D22E0
	// RVA: 0x1A7AB50 Offset: 0x1A79150 VA: 0x181A7AB50
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] // RVA: 0xD23A0 Offset: 0xD17A0 VA: 0x1800D23A0
	// RVA: 0x1A7ABE0 Offset: 0x1A791E0 VA: 0x181A7ABE0
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0xD2560 Offset: 0xD1960 VA: 0x1800D2560
	// RVA: 0x1A7A980 Offset: 0x1A78F80 VA: 0x181A7A980
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD2620 Offset: 0xD1A20 VA: 0x1800D2620
	// RVA: 0x1A7A940 Offset: 0x1A78F40 VA: 0x181A7A940
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD2710 Offset: 0xD1B10 VA: 0x1800D2710
	// RVA: 0x1A7B270 Offset: 0x1A79870 VA: 0x181A7B270
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] // RVA: 0xD2940 Offset: 0xD1D40 VA: 0x1800D2940
	// RVA: 0x1A7AFF0 Offset: 0x1A795F0 VA: 0x181A7AFF0
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0xD3CB0 Offset: 0xD30B0 VA: 0x1800D3CB0
	// RVA: 0x1A7AC90 Offset: 0x1A79290 VA: 0x181A7AC90
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0xD3E00 Offset: 0xD3200 VA: 0x1800D3E00
	// RVA: 0x1A7AD70 Offset: 0x1A79370 VA: 0x181A7AD70
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] // RVA: 0xD3F20 Offset: 0xD3320 VA: 0x1800D3F20
	// RVA: 0x1A7AE90 Offset: 0x1A79490 VA: 0x181A7AE90
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] // RVA: 0xD5360 Offset: 0xD4760 VA: 0x1800D5360
	// RVA: 0x1A7B120 Offset: 0x1A79720 VA: 0x181A7B120
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5480 Offset: 0xD4880 VA: 0x1800D5480
	// RVA: 0x1A7B210 Offset: 0x1A79810 VA: 0x181A7B210
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD5510 Offset: 0xD4910 VA: 0x1800D5510
	// RVA: 0x1A7B320 Offset: 0x1A79920 VA: 0x181A7B320
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD55A0 Offset: 0xD49A0 VA: 0x1800D55A0
	// RVA: 0x1A79890 Offset: 0x1A77E90 VA: 0x181A79890
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5710 Offset: 0xD4B10 VA: 0x1800D5710
	// RVA: 0x1A79830 Offset: 0x1A77E30 VA: 0x181A79830
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0xD57A0 Offset: 0xD4BA0 VA: 0x1800D57A0
	// RVA: 0x1A79750 Offset: 0x1A77D50 VA: 0x181A79750
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0xD57E0 Offset: 0xD4BE0 VA: 0x1800D57E0
	// RVA: 0x1A7AA20 Offset: 0x1A79020 VA: 0x181A7AA20
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5950 Offset: 0xD4D50 VA: 0x1800D5950
	// RVA: 0x1A7B420 Offset: 0x1A79A20 VA: 0x181A7B420
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0xD5A20 Offset: 0xD4E20 VA: 0x1800D5A20
	// RVA: 0x1A7B080 Offset: 0x1A79680 VA: 0x181A7B080
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] // RVA: 0xD5B20 Offset: 0xD4F20 VA: 0x1800D5B20
	// RVA: 0x1A7B390 Offset: 0x1A79990 VA: 0x181A7B390
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x1A7B6C0 Offset: 0x1A79CC0 VA: 0x181A7B6C0
	public void .ctor() { }

	// RVA: 0x1A7B5F0 Offset: 0x1A79BF0 VA: 0x181A7B5F0
	public void .ctor(GUIStyle other) { }

	// RVA: 0x1A7A760 Offset: 0x1A78D60 VA: 0x181A7A760 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A7BAE0 Offset: 0x1A7A0E0 VA: 0x181A7BAE0
	public string get_name() { }

	// RVA: 0x1A7C0F0 Offset: 0x1A7A6F0 VA: 0x181A7C0F0
	public void set_name(string value) { }

	// RVA: 0x1A7BC00 Offset: 0x1A7A200 VA: 0x181A7BC00
	public GUIStyleState get_normal() { }

	// RVA: 0x1A7BA30 Offset: 0x1A7A030 VA: 0x181A7BA30
	public RectOffset get_margin() { }

	// RVA: 0x1A7BCC0 Offset: 0x1A7A2C0 VA: 0x181A7BCC0
	public RectOffset get_padding() { }

	// RVA: 0x1A7B980 Offset: 0x1A79F80 VA: 0x181A7B980
	public float get_lineHeight() { }

	// RVA: 0x1A7A530 Offset: 0x1A78B30 VA: 0x181A7A530
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A7A6A0 Offset: 0x1A78CA0 VA: 0x181A7A6A0
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x1A7A460 Offset: 0x1A78A60 VA: 0x181A7A460
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A7A340 Offset: 0x1A78940 VA: 0x181A7A340
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x1A7A5C0 Offset: 0x1A78BC0 VA: 0x181A7A5C0
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A798F0 Offset: 0x1A77EF0 VA: 0x181A798F0
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x1A79DB0 Offset: 0x1A783B0 VA: 0x181A79DB0
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x1A79BD0 Offset: 0x1A781D0 VA: 0x181A79BD0
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x1A7A170 Offset: 0x1A78770 VA: 0x181A7A170
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x1A7BE70 Offset: 0x1A7A470 VA: 0x181A7BE70
	public static GUIStyle op_Implicit(string str) { }

	// RVA: 0x1A7BB40 Offset: 0x1A7A140 VA: 0x181A7BB40
	public static GUIStyle get_none() { }

	// RVA: 0x1A7A860 Offset: 0x1A78E60 VA: 0x181A7A860
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x1A7A8E0 Offset: 0x1A78EE0 VA: 0x181A7A8E0
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x1A79890 Offset: 0x1A77E90 VA: 0x181A79890
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x1A79830 Offset: 0x1A77E30 VA: 0x181A79830
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x1A79750 Offset: 0x1A77D50 VA: 0x181A79750
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x1A7B8E0 Offset: 0x1A79EE0 VA: 0x181A7B8E0
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x1A797B0 Offset: 0x1A77DB0 VA: 0x181A797B0
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x1A7B4A0 Offset: 0x1A79AA0 VA: 0x181A7B4A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A7B5B0 Offset: 0x1A79BB0 VA: 0x181A7B5B0
	private static void .cctor() { }

	// RVA: 0x1A7B740 Offset: 0x1A79D40 VA: 0x181A7B740
	private void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0x1A7C020 Offset: 0x1A7A620 VA: 0x181A7C020
	private void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A7BF50 Offset: 0x1A7A550 VA: 0x181A7BF50
	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A7AF60 Offset: 0x1A79560 VA: 0x181A7AF60
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A7AC20 Offset: 0x1A79220 VA: 0x181A7AC20
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A7AD00 Offset: 0x1A79300 VA: 0x181A7AD00
	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	// RVA: 0x1A7ADE0 Offset: 0x1A793E0 VA: 0x181A7ADE0
	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0x1A7B0B0 Offset: 0x1A796B0 VA: 0x181A7B0B0
	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	// RVA: 0x1A7B1A0 Offset: 0x1A797A0 VA: 0x181A7B1A0
	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0x1A7B2B0 Offset: 0x1A798B0 VA: 0x181A7B2B0
	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x1A7AAF0 Offset: 0x1A790F0 VA: 0x181A7AAF0
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A7AA80 Offset: 0x1A79080 VA: 0x181A7AA80
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x1A7A9C0 Offset: 0x1A78FC0 VA: 0x181A7A9C0
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A7B3D0 Offset: 0x1A799D0 VA: 0x181A7B3D0
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

}

