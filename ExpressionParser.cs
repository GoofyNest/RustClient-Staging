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

	// RVA: 0x13E4A80 Offset: 0x13E3080 VA: 0x1813E4A80
	internal void .ctor(DataTable table) { }

	// RVA: 0x13E1950 Offset: 0x13DFF50 VA: 0x1813E1950
	internal void LoadExpression(string data) { }

	// RVA: 0x13E4540 Offset: 0x13E2B40 VA: 0x1813E4540
	internal void StartScan() { }

	// RVA: 0x13E2070 Offset: 0x13E0670 VA: 0x1813E2070
	internal ExpressionNode Parse() { }

	// RVA: 0x13E1BC0 Offset: 0x13E01C0 VA: 0x1813E1BC0
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x13E1AA0 Offset: 0x13E00A0 VA: 0x1813E1AA0
	private ExpressionNode NodePop() { }

	// RVA: 0x13E1A50 Offset: 0x13E0050 VA: 0x1813E1A50
	private ExpressionNode NodePeek() { }

	// RVA: 0x13E1AF0 Offset: 0x13E00F0 VA: 0x1813E1AF0
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x13E1430 Offset: 0x13DFA30 VA: 0x1813E1430
	private void BuildExpression(int pri) { }

	// RVA: 0x13E1750 Offset: 0x13DFD50 VA: 0x1813E1750
	internal void CheckToken(Tokens token) { }

	// RVA: 0x13E3E90 Offset: 0x13E2490 VA: 0x1813E3E90
	internal Tokens Scan() { }

	// RVA: 0x13E3770 Offset: 0x13E1D70 VA: 0x1813E3770
	private void ScanNumeric() { }

	// RVA: 0x13E3510 Offset: 0x13E1B10 VA: 0x1813E3510
	private void ScanName() { }

	// RVA: 0x13E35F0 Offset: 0x13E1BF0 VA: 0x1813E35F0
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x13E3380 Offset: 0x13E1980 VA: 0x1813E3380
	private void ScanDate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void ScanBinaryConstant() { }

	// RVA: 0x13E39E0 Offset: 0x13E1FE0 VA: 0x1813E39E0
	private void ScanReserved() { }

	// RVA: 0x13E3CD0 Offset: 0x13E22D0 VA: 0x1813E3CD0
	private void ScanString(char escape) { }

	// RVA: 0x13E3E00 Offset: 0x13E2400 VA: 0x1813E3E00
	internal void ScanToken(Tokens token) { }

	// RVA: 0x13E3E30 Offset: 0x13E2430 VA: 0x1813E3E30
	private void ScanWhite() { }

	// RVA: 0x13E1940 Offset: 0x13DFF40 VA: 0x1813E1940
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x13E17D0 Offset: 0x13DFDD0 VA: 0x1813E17D0
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x13E18F0 Offset: 0x13DFEF0 VA: 0x1813E18F0
	private bool IsDigit(char ch) { }

	// RVA: 0x13E1870 Offset: 0x13DFE70 VA: 0x1813E1870
	private bool IsAlpha(char ch) { }

	// RVA: 0x13E4610 Offset: 0x13E2C10 VA: 0x1813E4610
	private static void .cctor() { }

}

private struct ExpressionParser.ReservedWords // TypeDefIndex: 4252
{	// Fields
	internal readonly string _word; // 0x0
	internal readonly Tokens _token; // 0x8
	internal readonly int _op; // 0xC

	// Methods

	// RVA: 0xF9120 Offset: 0xF8520 VA: 0x1800F9120
	internal void .ctor(string word, Tokens token, int op) { }

}

