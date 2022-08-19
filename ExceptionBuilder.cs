internal static class ExceptionBuilder // TypeDefIndex: 4201
{	// Methods

	// RVA: 0x13DF340 Offset: 0x13DD940 VA: 0x1813DF340
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x13DF130 Offset: 0x13DD730 VA: 0x1813DF130
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x13DF1E0 Offset: 0x13DD7E0 VA: 0x1813DF1E0
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x13DF290 Offset: 0x13DD890 VA: 0x1813DF290
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x13DF940 Offset: 0x13DDF40 VA: 0x1813DF940
	internal static Exception _Argument(string error) { }

	// RVA: 0x13DF8D0 Offset: 0x13DDED0 VA: 0x1813DF8D0
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x13DF7F0 Offset: 0x13DDDF0 VA: 0x1813DF7F0
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x13DF860 Offset: 0x13DDE60 VA: 0x1813DF860
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x13DFB20 Offset: 0x13DE120 VA: 0x1813DFB20
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x13DFC40 Offset: 0x13DE240 VA: 0x1813DFC40
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x13DFBE0 Offset: 0x13DE1E0 VA: 0x1813DFBE0
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1A0F0 Offset: 0x1B186F0 VA: 0x181B1A0F0
	|-ExceptionBuilder._InvalidEnumArgumentException<DataRowState>
	|-ExceptionBuilder._InvalidEnumArgumentException<DataSetDateTime>
	|-ExceptionBuilder._InvalidEnumArgumentException<SerializationFormat>
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0x1B1A1F0 Offset: 0x1B187F0 VA: 0x181B1A1F0
	|-ExceptionBuilder._InvalidEnumArgumentException<object>
	*/

	// RVA: 0x13DEFF0 Offset: 0x13DD5F0 VA: 0x1813DEFF0
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x13DC060 Offset: 0x13DA660 VA: 0x1813DC060
	private static Exception _Data(string error) { }

	// RVA: 0x13DF9A0 Offset: 0x13DDFA0 VA: 0x1813DF9A0
	private static Exception _Constraint(string error) { }

	// RVA: 0x13DFB80 Offset: 0x13DE180 VA: 0x1813DFB80
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x13DFA00 Offset: 0x13DE000 VA: 0x1813DFA00
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x13DFA60 Offset: 0x13DE060 VA: 0x1813DFA60
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x13DFAC0 Offset: 0x13DE0C0 VA: 0x1813DFAC0
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x13DFCA0 Offset: 0x13DE2A0 VA: 0x1813DFCA0
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x13DFD00 Offset: 0x13DE300 VA: 0x1813DFD00
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x13DFD60 Offset: 0x13DE360 VA: 0x1813DFD60
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x13DFDC0 Offset: 0x13DE3C0 VA: 0x1813DFDC0
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x13D7230 Offset: 0x13D5830 VA: 0x1813D7230
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x13D72D0 Offset: 0x13D58D0 VA: 0x1813D72D0
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x13D7630 Offset: 0x13D5C30 VA: 0x1813D7630
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x13D8B10 Offset: 0x13D7110 VA: 0x1813D8B10
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x13DC550 Offset: 0x13DAB50 VA: 0x1813DC550
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x13DB480 Offset: 0x13D9A80 VA: 0x1813DB480
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x13D8E30 Offset: 0x13D7430 VA: 0x1813D8E30
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x13D8DB0 Offset: 0x13D73B0 VA: 0x1813D8DB0
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x13D8EC0 Offset: 0x13D74C0 VA: 0x1813D8EC0
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x13D8F80 Offset: 0x13D7580 VA: 0x1813D8F80
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x13D7BC0 Offset: 0x13D61C0 VA: 0x1813D7BC0
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x13D7C50 Offset: 0x13D6250 VA: 0x1813D7C50
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x13D7CE0 Offset: 0x13D62E0 VA: 0x1813D7CE0
	public static Exception CannotAddColumn3() { }

	// RVA: 0x13D7D60 Offset: 0x13D6360 VA: 0x1813D7D60
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x13D7F10 Offset: 0x13D6510 VA: 0x1813D7F10
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x13D7DF0 Offset: 0x13D63F0 VA: 0x1813D7DF0
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x13D7E80 Offset: 0x13D6480 VA: 0x1813D7E80
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x13D82F0 Offset: 0x13D68F0 VA: 0x1813D82F0
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x13D8490 Offset: 0x13D6A90 VA: 0x1813D8490
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x13D8260 Offset: 0x13D6860 VA: 0x1813D8260
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x13D8370 Offset: 0x13D6970 VA: 0x1813D8370
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x13D8400 Offset: 0x13D6A00 VA: 0x1813D8400
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x13D70B0 Offset: 0x13D56B0 VA: 0x1813D70B0
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x13DC7C0 Offset: 0x13DADC0 VA: 0x1813DC7C0
	public static Exception NoConstraintName() { }

	// RVA: 0x13D9450 Offset: 0x13D7A50 VA: 0x1813D9450
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x13DBDF0 Offset: 0x13DA3F0 VA: 0x1813DBDF0
	public static string KeysToString(object[] keys) { }

	// RVA: 0x13DF570 Offset: 0x13DDB70 VA: 0x1813DF570
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x13D94E0 Offset: 0x13D7AE0 VA: 0x1813D94E0
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x13D9290 Offset: 0x13D7890 VA: 0x1813D9290
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x13D9FD0 Offset: 0x13D85D0 VA: 0x1813D9FD0
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x13D9EB0 Offset: 0x13D84B0 VA: 0x1813D9EB0
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x13DC5E0 Offset: 0x13DABE0 VA: 0x1813DC5E0
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x13DF6F0 Offset: 0x13DDCF0 VA: 0x1813DF6F0
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x13D9210 Offset: 0x13D7810 VA: 0x1813D9210
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x13D9350 Offset: 0x13D7950 VA: 0x1813D9350
	public static Exception ConstraintParentValues() { }

	// RVA: 0x13D9170 Offset: 0x13D7770 VA: 0x1813D9170
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x13D93D0 Offset: 0x13D79D0 VA: 0x1813D93D0
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x13DA820 Offset: 0x13D8E20 VA: 0x1813DA820
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x13DA8B0 Offset: 0x13D8EB0 VA: 0x1813DA8B0
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x13DA940 Offset: 0x13D8F40 VA: 0x1813DA940
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x13DA9F0 Offset: 0x13D8FF0 VA: 0x1813DA9F0
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x13DDC40 Offset: 0x13DC240 VA: 0x1813DDC40
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x13DC020 Offset: 0x13DA620 VA: 0x1813DC020
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x13DCAD0 Offset: 0x13DB0D0 VA: 0x1813DCAD0
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x13D88D0 Offset: 0x13D6ED0 VA: 0x1813D88D0
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x13D74A0 Offset: 0x13D5AA0 VA: 0x1813D74A0
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x13D7420 Offset: 0x13D5A20 VA: 0x1813D7420
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x13D75B0 Offset: 0x13D5BB0 VA: 0x1813D75B0
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x13D8960 Offset: 0x13D6F60 VA: 0x1813D8960
	public static Exception CantChangeDataType() { }

	// RVA: 0x13DCB90 Offset: 0x13DB190 VA: 0x1813DCB90
	public static Exception NullDataType() { }

	// RVA: 0x13D8D30 Offset: 0x13D7330 VA: 0x1813D8D30
	public static Exception ColumnNameRequired() { }

	// RVA: 0x13D9A10 Offset: 0x13D8010 VA: 0x1813D9A10
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x13D9B90 Offset: 0x13D8190 VA: 0x1813D9B90
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x13D9A90 Offset: 0x13D8090 VA: 0x1813D9A90
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x13DA680 Offset: 0x13D8C80 VA: 0x1813DA680
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x13DA600 Offset: 0x13D8C00 VA: 0x1813DA600
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x13DA540 Offset: 0x13D8B40 VA: 0x1813DA540
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x13DA780 Offset: 0x13D8D80 VA: 0x1813DA780
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x13DA700 Offset: 0x13D8D00 VA: 0x1813DA700
	public static Exception ExpressionCircular() { }

	// RVA: 0x13DCA40 Offset: 0x13DB040 VA: 0x1813DCA40
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x13DCC10 Offset: 0x13DB210 VA: 0x1813DCC10
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x13DCD20 Offset: 0x13DB320 VA: 0x1813DCD20
	public static Exception NullValues(string column) { }

	// RVA: 0x13DD110 Offset: 0x13DB710 VA: 0x1813DD110
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x13DD190 Offset: 0x13DB790 VA: 0x1813DD190
	public static Exception ReadOnly(string column) { }

	// RVA: 0x13DF4F0 Offset: 0x13DDAF0 VA: 0x1813DF4F0
	public static Exception UniqueAndExpression() { }

	// RVA: 0x13DE670 Offset: 0x13DCC70 VA: 0x1813DE670
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x13D8830 Offset: 0x13D6E30 VA: 0x1813D8830
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x13DBEF0 Offset: 0x13DA4F0 VA: 0x1813DBEF0
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x13D8630 Offset: 0x13D6C30 VA: 0x1813D8630
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x13D8590 Offset: 0x13D6B90 VA: 0x1813D8590
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x13D8710 Offset: 0x13D6D10 VA: 0x1813D8710
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x13D87A0 Offset: 0x13D6DA0 VA: 0x1813D87A0
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x13D80B0 Offset: 0x13D66B0 VA: 0x1813D80B0
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x13DACE0 Offset: 0x13D92E0 VA: 0x1813DACE0
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x13D7520 Offset: 0x13D5B20 VA: 0x1813D7520
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x13DAE10 Offset: 0x13D9410 VA: 0x1813DAE10
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x13DAD80 Offset: 0x13D9380 VA: 0x1813DAD80
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x13DF3D0 Offset: 0x13DD9D0 VA: 0x1813DF3D0
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x13DB1E0 Offset: 0x13D97E0 VA: 0x1813DB1E0
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x13D8510 Offset: 0x13D6B10 VA: 0x1813D8510
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x13DB290 Offset: 0x13D9890 VA: 0x1813DB290
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x13D89E0 Offset: 0x13D6FE0 VA: 0x1813D89E0
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x13D90A0 Offset: 0x13D76A0 VA: 0x1813D90A0
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x13DE5E0 Offset: 0x13DCBE0 VA: 0x1813DE5E0
	public static Exception SetFailed(string name) { }

	// RVA: 0x13D7AC0 Offset: 0x13D60C0 VA: 0x1813D7AC0
	public static Exception CanNotUse() { }

	// RVA: 0x13DE7B0 Offset: 0x13DCDB0 VA: 0x1813DE7B0
	public static Exception SetIListObject() { }

	// RVA: 0x13D7030 Offset: 0x13D5630 VA: 0x1813D7030
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x13DCB10 Offset: 0x13DB110 VA: 0x1813DCB10
	public static Exception NotOpen() { }

	// RVA: 0x13D9770 Offset: 0x13D7D70 VA: 0x1813D9770
	public static Exception CreateChildView() { }

	// RVA: 0x13D77C0 Offset: 0x13D5DC0 VA: 0x1813D77C0
	public static Exception CanNotDelete() { }

	// RVA: 0x13DAB90 Offset: 0x13D9190 VA: 0x1813DAB90
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x13D6FB0 Offset: 0x13D55B0 VA: 0x1813D6FB0
	public static Exception AddExternalObject() { }

	// RVA: 0x13D7740 Offset: 0x13D5D40 VA: 0x1813D7740
	public static Exception CanNotClear() { }

	// RVA: 0x13DB030 Offset: 0x13D9630 VA: 0x1813DB030
	public static Exception InsertExternalObject() { }

	// RVA: 0x13DDBC0 Offset: 0x13DC1C0 VA: 0x1813DDBC0
	public static Exception RemoveExternalObject() { }

	// RVA: 0x13DBCB0 Offset: 0x13DA2B0 VA: 0x1813DBCB0
	public static Exception KeyTableMismatch() { }

	// RVA: 0x13DBC30 Offset: 0x13DA230 VA: 0x1813DBC30
	public static Exception KeyNoColumns() { }

	// RVA: 0x13DBD30 Offset: 0x13DA330 VA: 0x1813DBD30
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x13DBAA0 Offset: 0x13DA0A0 VA: 0x1813DBAA0
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x13DD540 Offset: 0x13DBB40 VA: 0x1813DD540
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x13D90F0 Offset: 0x13D76F0 VA: 0x1813D90F0
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x13DBB30 Offset: 0x13DA130 VA: 0x1813DBB30
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x13DBBB0 Offset: 0x13DA1B0 VA: 0x1813DBBB0
	public static Exception KeyLengthZero() { }

	// RVA: 0x13DAA90 Offset: 0x13D9090 VA: 0x1813DAA90
	public static Exception ForeignRelation() { }

	// RVA: 0x13DBA20 Offset: 0x13DA020 VA: 0x1813DBA20
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x13DD740 Offset: 0x13DBD40 VA: 0x1813DD740
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x13DAC50 Offset: 0x13D9250 VA: 0x1813DAC50
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x13DE830 Offset: 0x13DCE30 VA: 0x1813DE830
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x13DD6C0 Offset: 0x13DBCC0 VA: 0x1813DD6C0
	public static Exception RelationForeignRow() { }

	// RVA: 0x13DD7D0 Offset: 0x13DBDD0 VA: 0x1813DD7D0
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x13DEB40 Offset: 0x13DD140 VA: 0x1813DEB40
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x13DBF90 Offset: 0x13DA590 VA: 0x1813DBF90
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x13DD640 Offset: 0x13DBC40 VA: 0x1813DD640
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x13DCDB0 Offset: 0x13DB3B0 VA: 0x1813DCDB0
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x13DAEA0 Offset: 0x13D94A0 VA: 0x1813DAEA0
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x13DB500 Offset: 0x13D9B00 VA: 0x1813DB500
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x13DE180 Offset: 0x13DC780 VA: 0x1813DE180
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x13DE200 Offset: 0x13DC800 VA: 0x1813DE200
	public static Exception RowNotInTheTable() { }

	// RVA: 0x13DA2B0 Offset: 0x13D88B0 VA: 0x1813DA2B0
	public static Exception EditInRowChanging() { }

	// RVA: 0x13DA3C0 Offset: 0x13D89C0 VA: 0x1813DA3C0
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x13D76C0 Offset: 0x13D5CC0 VA: 0x1813D76C0
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x13D7B40 Offset: 0x13D6140 VA: 0x1813D7B40
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x13D9CA0 Offset: 0x13D82A0 VA: 0x1813D9CA0
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x13DF770 Offset: 0x13DDD70 VA: 0x1813DF770
	public static Exception ValueArrayLength() { }

	// RVA: 0x13DC840 Offset: 0x13DAE40 VA: 0x1813DC840
	public static Exception NoCurrentData() { }

	// RVA: 0x13DC8C0 Offset: 0x13DAEC0 VA: 0x1813DC8C0
	public static Exception NoOriginalData() { }

	// RVA: 0x13DC940 Offset: 0x13DAF40 VA: 0x1813DC940
	public static Exception NoProposedData() { }

	// RVA: 0x13DE3C0 Offset: 0x13DC9C0 VA: 0x1813DE3C0
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x13D9D20 Offset: 0x13D8320 VA: 0x1813D9D20
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x13DDDA0 Offset: 0x13DC3A0 VA: 0x1813DDDA0
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x13DDFA0 Offset: 0x13DC5A0 VA: 0x1813DDFA0
	public static Exception RowEmpty() { }

	// RVA: 0x13DB720 Offset: 0x13D9D20 VA: 0x1813DB720
	public static Exception InvalidRowVersion() { }

	// RVA: 0x13DE340 Offset: 0x13DC940 VA: 0x1813DE340
	public static Exception RowOutOfRange() { }

	// RVA: 0x13DE280 Offset: 0x13DC880 VA: 0x1813DE280
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x13DE0B0 Offset: 0x13DC6B0 VA: 0x1813DE0B0
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x13DE020 Offset: 0x13DC620 VA: 0x1813DE020
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x13DDF20 Offset: 0x13DC520 VA: 0x1813DDF20
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x13DC450 Offset: 0x13DAA50 VA: 0x1813DC450
	public static Exception MultipleParents() { }

	// RVA: 0x13DB6E0 Offset: 0x13D9CE0 VA: 0x1813DB6E0
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x13DB660 Offset: 0x13D9C60 VA: 0x1813DB660
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x13DE560 Offset: 0x13DCB60 VA: 0x1813DE560
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x13DE4D0 Offset: 0x13DCAD0 VA: 0x1813DE4D0
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x13D97F0 Offset: 0x13D7DF0 VA: 0x1813D97F0
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x13DC0C0 Offset: 0x13DA6C0 VA: 0x1813DC0C0
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x13DEF70 Offset: 0x13DD570 VA: 0x1813DEF70
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x13DD2A0 Offset: 0x13DB8A0 VA: 0x1813DD2A0
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x13DDE20 Offset: 0x13DC420 VA: 0x1813DDE20
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x13DDEA0 Offset: 0x13DC4A0 VA: 0x1813DDEA0
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x13DD220 Offset: 0x13DB820 VA: 0x1813DD220
	public static Exception RecordStateRange() { }

	// RVA: 0x13DAF30 Offset: 0x13D9530 VA: 0x1813DAF30
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x13DDCF0 Offset: 0x13DC2F0 VA: 0x1813DDCF0
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x13DD320 Offset: 0x13DB920 VA: 0x1813DD320
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x13DD3A0 Offset: 0x13DB9A0 VA: 0x1813DD3A0
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x13DD850 Offset: 0x13DBE50 VA: 0x1813DD850
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x13DD8E0 Offset: 0x13DBEE0 VA: 0x1813DD8E0
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x13DA0F0 Offset: 0x13D86F0 VA: 0x1813DA0F0
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x13DDAC0 Offset: 0x13DC0C0 VA: 0x1813DDAC0
	public static Exception RelationTableNull() { }

	// RVA: 0x13DD5C0 Offset: 0x13DBBC0 VA: 0x1813DD5C0
	public static Exception RelationDataSetNull() { }

	// RVA: 0x13DDB40 Offset: 0x13DC140 VA: 0x1813DDB40
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x13DCE30 Offset: 0x13DB430 VA: 0x1813DCE30
	public static Exception ParentTableMismatch() { }

	// RVA: 0x13D8C20 Offset: 0x13D7220 VA: 0x1813D8C20
	public static Exception ChildTableMismatch() { }

	// RVA: 0x13DA440 Offset: 0x13D8A40 VA: 0x1813DA440
	public static Exception EnforceConstraint() { }

	// RVA: 0x13D8BA0 Offset: 0x13D71A0 VA: 0x1813D8BA0
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x13D8030 Offset: 0x13D6630 VA: 0x1813D8030
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x13D7FA0 Offset: 0x13D65A0 VA: 0x1813D7FA0
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x13DB620 Offset: 0x13D9C20 VA: 0x1813DB620
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x13DEBD0 Offset: 0x13DD1D0 VA: 0x1813DEBD0
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x13DEAC0 Offset: 0x13DD0C0 VA: 0x1813DEAC0
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x13DC9C0 Offset: 0x13DAFC0 VA: 0x1813DC9C0
	public static Exception NoTableName() { }

	// RVA: 0x13DC4D0 Offset: 0x13DAAD0 VA: 0x1813DC4D0
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x13DB830 Offset: 0x13D9E30 VA: 0x1813DB830
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x13DA220 Offset: 0x13D8820 VA: 0x1813DA220
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x13DA180 Offset: 0x13D8780 VA: 0x1813DA180
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x13DE440 Offset: 0x13DCA40 VA: 0x1813DE440
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x13D9900 Offset: 0x13D7F00 VA: 0x1813D9900
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x13DE9C0 Offset: 0x13DCFC0 VA: 0x1813DE9C0
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x13DEA40 Offset: 0x13DD040 VA: 0x1813DEA40
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x13DEEB0 Offset: 0x13DD4B0 VA: 0x1813DEEB0
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x13DEE20 Offset: 0x13DD420 VA: 0x1813DEE20
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x13DED10 Offset: 0x13DD310 VA: 0x1813DED10
	public static Exception TableInRelation() { }

	// RVA: 0x13DEC50 Offset: 0x13DD250 VA: 0x1813DEC50
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x13D7940 Offset: 0x13D5F40 VA: 0x1813D7940
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x13D78C0 Offset: 0x13D5EC0 VA: 0x1813D78C0
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x13D7A40 Offset: 0x13D6040 VA: 0x1813D7A40
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x13D79C0 Offset: 0x13D5FC0 VA: 0x1813D79C0
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x13DED90 Offset: 0x13DD390 VA: 0x1813DED90
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x13D7130 Offset: 0x13D5730 VA: 0x1813D7130
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x13DB8C0 Offset: 0x13D9EC0 VA: 0x1813DB8C0
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x13DD020 Offset: 0x13DB620 VA: 0x1813DD020
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x13DCCA0 Offset: 0x13DB2A0 VA: 0x1813DCCA0
	public static Exception NullRange() { }

	// RVA: 0x13DC6B0 Offset: 0x13DACB0 VA: 0x1813DC6B0
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x13DCF40 Offset: 0x13DB540 VA: 0x1813DCF40
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x13DE940 Offset: 0x13DCF40 VA: 0x1813DE940
	public static Exception StorageSetFailed() { }

	// RVA: 0x13DE8C0 Offset: 0x13DCEC0 VA: 0x1813DE8C0
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x13DC260 Offset: 0x13DA860 VA: 0x1813DC260
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x13DC1D0 Offset: 0x13DA7D0 VA: 0x1813DC1D0
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x13DB150 Offset: 0x13D9750 VA: 0x1813DB150
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x13D7370 Offset: 0x13D5970 VA: 0x1813D7370
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x13DA330 Offset: 0x13D8930 VA: 0x1813DA330
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x13DD9A0 Offset: 0x13DBFA0 VA: 0x1813DD9A0
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x13DD4B0 Offset: 0x13DBAB0 VA: 0x1813DD4B0
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x13DDA30 Offset: 0x13DC030 VA: 0x1813DDA30
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x13DD420 Offset: 0x13DBA20 VA: 0x1813DD420
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x13DF460 Offset: 0x13DDA60 VA: 0x1813DF460
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x13D9990 Offset: 0x13D7F90 VA: 0x1813D9990
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x13DC150 Offset: 0x13DA750 VA: 0x1813DC150
	public static Exception MismatchKeyLength() { }

	// RVA: 0x13DB360 Offset: 0x13D9960 VA: 0x1813DB360
	public static Exception InvalidField(string name) { }

	// RVA: 0x13DB7A0 Offset: 0x13D9DA0 VA: 0x1813DB7A0
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x13D8CA0 Offset: 0x13D72A0 VA: 0x1813D8CA0
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x13D81D0 Offset: 0x13D67D0 VA: 0x1813D81D0
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x13DB3F0 Offset: 0x13D99F0 VA: 0x1813DB3F0
	public static Exception InvalidKey(string name) { }

	// RVA: 0x13D9E20 Offset: 0x13D8420 VA: 0x1813D9E20
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x13D9DA0 Offset: 0x13D83A0 VA: 0x1813D9DA0
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x13D9F40 Offset: 0x13D8540 VA: 0x1813D9F40
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x13D9010 Offset: 0x13D7610 VA: 0x1813D9010
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x13D8140 Offset: 0x13D6740 VA: 0x1813D8140
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x13DC320 Offset: 0x13DA920 VA: 0x1813DC320
	public static Exception MissingRefer(string name) { }

	// RVA: 0x13DB590 Offset: 0x13D9B90 VA: 0x1813DB590
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x13D7840 Offset: 0x13D5E40 VA: 0x1813D7840
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x13DB9A0 Offset: 0x13D9FA0 VA: 0x1813DB9A0
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x13DF0B0 Offset: 0x13DD6B0 VA: 0x1813DF0B0
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x13DC730 Offset: 0x13DAD30 VA: 0x1813DC730
	public static Exception NestedCircular(string name) { }

	// RVA: 0x13DC3C0 Offset: 0x13DA9C0 VA: 0x1813DC3C0
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x13DCEB0 Offset: 0x13DB4B0 VA: 0x1813DCEB0
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x13D9880 Offset: 0x13D7E80 VA: 0x1813D9880
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x13DF060 Offset: 0x13DD660 VA: 0x1813DF060
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x13DA060 Offset: 0x13D8660 VA: 0x1813DA060
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x13DAB10 Offset: 0x13D9110 VA: 0x1813DAB10
	public static Exception FoundEntity() { }

	// RVA: 0x13DC060 Offset: 0x13DA660 VA: 0x1813DC060
	public static Exception MergeFailed(string name) { }

	// RVA: 0x13D96A0 Offset: 0x13D7CA0 VA: 0x1813D96A0
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x13DB2D0 Offset: 0x13D98D0 VA: 0x1813DB2D0
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x13DB0B0 Offset: 0x13D96B0 VA: 0x1813DB0B0
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x13DA4C0 Offset: 0x13D8AC0 VA: 0x1813DA4C0
	public static Exception EnumeratorModified() { }

}

