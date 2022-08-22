internal sealed class ExprException // TypeDefIndex: 4258
{	// Methods

	// RVA: 0x13E2070 Offset: 0x13E0670 VA: 0x1813E2070
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x13E2010 Offset: 0x13E0610 VA: 0x1813E2010
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x13E20D0 Offset: 0x13E06D0 VA: 0x1813E20D0
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x13E1FB0 Offset: 0x13E05B0 VA: 0x1813E1FB0
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x13E1F50 Offset: 0x13E0550 VA: 0x1813E1F50
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x13E1180 Offset: 0x13DF780 VA: 0x1813E1180
	public static Exception InvokeArgument() { }

	// RVA: 0x13E1570 Offset: 0x13DFB70 VA: 0x1813E1570
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x13E1390 Offset: 0x13DF990 VA: 0x1813E1390
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x13E1460 Offset: 0x13DFA60 VA: 0x1813E1460
	public static Exception MissingOperator(string token) { }

	// RVA: 0x13E1950 Offset: 0x13DFF50 VA: 0x1813E1950
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x13E0A80 Offset: 0x13DF080 VA: 0x1813E0A80
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x13E0850 Offset: 0x13DEE50 VA: 0x1813E0850
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x13E19E0 Offset: 0x13DFFE0 VA: 0x1813E19E0
	public static Exception UnboundName(string name) { }

	// RVA: 0x13E0FE0 Offset: 0x13DF5E0 VA: 0x1813E0FE0
	public static Exception InvalidString(string str) { }

	// RVA: 0x13E1A70 Offset: 0x13E0070 VA: 0x1813E1A70
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x13E1730 Offset: 0x13DFD30 VA: 0x1813E1730
	public static Exception SyntaxError() { }

	// RVA: 0x13E09F0 Offset: 0x13DEFF0 VA: 0x1813E09F0
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x13E14F0 Offset: 0x13DFAF0 VA: 0x1813E14F0
	public static Exception MissingRightParen() { }

	// RVA: 0x13E1B00 Offset: 0x13E0100 VA: 0x1813E1B00
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x13E1BD0 Offset: 0x13E01D0 VA: 0x1813E1BD0
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x13E0610 Offset: 0x13DEC10 VA: 0x1813E0610
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x13E06F0 Offset: 0x13DECF0 VA: 0x1813E06F0
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x13E0EC0 Offset: 0x13DF4C0 VA: 0x1813E0EC0
	public static Exception InvalidName(string name) { }

	// RVA: 0x13E0C20 Offset: 0x13DF220 VA: 0x1813E0C20
	public static Exception InvalidDate(string date) { }

	// RVA: 0x13E1600 Offset: 0x13DFC00 VA: 0x1813E1600
	public static Exception NonConstantArgument() { }

	// RVA: 0x13E0F50 Offset: 0x13DF550 VA: 0x1813E0F50
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x13E0BA0 Offset: 0x13DF1A0 VA: 0x1813E0BA0
	public static Exception InWithoutParentheses() { }

	// RVA: 0x13E0B20 Offset: 0x13DF120 VA: 0x1813E0B20
	public static Exception InWithoutList() { }

	// RVA: 0x13E0D30 Offset: 0x13DF330 VA: 0x1813E0D30
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x13E1680 Offset: 0x13DFC80 VA: 0x1813E1680
	public static Exception Overflow(Type type) { }

	// RVA: 0x13E03E0 Offset: 0x13DE9E0 VA: 0x1813E03E0
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x13E0310 Offset: 0x13DE910 VA: 0x1813E0310
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x13E1830 Offset: 0x13DFE30 VA: 0x1813E1830
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x13E01F0 Offset: 0x13DE7F0 VA: 0x1813E01F0
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x13E1E90 Offset: 0x13E0490 VA: 0x1813E1E90
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x13E0E30 Offset: 0x13DF430 VA: 0x1813E0E30
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x13E1300 Offset: 0x13DF900 VA: 0x1813E1300
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x13E17B0 Offset: 0x13DFDB0 VA: 0x1813E17B0
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x13E1D40 Offset: 0x13E0340 VA: 0x1813E1D40
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x13E04F0 Offset: 0x13DEAF0 VA: 0x1813E04F0
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x13E00E0 Offset: 0x13DE6E0 VA: 0x1813E00E0
	public static Exception AggregateArgument() { }

	// RVA: 0x13E0160 Offset: 0x13DE760 VA: 0x1813E0160
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x13E07D0 Offset: 0x13DEDD0 VA: 0x1813E07D0
	public static Exception EvalNoContext() { }

	// RVA: 0x13E08D0 Offset: 0x13DEED0 VA: 0x1813E08D0
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x13E0580 Offset: 0x13DEB80 VA: 0x1813E0580
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x13E0960 Offset: 0x13DEF60 VA: 0x1813E0960
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x13E1200 Offset: 0x13DF800 VA: 0x1813E1200
	public static Exception LookupArgument() { }

	// RVA: 0x13E10F0 Offset: 0x13DF6F0 VA: 0x1813E10F0
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x13E0CB0 Offset: 0x13DF2B0 VA: 0x1813E0CB0
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x13E0DB0 Offset: 0x13DF3B0 VA: 0x1813E0DB0
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x13E1070 Offset: 0x13DF670 VA: 0x1813E1070
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x13E1280 Offset: 0x13DF880 VA: 0x1813E1280
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x13E1DE0 Offset: 0x13E03E0 VA: 0x1813E1DE0
	public static Exception UnsupportedDataType(Type type) { }

}

