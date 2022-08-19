internal sealed class ExpressionParser // TypeDefIndex: 4251
{	// Fields
	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; // 0x0
	private char _escape; // 0x10
	private char _decimalSeparator; // 0x12
	private char _listSeparator; // 0x14
	private char _exponentL; // 0x16
	private char _exponentU; // 0x18
	internal char[] _text; // 0x20
	internal int _pos; // 0x28
	internal int _start; // 0x2C
	internal Tokens _token; // 0x30
	internal int _op; // 0x34
	internal OperatorInfo[] _ops; // 0x38
	internal int _topOperator; // 0x40
	internal int _topNode; // 0x44
	private readonly DataTable _table; // 0x48
	internal ExpressionNode[] _nodeStack; // 0x50
	internal int _prevOperand; // 0x58
	internal ExpressionNode _expression; // 0x60

	// Methods

	// RVA: 0x13E56C0 Offset: 0x13E3CC0 VA: 0x1813E56C0
	internal void .ctor(DataTable table) { }

	// RVA: 0x13E2590 Offset: 0x13E0B90 VA: 0x1813E2590
	internal void LoadExpression(string data) { }

	// RVA: 0x13E5180 Offset: 0x13E3780 VA: 0x1813E5180
	internal void StartScan() { }

	// RVA: 0x13E2CB0 Offset: 0x13E12B0 VA: 0x1813E2CB0
	internal ExpressionNode Parse() { }

	// RVA: 0x13E2800 Offset: 0x13E0E00 VA: 0x1813E2800
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x13E26E0 Offset: 0x13E0CE0 VA: 0x1813E26E0
	private ExpressionNode NodePop() { }

	// RVA: 0x13E2690 Offset: 0x13E0C90 VA: 0x1813E2690
	private ExpressionNode NodePeek() { }

	// RVA: 0x13E2730 Offset: 0x13E0D30 VA: 0x1813E2730
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x13E2070 Offset: 0x13E0670 VA: 0x1813E2070
	private void BuildExpression(int pri) { }

	// RVA: 0x13E2390 Offset: 0x13E0990 VA: 0x1813E2390
	internal void CheckToken(Tokens token) { }

	// RVA: 0x13E4AD0 Offset: 0x13E30D0 VA: 0x1813E4AD0
	internal Tokens Scan() { }

	// RVA: 0x13E43B0 Offset: 0x13E29B0 VA: 0x1813E43B0
	private void ScanNumeric() { }

	// RVA: 0x13E4150 Offset: 0x13E2750 VA: 0x1813E4150
	private void ScanName() { }

	// RVA: 0x13E4230 Offset: 0x13E2830 VA: 0x1813E4230
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x13E3FC0 Offset: 0x13E25C0 VA: 0x1813E3FC0
	private void ScanDate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void ScanBinaryConstant() { }

	// RVA: 0x13E4620 Offset: 0x13E2C20 VA: 0x1813E4620
	private void ScanReserved() { }

	// RVA: 0x13E4910 Offset: 0x13E2F10 VA: 0x1813E4910
	private void ScanString(char escape) { }

	// RVA: 0x13E4A40 Offset: 0x13E3040 VA: 0x1813E4A40
	internal void ScanToken(Tokens token) { }

	// RVA: 0x13E4A70 Offset: 0x13E3070 VA: 0x1813E4A70
	private void ScanWhite() { }

	// RVA: 0x13E2580 Offset: 0x13E0B80 VA: 0x1813E2580
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x13E2410 Offset: 0x13E0A10 VA: 0x1813E2410
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x13E2530 Offset: 0x13E0B30 VA: 0x1813E2530
	private bool IsDigit(char ch) { }

	// RVA: 0x13E24B0 Offset: 0x13E0AB0 VA: 0x1813E24B0
	private bool IsAlpha(char ch) { }

	// RVA: 0x13E5250 Offset: 0x13E3850 VA: 0x1813E5250
	private static void .cctor() { }

}

private struct ExpressionParser.ReservedWords // TypeDefIndex: 4252
{	// Fields
	internal readonly string _word; // 0x0
	internal readonly Tokens _token; // 0x8
	internal readonly int _op; // 0xC

	// Methods

	// RVA: 0xF91A0 Offset: 0xF85A0 VA: 0x1800F91A0
	internal void .ctor(string word, Tokens token, int op) { }

}

