internal sealed class RegexParser // TypeDefIndex: 2627
{	// Fields
	internal RegexNode _stack; // 0x10
	internal RegexNode _group; // 0x18
	internal RegexNode _alternation; // 0x20
	internal RegexNode _concatenation; // 0x28
	internal RegexNode _unit; // 0x30
	internal string _pattern; // 0x38
	internal int _currentPos; // 0x40
	internal CultureInfo _culture; // 0x48
	internal int _autocap; // 0x50
	internal int _capcount; // 0x54
	internal int _captop; // 0x58
	internal int _capsize; // 0x5C
	internal Hashtable _caps; // 0x60
	internal Hashtable _capnames; // 0x68
	internal int[] _capnumlist; // 0x70
	internal List<string> _capnamelist; // 0x78
	internal RegexOptions _options; // 0x80
	internal List<RegexOptions> _optionsStack; // 0x88
	internal bool _ignoreNextParen; // 0x90
	internal static readonly byte[] _category; // 0x0

	// Methods

	// RVA: 0x16B2A00 Offset: 0x16B1000 VA: 0x1816B2A00
	internal static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x16B2870 Offset: 0x16B0E70 VA: 0x1816B2870
	internal static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x16B1A20 Offset: 0x16B0020 VA: 0x1816B1A20
	internal static string Escape(string input) { }

	// RVA: 0x16B6F50 Offset: 0x16B5550 VA: 0x1816B6F50
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x16B6CD0 Offset: 0x16B52D0 VA: 0x1816B6CD0
	internal void SetPattern(string Re) { }

	// RVA: 0x16B2F30 Offset: 0x16B1530 VA: 0x1816B2F30
	internal void Reset(RegexOptions topopts) { }

	// RVA: 0x16B6250 Offset: 0x16B4850 VA: 0x1816B6250
	internal RegexNode ScanRegex() { }

	// RVA: 0x16B6AB0 Offset: 0x16B50B0 VA: 0x1816B6AB0
	internal RegexNode ScanReplacement() { }

	// RVA: 0x16B4080 Offset: 0x16B2680 VA: 0x1816B4080
	internal RegexCharClass ScanCharClass(bool caseInsensitive) { }

	// RVA: 0x16B4090 Offset: 0x16B2690 VA: 0x1816B4090
	internal RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x16B52F0 Offset: 0x16B38F0 VA: 0x1816B52F0
	internal RegexNode ScanGroupOpen() { }

	// RVA: 0x16B3C10 Offset: 0x16B2210 VA: 0x1816B3C10
	internal void ScanBlank() { }

	// RVA: 0x16B3020 Offset: 0x16B1620 VA: 0x1816B3020
	internal RegexNode ScanBackslash() { }

	// RVA: 0x16B3570 Offset: 0x16B1B70 VA: 0x1816B3570
	internal RegexNode ScanBasicBackslash() { }

	// RVA: 0x16B4ED0 Offset: 0x16B34D0 VA: 0x1816B4ED0
	internal RegexNode ScanDollar() { }

	// RVA: 0x16B3FC0 Offset: 0x16B25C0 VA: 0x1816B3FC0
	internal string ScanCapname() { }

	// RVA: 0x16B60B0 Offset: 0x16B46B0 VA: 0x1816B60B0
	internal char ScanOctal() { }

	// RVA: 0x16B4E00 Offset: 0x16B3400 VA: 0x1816B4E00
	internal int ScanDecimal() { }

	// RVA: 0x16B5F90 Offset: 0x16B4590 VA: 0x1816B5F90
	internal char ScanHex(int c) { }

	// RVA: 0x16B1C20 Offset: 0x16B0220 VA: 0x1816B1C20
	internal static int HexDigit(char ch) { }

	// RVA: 0x16B4D30 Offset: 0x16B3330 VA: 0x1816B4D30
	internal char ScanControl() { }

	// RVA: 0x16B1DB0 Offset: 0x16B03B0 VA: 0x1816B1DB0
	internal bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x16B6140 Offset: 0x16B4740 VA: 0x1816B6140
	internal void ScanOptions() { }

	// RVA: 0x16B4970 Offset: 0x16B2F70 VA: 0x1816B4970
	internal char ScanCharEscape() { }

	// RVA: 0x16B26B0 Offset: 0x16B0CB0 VA: 0x1816B26B0
	internal string ParseProperty() { }

	// RVA: 0x16B6E00 Offset: 0x16B5400 VA: 0x1816B6E00
	internal int TypeFromCode(char ch) { }

	// RVA: 0x16B2610 Offset: 0x16B0C10 VA: 0x1816B2610
	internal static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x16B1650 Offset: 0x16AFC50 VA: 0x1816B1650
	internal void CountCaptures() { }

	// RVA: 0x16B24C0 Offset: 0x16B0AC0 VA: 0x1816B24C0
	internal void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x16B2390 Offset: 0x16B0990 VA: 0x1816B2390
	internal void NoteCaptureName(string name, int pos) { }

	// RVA: 0x16B25C0 Offset: 0x16B0BC0 VA: 0x1816B25C0
	internal void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x16B0F40 Offset: 0x16AF540 VA: 0x1816B0F40
	internal void AssignNameSlots() { }

	// RVA: 0x16B1580 Offset: 0x16AFB80 VA: 0x1816B1580
	internal int CaptureSlotFromName(string capname) { }

	// RVA: 0x16B1C70 Offset: 0x16B0270 VA: 0x1816B1C70
	internal bool IsCaptureSlot(int i) { }

	// RVA: 0x16B1C50 Offset: 0x16B0250 VA: 0x1816B1C50
	internal bool IsCaptureName(string capname) { }

