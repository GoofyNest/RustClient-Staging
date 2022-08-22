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

	// RVA: 0x12665C0 Offset: 0x1264BC0 VA: 0x1812665C0
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1266350 Offset: 0x1264950 VA: 0x181266350
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x12664F0 Offset: 0x1264AF0 VA: 0x1812664F0
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x1264610 Offset: 0x1262C10 VA: 0x181264610
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x1264580 Offset: 0x1262B80 VA: 0x181264580
	internal static ArgumentException Argument(string error, string parameter) { }

	// RVA: 0x12643F0 Offset: 0x12629F0 VA: 0x1812643F0
	internal static ArgumentNullException ArgumentNull(string parameter) { }

	// RVA: 0x1264500 Offset: 0x1262B00 VA: 0x181264500
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x1264470 Offset: 0x1262A70 VA: 0x181264470
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x1265750 Offset: 0x1263D50 VA: 0x181265750
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x12662C0 Offset: 0x12648C0 VA: 0x1812662C0
	internal static NotSupportedException NotSupported() { }

	// RVA: 0x1266240 Offset: 0x1264840 VA: 0x181266240
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x1265AB0 Offset: 0x12640B0 VA: 0x181265AB0
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x1265D60 Offset: 0x1264360 VA: 0x181265D60
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x1265540 Offset: 0x1263B40 VA: 0x181265540
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x1264690 Offset: 0x1262C90 VA: 0x181264690
	internal static string BuildQuotedString(string quotePrefix, string quoteSuffix, string unQuotedString) { }

	// RVA: 0x1264FB0 Offset: 0x12635B0 VA: 0x181264FB0
	internal static bool CompareInsensitiveInvariant(string strvalue, string strconst) { }

	// RVA: 0x1265FB0 Offset: 0x12645B0 VA: 0x181265FB0
	internal static bool IsNull(object value) { }

	// RVA: 0x1265860 Offset: 0x1263E60 VA: 0x181265860
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x1266420 Offset: 0x1264A20 VA: 0x181266420
	internal static void TraceExceptionForCapture(Exception e) { }

	// RVA: 0x1265420 Offset: 0x1263A20 VA: 0x181265420
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x12654B0 Offset: 0x1263AB0 VA: 0x1812654B0
	internal static ArgumentOutOfRangeException InvalidConflictOptions(ConflictOption value) { }

	// RVA: 0x1265630 Offset: 0x1263C30 VA: 0x181265630
	internal static ArgumentOutOfRangeException InvalidMissingMappingAction(MissingMappingAction value) { }

	// RVA: 0x12656C0 Offset: 0x1263CC0 VA: 0x1812656C0
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x12657D0 Offset: 0x1263DD0 VA: 0x1812657D0
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x1265990 Offset: 0x1263F90 VA: 0x181265990
	internal static ArgumentOutOfRangeException InvalidStatementType(StatementType value) { }

	// RVA: 0x1265A20 Offset: 0x1264020 VA: 0x181265A20
	internal static ArgumentOutOfRangeException InvalidUpdateStatus(UpdateStatus value) { }

	// RVA: 0x1266650 Offset: 0x1264C50 VA: 0x181266650
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x1265060 Offset: 0x1263660 VA: 0x181265060
	private static InvalidOperationException DataMapping(string error) { }

	// RVA: 0x1264B20 Offset: 0x1263120 VA: 0x181264B20
	internal static InvalidOperationException ColumnSchemaExpression(string srcColumn, string cacheColumn) { }

	// RVA: 0x1264BE0 Offset: 0x12631E0 VA: 0x181264BE0
	internal static InvalidOperationException ColumnSchemaMismatch(string srcColumn, Type srcType, DataColumn column) { }

	// RVA: 0x1264EC0 Offset: 0x12634C0 VA: 0x181264EC0
	internal static InvalidOperationException ColumnSchemaMissing(string cacheColumn, string tableName, string srcColumn) { }

	// RVA: 0x1266050 Offset: 0x1264650 VA: 0x181266050
	internal static InvalidOperationException MissingColumnMapping(string srcColumn) { }

	// RVA: 0x12658C0 Offset: 0x1263EC0 VA: 0x1812658C0
	internal static Exception InvalidSourceColumn(string parameter) { }

	// RVA: 0x12650C0 Offset: 0x12636C0 VA: 0x1812650C0
	internal static InvalidOperationException DynamicSQLJoinUnsupported() { }

	// RVA: 0x12652D0 Offset: 0x12638D0 VA: 0x1812652D0
	internal static InvalidOperationException DynamicSQLNoTableInfo() { }

	// RVA: 0x1265190 Offset: 0x1263790 VA: 0x181265190
	internal static InvalidOperationException DynamicSQLNoKeyInfoDelete() { }

	// RVA: 0x1265280 Offset: 0x1263880 VA: 0x181265280
	internal static InvalidOperationException DynamicSQLNoKeyInfoUpdate() { }

	// RVA: 0x12651E0 Offset: 0x12637E0 VA: 0x1812651E0
	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionDelete() { }

	// RVA: 0x1265230 Offset: 0x1263830 VA: 0x181265230
	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionUpdate() { }

	// RVA: 0x1265110 Offset: 0x1263710 VA: 0x181265110
	internal static InvalidOperationException DynamicSQLNestedQuote(string name, string quote) { }

	// RVA: 0x12661F0 Offset: 0x12647F0 VA: 0x1812661F0
	internal static InvalidOperationException NoQuoteChange() { }

	// RVA: 0x12661A0 Offset: 0x12647A0 VA: 0x1812661A0
	internal static InvalidOperationException MissingSourceCommand() { }

	// RVA: 0x1266150 Offset: 0x1264750 VA: 0x181266150
	internal static InvalidOperationException MissingSourceCommandConnection() { }

	// RVA: 0x12647A0 Offset: 0x1262DA0 VA: 0x1812647A0
	internal static void BuildSchemaTableInfoTableNames(string[] columnNameArray) { }

	// RVA: 0x1265320 Offset: 0x1263920 VA: 0x181265320
	private static int GenerateUniqueName(Dictionary<string, int> hash, ref string columnName, int index, int uniqueIndex) { }

	// RVA: 0x1266330 Offset: 0x1264930 VA: 0x181266330
	internal static int SrcCompare(string strA, string strB) { }

	// RVA: 0x1266770 Offset: 0x1264D70 VA: 0x181266770
	private static void .cctor() { }

}

