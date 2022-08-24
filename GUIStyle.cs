public sealed class GUIStyle // TypeDefIndex: 4048
{	internal IntPtr m_Ptr; // 0x10
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

	[NativePropertyAttribute] // RVA: 0xD5D80 Offset: 0xD5180 VA: 0x1800D5D80
	internal string rawName { get; set; }
	[NativePropertyAttribute] // RVA: 0xD5DC0 Offset: 0xD51C0 VA: 0x1800D5DC0
	public Font font { get; }
	[NativePropertyAttribute] // RVA: 0xD5E00 Offset: 0xD5200 VA: 0x1800D5E00
	public ImagePosition imagePosition { get; }
	[NativePropertyAttribute] // RVA: 0xD5F30 Offset: 0xD5330 VA: 0x1800D5F30
	public TextAnchor alignment { set; }
	[NativePropertyAttribute] // RVA: 0xD6050 Offset: 0xD5450 VA: 0x1800D6050
	public bool wordWrap { get; }
	[NativePropertyAttribute] // RVA: 0xD6090 Offset: 0xD5490 VA: 0x1800D6090
	public Vector2 contentOffset { get; set; }
	[NativePropertyAttribute] // RVA: 0xD60D0 Offset: 0xD54D0 VA: 0x1800D60D0
	public float fixedWidth { get; }
	[NativePropertyAttribute] // RVA: 0xD61F0 Offset: 0xD55F0 VA: 0x1800D61F0
	public float fixedHeight { get; }
	[NativePropertyAttribute] // RVA: 0xD6350 Offset: 0xD5750 VA: 0x1800D6350
	public bool stretchWidth { get; set; }
	[NativePropertyAttribute] // RVA: 0xD6460 Offset: 0xD5860 VA: 0x1800D6460
	public bool stretchHeight { get; set; }
	[NativePropertyAttribute] // RVA: 0xD64A0 Offset: 0xD58A0 VA: 0x1800D64A0
	public int fontSize { set; }
	[NativePropertyAttribute] // RVA: 0xD6530 Offset: 0xD5930 VA: 0x1800D6530
	internal Vector2 Internal_clipOffset { set; }
	public string name { get; set; }
	public GUIStyleState normal { get; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public float lineHeight { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }


	internal string get_rawName() { }

	internal void set_rawName(string value) { }

	public Font get_font() { }

	public ImagePosition get_imagePosition() { }

	public void set_alignment(TextAnchor value) { }

	public bool get_wordWrap() { }

	public Vector2 get_contentOffset() { }

	public void set_contentOffset(Vector2 value) { }

	public float get_fixedWidth() { }

	public float get_fixedHeight() { }

	public bool get_stretchWidth() { }

	public void set_stretchWidth(bool value) { }

	public bool get_stretchHeight() { }

	public void set_stretchHeight(bool value) { }

	public void set_fontSize(int value) { }

	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xD2380 Offset: 0xD1780 VA: 0x1800D2380
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0xD24A0 Offset: 0xD18A0 VA: 0x1800D24A0
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] // RVA: 0xD2560 Offset: 0xD1960 VA: 0x1800D2560
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0xD2720 Offset: 0xD1B20 VA: 0x1800D2720
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD2810 Offset: 0xD1C10 VA: 0x1800D2810
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD2900 Offset: 0xD1D00 VA: 0x1800D2900
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] // RVA: 0xD2B00 Offset: 0xD1F00 VA: 0x1800D2B00
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0xD3EF0 Offset: 0xD32F0 VA: 0x1800D3EF0
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0xD3FC0 Offset: 0xD33C0 VA: 0x1800D3FC0
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] // RVA: 0xD40E0 Offset: 0xD34E0 VA: 0x1800D40E0
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] // RVA: 0xD5520 Offset: 0xD4920 VA: 0x1800D5520
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5640 Offset: 0xD4A40 VA: 0x1800D5640
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD56D0 Offset: 0xD4AD0 VA: 0x1800D56D0
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5750 Offset: 0xD4B50 VA: 0x1800D5750
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD58C0 Offset: 0xD4CC0 VA: 0x1800D58C0
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0xD5950 Offset: 0xD4D50 VA: 0x1800D5950
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0xD5990 Offset: 0xD4D90 VA: 0x1800D5990
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5B40 Offset: 0xD4F40 VA: 0x1800D5B40
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0xD5C00 Offset: 0xD5000 VA: 0x1800D5C00
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] // RVA: 0xD5D00 Offset: 0xD5100 VA: 0x1800D5D00
	internal static void SetDefaultFont(Font font) { }

	public void .ctor() { }

	public void .ctor(GUIStyle other) { }

	protected override void Finalize() { }

	public string get_name() { }

	public void set_name(string value) { }

	public GUIStyleState get_normal() { }

	public RectOffset get_margin() { }

	public RectOffset get_padding() { }

	public float get_lineHeight() { }

	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	public static GUIStyle op_Implicit(string str) { }

	public static GUIStyle get_none() { }

	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	public Vector2 CalcSize(GUIContent content) { }

	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	public float CalcHeight(GUIContent content, float width) { }

	public bool get_isHeightDependantOnWidth() { }

	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	public override string ToString() { }

	private static void .cctor() { }

	private void get_contentOffset_Injected(out Vector2 ret) { }

	private void set_contentOffset_Injected(ref Vector2 value) { }

	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

}

