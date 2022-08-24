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

	[NativePropertyAttribute] // RVA: 0xD5CA0 Offset: 0xD50A0 VA: 0x1800D5CA0
	internal string rawName { get; set; }
	[NativePropertyAttribute] // RVA: 0xD5CE0 Offset: 0xD50E0 VA: 0x1800D5CE0
	public Font font { get; }
	[NativePropertyAttribute] // RVA: 0xD5D20 Offset: 0xD5120 VA: 0x1800D5D20
	public ImagePosition imagePosition { get; }
	[NativePropertyAttribute] // RVA: 0xD5E50 Offset: 0xD5250 VA: 0x1800D5E50
	public TextAnchor alignment { set; }
	[NativePropertyAttribute] // RVA: 0xD5F70 Offset: 0xD5370 VA: 0x1800D5F70
	public bool wordWrap { get; }
	[NativePropertyAttribute] // RVA: 0xD5FB0 Offset: 0xD53B0 VA: 0x1800D5FB0
	public Vector2 contentOffset { get; set; }
	[NativePropertyAttribute] // RVA: 0xD5FF0 Offset: 0xD53F0 VA: 0x1800D5FF0
	public float fixedWidth { get; }
	[NativePropertyAttribute] // RVA: 0xD6110 Offset: 0xD5510 VA: 0x1800D6110
	public float fixedHeight { get; }
	[NativePropertyAttribute] // RVA: 0xD62C0 Offset: 0xD56C0 VA: 0x1800D62C0
	public bool stretchWidth { get; set; }
	[NativePropertyAttribute] // RVA: 0xD63D0 Offset: 0xD57D0 VA: 0x1800D63D0
	public bool stretchHeight { get; set; }
	[NativePropertyAttribute] // RVA: 0xD6410 Offset: 0xD5810 VA: 0x1800D6410
	public int fontSize { set; }
	[NativePropertyAttribute] // RVA: 0xD64A0 Offset: 0xD58A0 VA: 0x1800D64A0
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

	[FreeFunctionAttribute] // RVA: 0xD2250 Offset: 0xD1650 VA: 0x1800D2250
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0xD2370 Offset: 0xD1770 VA: 0x1800D2370
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] // RVA: 0xD2430 Offset: 0xD1830 VA: 0x1800D2430
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0xD25F0 Offset: 0xD19F0 VA: 0x1800D25F0
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD26E0 Offset: 0xD1AE0 VA: 0x1800D26E0
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD27D0 Offset: 0xD1BD0 VA: 0x1800D27D0
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] // RVA: 0xD29D0 Offset: 0xD1DD0 VA: 0x1800D29D0
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0xD3DC0 Offset: 0xD31C0 VA: 0x1800D3DC0
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0xD3E90 Offset: 0xD3290 VA: 0x1800D3E90
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] // RVA: 0xD3FB0 Offset: 0xD33B0 VA: 0x1800D3FB0
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] // RVA: 0xD53F0 Offset: 0xD47F0 VA: 0x1800D53F0
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5510 Offset: 0xD4910 VA: 0x1800D5510
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD55A0 Offset: 0xD49A0 VA: 0x1800D55A0
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5620 Offset: 0xD4A20 VA: 0x1800D5620
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5790 Offset: 0xD4B90 VA: 0x1800D5790
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0xD5820 Offset: 0xD4C20 VA: 0x1800D5820
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0xD5860 Offset: 0xD4C60 VA: 0x1800D5860
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5A10 Offset: 0xD4E10 VA: 0x1800D5A10
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0xD5AD0 Offset: 0xD4ED0 VA: 0x1800D5AD0
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] // RVA: 0xD5BD0 Offset: 0xD4FD0 VA: 0x1800D5BD0
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

