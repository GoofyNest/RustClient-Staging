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

	// RVA: 0x13E5980 Offset: 0x13E3F80 VA: 0x1813E5980
	internal void .ctor(DataTable table) { }

	// RVA: 0x13E2850 Offset: 0x13E0E50 VA: 0x1813E2850
	internal void LoadExpression(string data) { }

	// RVA: 0x13E5440 Offset: 0x13E3A40 VA: 0x1813E5440
	internal void StartScan() { }

	// RVA: 0x13E2F70 Offset: 0x13E1570 VA: 0x1813E2F70
	internal ExpressionNode Parse() { }

	// RVA: 0x13E2AC0 Offset: 0x13E10C0 VA: 0x1813E2AC0
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x13E29A0 Offset: 0x13E0FA0 VA: 0x1813E29A0
	private ExpressionNode NodePop() { }

	// RVA: 0x13E2950 Offset: 0x13E0F50 VA: 0x1813E2950
	private ExpressionNode NodePeek() { }

	// RVA: 0x13E29F0 Offset: 0x13E0FF0 VA: 0x1813E29F0
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x13E2330 Offset: 0x13E0930 VA: 0x1813E2330
	private void BuildExpression(int pri) { }

	// RVA: 0x13E2650 Offset: 0x13E0C50 VA: 0x1813E2650
	internal void CheckToken(Tokens token) { }

	// RVA: 0x13E4D90 Offset: 0x13E3390 VA: 0x1813E4D90
	internal Tokens Scan() { }

	// RVA: 0x13E4670 Offset: 0x13E2C70 VA: 0x1813E4670
	private void ScanNumeric() { }

	// RVA: 0x13E4410 Offset: 0x13E2A10 VA: 0x1813E4410
	private void ScanName() { }

	// RVA: 0x13E44F0 Offset: 0x13E2AF0 VA: 0x1813E44F0
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x13E4280 Offset: 0x13E2880 VA: 0x1813E4280
	private void ScanDate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void ScanBinaryConstant() { }

	// RVA: 0x13E48E0 Offset: 0x13E2EE0 VA: 0x1813E48E0
	private void ScanReserved() { }

	// RVA: 0x13E4BD0 Offset: 0x13E31D0 VA: 0x1813E4BD0
	private void ScanString(char escape) { }

	// RVA: 0x13E4D00 Offset: 0x13E3300 VA: 0x1813E4D00
	internal void ScanToken(Tokens token) { }

	// RVA: 0x13E4D30 Offset: 0x13E3330 VA: 0x1813E4D30
	private void ScanWhite() { }

	// RVA: 0x13E2840 Offset: 0x13E0E40 VA: 0x1813E2840
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x13E26D0 Offset: 0x13E0CD0 VA: 0x1813E26D0
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x13E27F0 Offset: 0x13E0DF0 VA: 0x1813E27F0
	private bool IsDigit(char ch) { }

	// RVA: 0x13E2770 Offset: 0x13E0D70 VA: 0x1813E2770
	private bool IsAlpha(char ch) { }

	// RVA: 0x13E5510 Offset: 0x13E3B10 VA: 0x1813E5510
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

