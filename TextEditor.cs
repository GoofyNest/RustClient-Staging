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

	// RVA: 0x22E4490 Offset: 0x22E2A90 VA: 0x1822E4490
	public string get_text() { }

	// RVA: 0x22E4620 Offset: 0x22E2C20 VA: 0x1822E4620
	public void set_text(string value) { }

	// RVA: 0x22E4470 Offset: 0x22E2A70 VA: 0x1822E4470
	public Rect get_position() { }

	// RVA: 0x22E4500 Offset: 0x22E2B00 VA: 0x1822E4500
	public void set_position(Rect value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDD840 Offset: 0xDCC40 VA: 0x1800DD840
	// RVA: 0x22E4460 Offset: 0x22E2A60 VA: 0x1822E4460 Slot: 4
	internal virtual Rect get_localPosition() { }

	// RVA: 0x22E4440 Offset: 0x22E2A40 VA: 0x1822E4440
	public int get_cursorIndex() { }

	// RVA: 0x22E44B0 Offset: 0x22E2AB0 VA: 0x1822E44B0
	public void set_cursorIndex(int value) { }

	// RVA: 0x22E4480 Offset: 0x22E2A80 VA: 0x1822E4480
	public int get_selectIndex() { }

	// RVA: 0x22E45D0 Offset: 0x22E2BD0 VA: 0x1822E45D0
	public void set_selectIndex(int value) { }

	// RVA: 0x22DD8E0 Offset: 0x22DBEE0 VA: 0x1822DD8E0
	private void ClearCursorPos() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E4320 Offset: 0x22E2920 VA: 0x1822E4320
	public void .ctor() { }

	// RVA: 0x22E11B0 Offset: 0x22DF7B0 VA: 0x1822E11B0
	public void OnFocus() { }

	// RVA: 0x22E1260 Offset: 0x22DF860 VA: 0x1822E1260
	public void OnLostFocus() { }

	// RVA: 0x22DEF90 Offset: 0x22DD590 VA: 0x1822DEF90
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x22DF090 Offset: 0x22DD690 VA: 0x1822DF090
	public bool HandleKeyEvent(Event e) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DF190 Offset: 0x22DD790 VA: 0x1822DF190
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x22DDA20 Offset: 0x22DC020 VA: 0x1822DDA20
	public bool DeleteLineBack() { }

	// RVA: 0x22DDD40 Offset: 0x22DC340 VA: 0x1822DDD40
	public bool DeleteWordBack() { }

	// RVA: 0x22DDE50 Offset: 0x22DC450 VA: 0x1822DDE50
	public bool DeleteWordForward() { }

	// RVA: 0x22DDF20 Offset: 0x22DC520 VA: 0x1822DDF20
	public bool Delete() { }

	// RVA: 0x22DD600 Offset: 0x22DBC00 VA: 0x1822DD600
	public bool Backspace() { }

	// RVA: 0x22E2500 Offset: 0x22E0B00 VA: 0x1822E2500
	public void SelectAll() { }

	// RVA: 0x22E2DE0 Offset: 0x22E13E0 VA: 0x1822E2DE0
	public void SelectNone() { }

	// RVA: 0x22E4450 Offset: 0x22E2A50 VA: 0x1822E4450
	public bool get_hasSelection() { }

	// RVA: 0x22DDB10 Offset: 0x22DC110 VA: 0x1822DDB10
	public bool DeleteSelection() { }

	// RVA: 0x22E23B0 Offset: 0x22E09B0 VA: 0x1822E23B0
	public void ReplaceSelection(string replace) { }

	// RVA: 0x22DF920 Offset: 0x22DDF20 VA: 0x1822DF920
	public void Insert(char c) { }

	// RVA: 0x22E0730 Offset: 0x22DED30 VA: 0x1822E0730
	public void MoveRight() { }

	// RVA: 0x22E0130 Offset: 0x22DE730 VA: 0x1822E0130
	public void MoveLeft() { }

	// RVA: 0x22E0B40 Offset: 0x22DF140 VA: 0x1822E0B40
	public void MoveUp() { }

	// RVA: 0x22DFE10 Offset: 0x22DE410 VA: 0x1822DFE10
	public void MoveDown() { }

	// RVA: 0x22E0370 Offset: 0x22DE970 VA: 0x1822E0370
	public void MoveLineStart() { }

	// RVA: 0x22E0240 Offset: 0x22DE840 VA: 0x1822E0240
	public void MoveLineEnd() { }

	// RVA: 0x22E0080 Offset: 0x22DE680 VA: 0x1822E0080
	public void MoveGraphicalLineStart() { }

	// RVA: 0x22DFFD0 Offset: 0x22DE5D0 VA: 0x1822DFFD0
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x22E0910 Offset: 0x22DEF10 VA: 0x1822E0910
	public void MoveTextStart() { }

	// RVA: 0x22E0850 Offset: 0x22DEE50 VA: 0x1822E0850
	public void MoveTextEnd() { }

	// RVA: 0x22DF2A0 Offset: 0x22DD8A0 VA: 0x1822DF2A0
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x22E05D0 Offset: 0x22DEBD0 VA: 0x1822E05D0
	public void MoveParagraphForward() { }

	// RVA: 0x22E0480 Offset: 0x22DEA80 VA: 0x1822E0480
	public void MoveParagraphBackward() { }

	// RVA: 0x22DFC70 Offset: 0x22DE270 VA: 0x1822DFC70
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22DFAE0 Offset: 0x22DE0E0 VA: 0x1822DFAE0
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x22E3320 Offset: 0x22E1920 VA: 0x1822E3320
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x22E2D00 Offset: 0x22E1300 VA: 0x1822E2D00
	public void SelectLeft() { }

	// RVA: 0x22E30F0 Offset: 0x22E16F0 VA: 0x1822E30F0
	public void SelectRight() { }

	// RVA: 0x22E3AF0 Offset: 0x22E20F0 VA: 0x1822E3AF0
	public void SelectUp() { }

	// RVA: 0x22E2B20 Offset: 0x22E1120 VA: 0x1822E2B20
	public void SelectDown() { }

	// RVA: 0x22E31D0 Offset: 0x22E17D0 VA: 0x1822E31D0
	public void SelectTextEnd() { }

	// RVA: 0x22E3250 Offset: 0x22E1850 VA: 0x1822E3250
	public void SelectTextStart() { }

	// RVA: 0x22DFAD0 Offset: 0x22DE0D0 VA: 0x1822DFAD0
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0xCA6D80 Offset: 0xCA5380 VA: 0x180CA6D80
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x22DEE50 Offset: 0x22DD450 VA: 0x1822DEE50
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x22DED40 Offset: 0x22DD340 VA: 0x1822DED40
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x22DEA30 Offset: 0x22DD030 VA: 0x1822DEA30
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x22DEAD0 Offset: 0x22DD0D0 VA: 0x1822DEAD0
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x22E0E10 Offset: 0x22DF410 VA: 0x1822E0E10
	public void MoveWordRight() { }

	// RVA: 0x22E0A70 Offset: 0x22DF070 VA: 0x1822E0A70
	public void MoveToStartOfNextWord() { }

	// RVA: 0x22E09A0 Offset: 0x22DEFA0 VA: 0x1822E09A0
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x22E3A80 Offset: 0x22E2080 VA: 0x1822E3A80
	public void SelectToStartOfNextWord() { }

	// RVA: 0x22E32B0 Offset: 0x22E18B0 VA: 0x1822E32B0
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x22DD7B0 Offset: 0x22DBDB0 VA: 0x1822DD7B0
	private TextEditor.CharacterType ClassifyChar(int index) { }

	// RVA: 0x22DEB70 Offset: 0x22DD170 VA: 0x1822DEB70
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x22DE960 Offset: 0x22DCF60 VA: 0x1822DE960
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x22E0CC0 Offset: 0x22DF2C0 VA: 0x1822E0CC0
	public void MoveWordLeft() { }

	// RVA: 0x22E3D10 Offset: 0x22E2310 VA: 0x1822E3D10
	public void SelectWordRight() { }

	// RVA: 0x22E3BC0 Offset: 0x22E21C0 VA: 0x1822E3BC0
	public void SelectWordLeft() { }

	// RVA: 0x22DE710 Offset: 0x22DCD10 VA: 0x1822DE710
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x22DE620 Offset: 0x22DCC20 VA: 0x1822DE620
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x22E2C90 Offset: 0x22E1290 VA: 0x1822E2C90
	public void SelectGraphicalLineStart() { }

	// RVA: 0x22E2C20 Offset: 0x22E1220 VA: 0x1822E2C20
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x22E2FB0 Offset: 0x22E15B0 VA: 0x1822E2FB0
	public void SelectParagraphForward() { }

	// RVA: 0x22E2E40 Offset: 0x22E1440 VA: 0x1822E2E40
	public void SelectParagraphBackward() { }

	// RVA: 0x22E2700 Offset: 0x22E0D00 VA: 0x1822E2700
	public void SelectCurrentWord() { }

	// RVA: 0x22DE800 Offset: 0x22DCE00 VA: 0x1822DE800
	private int FindEndOfClassification(int p, TextEditor.Direction dir) { }

	// RVA: 0x22E25B0 Offset: 0x22E0BB0 VA: 0x1822E25B0
	public void SelectCurrentParagraph() { }

	// RVA: 0x22E3E60 Offset: 0x22E2460 VA: 0x1822E3E60
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E3EB0 Offset: 0x22E24B0 VA: 0x1822E3EB0
	internal void UpdateScrollOffset() { }

	// RVA: 0x22DDFE0 Offset: 0x22DC5E0 VA: 0x1822DDFE0
	public void DrawCursor(string newText) { }

	// RVA: 0x22E13C0 Offset: 0x22DF9C0 VA: 0x1822E13C0
	private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x22E24B0 Offset: 0x22E0AB0 VA: 0x1822E24B0
	public void SaveBackup() { }

	// RVA: 0x22DD980 Offset: 0x22DBF80 VA: 0x1822DD980
	public bool Cut() { }

	// RVA: 0x22DD8F0 Offset: 0x22DBEF0 VA: 0x1822DD8F0
	public void Copy() { }

	// RVA: 0x22E2330 Offset: 0x22E0930 VA: 0x1822E2330
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x22E12D0 Offset: 0x22DF8D0 VA: 0x1822E12D0
	public bool Paste() { }

	// RVA: 0x22DFA50 Offset: 0x22DE050 VA: 0x1822DFA50
	private static void MapKey(string key, TextEditor.TextEditOp action) { }

	// RVA: 0x22DF310 Offset: 0x22DD910 VA: 0x1822DF310
	private void InitKeyActions() { }

	// RVA: 0x95F940 Offset: 0x95DF40 VA: 0x18095F940
	public void DetectFocusChange() { }

	// RVA: 0x22E1070 Offset: 0x22DF670 VA: 0x1822E1070 Slot: 5
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x22DD720 Offset: 0x22DBD20 VA: 0x1822DD720
	private void ClampTextIndex(ref int index) { }

	// RVA: 0x22DE4A0 Offset: 0x22DCAA0 VA: 0x1822DE4A0
	private void EnsureValidCodePointIndex(ref int index) { }

	// RVA: 0x22DF950 Offset: 0x22DDF50 VA: 0x1822DF950
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x22E2280 Offset: 0x22E0880 VA: 0x1822E2280
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x22E0F70 Offset: 0x22DF570 VA: 0x1822E0F70
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

