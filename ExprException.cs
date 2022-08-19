internal sealed class ExprException // TypeDefIndex: 4258
{	// Methods

	// RVA: 0x13E1DB0 Offset: 0x13E03B0 VA: 0x1813E1DB0
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x13E1D50 Offset: 0x13E0350 VA: 0x1813E1D50
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x13E1E10 Offset: 0x13E0410 VA: 0x1813E1E10
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x13E1CF0 Offset: 0x13E02F0 VA: 0x1813E1CF0
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x13E1C90 Offset: 0x13E0290 VA: 0x1813E1C90
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x13E0EC0 Offset: 0x13DF4C0 VA: 0x1813E0EC0
	public static Exception InvokeArgument() { }

	// RVA: 0x13E12B0 Offset: 0x13DF8B0 VA: 0x1813E12B0
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x13E10D0 Offset: 0x13DF6D0 VA: 0x1813E10D0
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x13E11A0 Offset: 0x13DF7A0 VA: 0x1813E11A0
	public static Exception MissingOperator(string token) { }

	// RVA: 0x13E1690 Offset: 0x13DFC90 VA: 0x1813E1690
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x13E07C0 Offset: 0x13DEDC0 VA: 0x1813E07C0
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x13E0590 Offset: 0x13DEB90 VA: 0x1813E0590
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x13E1720 Offset: 0x13DFD20 VA: 0x1813E1720
	public static Exception UnboundName(string name) { }

	// RVA: 0x13E0D20 Offset: 0x13DF320 VA: 0x1813E0D20
	public static Exception InvalidString(string str) { }

	// RVA: 0x13E17B0 Offset: 0x13DFDB0 VA: 0x1813E17B0
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x13E1470 Offset: 0x13DFA70 VA: 0x1813E1470
	public static Exception SyntaxError() { }

	// RVA: 0x13E0730 Offset: 0x13DED30 VA: 0x1813E0730
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x13E1230 Offset: 0x13DF830 VA: 0x1813E1230
	public static Exception MissingRightParen() { }

	// RVA: 0x13E1840 Offset: 0x13DFE40 VA: 0x1813E1840
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x13E1910 Offset: 0x13DFF10 VA: 0x1813E1910
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x13E0350 Offset: 0x13DE950 VA: 0x1813E0350
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x13E0430 Offset: 0x13DEA30 VA: 0x1813E0430
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x13E0C00 Offset: 0x13DF200 VA: 0x1813E0C00
	public static Exception InvalidName(string name) { }

	// RVA: 0x13E0960 Offset: 0x13DEF60 VA: 0x1813E0960
	public static Exception InvalidDate(string date) { }

	// RVA: 0x13E1340 Offset: 0x13DF940 VA: 0x1813E1340
	public static Exception NonConstantArgument() { }

	// RVA: 0x13E0C90 Offset: 0x13DF290 VA: 0x1813E0C90
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x13E08E0 Offset: 0x13DEEE0 VA: 0x1813E08E0
	public static Exception InWithoutParentheses() { }

	// RVA: 0x13E0860 Offset: 0x13DEE60 VA: 0x1813E0860
	public static Exception InWithoutList() { }

	// RVA: 0x13E0A70 Offset: 0x13DF070 VA: 0x1813E0A70
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x13E13C0 Offset: 0x13DF9C0 VA: 0x1813E13C0
	public static Exception Overflow(Type type) { }

	// RVA: 0x13E0120 Offset: 0x13DE720 VA: 0x1813E0120
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x13E0050 Offset: 0x13DE650 VA: 0x1813E0050
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x13E1570 Offset: 0x13DFB70 VA: 0x1813E1570
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x13DFF30 Offset: 0x13DE530 VA: 0x1813DFF30
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x13E1BD0 Offset: 0x13E01D0 VA: 0x1813E1BD0
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x13E0B70 Offset: 0x13DF170 VA: 0x1813E0B70
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x13E1040 Offset: 0x13DF640 VA: 0x1813E1040
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x13E14F0 Offset: 0x13DFAF0 VA: 0x1813E14F0
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x13E1A80 Offset: 0x13E0080 VA: 0x1813E1A80
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x13E0230 Offset: 0x13DE830 VA: 0x1813E0230
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x13DFE20 Offset: 0x13DE420 VA: 0x1813DFE20
	public static Exception AggregateArgument() { }

	// RVA: 0x13DFEA0 Offset: 0x13DE4A0 VA: 0x1813DFEA0
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x13E0510 Offset: 0x13DEB10 VA: 0x1813E0510
	public static Exception EvalNoContext() { }

	// RVA: 0x13E0610 Offset: 0x13DEC10 VA: 0x1813E0610
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x13E02C0 Offset: 0x13DE8C0 VA: 0x1813E02C0
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x13E06A0 Offset: 0x13DECA0 VA: 0x1813E06A0
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x13E0F40 Offset: 0x13DF540 VA: 0x1813E0F40
	public static Exception LookupArgument() { }

	// RVA: 0x13E0E30 Offset: 0x13DF430 VA: 0x1813E0E30
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x13E09F0 Offset: 0x13DEFF0 VA: 0x1813E09F0
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x13E0AF0 Offset: 0x13DF0F0 VA: 0x1813E0AF0
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x13E0DB0 Offset: 0x13DF3B0 VA: 0x1813E0DB0
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x13E0FC0 Offset: 0x13DF5C0 VA: 0x1813E0FC0
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x13E1B20 Offset: 0x13E0120 VA: 0x1813E1B20
	public static Exception UnsupportedDataType(Type type) { }

}

