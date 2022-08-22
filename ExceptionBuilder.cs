internal static class ExceptionBuilder // TypeDefIndex: 4201
{	// Methods

	// RVA: 0x13DE700 Offset: 0x13DCD00 VA: 0x1813DE700
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x13DE4F0 Offset: 0x13DCAF0 VA: 0x1813DE4F0
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x13DE5A0 Offset: 0x13DCBA0 VA: 0x1813DE5A0
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x13DE650 Offset: 0x13DCC50 VA: 0x1813DE650
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x13DED00 Offset: 0x13DD300 VA: 0x1813DED00
	internal static Exception _Argument(string error) { }

	// RVA: 0x13DEC90 Offset: 0x13DD290 VA: 0x1813DEC90
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x13DEBB0 Offset: 0x13DD1B0 VA: 0x1813DEBB0
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x13DEC20 Offset: 0x13DD220 VA: 0x1813DEC20
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x13DEEE0 Offset: 0x13DD4E0 VA: 0x1813DEEE0
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x13DF000 Offset: 0x13DD600 VA: 0x1813DF000
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x13DEFA0 Offset: 0x13DD5A0 VA: 0x1813DEFA0
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1A9E0 Offset: 0x1B18FE0 VA: 0x181B1A9E0
	|-ExceptionBuilder._InvalidEnumArgumentException<DataRowState>
	|-ExceptionBuilder._InvalidEnumArgumentException<DataSetDateTime>
	|-ExceptionBuilder._InvalidEnumArgumentException<SerializationFormat>
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0x1B1AAE0 Offset: 0x1B190E0 VA: 0x181B1AAE0
	|-ExceptionBuilder._InvalidEnumArgumentException<object>
	*/

	// RVA: 0x13DE3B0 Offset: 0x13DC9B0 VA: 0x1813DE3B0
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x13DB420 Offset: 0x13D9A20 VA: 0x1813DB420
	private static Exception _Data(string error) { }

	// RVA: 0x13DED60 Offset: 0x13DD360 VA: 0x1813DED60
	private static Exception _Constraint(string error) { }

	// RVA: 0x13DEF40 Offset: 0x13DD540 VA: 0x1813DEF40
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x13DEDC0 Offset: 0x13DD3C0 VA: 0x1813DEDC0
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x13DEE20 Offset: 0x13DD420 VA: 0x1813DEE20
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x13DEE80 Offset: 0x13DD480 VA: 0x1813DEE80
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x13DF060 Offset: 0x13DD660 VA: 0x1813DF060
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x13DF0C0 Offset: 0x13DD6C0 VA: 0x1813DF0C0
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x13DF120 Offset: 0x13DD720 VA: 0x1813DF120
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x13DF180 Offset: 0x13DD780 VA: 0x1813DF180
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x13D65F0 Offset: 0x13D4BF0 VA: 0x1813D65F0
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x13D6690 Offset: 0x13D4C90 VA: 0x1813D6690
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x13D69F0 Offset: 0x13D4FF0 VA: 0x1813D69F0
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x13D7ED0 Offset: 0x13D64D0 VA: 0x1813D7ED0
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x13DB910 Offset: 0x13D9F10 VA: 0x1813DB910
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x13DA840 Offset: 0x13D8E40 VA: 0x1813DA840
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x13D81F0 Offset: 0x13D67F0 VA: 0x1813D81F0
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x13D8170 Offset: 0x13D6770 VA: 0x1813D8170
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x13D8280 Offset: 0x13D6880 VA: 0x1813D8280
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x13D8340 Offset: 0x13D6940 VA: 0x1813D8340
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x13D6F80 Offset: 0x13D5580 VA: 0x1813D6F80
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x13D7010 Offset: 0x13D5610 VA: 0x1813D7010
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x13D70A0 Offset: 0x13D56A0 VA: 0x1813D70A0
	public static Exception CannotAddColumn3() { }

	// RVA: 0x13D7120 Offset: 0x13D5720 VA: 0x1813D7120
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x13D72D0 Offset: 0x13D58D0 VA: 0x1813D72D0
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x13D71B0 Offset: 0x13D57B0 VA: 0x1813D71B0
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x13D7240 Offset: 0x13D5840 VA: 0x1813D7240
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x13D76B0 Offset: 0x13D5CB0 VA: 0x1813D76B0
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x13D7850 Offset: 0x13D5E50 VA: 0x1813D7850
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x13D7620 Offset: 0x13D5C20 VA: 0x1813D7620
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x13D7730 Offset: 0x13D5D30 VA: 0x1813D7730
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x13D77C0 Offset: 0x13D5DC0 VA: 0x1813D77C0
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x13D6470 Offset: 0x13D4A70 VA: 0x1813D6470
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x13DBB80 Offset: 0x13DA180 VA: 0x1813DBB80
	public static Exception NoConstraintName() { }

	// RVA: 0x13D8810 Offset: 0x13D6E10 VA: 0x1813D8810
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x13DB1B0 Offset: 0x13D97B0 VA: 0x1813DB1B0
	public static string KeysToString(object[] keys) { }

	// RVA: 0x13DE930 Offset: 0x13DCF30 VA: 0x1813DE930
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x13D88A0 Offset: 0x13D6EA0 VA: 0x1813D88A0
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x13D8650 Offset: 0x13D6C50 VA: 0x1813D8650
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x13D9390 Offset: 0x13D7990 VA: 0x1813D9390
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x13D9270 Offset: 0x13D7870 VA: 0x1813D9270
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x13DB9A0 Offset: 0x13D9FA0 VA: 0x1813DB9A0
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x13DEAB0 Offset: 0x13DD0B0 VA: 0x1813DEAB0
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x13D85D0 Offset: 0x13D6BD0 VA: 0x1813D85D0
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x13D8710 Offset: 0x13D6D10 VA: 0x1813D8710
	public static Exception ConstraintParentValues() { }

	// RVA: 0x13D8530 Offset: 0x13D6B30 VA: 0x1813D8530
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x13D8790 Offset: 0x13D6D90 VA: 0x1813D8790
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x13D9BE0 Offset: 0x13D81E0 VA: 0x1813D9BE0
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x13D9C70 Offset: 0x13D8270 VA: 0x1813D9C70
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x13D9D00 Offset: 0x13D8300 VA: 0x1813D9D00
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x13D9DB0 Offset: 0x13D83B0 VA: 0x1813D9DB0
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x13DD000 Offset: 0x13DB600 VA: 0x1813DD000
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x13DB3E0 Offset: 0x13D99E0 VA: 0x1813DB3E0
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x13DBE90 Offset: 0x13DA490 VA: 0x1813DBE90
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x13D7C90 Offset: 0x13D6290 VA: 0x1813D7C90
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x13D6860 Offset: 0x13D4E60 VA: 0x1813D6860
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x13D67E0 Offset: 0x13D4DE0 VA: 0x1813D67E0
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x13D6970 Offset: 0x13D4F70 VA: 0x1813D6970
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x13D7D20 Offset: 0x13D6320 VA: 0x1813D7D20
	public static Exception CantChangeDataType() { }

	// RVA: 0x13DBF50 Offset: 0x13DA550 VA: 0x1813DBF50
	public static Exception NullDataType() { }

	// RVA: 0x13D80F0 Offset: 0x13D66F0 VA: 0x1813D80F0
	public static Exception ColumnNameRequired() { }

	// RVA: 0x13D8DD0 Offset: 0x13D73D0 VA: 0x1813D8DD0
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x13D8F50 Offset: 0x13D7550 VA: 0x1813D8F50
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x13D8E50 Offset: 0x13D7450 VA: 0x1813D8E50
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x13D9A40 Offset: 0x13D8040 VA: 0x1813D9A40
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x13D99C0 Offset: 0x13D7FC0 VA: 0x1813D99C0
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x13D9900 Offset: 0x13D7F00 VA: 0x1813D9900
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x13D9B40 Offset: 0x13D8140 VA: 0x1813D9B40
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x13D9AC0 Offset: 0x13D80C0 VA: 0x1813D9AC0
	public static Exception ExpressionCircular() { }

	// RVA: 0x13DBE00 Offset: 0x13DA400 VA: 0x1813DBE00
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x13DBFD0 Offset: 0x13DA5D0 VA: 0x1813DBFD0
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x13DC0E0 Offset: 0x13DA6E0 VA: 0x1813DC0E0
	public static Exception NullValues(string column) { }

	// RVA: 0x13DC4D0 Offset: 0x13DAAD0 VA: 0x1813DC4D0
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x13DC550 Offset: 0x13DAB50 VA: 0x1813DC550
	public static Exception ReadOnly(string column) { }

	// RVA: 0x13DE8B0 Offset: 0x13DCEB0 VA: 0x1813DE8B0
	public static Exception UniqueAndExpression() { }

	// RVA: 0x13DDA30 Offset: 0x13DC030 VA: 0x1813DDA30
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x13D7BF0 Offset: 0x13D61F0 VA: 0x1813D7BF0
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x13DB2B0 Offset: 0x13D98B0 VA: 0x1813DB2B0
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x13D79F0 Offset: 0x13D5FF0 VA: 0x1813D79F0
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x13D7950 Offset: 0x13D5F50 VA: 0x1813D7950
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x13D7AD0 Offset: 0x13D60D0 VA: 0x1813D7AD0
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x13D7B60 Offset: 0x13D6160 VA: 0x1813D7B60
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x13D7470 Offset: 0x13D5A70 VA: 0x1813D7470
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x13DA0A0 Offset: 0x13D86A0 VA: 0x1813DA0A0
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x13D68E0 Offset: 0x13D4EE0 VA: 0x1813D68E0
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x13DA1D0 Offset: 0x13D87D0 VA: 0x1813DA1D0
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x13DA140 Offset: 0x13D8740 VA: 0x1813DA140
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x13DE790 Offset: 0x13DCD90 VA: 0x1813DE790
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x13DA5A0 Offset: 0x13D8BA0 VA: 0x1813DA5A0
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x13D78D0 Offset: 0x13D5ED0 VA: 0x1813D78D0
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x13DA650 Offset: 0x13D8C50 VA: 0x1813DA650
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x13D7DA0 Offset: 0x13D63A0 VA: 0x1813D7DA0
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x13D8460 Offset: 0x13D6A60 VA: 0x1813D8460
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x13DD9A0 Offset: 0x13DBFA0 VA: 0x1813DD9A0
	public static Exception SetFailed(string name) { }

	// RVA: 0x13D6E80 Offset: 0x13D5480 VA: 0x1813D6E80
	public static Exception CanNotUse() { }

	// RVA: 0x13DDB70 Offset: 0x13DC170 VA: 0x1813DDB70
	public static Exception SetIListObject() { }

	// RVA: 0x13D63F0 Offset: 0x13D49F0 VA: 0x1813D63F0
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x13DBED0 Offset: 0x13DA4D0 VA: 0x1813DBED0
	public static Exception NotOpen() { }

	// RVA: 0x13D8B30 Offset: 0x13D7130 VA: 0x1813D8B30
	public static Exception CreateChildView() { }

	// RVA: 0x13D6B80 Offset: 0x13D5180 VA: 0x1813D6B80
	public static Exception CanNotDelete() { }

	// RVA: 0x13D9F50 Offset: 0x13D8550 VA: 0x1813D9F50
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x13D6370 Offset: 0x13D4970 VA: 0x1813D6370
	public static Exception AddExternalObject() { }

	// RVA: 0x13D6B00 Offset: 0x13D5100 VA: 0x1813D6B00
	public static Exception CanNotClear() { }

	// RVA: 0x13DA3F0 Offset: 0x13D89F0 VA: 0x1813DA3F0
	public static Exception InsertExternalObject() { }

	// RVA: 0x13DCF80 Offset: 0x13DB580 VA: 0x1813DCF80
	public static Exception RemoveExternalObject() { }

	// RVA: 0x13DB070 Offset: 0x13D9670 VA: 0x1813DB070
	public static Exception KeyTableMismatch() { }

	// RVA: 0x13DAFF0 Offset: 0x13D95F0 VA: 0x1813DAFF0
	public static Exception KeyNoColumns() { }

	// RVA: 0x13DB0F0 Offset: 0x13D96F0 VA: 0x1813DB0F0
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x13DAE60 Offset: 0x13D9460 VA: 0x1813DAE60
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x13DC900 Offset: 0x13DAF00 VA: 0x1813DC900
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x13D84B0 Offset: 0x13D6AB0 VA: 0x1813D84B0
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x13DAEF0 Offset: 0x13D94F0 VA: 0x1813DAEF0
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x13DAF70 Offset: 0x13D9570 VA: 0x1813DAF70
	public static Exception KeyLengthZero() { }

	// RVA: 0x13D9E50 Offset: 0x13D8450 VA: 0x1813D9E50
	public static Exception ForeignRelation() { }

	// RVA: 0x13DADE0 Offset: 0x13D93E0 VA: 0x1813DADE0
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x13DCB00 Offset: 0x13DB100 VA: 0x1813DCB00
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x13DA010 Offset: 0x13D8610 VA: 0x1813DA010
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x13DDBF0 Offset: 0x13DC1F0 VA: 0x1813DDBF0
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x13DCA80 Offset: 0x13DB080 VA: 0x1813DCA80
	public static Exception RelationForeignRow() { }

	// RVA: 0x13DCB90 Offset: 0x13DB190 VA: 0x1813DCB90
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x13DDF00 Offset: 0x13DC500 VA: 0x1813DDF00
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x13DB350 Offset: 0x13D9950 VA: 0x1813DB350
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x13DCA00 Offset: 0x13DB000 VA: 0x1813DCA00
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x13DC170 Offset: 0x13DA770 VA: 0x1813DC170
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x13DA260 Offset: 0x13D8860 VA: 0x1813DA260
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x13DA8C0 Offset: 0x13D8EC0 VA: 0x1813DA8C0
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x13DD540 Offset: 0x13DBB40 VA: 0x1813DD540
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x13DD5C0 Offset: 0x13DBBC0 VA: 0x1813DD5C0
	public static Exception RowNotInTheTable() { }

	// RVA: 0x13D9670 Offset: 0x13D7C70 VA: 0x1813D9670
	public static Exception EditInRowChanging() { }

	// RVA: 0x13D9780 Offset: 0x13D7D80 VA: 0x1813D9780
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x13D6A80 Offset: 0x13D5080 VA: 0x1813D6A80
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x13D6F00 Offset: 0x13D5500 VA: 0x1813D6F00
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x13D9060 Offset: 0x13D7660 VA: 0x1813D9060
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x13DEB30 Offset: 0x13DD130 VA: 0x1813DEB30
	public static Exception ValueArrayLength() { }

	// RVA: 0x13DBC00 Offset: 0x13DA200 VA: 0x1813DBC00
	public static Exception NoCurrentData() { }

	// RVA: 0x13DBC80 Offset: 0x13DA280 VA: 0x1813DBC80
	public static Exception NoOriginalData() { }

	// RVA: 0x13DBD00 Offset: 0x13DA300 VA: 0x1813DBD00
	public static Exception NoProposedData() { }

	// RVA: 0x13DD780 Offset: 0x13DBD80 VA: 0x1813DD780
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x13D90E0 Offset: 0x13D76E0 VA: 0x1813D90E0
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x13DD160 Offset: 0x13DB760 VA: 0x1813DD160
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x13DD360 Offset: 0x13DB960 VA: 0x1813DD360
	public static Exception RowEmpty() { }

	// RVA: 0x13DAAE0 Offset: 0x13D90E0 VA: 0x1813DAAE0
	public static Exception InvalidRowVersion() { }

	// RVA: 0x13DD700 Offset: 0x13DBD00 VA: 0x1813DD700
	public static Exception RowOutOfRange() { }

	// RVA: 0x13DD640 Offset: 0x13DBC40 VA: 0x1813DD640
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x13DD470 Offset: 0x13DBA70 VA: 0x1813DD470
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x13DD3E0 Offset: 0x13DB9E0 VA: 0x1813DD3E0
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x13DD2E0 Offset: 0x13DB8E0 VA: 0x1813DD2E0
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x13DB810 Offset: 0x13D9E10 VA: 0x1813DB810
	public static Exception MultipleParents() { }

	// RVA: 0x13DAAA0 Offset: 0x13D90A0 VA: 0x1813DAAA0
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x13DAA20 Offset: 0x13D9020 VA: 0x1813DAA20
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x13DD920 Offset: 0x13DBF20 VA: 0x1813DD920
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x13DD890 Offset: 0x13DBE90 VA: 0x1813DD890
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x13D8BB0 Offset: 0x13D71B0 VA: 0x1813D8BB0
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x13DB480 Offset: 0x13D9A80 VA: 0x1813DB480
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x13DE330 Offset: 0x13DC930 VA: 0x1813DE330
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x13DC660 Offset: 0x13DAC60 VA: 0x1813DC660
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x13DD1E0 Offset: 0x13DB7E0 VA: 0x1813DD1E0
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x13DD260 Offset: 0x13DB860 VA: 0x1813DD260
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x13DC5E0 Offset: 0x13DABE0 VA: 0x1813DC5E0
	public static Exception RecordStateRange() { }

	// RVA: 0x13DA2F0 Offset: 0x13D88F0 VA: 0x1813DA2F0
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x13DD0B0 Offset: 0x13DB6B0 VA: 0x1813DD0B0
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x13DC6E0 Offset: 0x13DACE0 VA: 0x1813DC6E0
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x13DC760 Offset: 0x13DAD60 VA: 0x1813DC760
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x13DCC10 Offset: 0x13DB210 VA: 0x1813DCC10
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x13DCCA0 Offset: 0x13DB2A0 VA: 0x1813DCCA0
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x13D94B0 Offset: 0x13D7AB0 VA: 0x1813D94B0
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x13DCE80 Offset: 0x13DB480 VA: 0x1813DCE80
	public static Exception RelationTableNull() { }

	// RVA: 0x13DC980 Offset: 0x13DAF80 VA: 0x1813DC980
	public static Exception RelationDataSetNull() { }

	// RVA: 0x13DCF00 Offset: 0x13DB500 VA: 0x1813DCF00
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x13DC1F0 Offset: 0x13DA7F0 VA: 0x1813DC1F0
	public static Exception ParentTableMismatch() { }

	// RVA: 0x13D7FE0 Offset: 0x13D65E0 VA: 0x1813D7FE0
	public static Exception ChildTableMismatch() { }

	// RVA: 0x13D9800 Offset: 0x13D7E00 VA: 0x1813D9800
	public static Exception EnforceConstraint() { }

	// RVA: 0x13D7F60 Offset: 0x13D6560 VA: 0x1813D7F60
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x13D73F0 Offset: 0x13D59F0 VA: 0x1813D73F0
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x13D7360 Offset: 0x13D5960 VA: 0x1813D7360
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x13DA9E0 Offset: 0x13D8FE0 VA: 0x1813DA9E0
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x13DDF90 Offset: 0x13DC590 VA: 0x1813DDF90
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x13DDE80 Offset: 0x13DC480 VA: 0x1813DDE80
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x13DBD80 Offset: 0x13DA380 VA: 0x1813DBD80
	public static Exception NoTableName() { }

	// RVA: 0x13DB890 Offset: 0x13D9E90 VA: 0x1813DB890
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x13DABF0 Offset: 0x13D91F0 VA: 0x1813DABF0
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x13D95E0 Offset: 0x13D7BE0 VA: 0x1813D95E0
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x13D9540 Offset: 0x13D7B40 VA: 0x1813D9540
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x13DD800 Offset: 0x13DBE00 VA: 0x1813DD800
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x13D8CC0 Offset: 0x13D72C0 VA: 0x1813D8CC0
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x13DDD80 Offset: 0x13DC380 VA: 0x1813DDD80
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x13DDE00 Offset: 0x13DC400 VA: 0x1813DDE00
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x13DE270 Offset: 0x13DC870 VA: 0x1813DE270
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x13DE1E0 Offset: 0x13DC7E0 VA: 0x1813DE1E0
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x13DE0D0 Offset: 0x13DC6D0 VA: 0x1813DE0D0
	public static Exception TableInRelation() { }

	// RVA: 0x13DE010 Offset: 0x13DC610 VA: 0x1813DE010
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x13D6D00 Offset: 0x13D5300 VA: 0x1813D6D00
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x13D6C80 Offset: 0x13D5280 VA: 0x1813D6C80
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x13D6E00 Offset: 0x13D5400 VA: 0x1813D6E00
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x13D6D80 Offset: 0x13D5380 VA: 0x1813D6D80
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x13DE150 Offset: 0x13DC750 VA: 0x1813DE150
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x13D64F0 Offset: 0x13D4AF0 VA: 0x1813D64F0
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x13DAC80 Offset: 0x13D9280 VA: 0x1813DAC80
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x13DC3E0 Offset: 0x13DA9E0 VA: 0x1813DC3E0
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x13DC060 Offset: 0x13DA660 VA: 0x1813DC060
	public static Exception NullRange() { }

	// RVA: 0x13DBA70 Offset: 0x13DA070 VA: 0x1813DBA70
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x13DC300 Offset: 0x13DA900 VA: 0x1813DC300
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x13DDD00 Offset: 0x13DC300 VA: 0x1813DDD00
	public static Exception StorageSetFailed() { }

	// RVA: 0x13DDC80 Offset: 0x13DC280 VA: 0x1813DDC80
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x13DB620 Offset: 0x13D9C20 VA: 0x1813DB620
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x13DB590 Offset: 0x13D9B90 VA: 0x1813DB590
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x13DA510 Offset: 0x13D8B10 VA: 0x1813DA510
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x13D6730 Offset: 0x13D4D30 VA: 0x1813D6730
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x13D96F0 Offset: 0x13D7CF0 VA: 0x1813D96F0
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x13DCD60 Offset: 0x13DB360 VA: 0x1813DCD60
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x13DC870 Offset: 0x13DAE70 VA: 0x1813DC870
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x13DCDF0 Offset: 0x13DB3F0 VA: 0x1813DCDF0
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x13DC7E0 Offset: 0x13DADE0 VA: 0x1813DC7E0
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x13DE820 Offset: 0x13DCE20 VA: 0x1813DE820
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x13D8D50 Offset: 0x13D7350 VA: 0x1813D8D50
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x13DB510 Offset: 0x13D9B10 VA: 0x1813DB510
	public static Exception MismatchKeyLength() { }

	// RVA: 0x13DA720 Offset: 0x13D8D20 VA: 0x1813DA720
	public static Exception InvalidField(string name) { }

	// RVA: 0x13DAB60 Offset: 0x13D9160 VA: 0x1813DAB60
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x13D8060 Offset: 0x13D6660 VA: 0x1813D8060
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x13D7590 Offset: 0x13D5B90 VA: 0x1813D7590
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x13DA7B0 Offset: 0x13D8DB0 VA: 0x1813DA7B0
	public static Exception InvalidKey(string name) { }

	// RVA: 0x13D91E0 Offset: 0x13D77E0 VA: 0x1813D91E0
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x13D9160 Offset: 0x13D7760 VA: 0x1813D9160
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x13D9300 Offset: 0x13D7900 VA: 0x1813D9300
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x13D83D0 Offset: 0x13D69D0 VA: 0x1813D83D0
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x13D7500 Offset: 0x13D5B00 VA: 0x1813D7500
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x13DB6E0 Offset: 0x13D9CE0 VA: 0x1813DB6E0
	public static Exception MissingRefer(string name) { }

	// RVA: 0x13DA950 Offset: 0x13D8F50 VA: 0x1813DA950
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x13D6C00 Offset: 0x13D5200 VA: 0x1813D6C00
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x13DAD60 Offset: 0x13D9360 VA: 0x1813DAD60
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x13DE470 Offset: 0x13DCA70 VA: 0x1813DE470
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x13DBAF0 Offset: 0x13DA0F0 VA: 0x1813DBAF0
	public static Exception NestedCircular(string name) { }

	// RVA: 0x13DB780 Offset: 0x13D9D80 VA: 0x1813DB780
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x13DC270 Offset: 0x13DA870 VA: 0x1813DC270
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x13D8C40 Offset: 0x13D7240 VA: 0x1813D8C40
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x13DE420 Offset: 0x13DCA20 VA: 0x1813DE420
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x13D9420 Offset: 0x13D7A20 VA: 0x1813D9420
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x13D9ED0 Offset: 0x13D84D0 VA: 0x1813D9ED0
	public static Exception FoundEntity() { }

	// RVA: 0x13DB420 Offset: 0x13D9A20 VA: 0x1813DB420
	public static Exception MergeFailed(string name) { }

	// RVA: 0x13D8A60 Offset: 0x13D7060 VA: 0x1813D8A60
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x13DA690 Offset: 0x13D8C90 VA: 0x1813DA690
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x13DA470 Offset: 0x13D8A70 VA: 0x1813DA470
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x13D9880 Offset: 0x13D7E80 VA: 0x1813D9880
	public static Exception EnumeratorModified() { }

}

