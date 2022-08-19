public class TextEditor // TypeDefIndex: 4061
{	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public int controlID; // 0x18
	public GUIStyle style; // 0x20
	public bool multiline; // 0x28
	public bool hasHorizontalCursorPos; // 0x29
	public bool isPasswordField; // 0x2A
	[VisibleToOtherModulesAttribute] // RVA: 0xDC300 Offset: 0xDB700 VA: 0x1800DC300
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

	// RVA: 0x22E4390 Offset: 0x22E2990 VA: 0x1822E4390
	public string get_text() { }

	// RVA: 0x22E4520 Offset: 0x22E2B20 VA: 0x1822E4520
	public void set_text(string value) { }

	// RVA: 0x22E4370 Offset: 0x22E2970 VA: 0x1822E4370
	public Rect get_position() { }

	// RVA: 0x22E4400 Offset: 0x22E2A00 VA: 0x1822E4400
	public void set_position(Rect value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDD7E0 Offset: 0xDCBE0 VA: 0x1800DD7E0
	// RVA: 0x22E4360 Offset: 0x22E2960 VA: 0x1822E4360 Slot: 4
	internal virtual Rect get_localPosition() { }

	// RVA: 0x22E4340 Offset: 0x22E2940 VA: 0x1822E4340
	public int get_cursorIndex() { }

	// RVA: 0x22E43B0 Offset: 0x22E29B0 VA: 0x1822E43B0
	public void set_cursorIndex(int value) { }

	// RVA: 0x22E4380 Offset: 0x22E2980 VA: 0x1822E4380
	public int get_selectIndex() { }

	// RVA: 0x22E44D0 Offset: 0x22E2AD0 VA: 0x1822E44D0
	public void set_selectIndex(int value) { }

	// RVA: 0x22DD7E0 Offset: 0x22DBDE0 VA: 0x1822DD7E0
	private void ClearCursorPos() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E4220 Offset: 0x22E2820 VA: 0x1822E4220
	public void .ctor() { }

	// RVA: 0x22E10B0 Offset: 0x22DF6B0 VA: 0x1822E10B0
	public void OnFocus() { }

	// RVA: 0x22E1160 Offset: 0x22DF760 VA: 0x1822E1160
	public void OnLostFocus() { }

	// RVA: 0x22DEE90 Offset: 0x22DD490 VA: 0x1822DEE90
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x22DEF90 Offset: 0x22DD590 VA: 0x1822DEF90
	public bool HandleKeyEvent(Event e) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DF090 Offset: 0x22DD690 VA: 0x1822DF090
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x22DD920 Offset: 0x22DBF20 VA: 0x1822DD920
	public bool DeleteLineBack() { }

	// RVA: 0x22DDC40 Offset: 0x22DC240 VA: 0x1822DDC40
	public bool DeleteWordBack() { }

	// RVA: 0x22DDD50 Offset: 0x22DC350 VA: 0x1822DDD50
	public bool DeleteWordForward() { }

	// RVA: 0x22DDE20 Offset: 0x22DC420 VA: 0x1822DDE20
	public bool Delete() { }

	// RVA: 0x22DD500 Offset: 0x22DBB00 VA: 0x1822DD500
	public bool Backspace() { }

	// RVA: 0x22E2400 Offset: 0x22E0A00 VA: 0x1822E2400
	public void SelectAll() { }

	// RVA: 0x22E2CE0 Offset: 0x22E12E0 VA: 0x1822E2CE0
	public void SelectNone() { }

	// RVA: 0x22E4350 Offset: 0x22E2950 VA: 0x1822E4350
	public bool get_hasSelection() { }

	// RVA: 0x22DDA10 Offset: 0x22DC010 VA: 0x1822DDA10
	public bool DeleteSelection() { }

	// RVA: 0x22E22B0 Offset: 0x22E08B0 VA: 0x1822E22B0
	public void ReplaceSelection(string replace) { }

	// RVA: 0x22DF820 Offset: 0x22DDE20 VA: 0x1822DF820
	public void Insert(char c) { }

	// RVA: 0x22E0630 Offset: 0x22DEC30 VA: 0x1822E0630
	public void MoveRight() { }

	// RVA: 0x22E0030 Offset: 0x22DE630 VA: 0x1822E0030
	public void MoveLeft() { }

	// RVA: 0x22E0A40 Offset: 0x22DF040 VA: 0x1822E0A40
	public void MoveUp() { }

	// RVA: 0x22DFD10 Offset: 0x22DE310 VA: 0x1822DFD10
	public void MoveDown() { }

	// RVA: 0x22E0270 Offset: 0x22DE870 VA: 0x1822E0270
	public void MoveLineStart() { }

	// RVA: 0x22E0140 Offset: 0x22DE740 VA: 0x1822E0140
	public void MoveLineEnd() { }

	// RVA: 0x22DFF80 Offset: 0x22DE580 VA: 0x1822DFF80
	public void MoveGraphicalLineStart() { }

	// RVA: 0x22DFED0 Offset: 0x22DE4D0 VA: 0x1822DFED0
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x22E0810 Offset: 0x22DEE10 VA: 0x1822E0810
	public void MoveTextStart() { }

	// RVA: 0x22E0750 Offset: 0x22DED50 VA: 0x1822E0750
	public void MoveTextEnd() { }

	// RVA: 0x22DF1A0 Offset: 0x22DD7A0 VA: 0x1822DF1A0
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x22E04D0 Offset: 0x22DEAD0 VA: 0x1822E04D0
	public void MoveParagraphForward() { }

	// RVA: 0x22E0380 Offset: 0x22DE980 VA: 0x1822E0380
	public void MoveParagraphBackward() { }

	// RVA: 0x22DFB70 Offset: 0x22DE170 VA: 0x1822DFB70
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22DF9E0 Offset: 0x22DDFE0 VA: 0x1822DF9E0
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x22E3220 Offset: 0x22E1820 VA: 0x1822E3220
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22E2C00 Offset: 0x22E1200 VA: 0x1822E2C00
	public void SelectLeft() { }

	// RVA: 0x22E2FF0 Offset: 0x22E15F0 VA: 0x1822E2FF0
	public void SelectRight() { }

	// RVA: 0x22E39F0 Offset: 0x22E1FF0 VA: 0x1822E39F0
	public void SelectUp() { }

	// RVA: 0x22E2A20 Offset: 0x22E1020 VA: 0x1822E2A20
	public void SelectDown() { }

	// RVA: 0x22E30D0 Offset: 0x22E16D0 VA: 0x1822E30D0
	public void SelectTextEnd() { }

	// RVA: 0x22E3150 Offset: 0x22E1750 VA: 0x1822E3150
	public void SelectTextStart() { }

	// RVA: 0x22DF9D0 Offset: 0x22DDFD0 VA: 0x1822DF9D0
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0xCA6AC0 Offset: 0xCA50C0 VA: 0x180CA6AC0
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x22DED50 Offset: 0x22DD350 VA: 0x1822DED50
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x22DEC40 Offset: 0x22DD240 VA: 0x1822DEC40
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x22DE930 Offset: 0x22DCF30 VA: 0x1822DE930
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x22DE9D0 Offset: 0x22DCFD0 VA: 0x1822DE9D0
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x22E0D10 Offset: 0x22DF310 VA: 0x1822E0D10
	public void MoveWordRight() { }

	// RVA: 0x22E0970 Offset: 0x22DEF70 VA: 0x1822E0970
	public void MoveToStartOfNextWord() { }

	// RVA: 0x22E08A0 Offset: 0x22DEEA0 VA: 0x1822E08A0
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x22E3980 Offset: 0x22E1F80 VA: 0x1822E3980
	public void SelectToStartOfNextWord() { }

	// RVA: 0x22E31B0 Offset: 0x22E17B0 VA: 0x1822E31B0
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x22DD6B0 Offset: 0x22DBCB0 VA: 0x1822DD6B0
	private TextEditor.CharacterType ClassifyChar(int index) { }

	// RVA: 0x22DEA70 Offset: 0x22DD070 VA: 0x1822DEA70
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x22DE860 Offset: 0x22DCE60 VA: 0x1822DE860
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x22E0BC0 Offset: 0x22DF1C0 VA: 0x1822E0BC0
	public void MoveWordLeft() { }

	// RVA: 0x22E3C10 Offset: 0x22E2210 VA: 0x1822E3C10
	public void SelectWordRight() { }

	// RVA: 0x22E3AC0 Offset: 0x22E20C0 VA: 0x1822E3AC0
	public void SelectWordLeft() { }

	// RVA: 0x22DE610 Offset: 0x22DCC10 VA: 0x1822DE610
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x22DE520 Offset: 0x22DCB20 VA: 0x1822DE520
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x22E2B90 Offset: 0x22E1190 VA: 0x1822E2B90
	public void SelectGraphicalLineStart() { }

	// RVA: 0x22E2B20 Offset: 0x22E1120 VA: 0x1822E2B20
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x22E2EB0 Offset: 0x22E14B0 VA: 0x1822E2EB0
	public void SelectParagraphForward() { }

	// RVA: 0x22E2D40 Offset: 0x22E1340 VA: 0x1822E2D40
	public void SelectParagraphBackward() { }

	// RVA: 0x22E2600 Offset: 0x22E0C00 VA: 0x1822E2600
	public void SelectCurrentWord() { }

	// RVA: 0x22DE700 Offset: 0x22DCD00 VA: 0x1822DE700
	private int FindEndOfClassification(int p, TextEditor.Direction dir) { }

	// RVA: 0x22E24B0 Offset: 0x22E0AB0 VA: 0x1822E24B0
	public void SelectCurrentParagraph() { }

	// RVA: 0x22E3D60 Offset: 0x22E2360 VA: 0x1822E3D60
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E3DB0 Offset: 0x22E23B0 VA: 0x1822E3DB0
	internal void UpdateScrollOffset() { }

	// RVA: 0x22DDEE0 Offset: 0x22DC4E0 VA: 0x1822DDEE0
	public void DrawCursor(string newText) { }

	// RVA: 0x22E12C0 Offset: 0x22DF8C0 VA: 0x1822E12C0
	private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x22E23B0 Offset: 0x22E09B0 VA: 0x1822E23B0
	public void SaveBackup() { }

	// RVA: 0x22DD880 Offset: 0x22DBE80 VA: 0x1822DD880
	public bool Cut() { }

	// RVA: 0x22DD7F0 Offset: 0x22DBDF0 VA: 0x1822DD7F0
	public void Copy() { }

	// RVA: 0x22E2230 Offset: 0x22E0830 VA: 0x1822E2230
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x22E11D0 Offset: 0x22DF7D0 VA: 0x1822E11D0
	public bool Paste() { }

	// RVA: 0x22DF950 Offset: 0x22DDF50 VA: 0x1822DF950
	private static void MapKey(string key, TextEditor.TextEditOp action) { }

	// RVA: 0x22DF210 Offset: 0x22DD810 VA: 0x1822DF210
	private void InitKeyActions() { }

	// RVA: 0x95F830 Offset: 0x95DE30 VA: 0x18095F830
	public void DetectFocusChange() { }

	// RVA: 0x22E0F70 Offset: 0x22DF570 VA: 0x1822E0F70 Slot: 5
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x22DD620 Offset: 0x22DBC20 VA: 0x1822DD620
	private void ClampTextIndex(ref int index) { }

	// RVA: 0x22DE3A0 Offset: 0x22DC9A0 VA: 0x1822DE3A0
	private void EnsureValidCodePointIndex(ref int index) { }

	// RVA: 0x22DF850 Offset: 0x22DDE50 VA: 0x1822DF850
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x22E2180 Offset: 0x22E0780 VA: 0x1822E2180
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x22E0E70 Offset: 0x22DF470 VA: 0x1822E0E70
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

