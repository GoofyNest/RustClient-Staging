public class TextEditor // TypeDefIndex: 4061
{	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public int controlID; // 0x18
	public GUIStyle style; // 0x20
	public bool multiline; // 0x28
	public bool hasHorizontalCursorPos; // 0x29
	public bool isPasswordField; // 0x2A
	[VisibleToOtherModulesAttribute] // RVA: 0xDC3A0 Offset: 0xDB7A0 VA: 0x1800DC3A0
	internal bool m_HasFocus; // 0x2B
	public Vector2 scrollOffset; // 0x2C
	private GUIContent m_Content; // 0x38
	private Rect m_Position; // 0x40
	private int m_CursorIndex; // 0x50
	private int m_SelectIndex; // 0x54
	private bool m_RevealCursor; // 0x58
	public Vector2 graphicalCursorPos; // 0x5C
	public Vector2 graphicalSelectCursorPos; // 0x64
	private bool m_MouseDragSelectsWholeWords; // 0x6C
	private int m_DblClickInitPos; // 0x70
	private TextEditor.DblClickSnapping m_DblClickSnap; // 0x74
	private bool m_bJustSelected; // 0x75
	private int m_iAltCursorPos; // 0x78
	private string oldText; // 0x80
	private int oldPos; // 0x88
	private int oldSelectPos; // 0x8C
	private static Dictionary<Event, TextEditor.TextEditOp> s_Keyactions; // 0x0

	// Properties
	public string text { get; set; }
	public Rect position { get; set; }
	internal virtual Rect localPosition { get; }
	public int cursorIndex { get; set; }
	public int selectIndex { get; set; }
	public bool hasSelection { get; }

	// Methods

	// RVA: 0x22E4CB0 Offset: 0x22E32B0 VA: 0x1822E4CB0
	public string get_text() { }

	// RVA: 0x22E4E40 Offset: 0x22E3440 VA: 0x1822E4E40
	public void set_text(string value) { }

	// RVA: 0x22E4C90 Offset: 0x22E3290 VA: 0x1822E4C90
	public Rect get_position() { }

	// RVA: 0x22E4D20 Offset: 0x22E3320 VA: 0x1822E4D20
	public void set_position(Rect value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDD840 Offset: 0xDCC40 VA: 0x1800DD840
	// RVA: 0x22E4C80 Offset: 0x22E3280 VA: 0x1822E4C80 Slot: 4
	internal virtual Rect get_localPosition() { }

	// RVA: 0x22E4C60 Offset: 0x22E3260 VA: 0x1822E4C60
	public int get_cursorIndex() { }

	// RVA: 0x22E4CD0 Offset: 0x22E32D0 VA: 0x1822E4CD0
	public void set_cursorIndex(int value) { }

	// RVA: 0x22E4CA0 Offset: 0x22E32A0 VA: 0x1822E4CA0
	public int get_selectIndex() { }

	// RVA: 0x22E4DF0 Offset: 0x22E33F0 VA: 0x1822E4DF0
	public void set_selectIndex(int value) { }

	// RVA: 0x22DE100 Offset: 0x22DC700 VA: 0x1822DE100
	private void ClearCursorPos() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E4B40 Offset: 0x22E3140 VA: 0x1822E4B40
	public void .ctor() { }

	// RVA: 0x22E19D0 Offset: 0x22DFFD0 VA: 0x1822E19D0
	public void OnFocus() { }

	// RVA: 0x22E1A80 Offset: 0x22E0080 VA: 0x1822E1A80
	public void OnLostFocus() { }

	// RVA: 0x22DF7B0 Offset: 0x22DDDB0 VA: 0x1822DF7B0
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x22DF8B0 Offset: 0x22DDEB0 VA: 0x1822DF8B0
	public bool HandleKeyEvent(Event e) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DF9B0 Offset: 0x22DDFB0 VA: 0x1822DF9B0
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x22DE240 Offset: 0x22DC840 VA: 0x1822DE240
	public bool DeleteLineBack() { }

	// RVA: 0x22DE560 Offset: 0x22DCB60 VA: 0x1822DE560
	public bool DeleteWordBack() { }

	// RVA: 0x22DE670 Offset: 0x22DCC70 VA: 0x1822DE670
	public bool DeleteWordForward() { }

	// RVA: 0x22DE740 Offset: 0x22DCD40 VA: 0x1822DE740
	public bool Delete() { }

	// RVA: 0x22DDE20 Offset: 0x22DC420 VA: 0x1822DDE20
	public bool Backspace() { }

	// RVA: 0x22E2D20 Offset: 0x22E1320 VA: 0x1822E2D20
	public void SelectAll() { }

	// RVA: 0x22E3600 Offset: 0x22E1C00 VA: 0x1822E3600
	public void SelectNone() { }

	// RVA: 0x22E4C70 Offset: 0x22E3270 VA: 0x1822E4C70
	public bool get_hasSelection() { }

	// RVA: 0x22DE330 Offset: 0x22DC930 VA: 0x1822DE330
	public bool DeleteSelection() { }

	// RVA: 0x22E2BD0 Offset: 0x22E11D0 VA: 0x1822E2BD0
	public void ReplaceSelection(string replace) { }

	// RVA: 0x22E0140 Offset: 0x22DE740 VA: 0x1822E0140
	public void Insert(char c) { }

	// RVA: 0x22E0F50 Offset: 0x22DF550 VA: 0x1822E0F50
	public void MoveRight() { }

	// RVA: 0x22E0950 Offset: 0x22DEF50 VA: 0x1822E0950
	public void MoveLeft() { }

	// RVA: 0x22E1360 Offset: 0x22DF960 VA: 0x1822E1360
	public void MoveUp() { }

	// RVA: 0x22E0630 Offset: 0x22DEC30 VA: 0x1822E0630
	public void MoveDown() { }

	// RVA: 0x22E0B90 Offset: 0x22DF190 VA: 0x1822E0B90
	public void MoveLineStart() { }

	// RVA: 0x22E0A60 Offset: 0x22DF060 VA: 0x1822E0A60
	public void MoveLineEnd() { }

	// RVA: 0x22E08A0 Offset: 0x22DEEA0 VA: 0x1822E08A0
	public void MoveGraphicalLineStart() { }

	// RVA: 0x22E07F0 Offset: 0x22DEDF0 VA: 0x1822E07F0
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x22E1130 Offset: 0x22DF730 VA: 0x1822E1130
	public void MoveTextStart() { }

	// RVA: 0x22E1070 Offset: 0x22DF670 VA: 0x1822E1070
	public void MoveTextEnd() { }

	// RVA: 0x22DFAC0 Offset: 0x22DE0C0 VA: 0x1822DFAC0
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x22E0DF0 Offset: 0x22DF3F0 VA: 0x1822E0DF0
	public void MoveParagraphForward() { }

	// RVA: 0x22E0CA0 Offset: 0x22DF2A0 VA: 0x1822E0CA0
	public void MoveParagraphBackward() { }

	// RVA: 0x22E0490 Offset: 0x22DEA90 VA: 0x1822E0490
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22E0300 Offset: 0x22DE900 VA: 0x1822E0300
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x22E3B40 Offset: 0x22E2140 VA: 0x1822E3B40
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22E3520 Offset: 0x22E1B20 VA: 0x1822E3520
	public void SelectLeft() { }

	// RVA: 0x22E3910 Offset: 0x22E1F10 VA: 0x1822E3910
	public void SelectRight() { }

	// RVA: 0x22E4310 Offset: 0x22E2910 VA: 0x1822E4310
	public void SelectUp() { }

	// RVA: 0x22E3340 Offset: 0x22E1940 VA: 0x1822E3340
	public void SelectDown() { }

	// RVA: 0x22E39F0 Offset: 0x22E1FF0 VA: 0x1822E39F0
	public void SelectTextEnd() { }

	// RVA: 0x22E3A70 Offset: 0x22E2070 VA: 0x1822E3A70
	public void SelectTextStart() { }

	// RVA: 0x22E02F0 Offset: 0x22DE8F0 VA: 0x1822E02F0
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0xCA7220 Offset: 0xCA5820 VA: 0x180CA7220
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x22DF670 Offset: 0x22DDC70 VA: 0x1822DF670
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x22DF560 Offset: 0x22DDB60 VA: 0x1822DF560
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x22DF250 Offset: 0x22DD850 VA: 0x1822DF250
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x22DF2F0 Offset: 0x22DD8F0 VA: 0x1822DF2F0
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x22E1630 Offset: 0x22DFC30 VA: 0x1822E1630
	public void MoveWordRight() { }

	// RVA: 0x22E1290 Offset: 0x22DF890 VA: 0x1822E1290
	public void MoveToStartOfNextWord() { }

	// RVA: 0x22E11C0 Offset: 0x22DF7C0 VA: 0x1822E11C0
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x22E42A0 Offset: 0x22E28A0 VA: 0x1822E42A0
	public void SelectToStartOfNextWord() { }

	// RVA: 0x22E3AD0 Offset: 0x22E20D0 VA: 0x1822E3AD0
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x22DDFD0 Offset: 0x22DC5D0 VA: 0x1822DDFD0
	private TextEditor.CharacterType ClassifyChar(int index) { }

	// RVA: 0x22DF390 Offset: 0x22DD990 VA: 0x1822DF390
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x22DF180 Offset: 0x22DD780 VA: 0x1822DF180
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x22E14E0 Offset: 0x22DFAE0 VA: 0x1822E14E0
	public void MoveWordLeft() { }

	// RVA: 0x22E4530 Offset: 0x22E2B30 VA: 0x1822E4530
	public void SelectWordRight() { }

	// RVA: 0x22E43E0 Offset: 0x22E29E0 VA: 0x1822E43E0
	public void SelectWordLeft() { }

	// RVA: 0x22DEF30 Offset: 0x22DD530 VA: 0x1822DEF30
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x22DEE40 Offset: 0x22DD440 VA: 0x1822DEE40
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x22E34B0 Offset: 0x22E1AB0 VA: 0x1822E34B0
	public void SelectGraphicalLineStart() { }

	// RVA: 0x22E3440 Offset: 0x22E1A40 VA: 0x1822E3440
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x22E37D0 Offset: 0x22E1DD0 VA: 0x1822E37D0
	public void SelectParagraphForward() { }

	// RVA: 0x22E3660 Offset: 0x22E1C60 VA: 0x1822E3660
	public void SelectParagraphBackward() { }

	// RVA: 0x22E2F20 Offset: 0x22E1520 VA: 0x1822E2F20
	public void SelectCurrentWord() { }

	// RVA: 0x22DF020 Offset: 0x22DD620 VA: 0x1822DF020
	private int FindEndOfClassification(int p, TextEditor.Direction dir) { }

	// RVA: 0x22E2DD0 Offset: 0x22E13D0 VA: 0x1822E2DD0
	public void SelectCurrentParagraph() { }

	// RVA: 0x22E4680 Offset: 0x22E2C80 VA: 0x1822E4680
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E46D0 Offset: 0x22E2CD0 VA: 0x1822E46D0
	internal void UpdateScrollOffset() { }

	// RVA: 0x22DE800 Offset: 0x22DCE00 VA: 0x1822DE800
	public void DrawCursor(string newText) { }

	// RVA: 0x22E1BE0 Offset: 0x22E01E0 VA: 0x1822E1BE0
	private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x22E2CD0 Offset: 0x22E12D0 VA: 0x1822E2CD0
	public void SaveBackup() { }

	// RVA: 0x22DE1A0 Offset: 0x22DC7A0 VA: 0x1822DE1A0
	public bool Cut() { }

	// RVA: 0x22DE110 Offset: 0x22DC710 VA: 0x1822DE110
	public void Copy() { }

	// RVA: 0x22E2B50 Offset: 0x22E1150 VA: 0x1822E2B50
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x22E1AF0 Offset: 0x22E00F0 VA: 0x1822E1AF0
	public bool Paste() { }

	// RVA: 0x22E0270 Offset: 0x22DE870 VA: 0x1822E0270
	private static void MapKey(string key, TextEditor.TextEditOp action) { }

	// RVA: 0x22DFB30 Offset: 0x22DE130 VA: 0x1822DFB30
	private void InitKeyActions() { }

	// RVA: 0x95FE40 Offset: 0x95E440 VA: 0x18095FE40
	public void DetectFocusChange() { }

	// RVA: 0x22E1890 Offset: 0x22DFE90 VA: 0x1822E1890 Slot: 5
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x22DDF40 Offset: 0x22DC540 VA: 0x1822DDF40
	private void ClampTextIndex(ref int index) { }

	// RVA: 0x22DECC0 Offset: 0x22DD2C0 VA: 0x1822DECC0
	private void EnsureValidCodePointIndex(ref int index) { }

	// RVA: 0x22E0170 Offset: 0x22DE770 VA: 0x1822E0170
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x22E2AA0 Offset: 0x22E10A0 VA: 0x1822E2AA0
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x22E1790 Offset: 0x22DFD90 VA: 0x1822E1790
	private int NextCodePointIndex(int index) { }

}

public enum TextEditor.DblClickSnapping // TypeDefIndex: 4062
{	// Fields
	public byte value__; // 0x0
	public const TextEditor.DblClickSnapping WORDS = 0;
	public const TextEditor.DblClickSnapping PARAGRAPHS = 1;

}

private enum TextEditor.CharacterType // TypeDefIndex: 4063
{	// Fields
	public int value__; // 0x0
	public const TextEditor.CharacterType LetterLike = 0;
	public const TextEditor.CharacterType Symbol = 1;
	public const TextEditor.CharacterType Symbol2 = 2;
	public const TextEditor.CharacterType WhiteSpace = 3;

}

private enum TextEditor.Direction // TypeDefIndex: 4064
{	// Fields
	public int value__; // 0x0
	public const TextEditor.Direction Forward = 0;
	public const TextEditor.Direction Backward = 1;

}

private enum TextEditor.TextEditOp // TypeDefIndex: 4065
{	// Fields
	public int value__; // 0x0
	public const TextEditor.TextEditOp MoveLeft = 0;
	public const TextEditor.TextEditOp MoveRight = 1;
	public const TextEditor.TextEditOp MoveUp = 2;
	public const TextEditor.TextEditOp MoveDown = 3;
	public const TextEditor.TextEditOp MoveLineStart = 4;
	public const TextEditor.TextEditOp MoveLineEnd = 5;
	public const TextEditor.TextEditOp MoveTextStart = 6;
	public const TextEditor.TextEditOp MoveTextEnd = 7;
	public const TextEditor.TextEditOp MovePageUp = 8;
	public const TextEditor.TextEditOp MovePageDown = 9;
	public const TextEditor.TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditor.TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditor.TextEditOp MoveWordLeft = 12;
	public const TextEditor.TextEditOp MoveWordRight = 13;
	public const TextEditor.TextEditOp MoveParagraphForward = 14;
	public const TextEditor.TextEditOp MoveParagraphBackward = 15;
	public const TextEditor.TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditor.TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditor.TextEditOp SelectLeft = 18;
	public const TextEditor.TextEditOp SelectRight = 19;
	public const TextEditor.TextEditOp SelectUp = 20;
	public const TextEditor.TextEditOp SelectDown = 21;
	public const TextEditor.TextEditOp SelectTextStart = 22;
	public const TextEditor.TextEditOp SelectTextEnd = 23;
	public const TextEditor.TextEditOp SelectPageUp = 24;
	public const TextEditor.TextEditOp SelectPageDown = 25;
	public const TextEditor.TextEditOp ExpandSelectGraphicalLineStart = 26;
	public const TextEditor.TextEditOp ExpandSelectGraphicalLineEnd = 27;
	public const TextEditor.TextEditOp SelectGraphicalLineStart = 28;
	public const TextEditor.TextEditOp SelectGraphicalLineEnd = 29;
	public const TextEditor.TextEditOp SelectWordLeft = 30;
	public const TextEditor.TextEditOp SelectWordRight = 31;
	public const TextEditor.TextEditOp SelectToEndOfPreviousWord = 32;
	public const TextEditor.TextEditOp SelectToStartOfNextWord = 33;
	public const TextEditor.TextEditOp SelectParagraphBackward = 34;
	public const TextEditor.TextEditOp SelectParagraphForward = 35;
	public const TextEditor.TextEditOp Delete = 36;
	public const TextEditor.TextEditOp Backspace = 37;
	public const TextEditor.TextEditOp DeleteWordBack = 38;
	public const TextEditor.TextEditOp DeleteWordForward = 39;
	public const TextEditor.TextEditOp DeleteLineBack = 40;
	public const TextEditor.TextEditOp Cut = 41;
	public const TextEditor.TextEditOp Copy = 42;
	public const TextEditor.TextEditOp Paste = 43;
	public const TextEditor.TextEditOp SelectAll = 44;
	public const TextEditor.TextEditOp SelectNone = 45;
	public const TextEditor.TextEditOp ScrollStart = 46;
	public const TextEditor.TextEditOp ScrollEnd = 47;
	public const TextEditor.TextEditOp ScrollPageUp = 48;
	public const TextEditor.TextEditOp ScrollPageDown = 49;

}

