internal sealed class ExprException // TypeDefIndex: 4258
{	// Methods

	// RVA: 0x13E1170 Offset: 0x13DF770 VA: 0x1813E1170
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x13E1110 Offset: 0x13DF710 VA: 0x1813E1110
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x13E11D0 Offset: 0x13DF7D0 VA: 0x1813E11D0
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x13E10B0 Offset: 0x13DF6B0 VA: 0x1813E10B0
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x13E1050 Offset: 0x13DF650 VA: 0x1813E1050
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x13E0280 Offset: 0x13DE880 VA: 0x1813E0280
	public static Exception InvokeArgument() { }

	// RVA: 0x13E0670 Offset: 0x13DEC70 VA: 0x1813E0670
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x13E0490 Offset: 0x13DEA90 VA: 0x1813E0490
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x13E0560 Offset: 0x13DEB60 VA: 0x1813E0560
	public static Exception MissingOperator(string token) { }

	// RVA: 0x13E0A50 Offset: 0x13DF050 VA: 0x1813E0A50
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x13DFB80 Offset: 0x13DE180 VA: 0x1813DFB80
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x13DF950 Offset: 0x13DDF50 VA: 0x1813DF950
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x13E0AE0 Offset: 0x13DF0E0 VA: 0x1813E0AE0
	public static Exception UnboundName(string name) { }

	// RVA: 0x13E00E0 Offset: 0x13DE6E0 VA: 0x1813E00E0
	public static Exception InvalidString(string str) { }

	// RVA: 0x13E0B70 Offset: 0x13DF170 VA: 0x1813E0B70
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x13E0830 Offset: 0x13DEE30 VA: 0x1813E0830
	public static Exception SyntaxError() { }

	// RVA: 0x13DFAF0 Offset: 0x13DE0F0 VA: 0x1813DFAF0
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x13E05F0 Offset: 0x13DEBF0 VA: 0x1813E05F0
	public static Exception MissingRightParen() { }

	// RVA: 0x13E0C00 Offset: 0x13DF200 VA: 0x1813E0C00
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x13E0CD0 Offset: 0x13DF2D0 VA: 0x1813E0CD0
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x13DF710 Offset: 0x13DDD10 VA: 0x1813DF710
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x13DF7F0 Offset: 0x13DDDF0 VA: 0x1813DF7F0
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x13DFFC0 Offset: 0x13DE5C0 VA: 0x1813DFFC0
	public static Exception InvalidName(string name) { }

	// RVA: 0x13DFD20 Offset: 0x13DE320 VA: 0x1813DFD20
	public static Exception InvalidDate(string date) { }

	// RVA: 0x13E0700 Offset: 0x13DED00 VA: 0x1813E0700
	public static Exception NonConstantArgument() { }

	// RVA: 0x13E0050 Offset: 0x13DE650 VA: 0x1813E0050
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x13DFCA0 Offset: 0x13DE2A0 VA: 0x1813DFCA0
	public static Exception InWithoutParentheses() { }

	// RVA: 0x13DFC20 Offset: 0x13DE220 VA: 0x1813DFC20
	public static Exception InWithoutList() { }

	// RVA: 0x13DFE30 Offset: 0x13DE430 VA: 0x1813DFE30
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x13E0780 Offset: 0x13DED80 VA: 0x1813E0780
	public static Exception Overflow(Type type) { }

	// RVA: 0x13DF4E0 Offset: 0x13DDAE0 VA: 0x1813DF4E0
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x13DF410 Offset: 0x13DDA10 VA: 0x1813DF410
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x13E0930 Offset: 0x13DEF30 VA: 0x1813E0930
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x13DF2F0 Offset: 0x13DD8F0 VA: 0x1813DF2F0
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x13E0F90 Offset: 0x13DF590 VA: 0x1813E0F90
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x13DFF30 Offset: 0x13DE530 VA: 0x1813DFF30
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x13E0400 Offset: 0x13DEA00 VA: 0x1813E0400
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x13E08B0 Offset: 0x13DEEB0 VA: 0x1813E08B0
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x13E0E40 Offset: 0x13DF440 VA: 0x1813E0E40
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x13DF5F0 Offset: 0x13DDBF0 VA: 0x1813DF5F0
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x13DF1E0 Offset: 0x13DD7E0 VA: 0x1813DF1E0
	public static Exception AggregateArgument() { }

	// RVA: 0x13DF260 Offset: 0x13DD860 VA: 0x1813DF260
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x13DF8D0 Offset: 0x13DDED0 VA: 0x1813DF8D0
	public static Exception EvalNoContext() { }

	// RVA: 0x13DF9D0 Offset: 0x13DDFD0 VA: 0x1813DF9D0
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x13DF680 Offset: 0x13DDC80 VA: 0x1813DF680
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x13DFA60 Offset: 0x13DE060 VA: 0x1813DFA60
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x13E0300 Offset: 0x13DE900 VA: 0x1813E0300
	public static Exception LookupArgument() { }

	// RVA: 0x13E01F0 Offset: 0x13DE7F0 VA: 0x1813E01F0
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x13DFDB0 Offset: 0x13DE3B0 VA: 0x1813DFDB0
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x13DFEB0 Offset: 0x13DE4B0 VA: 0x1813DFEB0
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x13E0170 Offset: 0x13DE770 VA: 0x1813E0170
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x13E0380 Offset: 0x13DE980 VA: 0x1813E0380
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x13E0EE0 Offset: 0x13DF4E0 VA: 0x1813E0EE0
	public static Exception UnsupportedDataType(Type type) { }

}

