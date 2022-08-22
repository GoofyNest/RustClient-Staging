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

	// RVA: 0x16B08B0 Offset: 0x16AEEB0 VA: 0x1816B08B0
	internal static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x16B0720 Offset: 0x16AED20 VA: 0x1816B0720
	internal static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x16AF8D0 Offset: 0x16ADED0 VA: 0x1816AF8D0
	internal static string Escape(string input) { }

	// RVA: 0x16B4E00 Offset: 0x16B3400 VA: 0x1816B4E00
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x16B4B80 Offset: 0x16B3180 VA: 0x1816B4B80
	internal void SetPattern(string Re) { }

	// RVA: 0x16B0DE0 Offset: 0x16AF3E0 VA: 0x1816B0DE0
	internal void Reset(RegexOptions topopts) { }

	// RVA: 0x16B4100 Offset: 0x16B2700 VA: 0x1816B4100
	internal RegexNode ScanRegex() { }

	// RVA: 0x16B4960 Offset: 0x16B2F60 VA: 0x1816B4960
	internal RegexNode ScanReplacement() { }

	// RVA: 0x16B1F30 Offset: 0x16B0530 VA: 0x1816B1F30
	internal RegexCharClass ScanCharClass(bool caseInsensitive) { }

	// RVA: 0x16B1F40 Offset: 0x16B0540 VA: 0x1816B1F40
	internal RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x16B31A0 Offset: 0x16B17A0 VA: 0x1816B31A0
	internal RegexNode ScanGroupOpen() { }

	// RVA: 0x16B1AC0 Offset: 0x16B00C0 VA: 0x1816B1AC0
	internal void ScanBlank() { }

	// RVA: 0x16B0ED0 Offset: 0x16AF4D0 VA: 0x1816B0ED0
	internal RegexNode ScanBackslash() { }

	// RVA: 0x16B1420 Offset: 0x16AFA20 VA: 0x1816B1420
	internal RegexNode ScanBasicBackslash() { }

	// RVA: 0x16B2D80 Offset: 0x16B1380 VA: 0x1816B2D80
	internal RegexNode ScanDollar() { }

	// RVA: 0x16B1E70 Offset: 0x16B0470 VA: 0x1816B1E70
	internal string ScanCapname() { }

	// RVA: 0x16B3F60 Offset: 0x16B2560 VA: 0x1816B3F60
	internal char ScanOctal() { }

	// RVA: 0x16B2CB0 Offset: 0x16B12B0 VA: 0x1816B2CB0
	internal int ScanDecimal() { }

	// RVA: 0x16B3E40 Offset: 0x16B2440 VA: 0x1816B3E40
	internal char ScanHex(int c) { }

	// RVA: 0x16AFAD0 Offset: 0x16AE0D0 VA: 0x1816AFAD0
	internal static int HexDigit(char ch) { }

	// RVA: 0x16B2BE0 Offset: 0x16B11E0 VA: 0x1816B2BE0
	internal char ScanControl() { }

	// RVA: 0x16AFC60 Offset: 0x16AE260 VA: 0x1816AFC60
	internal bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x16B3FF0 Offset: 0x16B25F0 VA: 0x1816B3FF0
	internal void ScanOptions() { }

	// RVA: 0x16B2820 Offset: 0x16B0E20 VA: 0x1816B2820
	internal char ScanCharEscape() { }

	// RVA: 0x16B0560 Offset: 0x16AEB60 VA: 0x1816B0560
	internal string ParseProperty() { }

	// RVA: 0x16B4CB0 Offset: 0x16B32B0 VA: 0x1816B4CB0
	internal int TypeFromCode(char ch) { }

	// RVA: 0x16B04C0 Offset: 0x16AEAC0 VA: 0x1816B04C0
	internal static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x16AF500 Offset: 0x16ADB00 VA: 0x1816AF500
	internal void CountCaptures() { }

	// RVA: 0x16B0370 Offset: 0x16AE970 VA: 0x1816B0370
	internal void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x16B0240 Offset: 0x16AE840 VA: 0x1816B0240
	internal void NoteCaptureName(string name, int pos) { }

	// RVA: 0x16B0470 Offset: 0x16AEA70 VA: 0x1816B0470
	internal void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x16AEDF0 Offset: 0x16AD3F0 VA: 0x1816AEDF0
	internal void AssignNameSlots() { }

	// RVA: 0x16AF430 Offset: 0x16ADA30 VA: 0x1816AF430
	internal int CaptureSlotFromName(string capname) { }

	// RVA: 0x16AFB20 Offset: 0x16AE120 VA: 0x1816AFB20
	internal bool IsCaptureSlot(int i) { }

	// RVA: 0x16AFB00 Offset: 0x16AE100 VA: 0x1816AFB00
	internal bool IsCaptureName(string capname) { }

	// RVA: 0x16B4D60 Offset: 0x16B3360 VA: 0x1816B4D60
	internal bool UseOptionN() { }

	// RVA: 0x16B4D40 Offset: 0x16B3340 VA: 0x1816B4D40
	internal bool UseOptionI() { }

	// RVA: 0x16B4D50 Offset: 0x16B3350 VA: 0x1816B4D50
	internal bool UseOptionM() { }

	// RVA: 0x16B4D70 Offset: 0x16B3370 VA: 0x1816B4D70
	internal bool UseOptionS() { }

	// RVA: 0x16B4D80 Offset: 0x16B3380 VA: 0x1816B4D80
	internal bool UseOptionX() { }

	// RVA: 0x16B4D30 Offset: 0x16B3330 VA: 0x1816B4D30
	internal bool UseOptionE() { }

	// RVA: 0x16AFDC0 Offset: 0x16AE3C0 VA: 0x1816AFDC0
	internal static bool IsSpecial(char ch) { }

	// RVA: 0x16AFE60 Offset: 0x16AE460 VA: 0x1816AFE60
	internal static bool IsStopperX(char ch) { }

	// RVA: 0x16AFC80 Offset: 0x16AE280 VA: 0x1816AFC80
	internal static bool IsQuantifier(char ch) { }

	// RVA: 0x16AFF00 Offset: 0x16AE500 VA: 0x1816AFF00
	internal bool IsTrueQuantifier() { }

	// RVA: 0x16AFD20 Offset: 0x16AE320 VA: 0x1816AFD20
	internal static bool IsSpace(char ch) { }

	// RVA: 0x16AFBC0 Offset: 0x16AE1C0 VA: 0x1816AFBC0
	internal static bool IsMetachar(char ch) { }

	// RVA: 0x16AE580 Offset: 0x16ACB80 VA: 0x1816AE580
	internal void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x16B0D10 Offset: 0x16AF310 VA: 0x1816B0D10
	internal void PushGroup() { }

	// RVA: 0x16B0AF0 Offset: 0x16AF0F0 VA: 0x1816B0AF0
	internal void PopGroup() { }

	// RVA: 0x16AF8C0 Offset: 0x16ADEC0 VA: 0x1816AF8C0
	internal bool EmptyStack() { }

	// RVA: 0x16B4BF0 Offset: 0x16B31F0 VA: 0x1816B4BF0
	internal void StartGroup(RegexNode openGroup) { }

	// RVA: 0x16AE420 Offset: 0x16ACA20 VA: 0x1816AE420
	internal void AddAlternate() { }

	// RVA: 0x16AE900 Offset: 0x16ACF00 VA: 0x1816AE900
	internal void AddConcatenate() { }

	// RVA: 0x16AE7B0 Offset: 0x16ACDB0 VA: 0x1816AE7B0
	internal void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal RegexNode Unit() { }

	// RVA: 0x16AEC10 Offset: 0x16AD210 VA: 0x1816AEC10
	internal void AddUnitOne(char ch) { }

	// RVA: 0x16AEB40 Offset: 0x16AD140 VA: 0x1816AEB40
	internal void AddUnitNotone(char ch) { }

	// RVA: 0x16AECE0 Offset: 0x16AD2E0 VA: 0x1816AECE0
	internal void AddUnitSet(string cc) { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void AddUnitNode(RegexNode node) { }

	// RVA: 0x16AED70 Offset: 0x16AD370 VA: 0x1816AED70
	internal void AddUnitType(int type) { }

	// RVA: 0x16AE950 Offset: 0x16ACF50 VA: 0x1816AE950
	internal void AddGroup() { }

	// RVA: 0x16B0D90 Offset: 0x16AF390 VA: 0x1816B0D90
	internal void PushOptions() { }

	// RVA: 0x16B0C80 Offset: 0x16AF280 VA: 0x1816B0C80
	internal void PopOptions() { }

	// RVA: 0x16AF870 Offset: 0x16ADE70 VA: 0x1816AF870
	internal bool EmptyOptionsStack() { }

	// RVA: 0x16B0C30 Offset: 0x16AF230 VA: 0x1816B0C30
	internal void PopKeepOptions() { }

	// RVA: 0x16B0090 Offset: 0x16AE690 VA: 0x1816B0090
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	internal int Textpos() { }

	// RVA: 0x6840F0 Offset: 0x6826F0 VA: 0x1806840F0
	internal void Textto(int pos) { }

	// RVA: 0x16B01F0 Offset: 0x16AE7F0 VA: 0x1816B01F0
	internal char MoveRightGetChar() { }

	// RVA: 0x16B0220 Offset: 0x16AE820 VA: 0x1816B0220
	internal void MoveRight() { }

	// RVA: 0x16B0230 Offset: 0x16AE830 VA: 0x1816B0230
	internal void MoveRight(int i) { }

	// RVA: 0x16B01E0 Offset: 0x16AE7E0 VA: 0x1816B01E0
	internal void MoveLeft() { }

	// RVA: 0x16AF4C0 Offset: 0x16ADAC0 VA: 0x1816AF4C0
	internal char CharAt(int i) { }

	// RVA: 0x16B0EA0 Offset: 0x16AF4A0 VA: 0x1816B0EA0
	internal char RightChar() { }

	// RVA: 0x16B0E70 Offset: 0x16AF470 VA: 0x1816B0E70
	internal char RightChar(int i) { }

	// RVA: 0x16AF4E0 Offset: 0x16ADAE0 VA: 0x1816AF4E0
	internal int CharsRight() { }

	// RVA: 0x16B4D90 Offset: 0x16B3390 VA: 0x1816B4D90
	private static void .cctor() { }

}

