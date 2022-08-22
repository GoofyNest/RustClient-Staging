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

	// RVA: 0x1266C60 Offset: 0x1265260 VA: 0x181266C60
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x12669F0 Offset: 0x1264FF0 VA: 0x1812669F0
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1266B90 Offset: 0x1265190 VA: 0x181266B90
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x1264CB0 Offset: 0x12632B0 VA: 0x181264CB0
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x1264C20 Offset: 0x1263220 VA: 0x181264C20
	internal static ArgumentException Argument(string error, string parameter) { }

	// RVA: 0x1264A90 Offset: 0x1263090 VA: 0x181264A90
	internal static ArgumentNullException ArgumentNull(string parameter) { }

	// RVA: 0x1264BA0 Offset: 0x12631A0 VA: 0x181264BA0
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x1264B10 Offset: 0x1263110 VA: 0x181264B10
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x1265DF0 Offset: 0x12643F0 VA: 0x181265DF0
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x1266960 Offset: 0x1264F60 VA: 0x181266960
	internal static NotSupportedException NotSupported() { }

	// RVA: 0x12668E0 Offset: 0x1264EE0 VA: 0x1812668E0
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x1266150 Offset: 0x1264750 VA: 0x181266150
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x1266400 Offset: 0x1264A00 VA: 0x181266400
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x1265BE0 Offset: 0x12641E0 VA: 0x181265BE0
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x1264D30 Offset: 0x1263330 VA: 0x181264D30
	internal static string BuildQuotedString(string quotePrefix, string quoteSuffix, string unQuotedString) { }

	// RVA: 0x1265650 Offset: 0x1263C50 VA: 0x181265650
	internal static bool CompareInsensitiveInvariant(string strvalue, string strconst) { }

	// RVA: 0x1266650 Offset: 0x1264C50 VA: 0x181266650
	internal static bool IsNull(object value) { }

	// RVA: 0x1265F00 Offset: 0x1264500 VA: 0x181265F00
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x1266AC0 Offset: 0x12650C0 VA: 0x181266AC0
	internal static void TraceExceptionForCapture(Exception e) { }

	// RVA: 0x1265AC0 Offset: 0x12640C0 VA: 0x181265AC0
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x1265B50 Offset: 0x1264150 VA: 0x181265B50
	internal static ArgumentOutOfRangeException InvalidConflictOptions(ConflictOption value) { }

	// RVA: 0x1265CD0 Offset: 0x12642D0 VA: 0x181265CD0
	internal static ArgumentOutOfRangeException InvalidMissingMappingAction(MissingMappingAction value) { }

	// RVA: 0x1265D60 Offset: 0x1264360 VA: 0x181265D60
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x1265E70 Offset: 0x1264470 VA: 0x181265E70
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x1266030 Offset: 0x1264630 VA: 0x181266030
	internal static ArgumentOutOfRangeException InvalidStatementType(StatementType value) { }

	// RVA: 0x12660C0 Offset: 0x12646C0 VA: 0x1812660C0
	internal static ArgumentOutOfRangeException InvalidUpdateStatus(UpdateStatus value) { }

	// RVA: 0x1266CF0 Offset: 0x12652F0 VA: 0x181266CF0
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x1265700 Offset: 0x1263D00 VA: 0x181265700
	private static InvalidOperationException DataMapping(string error) { }

	// RVA: 0x12651C0 Offset: 0x12637C0 VA: 0x1812651C0
	internal static InvalidOperationException ColumnSchemaExpression(string srcColumn, string cacheColumn) { }

	// RVA: 0x1265280 Offset: 0x1263880 VA: 0x181265280
	internal static InvalidOperationException ColumnSchemaMismatch(string srcColumn, Type srcType, DataColumn column) { }

	// RVA: 0x1265560 Offset: 0x1263B60 VA: 0x181265560
	internal static InvalidOperationException ColumnSchemaMissing(string cacheColumn, string tableName, string srcColumn) { }

	// RVA: 0x12666F0 Offset: 0x1264CF0 VA: 0x1812666F0
	internal static InvalidOperationException MissingColumnMapping(string srcColumn) { }

	// RVA: 0x1265F60 Offset: 0x1264560 VA: 0x181265F60
	internal static Exception InvalidSourceColumn(string parameter) { }

	// RVA: 0x1265760 Offset: 0x1263D60 VA: 0x181265760
	internal static InvalidOperationException DynamicSQLJoinUnsupported() { }

	// RVA: 0x1265970 Offset: 0x1263F70 VA: 0x181265970
	internal static InvalidOperationException DynamicSQLNoTableInfo() { }

	// RVA: 0x1265830 Offset: 0x1263E30 VA: 0x181265830
	internal static InvalidOperationException DynamicSQLNoKeyInfoDelete() { }

	// RVA: 0x1265920 Offset: 0x1263F20 VA: 0x181265920
	internal static InvalidOperationException DynamicSQLNoKeyInfoUpdate() { }

	// RVA: 0x1265880 Offset: 0x1263E80 VA: 0x181265880
	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionDelete() { }

	// RVA: 0x12658D0 Offset: 0x1263ED0 VA: 0x1812658D0
	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionUpdate() { }

	// RVA: 0x12657B0 Offset: 0x1263DB0 VA: 0x1812657B0
	internal static InvalidOperationException DynamicSQLNestedQuote(string name, string quote) { }

	// RVA: 0x1266890 Offset: 0x1264E90 VA: 0x181266890
	internal static InvalidOperationException NoQuoteChange() { }

	// RVA: 0x1266840 Offset: 0x1264E40 VA: 0x181266840
	internal static InvalidOperationException MissingSourceCommand() { }

	// RVA: 0x12667F0 Offset: 0x1264DF0 VA: 0x1812667F0
	internal static InvalidOperationException MissingSourceCommandConnection() { }

	// RVA: 0x1264E40 Offset: 0x1263440 VA: 0x181264E40
	internal static void BuildSchemaTableInfoTableNames(string[] columnNameArray) { }

	// RVA: 0x12659C0 Offset: 0x1263FC0 VA: 0x1812659C0
	private static int GenerateUniqueName(Dictionary<string, int> hash, ref string columnName, int index, int uniqueIndex) { }

	// RVA: 0x12669D0 Offset: 0x1264FD0 VA: 0x1812669D0
	internal static int SrcCompare(string strA, string strB) { }

	// RVA: 0x1266E10 Offset: 0x1265410 VA: 0x181266E10
	private static void .cctor() { }

}