	// RVA: 0x16B6EB0 Offset: 0x16B54B0 VA: 0x1816B6EB0
	internal bool UseOptionN() { }

	// RVA: 0x16B6E90 Offset: 0x16B5490 VA: 0x1816B6E90
	internal bool UseOptionI() { }

	// RVA: 0x16B6EA0 Offset: 0x16B54A0 VA: 0x1816B6EA0
	internal bool UseOptionM() { }

	// RVA: 0x16B6EC0 Offset: 0x16B54C0 VA: 0x1816B6EC0
	internal bool UseOptionS() { }

	// RVA: 0x16B6ED0 Offset: 0x16B54D0 VA: 0x1816B6ED0
	internal bool UseOptionX() { }

	// RVA: 0x16B6E80 Offset: 0x16B5480 VA: 0x1816B6E80
	internal bool UseOptionE() { }

	// RVA: 0x16B1F10 Offset: 0x16B0510 VA: 0x1816B1F10
	internal static bool IsSpecial(char ch) { }

	// RVA: 0x16B1FB0 Offset: 0x16B05B0 VA: 0x1816B1FB0
	internal static bool IsStopperX(char ch) { }

	// RVA: 0x16B1DD0 Offset: 0x16B03D0 VA: 0x1816B1DD0
	internal static bool IsQuantifier(char ch) { }

	// RVA: 0x16B2050 Offset: 0x16B0650 VA: 0x1816B2050
	internal bool IsTrueQuantifier() { }

	// RVA: 0x16B1E70 Offset: 0x16B0470 VA: 0x1816B1E70
	internal static bool IsSpace(char ch) { }

	// RVA: 0x16B1D10 Offset: 0x16B0310 VA: 0x1816B1D10
	internal static bool IsMetachar(char ch) { }

	// RVA: 0x16B06D0 Offset: 0x16AECD0 VA: 0x1816B06D0
	internal void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x16B2E60 Offset: 0x16B1460 VA: 0x1816B2E60
	internal void PushGroup() { }

	// RVA: 0x16B2C40 Offset: 0x16B1240 VA: 0x1816B2C40
	internal void PopGroup() { }

	// RVA: 0x16B1A10 Offset: 0x16B0010 VA: 0x1816B1A10
	internal bool EmptyStack() { }

	// RVA: 0x16B6D40 Offset: 0x16B5340 VA: 0x1816B6D40
	internal void StartGroup(RegexNode openGroup) { }

	// RVA: 0x16B0570 Offset: 0x16AEB70 VA: 0x1816B0570
	internal void AddAlternate() { }

	// RVA: 0x16B0A50 Offset: 0x16AF050 VA: 0x1816B0A50
	internal void AddConcatenate() { }

	// RVA: 0x16B0900 Offset: 0x16AEF00 VA: 0x1816B0900
	internal void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal RegexNode Unit() { }

	// RVA: 0x16B0D60 Offset: 0x16AF360 VA: 0x1816B0D60
	internal void AddUnitOne(char ch) { }

	// RVA: 0x16B0C90 Offset: 0x16AF290 VA: 0x1816B0C90
	internal void AddUnitNotone(char ch) { }

	// RVA: 0x16B0E30 Offset: 0x16AF430 VA: 0x1816B0E30
	internal void AddUnitSet(string cc) { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void AddUnitNode(RegexNode node) { }

	// RVA: 0x16B0EC0 Offset: 0x16AF4C0 VA: 0x1816B0EC0
	internal void AddUnitType(int type) { }

	// RVA: 0x16B0AA0 Offset: 0x16AF0A0 VA: 0x1816B0AA0
	internal void AddGroup() { }

	// RVA: 0x16B2EE0 Offset: 0x16B14E0 VA: 0x1816B2EE0
	internal void PushOptions() { }

	// RVA: 0x16B2DD0 Offset: 0x16B13D0 VA: 0x1816B2DD0
	internal void PopOptions() { }

	// RVA: 0x16B19C0 Offset: 0x16AFFC0 VA: 0x1816B19C0
	internal bool EmptyOptionsStack() { }

	// RVA: 0x16B2D80 Offset: 0x16B1380 VA: 0x1816B2D80
	internal void PopKeepOptions() { }

	// RVA: 0x16B21E0 Offset: 0x16B07E0 VA: 0x1816B21E0
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	internal int Textpos() { }

	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	internal void Textto(int pos) { }

	// RVA: 0x16B2340 Offset: 0x16B0940 VA: 0x1816B2340
	internal char MoveRightGetChar() { }

	// RVA: 0x16B2370 Offset: 0x16B0970 VA: 0x1816B2370
	internal void MoveRight() { }

	// RVA: 0x16B2380 Offset: 0x16B0980 VA: 0x1816B2380
	internal void MoveRight(int i) { }

	// RVA: 0x16B2330 Offset: 0x16B0930 VA: 0x1816B2330
	internal void MoveLeft() { }

	// RVA: 0x16B1610 Offset: 0x16AFC10 VA: 0x1816B1610
	internal char CharAt(int i) { }

	// RVA: 0x16B2FF0 Offset: 0x16B15F0 VA: 0x1816B2FF0
	internal char RightChar() { }

	// RVA: 0x16B2FC0 Offset: 0x16B15C0 VA: 0x1816B2FC0
	internal char RightChar(int i) { }

	// RVA: 0x16B1630 Offset: 0x16AFC30 VA: 0x1816B1630
	internal int CharsRight() { }

	// RVA: 0x16B6EE0 Offset: 0x16B54E0 VA: 0x1816B6EE0
	private static void .cctor() { }

}

