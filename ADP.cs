internal static class ADP // TypeDefIndex: 4363
{	// Fields
	private static readonly Type s_stackOverflowType; // 0x0
	private static readonly Type s_outOfMemoryType; // 0x8
	private static readonly Type s_threadAbortType; // 0x10
	private static readonly Type s_nullReferenceType; // 0x18
	private static readonly Type s_accessViolationType; // 0x20
	private static readonly Type s_securityType; // 0x28
	internal static readonly bool IsWindowsNT; // 0x30
	internal static readonly bool IsPlatformNT5; // 0x31
	internal static readonly string StrEmpty; // 0x38
	internal static readonly string[] AzureSqlServerEndpoints; // 0x40
	internal static readonly IntPtr PtrZero; // 0x48
	internal static readonly int PtrSize; // 0x50

	// Methods

	// RVA: 0x1266300 Offset: 0x1264900 VA: 0x181266300
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1266090 Offset: 0x1264690 VA: 0x181266090
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1266230 Offset: 0x1264830 VA: 0x181266230
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x1264350 Offset: 0x1262950 VA: 0x181264350
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x12642C0 Offset: 0x12628C0 VA: 0x1812642C0
	internal static ArgumentException Argument(string error, string parameter) { }

	// RVA: 0x1264130 Offset: 0x1262730 VA: 0x181264130
	internal static ArgumentNullException ArgumentNull(string parameter) { }

	// RVA: 0x1264240 Offset: 0x1262840 VA: 0x181264240
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x12641B0 Offset: 0x12627B0 VA: 0x1812641B0
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x1265490 Offset: 0x1263A90 VA: 0x181265490
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x1266000 Offset: 0x1264600 VA: 0x181266000
	internal static NotSupportedException NotSupported() { }

	// RVA: 0x1265F80 Offset: 0x1264580 VA: 0x181265F80
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x12657F0 Offset: 0x1263DF0 VA: 0x1812657F0
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x1265AA0 Offset: 0x12640A0 VA: 0x181265AA0
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x1265280 Offset: 0x1263880 VA: 0x181265280
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x12643D0 Offset: 0x12629D0 VA: 0x1812643D0
	internal static string BuildQuotedString(string quotePrefix, string quoteSuffix, string unQuotedString) { }

	// RVA: 0x1264CF0 Offset: 0x12632F0 VA: 0x181264CF0
	internal static bool CompareInsensitiveInvariant(string strvalue, string strconst) { }

	// RVA: 0x1265CF0 Offset: 0x12642F0 VA: 0x181265CF0
	internal static bool IsNull(object value) { }

	// RVA: 0x12655A0 Offset: 0x1263BA0 VA: 0x1812655A0
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x1266160 Offset: 0x1264760 VA: 0x181266160
	internal static void TraceExceptionForCapture(Exception e) { }

	// RVA: 0x1265160 Offset: 0x1263760 VA: 0x181265160
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x12651F0 Offset: 0x12637F0 VA: 0x1812651F0
	internal static ArgumentOutOfRangeException InvalidConflictOptions(ConflictOption value) { }

	// RVA: 0x1265370 Offset: 0x1263970 VA: 0x181265370
	internal static ArgumentOutOfRangeException InvalidMissingMappingAction(MissingMappingAction value) { }

	// RVA: 0x1265400 Offset: 0x1263A00 VA: 0x181265400
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x1265510 Offset: 0x1263B10 VA: 0x181265510
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x12656D0 Offset: 0x1263CD0 VA: 0x1812656D0
	internal static ArgumentOutOfRangeException InvalidStatementType(StatementType value) { }

	// RVA: 0x1265760 Offset: 0x1263D60 VA: 0x181265760
	internal static ArgumentOutOfRangeException InvalidUpdateStatus(UpdateStatus value) { }

	// RVA: 0x1266390 Offset: 0x1264990 VA: 0x181266390
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x1264DA0 Offset: 0x12633A0 VA: 0x181264DA0
	private static InvalidOperationException DataMapping(string error) { }

	// RVA: 0x1264860 Offset: 0x1262E60 VA: 0x181264860
	internal static InvalidOperationException ColumnSchemaExpression(string srcColumn, string cacheColumn) { }

	// RVA: 0x1264920 Offset: 0x1262F20 VA: 0x181264920
	internal static InvalidOperationException ColumnSchemaMismatch(string srcColumn, Type srcType, DataColumn column) { }

	// RVA: 0x1264C00 Offset: 0x1263200 VA: 0x181264C00
	internal static InvalidOperationException ColumnSchemaMissing(string cacheColumn, string tableName, string srcColumn) { }

	// RVA: 0x1265D90 Offset: 0x1264390 VA: 0x181265D90
	internal static InvalidOperationException MissingColumnMapping(string srcColumn) { }

	// RVA: 0x1265600 Offset: 0x1263C00 VA: 0x181265600
	internal static Exception InvalidSourceColumn(string parameter) { }

	// RVA: 0x1264E00 Offset: 0x1263400 VA: 0x181264E00
	internal static InvalidOperationException DynamicSQLJoinUnsupported() { }

	// RVA: 0x1265010 Offset: 0x1263610 VA: 0x181265010
	internal static InvalidOperationException DynamicSQLNoTableInfo() { }

	// RVA: 0x1264ED0 Offset: 0x12634D0 VA: 0x181264ED0
	internal static InvalidOperationException DynamicSQLNoKeyInfoDelete() { }

	// RVA: 0x1264FC0 Offset: 0x12635C0 VA: 0x181264FC0
	internal static InvalidOperationException DynamicSQLNoKeyInfoUpdate() { }

	// RVA: 0x1264F20 Offset: 0x1263520 VA: 0x181264F20
	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionDelete() { }

	// RVA: 0x1264F70 Offset: 0x1263570 VA: 0x181264F70
	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionUpdate() { }

	// RVA: 0x1264E50 Offset: 0x1263450 VA: 0x181264E50
	internal static InvalidOperationException DynamicSQLNestedQuote(string name, string quote) { }

	// RVA: 0x1265F30 Offset: 0x1264530 VA: 0x181265F30
	internal static InvalidOperationException NoQuoteChange() { }

	// RVA: 0x1265EE0 Offset: 0x12644E0 VA: 0x181265EE0
	internal static InvalidOperationException MissingSourceCommand() { }

	// RVA: 0x1265E90 Offset: 0x1264490 VA: 0x181265E90
	internal static InvalidOperationException MissingSourceCommandConnection() { }

	// RVA: 0x12644E0 Offset: 0x1262AE0 VA: 0x1812644E0
	internal static void BuildSchemaTableInfoTableNames(string[] columnNameArray) { }

	// RVA: 0x1265060 Offset: 0x1263660 VA: 0x181265060
	private static int GenerateUniqueName(Dictionary<string, int> hash, ref string columnName, int index, int uniqueIndex) { }

	// RVA: 0x1266070 Offset: 0x1264670 VA: 0x181266070
	internal static int SrcCompare(string strA, string strB) { }

	// RVA: 0x12664B0 Offset: 0x1264AB0 VA: 0x1812664B0
	private static void .cctor() { }

}

