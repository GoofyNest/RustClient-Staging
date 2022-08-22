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

	// RVA: 0x16B2CC0 Offset: 0x16B12C0 VA: 0x1816B2CC0
	internal static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x16B2B30 Offset: 0x16B1130 VA: 0x1816B2B30
	internal static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x16B1CE0 Offset: 0x16B02E0 VA: 0x1816B1CE0
	internal static string Escape(string input) { }

	// RVA: 0x16B7210 Offset: 0x16B5810 VA: 0x1816B7210
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x16B6F90 Offset: 0x16B5590 VA: 0x1816B6F90
	internal void SetPattern(string Re) { }

	// RVA: 0x16B31F0 Offset: 0x16B17F0 VA: 0x1816B31F0
	internal void Reset(RegexOptions topopts) { }

	// RVA: 0x16B6510 Offset: 0x16B4B10 VA: 0x1816B6510
	internal RegexNode ScanRegex() { }

	// RVA: 0x16B6D70 Offset: 0x16B5370 VA: 0x1816B6D70
	internal RegexNode ScanReplacement() { }

	// RVA: 0x16B4340 Offset: 0x16B2940 VA: 0x1816B4340
	internal RegexCharClass ScanCharClass(bool caseInsensitive) { }

	// RVA: 0x16B4350 Offset: 0x16B2950 VA: 0x1816B4350
	internal RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x16B55B0 Offset: 0x16B3BB0 VA: 0x1816B55B0
	internal RegexNode ScanGroupOpen() { }

	// RVA: 0x16B3ED0 Offset: 0x16B24D0 VA: 0x1816B3ED0
	internal void ScanBlank() { }

	// RVA: 0x16B32E0 Offset: 0x16B18E0 VA: 0x1816B32E0
	internal RegexNode ScanBackslash() { }

	// RVA: 0x16B3830 Offset: 0x16B1E30 VA: 0x1816B3830
	internal RegexNode ScanBasicBackslash() { }

	// RVA: 0x16B5190 Offset: 0x16B3790 VA: 0x1816B5190
	internal RegexNode ScanDollar() { }

	// RVA: 0x16B4280 Offset: 0x16B2880 VA: 0x1816B4280
	internal string ScanCapname() { }

	// RVA: 0x16B6370 Offset: 0x16B4970 VA: 0x1816B6370
	internal char ScanOctal() { }

	// RVA: 0x16B50C0 Offset: 0x16B36C0 VA: 0x1816B50C0
	internal int ScanDecimal() { }

	// RVA: 0x16B6250 Offset: 0x16B4850 VA: 0x1816B6250
	internal char ScanHex(int c) { }

	// RVA: 0x16B1EE0 Offset: 0x16B04E0 VA: 0x1816B1EE0
	internal static int HexDigit(char ch) { }

	// RVA: 0x16B4FF0 Offset: 0x16B35F0 VA: 0x1816B4FF0
	internal char ScanControl() { }

	// RVA: 0x16B2070 Offset: 0x16B0670 VA: 0x1816B2070
	internal bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x16B6400 Offset: 0x16B4A00 VA: 0x1816B6400
	internal void ScanOptions() { }

	// RVA: 0x16B4C30 Offset: 0x16B3230 VA: 0x1816B4C30
	internal char ScanCharEscape() { }

	// RVA: 0x16B2970 Offset: 0x16B0F70 VA: 0x1816B2970
	internal string ParseProperty() { }

	// RVA: 0x16B70C0 Offset: 0x16B56C0 VA: 0x1816B70C0
	internal int TypeFromCode(char ch) { }

	// RVA: 0x16B28D0 Offset: 0x16B0ED0 VA: 0x1816B28D0
	internal static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x16B1910 Offset: 0x16AFF10 VA: 0x1816B1910
	internal void CountCaptures() { }

	// RVA: 0x16B2780 Offset: 0x16B0D80 VA: 0x1816B2780
	internal void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x16B2650 Offset: 0x16B0C50 VA: 0x1816B2650
	internal void NoteCaptureName(string name, int pos) { }

	// RVA: 0x16B2880 Offset: 0x16B0E80 VA: 0x1816B2880
	internal void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x16B1200 Offset: 0x16AF800 VA: 0x1816B1200
	internal void AssignNameSlots() { }

	// RVA: 0x16B1840 Offset: 0x16AFE40 VA: 0x1816B1840
	internal int CaptureSlotFromName(string capname) { }

	// RVA: 0x16B1F30 Offset: 0x16B0530 VA: 0x1816B1F30
	internal bool IsCaptureSlot(int i) { }

	// RVA: 0x16B1F10 Offset: 0x16B0510 VA: 0x1816B1F10
	internal bool IsCaptureName(string capname) { }

	// RVA: 0x16B7170 Offset: 0x16B5770 VA: 0x1816B7170
	internal bool UseOptionN() { }

	// RVA: 0x16B7150 Offset: 0x16B5750 VA: 0x1816B7150
	internal bool UseOptionI() { }

	// RVA: 0x16B7160 Offset: 0x16B5760 VA: 0x1816B7160
	internal bool UseOptionM() { }

	// RVA: 0x16B7180 Offset: 0x16B5780 VA: 0x1816B7180
	internal bool UseOptionS() { }

	// RVA: 0x16B7190 Offset: 0x16B5790 VA: 0x1816B7190
	internal bool UseOptionX() { }

	// RVA: 0x16B7140 Offset: 0x16B5740 VA: 0x1816B7140
	internal bool UseOptionE() { }

	// RVA: 0x16B21D0 Offset: 0x16B07D0 VA: 0x1816B21D0
	internal static bool IsSpecial(char ch) { }

	// RVA: 0x16B2270 Offset: 0x16B0870 VA: 0x1816B2270
	internal static bool IsStopperX(char ch) { }

	// RVA: 0x16B2090 Offset: 0x16B0690 VA: 0x1816B2090
	internal static bool IsQuantifier(char ch) { }

	// RVA: 0x16B2310 Offset: 0x16B0910 VA: 0x1816B2310
	internal bool IsTrueQuantifier() { }

	// RVA: 0x16B2130 Offset: 0x16B0730 VA: 0x1816B2130
	internal static bool IsSpace(char ch) { }

	// RVA: 0x16B1FD0 Offset: 0x16B05D0 VA: 0x1816B1FD0
	internal static bool IsMetachar(char ch) { }

	// RVA: 0x16B0990 Offset: 0x16AEF90 VA: 0x1816B0990
	internal void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x16B3120 Offset: 0x16B1720 VA: 0x1816B3120
	internal void PushGroup() { }

	// RVA: 0x16B2F00 Offset: 0x16B1500 VA: 0x1816B2F00
	internal void PopGroup() { }

	// RVA: 0x16B1CD0 Offset: 0x16B02D0 VA: 0x1816B1CD0
	internal bool EmptyStack() { }

	// RVA: 0x16B7000 Offset: 0x16B5600 VA: 0x1816B7000
	internal void StartGroup(RegexNode openGroup) { }

	// RVA: 0x16B0830 Offset: 0x16AEE30 VA: 0x1816B0830
	internal void AddAlternate() { }

	// RVA: 0x16B0D10 Offset: 0x16AF310 VA: 0x1816B0D10
	internal void AddConcatenate() { }

	// RVA: 0x16B0BC0 Offset: 0x16AF1C0 VA: 0x1816B0BC0
	internal void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal RegexNode Unit() { }

	// RVA: 0x16B1020 Offset: 0x16AF620 VA: 0x1816B1020
	internal void AddUnitOne(char ch) { }

	// RVA: 0x16B0F50 Offset: 0x16AF550 VA: 0x1816B0F50
	internal void AddUnitNotone(char ch) { }

	// RVA: 0x16B10F0 Offset: 0x16AF6F0 VA: 0x1816B10F0
	internal void AddUnitSet(string cc) { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void AddUnitNode(RegexNode node) { }

	// RVA: 0x16B1180 Offset: 0x16AF780 VA: 0x1816B1180
	internal void AddUnitType(int type) { }

	// RVA: 0x16B0D60 Offset: 0x16AF360 VA: 0x1816B0D60
	internal void AddGroup() { }

	// RVA: 0x16B31A0 Offset: 0x16B17A0 VA: 0x1816B31A0
	internal void PushOptions() { }

	// RVA: 0x16B3090 Offset: 0x16B1690 VA: 0x1816B3090
	internal void PopOptions() { }

	// RVA: 0x16B1C80 Offset: 0x16B0280 VA: 0x1816B1C80
	internal bool EmptyOptionsStack() { }

	// RVA: 0x16B3040 Offset: 0x16B1640 VA: 0x1816B3040
	internal void PopKeepOptions() { }

	// RVA: 0x16B24A0 Offset: 0x16B0AA0 VA: 0x1816B24A0
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	internal int Textpos() { }

	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	internal void Textto(int pos) { }

	// RVA: 0x16B2600 Offset: 0x16B0C00 VA: 0x1816B2600
	internal char MoveRightGetChar() { }

	// RVA: 0x16B2630 Offset: 0x16B0C30 VA: 0x1816B2630
	internal void MoveRight() { }

	// RVA: 0x16B2640 Offset: 0x16B0C40 VA: 0x1816B2640
	internal void MoveRight(int i) { }

	// RVA: 0x16B25F0 Offset: 0x16B0BF0 VA: 0x1816B25F0
	internal void MoveLeft() { }

	// RVA: 0x16B18D0 Offset: 0x16AFED0 VA: 0x1816B18D0
	internal char CharAt(int i) { }

	// RVA: 0x16B32B0 Offset: 0x16B18B0 VA: 0x1816B32B0
	internal char RightChar() { }

	// RVA: 0x16B3280 Offset: 0x16B1880 VA: 0x1816B3280
	internal char RightChar(int i) { }

	// RVA: 0x16B18F0 Offset: 0x16AFEF0 VA: 0x1816B18F0
	internal int CharsRight() { }

	// RVA: 0x16B71A0 Offset: 0x16B57A0 VA: 0x1816B71A0
	private static void .cctor() { }

}

