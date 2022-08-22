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

	// RVA: 0x22E41D0 Offset: 0x22E27D0 VA: 0x1822E41D0
	public string get_text() { }

	// RVA: 0x22E4360 Offset: 0x22E2960 VA: 0x1822E4360
	public void set_text(string value) { }

	// RVA: 0x22E41B0 Offset: 0x22E27B0 VA: 0x1822E41B0
	public Rect get_position() { }

	// RVA: 0x22E4240 Offset: 0x22E2840 VA: 0x1822E4240
	public void set_position(Rect value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDD840 Offset: 0xDCC40 VA: 0x1800DD840
	// RVA: 0x22E41A0 Offset: 0x22E27A0 VA: 0x1822E41A0 Slot: 4
	internal virtual Rect get_localPosition() { }

	// RVA: 0x22E4180 Offset: 0x22E2780 VA: 0x1822E4180
	public int get_cursorIndex() { }

	// RVA: 0x22E41F0 Offset: 0x22E27F0 VA: 0x1822E41F0
	public void set_cursorIndex(int value) { }

	// RVA: 0x22E41C0 Offset: 0x22E27C0 VA: 0x1822E41C0
	public int get_selectIndex() { }

	// RVA: 0x22E4310 Offset: 0x22E2910 VA: 0x1822E4310
	public void set_selectIndex(int value) { }

	// RVA: 0x22DD620 Offset: 0x22DBC20 VA: 0x1822DD620
	private void ClearCursorPos() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E4060 Offset: 0x22E2660 VA: 0x1822E4060
	public void .ctor() { }

	// RVA: 0x22E0EF0 Offset: 0x22DF4F0 VA: 0x1822E0EF0
	public void OnFocus() { }

	// RVA: 0x22E0FA0 Offset: 0x22DF5A0 VA: 0x1822E0FA0
	public void OnLostFocus() { }

	// RVA: 0x22DECD0 Offset: 0x22DD2D0 VA: 0x1822DECD0
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x22DEDD0 Offset: 0x22DD3D0 VA: 0x1822DEDD0
	public bool HandleKeyEvent(Event e) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DEED0 Offset: 0x22DD4D0 VA: 0x1822DEED0
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x22DD760 Offset: 0x22DBD60 VA: 0x1822DD760
	public bool DeleteLineBack() { }

	// RVA: 0x22DDA80 Offset: 0x22DC080 VA: 0x1822DDA80
	public bool DeleteWordBack() { }

	// RVA: 0x22DDB90 Offset: 0x22DC190 VA: 0x1822DDB90
	public bool DeleteWordForward() { }

	// RVA: 0x22DDC60 Offset: 0x22DC260 VA: 0x1822DDC60
	public bool Delete() { }

	// RVA: 0x22DD340 Offset: 0x22DB940 VA: 0x1822DD340
	public bool Backspace() { }

	// RVA: 0x22E2240 Offset: 0x22E0840 VA: 0x1822E2240
	public void SelectAll() { }

	// RVA: 0x22E2B20 Offset: 0x22E1120 VA: 0x1822E2B20
	public void SelectNone() { }

	// RVA: 0x22E4190 Offset: 0x22E2790 VA: 0x1822E4190
	public bool get_hasSelection() { }

	// RVA: 0x22DD850 Offset: 0x22DBE50 VA: 0x1822DD850
	public bool DeleteSelection() { }

	// RVA: 0x22E20F0 Offset: 0x22E06F0 VA: 0x1822E20F0
	public void ReplaceSelection(string replace) { }

	// RVA: 0x22DF660 Offset: 0x22DDC60 VA: 0x1822DF660
	public void Insert(char c) { }

	// RVA: 0x22E0470 Offset: 0x22DEA70 VA: 0x1822E0470
	public void MoveRight() { }

	// RVA: 0x22DFE70 Offset: 0x22DE470 VA: 0x1822DFE70
	public void MoveLeft() { }

	// RVA: 0x22E0880 Offset: 0x22DEE80 VA: 0x1822E0880
	public void MoveUp() { }

	// RVA: 0x22DFB50 Offset: 0x22DE150 VA: 0x1822DFB50
	public void MoveDown() { }

	// RVA: 0x22E00B0 Offset: 0x22DE6B0 VA: 0x1822E00B0
	public void MoveLineStart() { }

	// RVA: 0x22DFF80 Offset: 0x22DE580 VA: 0x1822DFF80
	public void MoveLineEnd() { }

	// RVA: 0x22DFDC0 Offset: 0x22DE3C0 VA: 0x1822DFDC0
	public void MoveGraphicalLineStart() { }

	// RVA: 0x22DFD10 Offset: 0x22DE310 VA: 0x1822DFD10
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x22E0650 Offset: 0x22DEC50 VA: 0x1822E0650
	public void MoveTextStart() { }

	// RVA: 0x22E0590 Offset: 0x22DEB90 VA: 0x1822E0590
	public void MoveTextEnd() { }

	// RVA: 0x22DEFE0 Offset: 0x22DD5E0 VA: 0x1822DEFE0
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x22E0310 Offset: 0x22DE910 VA: 0x1822E0310
	public void MoveParagraphForward() { }

	// RVA: 0x22E01C0 Offset: 0x22DE7C0 VA: 0x1822E01C0
	public void MoveParagraphBackward() { }

	// RVA: 0x22DF9B0 Offset: 0x22DDFB0 VA: 0x1822DF9B0
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22DF820 Offset: 0x22DDE20 VA: 0x1822DF820
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x22E3060 Offset: 0x22E1660 VA: 0x1822E3060
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22E2A40 Offset: 0x22E1040 VA: 0x1822E2A40
	public void SelectLeft() { }

	// RVA: 0x22E2E30 Offset: 0x22E1430 VA: 0x1822E2E30
	public void SelectRight() { }

	// RVA: 0x22E3830 Offset: 0x22E1E30 VA: 0x1822E3830
	public void SelectUp() { }

	// RVA: 0x22E2860 Offset: 0x22E0E60 VA: 0x1822E2860
	public void SelectDown() { }

	// RVA: 0x22E2F10 Offset: 0x22E1510 VA: 0x1822E2F10
	public void SelectTextEnd() { }

	// RVA: 0x22E2F90 Offset: 0x22E1590 VA: 0x1822E2F90
	public void SelectTextStart() { }

	// RVA: 0x22DF810 Offset: 0x22DDE10 VA: 0x1822DF810
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0xCA6AC0 Offset: 0xCA50C0 VA: 0x180CA6AC0
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x22DEB90 Offset: 0x22DD190 VA: 0x1822DEB90
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x22DEA80 Offset: 0x22DD080 VA: 0x1822DEA80
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x22DE770 Offset: 0x22DCD70 VA: 0x1822DE770
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x22DE810 Offset: 0x22DCE10 VA: 0x1822DE810
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x22E0B50 Offset: 0x22DF150 VA: 0x1822E0B50
	public void MoveWordRight() { }

	// RVA: 0x22E07B0 Offset: 0x22DEDB0 VA: 0x1822E07B0
	public void MoveToStartOfNextWord() { }

	// RVA: 0x22E06E0 Offset: 0x22DECE0 VA: 0x1822E06E0
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x22E37C0 Offset: 0x22E1DC0 VA: 0x1822E37C0
	public void SelectToStartOfNextWord() { }

	// RVA: 0x22E2FF0 Offset: 0x22E15F0 VA: 0x1822E2FF0
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x22DD4F0 Offset: 0x22DBAF0 VA: 0x1822DD4F0
	private TextEditor.CharacterType ClassifyChar(int index) { }

	// RVA: 0x22DE8B0 Offset: 0x22DCEB0 VA: 0x1822DE8B0
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x22DE6A0 Offset: 0x22DCCA0 VA: 0x1822DE6A0
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x22E0A00 Offset: 0x22DF000 VA: 0x1822E0A00
	public void MoveWordLeft() { }

	// RVA: 0x22E3A50 Offset: 0x22E2050 VA: 0x1822E3A50
	public void SelectWordRight() { }

	// RVA: 0x22E3900 Offset: 0x22E1F00 VA: 0x1822E3900
	public void SelectWordLeft() { }

	// RVA: 0x22DE450 Offset: 0x22DCA50 VA: 0x1822DE450
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x22DE360 Offset: 0x22DC960 VA: 0x1822DE360
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x22E29D0 Offset: 0x22E0FD0 VA: 0x1822E29D0
	public void SelectGraphicalLineStart() { }

	// RVA: 0x22E2960 Offset: 0x22E0F60 VA: 0x1822E2960
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x22E2CF0 Offset: 0x22E12F0 VA: 0x1822E2CF0
	public void SelectParagraphForward() { }

	// RVA: 0x22E2B80 Offset: 0x22E1180 VA: 0x1822E2B80
	public void SelectParagraphBackward() { }

	// RVA: 0x22E2440 Offset: 0x22E0A40 VA: 0x1822E2440
	public void SelectCurrentWord() { }

	// RVA: 0x22DE540 Offset: 0x22DCB40 VA: 0x1822DE540
	private int FindEndOfClassification(int p, TextEditor.Direction dir) { }

	// RVA: 0x22E22F0 Offset: 0x22E08F0 VA: 0x1822E22F0
	public void SelectCurrentParagraph() { }

	// RVA: 0x22E3BA0 Offset: 0x22E21A0 VA: 0x1822E3BA0
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E3BF0 Offset: 0x22E21F0 VA: 0x1822E3BF0
	internal void UpdateScrollOffset() { }

	// RVA: 0x22DDD20 Offset: 0x22DC320 VA: 0x1822DDD20
	public void DrawCursor(string newText) { }

	// RVA: 0x22E1100 Offset: 0x22DF700 VA: 0x1822E1100
	private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x22E21F0 Offset: 0x22E07F0 VA: 0x1822E21F0
	public void SaveBackup() { }

	// RVA: 0x22DD6C0 Offset: 0x22DBCC0 VA: 0x1822DD6C0
	public bool Cut() { }

	// RVA: 0x22DD630 Offset: 0x22DBC30 VA: 0x1822DD630
	public void Copy() { }

	// RVA: 0x22E2070 Offset: 0x22E0670 VA: 0x1822E2070
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x22E1010 Offset: 0x22DF610 VA: 0x1822E1010
	public bool Paste() { }

	// RVA: 0x22DF790 Offset: 0x22DDD90 VA: 0x1822DF790
	private static void MapKey(string key, TextEditor.TextEditOp action) { }

	// RVA: 0x22DF050 Offset: 0x22DD650 VA: 0x1822DF050
	private void InitKeyActions() { }

	// RVA: 0x95F830 Offset: 0x95DE30 VA: 0x18095F830
	public void DetectFocusChange() { }

	// RVA: 0x22E0DB0 Offset: 0x22DF3B0 VA: 0x1822E0DB0 Slot: 5
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x22DD460 Offset: 0x22DBA60 VA: 0x1822DD460
	private void ClampTextIndex(ref int index) { }

	// RVA: 0x22DE1E0 Offset: 0x22DC7E0 VA: 0x1822DE1E0
	private void EnsureValidCodePointIndex(ref int index) { }

	// RVA: 0x22DF690 Offset: 0x22DDC90 VA: 0x1822DF690
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x22E1FC0 Offset: 0x22E05C0 VA: 0x1822E1FC0
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x22E0CB0 Offset: 0x22DF2B0 VA: 0x1822E0CB0
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

