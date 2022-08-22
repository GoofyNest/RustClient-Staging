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

	// RVA: 0x1A68520 Offset: 0x1A66B20 VA: 0x181A68520
	internal string get_rawName() { }

	// RVA: 0x1A688F0 Offset: 0x1A66EF0 VA: 0x181A688F0
	internal void set_rawName(string value) { }

	// RVA: 0x1A68010 Offset: 0x1A66610 VA: 0x181A68010
	public Font get_font() { }

	// RVA: 0x1A68050 Offset: 0x1A66650 VA: 0x181A68050
	public ImagePosition get_imagePosition() { }

	// RVA: 0x1A68790 Offset: 0x1A66D90 VA: 0x181A68790
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1A685E0 Offset: 0x1A66BE0 VA: 0x181A685E0
	public bool get_wordWrap() { }

	// RVA: 0x1A67F40 Offset: 0x1A66540 VA: 0x181A67F40
	public Vector2 get_contentOffset() { }

	// RVA: 0x1A68820 Offset: 0x1A66E20 VA: 0x181A68820
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x1A67FD0 Offset: 0x1A665D0 VA: 0x181A67FD0
	public float get_fixedWidth() { }

	// RVA: 0x1A67F90 Offset: 0x1A66590 VA: 0x181A67F90
	public float get_fixedHeight() { }

	// RVA: 0x1A685A0 Offset: 0x1A66BA0 VA: 0x181A685A0
	public bool get_stretchWidth() { }

	// RVA: 0x1A68990 Offset: 0x1A66F90 VA: 0x181A68990
	public void set_stretchWidth(bool value) { }

	// RVA: 0x1A68560 Offset: 0x1A66B60 VA: 0x181A68560
	public bool get_stretchHeight() { }

	// RVA: 0x1A68940 Offset: 0x1A66F40 VA: 0x181A68940
	public void set_stretchHeight(bool value) { }

	// RVA: 0x1A68860 Offset: 0x1A66E60 VA: 0x181A68860
	public void set_fontSize(int value) { }

	// RVA: 0x1A68750 Offset: 0x1A66D50 VA: 0x181A68750
	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xD2250 Offset: 0xD1650 VA: 0x1800D2250
	// RVA: 0x1A67350 Offset: 0x1A65950 VA: 0x181A67350
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0xD2370 Offset: 0xD1770 VA: 0x1800D2370
	// RVA: 0x1A67300 Offset: 0x1A65900 VA: 0x181A67300
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] // RVA: 0xD2430 Offset: 0xD1830 VA: 0x1800D2430
	// RVA: 0x1A67390 Offset: 0x1A65990 VA: 0x181A67390
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0xD25F0 Offset: 0xD19F0 VA: 0x1800D25F0
	// RVA: 0x1A67130 Offset: 0x1A65730 VA: 0x181A67130
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD26E0 Offset: 0xD1AE0 VA: 0x1800D26E0
	// RVA: 0x1A670F0 Offset: 0x1A656F0 VA: 0x181A670F0
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD27D0 Offset: 0xD1BD0 VA: 0x1800D27D0
	// RVA: 0x1A67A20 Offset: 0x1A66020 VA: 0x181A67A20
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] // RVA: 0xD29D0 Offset: 0xD1DD0 VA: 0x1800D29D0
	// RVA: 0x1A677A0 Offset: 0x1A65DA0 VA: 0x181A677A0
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0xD3DC0 Offset: 0xD31C0 VA: 0x1800D3DC0
	// RVA: 0x1A67440 Offset: 0x1A65A40 VA: 0x181A67440
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0xD3E90 Offset: 0xD3290 VA: 0x1800D3E90
	// RVA: 0x1A67520 Offset: 0x1A65B20 VA: 0x181A67520
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] // RVA: 0xD3FB0 Offset: 0xD33B0 VA: 0x1800D3FB0
	// RVA: 0x1A67640 Offset: 0x1A65C40 VA: 0x181A67640
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] // RVA: 0xD53F0 Offset: 0xD47F0 VA: 0x1800D53F0
	// RVA: 0x1A678D0 Offset: 0x1A65ED0 VA: 0x181A678D0
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5510 Offset: 0xD4910 VA: 0x1800D5510
	// RVA: 0x1A679C0 Offset: 0x1A65FC0 VA: 0x181A679C0
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD55A0 Offset: 0xD49A0 VA: 0x1800D55A0
	// RVA: 0x1A67AD0 Offset: 0x1A660D0 VA: 0x181A67AD0
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5620 Offset: 0xD4A20 VA: 0x1800D5620
	// RVA: 0x1A66040 Offset: 0x1A64640 VA: 0x181A66040
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5790 Offset: 0xD4B90 VA: 0x1800D5790
	// RVA: 0x1A65FE0 Offset: 0x1A645E0 VA: 0x181A65FE0
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0xD5820 Offset: 0xD4C20 VA: 0x1800D5820
	// RVA: 0x1A65F00 Offset: 0x1A64500 VA: 0x181A65F00
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0xD5860 Offset: 0xD4C60 VA: 0x1800D5860
	// RVA: 0x1A671D0 Offset: 0x1A657D0 VA: 0x181A671D0
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5A00 Offset: 0xD4E00 VA: 0x1800D5A00
	// RVA: 0x1A67BD0 Offset: 0x1A661D0 VA: 0x181A67BD0
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0xD5AD0 Offset: 0xD4ED0 VA: 0x1800D5AD0
	// RVA: 0x1A67830 Offset: 0x1A65E30 VA: 0x181A67830
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] // RVA: 0xD5BD0 Offset: 0xD4FD0 VA: 0x1800D5BD0
	// RVA: 0x1A67B40 Offset: 0x1A66140 VA: 0x181A67B40
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x1A67E70 Offset: 0x1A66470 VA: 0x181A67E70
	public void .ctor() { }

	// RVA: 0x1A67DA0 Offset: 0x1A663A0 VA: 0x181A67DA0
	public void .ctor(GUIStyle other) { }

	// RVA: 0x1A66F10 Offset: 0x1A65510 VA: 0x181A66F10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A68290 Offset: 0x1A66890 VA: 0x181A68290
	public string get_name() { }

	// RVA: 0x1A688A0 Offset: 0x1A66EA0 VA: 0x181A688A0
	public void set_name(string value) { }

	// RVA: 0x1A683B0 Offset: 0x1A669B0 VA: 0x181A683B0
	public GUIStyleState get_normal() { }

	// RVA: 0x1A681E0 Offset: 0x1A667E0 VA: 0x181A681E0
	public RectOffset get_margin() { }

	// RVA: 0x1A68470 Offset: 0x1A66A70 VA: 0x181A68470
	public RectOffset get_padding() { }

	// RVA: 0x1A68130 Offset: 0x1A66730 VA: 0x181A68130
	public float get_lineHeight() { }

	// RVA: 0x1A66CE0 Offset: 0x1A652E0 VA: 0x181A66CE0
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A66E50 Offset: 0x1A65450 VA: 0x181A66E50
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x1A66C10 Offset: 0x1A65210 VA: 0x181A66C10
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A66AF0 Offset: 0x1A650F0 VA: 0x181A66AF0
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x1A66D70 Offset: 0x1A65370 VA: 0x181A66D70
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A660A0 Offset: 0x1A646A0 VA: 0x181A660A0
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x1A66560 Offset: 0x1A64B60 VA: 0x181A66560
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x1A66380 Offset: 0x1A64980 VA: 0x181A66380
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x1A66920 Offset: 0x1A64F20 VA: 0x181A66920
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x1A68620 Offset: 0x1A66C20 VA: 0x181A68620
	public static GUIStyle op_Implicit(string str) { }

	// RVA: 0x1A682F0 Offset: 0x1A668F0 VA: 0x181A682F0
	public static GUIStyle get_none() { }

	// RVA: 0x1A67010 Offset: 0x1A65610 VA: 0x181A67010
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x1A67090 Offset: 0x1A65690 VA: 0x181A67090
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x1A66040 Offset: 0x1A64640 VA: 0x181A66040
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x1A65FE0 Offset: 0x1A645E0 VA: 0x181A65FE0
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x1A65F00 Offset: 0x1A64500 VA: 0x181A65F00
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x1A68090 Offset: 0x1A66690 VA: 0x181A68090
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x1A65F60 Offset: 0x1A64560 VA: 0x181A65F60
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x1A67C50 Offset: 0x1A66250 VA: 0x181A67C50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A67D60 Offset: 0x1A66360 VA: 0x181A67D60
	private static void .cctor() { }

	// RVA: 0x1A67EF0 Offset: 0x1A664F0 VA: 0x181A67EF0
	private void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0x1A687D0 Offset: 0x1A66DD0 VA: 0x181A687D0
	private void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A68700 Offset: 0x1A66D00 VA: 0x181A68700
	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A67710 Offset: 0x1A65D10 VA: 0x181A67710
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A673D0 Offset: 0x1A659D0 VA: 0x181A673D0
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A674B0 Offset: 0x1A65AB0 VA: 0x181A674B0
	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	// RVA: 0x1A67590 Offset: 0x1A65B90 VA: 0x181A67590
	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0x1A67860 Offset: 0x1A65E60 VA: 0x181A67860
	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	// RVA: 0x1A67950 Offset: 0x1A65F50 VA: 0x181A67950
	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0x1A67A60 Offset: 0x1A66060 VA: 0x181A67A60
	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x1A672A0 Offset: 0x1A658A0 VA: 0x181A672A0
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A67230 Offset: 0x1A65830 VA: 0x181A67230
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x1A67170 Offset: 0x1A65770 VA: 0x181A67170
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A67B80 Offset: 0x1A66180 VA: 0x181A67B80
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

}

