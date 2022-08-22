internal static class ExceptionBuilder // TypeDefIndex: 4201
{	// Methods

	// RVA: 0x13DF600 Offset: 0x13DDC00 VA: 0x1813DF600
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x13DF3F0 Offset: 0x13DD9F0 VA: 0x1813DF3F0
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x13DF4A0 Offset: 0x13DDAA0 VA: 0x1813DF4A0
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x13DF550 Offset: 0x13DDB50 VA: 0x1813DF550
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x13DFC00 Offset: 0x13DE200 VA: 0x1813DFC00
	internal static Exception _Argument(string error) { }

	// RVA: 0x13DFB90 Offset: 0x13DE190 VA: 0x1813DFB90
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x13DFAB0 Offset: 0x13DE0B0 VA: 0x1813DFAB0
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x13DFB20 Offset: 0x13DE120 VA: 0x1813DFB20
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x13DFDE0 Offset: 0x13DE3E0 VA: 0x1813DFDE0
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x13DFF00 Offset: 0x13DE500 VA: 0x1813DFF00
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x13DFEA0 Offset: 0x13DE4A0 VA: 0x1813DFEA0
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1A1F0 Offset: 0x1B187F0 VA: 0x181B1A1F0
	|-ExceptionBuilder._InvalidEnumArgumentException<DataRowState>
	|-ExceptionBuilder._InvalidEnumArgumentException<DataSetDateTime>
	|-ExceptionBuilder._InvalidEnumArgumentException<SerializationFormat>
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0x1B1A2F0 Offset: 0x1B188F0 VA: 0x181B1A2F0
	|-ExceptionBuilder._InvalidEnumArgumentException<object>
	*/

	// RVA: 0x13DF2B0 Offset: 0x13DD8B0 VA: 0x1813DF2B0
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x13DC320 Offset: 0x13DA920 VA: 0x1813DC320
	private static Exception _Data(string error) { }

	// RVA: 0x13DFC60 Offset: 0x13DE260 VA: 0x1813DFC60
	private static Exception _Constraint(string error) { }

	// RVA: 0x13DFE40 Offset: 0x13DE440 VA: 0x1813DFE40
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x13DFCC0 Offset: 0x13DE2C0 VA: 0x1813DFCC0
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x13DFD20 Offset: 0x13DE320 VA: 0x1813DFD20
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x13DFD80 Offset: 0x13DE380 VA: 0x1813DFD80
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x13DFF60 Offset: 0x13DE560 VA: 0x1813DFF60
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x13DFFC0 Offset: 0x13DE5C0 VA: 0x1813DFFC0
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x13E0020 Offset: 0x13DE620 VA: 0x1813E0020
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x13E0080 Offset: 0x13DE680 VA: 0x1813E0080
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x13D74F0 Offset: 0x13D5AF0 VA: 0x1813D74F0
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x13D7590 Offset: 0x13D5B90 VA: 0x1813D7590
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x13D78F0 Offset: 0x13D5EF0 VA: 0x1813D78F0
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x13D8DD0 Offset: 0x13D73D0 VA: 0x1813D8DD0
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x13DC810 Offset: 0x13DAE10 VA: 0x1813DC810
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x13DB740 Offset: 0x13D9D40 VA: 0x1813DB740
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x13D90F0 Offset: 0x13D76F0 VA: 0x1813D90F0
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x13D9070 Offset: 0x13D7670 VA: 0x1813D9070
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x13D9180 Offset: 0x13D7780 VA: 0x1813D9180
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x13D9240 Offset: 0x13D7840 VA: 0x1813D9240
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x13D7E80 Offset: 0x13D6480 VA: 0x1813D7E80
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x13D7F10 Offset: 0x13D6510 VA: 0x1813D7F10
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x13D7FA0 Offset: 0x13D65A0 VA: 0x1813D7FA0
	public static Exception CannotAddColumn3() { }

	// RVA: 0x13D8020 Offset: 0x13D6620 VA: 0x1813D8020
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x13D81D0 Offset: 0x13D67D0 VA: 0x1813D81D0
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x13D80B0 Offset: 0x13D66B0 VA: 0x1813D80B0
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x13D8140 Offset: 0x13D6740 VA: 0x1813D8140
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x13D85B0 Offset: 0x13D6BB0 VA: 0x1813D85B0
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x13D8750 Offset: 0x13D6D50 VA: 0x1813D8750
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x13D8520 Offset: 0x13D6B20 VA: 0x1813D8520
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x13D8630 Offset: 0x13D6C30 VA: 0x1813D8630
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x13D86C0 Offset: 0x13D6CC0 VA: 0x1813D86C0
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x13D7370 Offset: 0x13D5970 VA: 0x1813D7370
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x13DCA80 Offset: 0x13DB080 VA: 0x1813DCA80
	public static Exception NoConstraintName() { }

	// RVA: 0x13D9710 Offset: 0x13D7D10 VA: 0x1813D9710
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x13DC0B0 Offset: 0x13DA6B0 VA: 0x1813DC0B0
	public static string KeysToString(object[] keys) { }

	// RVA: 0x13DF830 Offset: 0x13DDE30 VA: 0x1813DF830
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x13D97A0 Offset: 0x13D7DA0 VA: 0x1813D97A0
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x13D9550 Offset: 0x13D7B50 VA: 0x1813D9550
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x13DA290 Offset: 0x13D8890 VA: 0x1813DA290
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x13DA170 Offset: 0x13D8770 VA: 0x1813DA170
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x13DC8A0 Offset: 0x13DAEA0 VA: 0x1813DC8A0
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x13DF9B0 Offset: 0x13DDFB0 VA: 0x1813DF9B0
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x13D94D0 Offset: 0x13D7AD0 VA: 0x1813D94D0
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x13D9610 Offset: 0x13D7C10 VA: 0x1813D9610
	public static Exception ConstraintParentValues() { }

	// RVA: 0x13D9430 Offset: 0x13D7A30 VA: 0x1813D9430
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x13D9690 Offset: 0x13D7C90 VA: 0x1813D9690
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x13DAAE0 Offset: 0x13D90E0 VA: 0x1813DAAE0
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x13DAB70 Offset: 0x13D9170 VA: 0x1813DAB70
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x13DAC00 Offset: 0x13D9200 VA: 0x1813DAC00
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x13DACB0 Offset: 0x13D92B0 VA: 0x1813DACB0
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x13DDF00 Offset: 0x13DC500 VA: 0x1813DDF00
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x13DC2E0 Offset: 0x13DA8E0 VA: 0x1813DC2E0
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x13DCD90 Offset: 0x13DB390 VA: 0x1813DCD90
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x13D8B90 Offset: 0x13D7190 VA: 0x1813D8B90
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x13D7760 Offset: 0x13D5D60 VA: 0x1813D7760
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x13D76E0 Offset: 0x13D5CE0 VA: 0x1813D76E0
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x13D7870 Offset: 0x13D5E70 VA: 0x1813D7870
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x13D8C20 Offset: 0x13D7220 VA: 0x1813D8C20
	public static Exception CantChangeDataType() { }

	// RVA: 0x13DCE50 Offset: 0x13DB450 VA: 0x1813DCE50
	public static Exception NullDataType() { }

	// RVA: 0x13D8FF0 Offset: 0x13D75F0 VA: 0x1813D8FF0
	public static Exception ColumnNameRequired() { }

	// RVA: 0x13D9CD0 Offset: 0x13D82D0 VA: 0x1813D9CD0
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x13D9E50 Offset: 0x13D8450 VA: 0x1813D9E50
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x13D9D50 Offset: 0x13D8350 VA: 0x1813D9D50
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x13DA940 Offset: 0x13D8F40 VA: 0x1813DA940
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x13DA8C0 Offset: 0x13D8EC0 VA: 0x1813DA8C0
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x13DA800 Offset: 0x13D8E00 VA: 0x1813DA800
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x13DAA40 Offset: 0x13D9040 VA: 0x1813DAA40
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x13DA9C0 Offset: 0x13D8FC0 VA: 0x1813DA9C0
	public static Exception ExpressionCircular() { }

	// RVA: 0x13DCD00 Offset: 0x13DB300 VA: 0x1813DCD00
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x13DCED0 Offset: 0x13DB4D0 VA: 0x1813DCED0
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x13DCFE0 Offset: 0x13DB5E0 VA: 0x1813DCFE0
	public static Exception NullValues(string column) { }

	// RVA: 0x13DD3D0 Offset: 0x13DB9D0 VA: 0x1813DD3D0
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x13DD450 Offset: 0x13DBA50 VA: 0x1813DD450
	public static Exception ReadOnly(string column) { }

	// RVA: 0x13DF7B0 Offset: 0x13DDDB0 VA: 0x1813DF7B0
	public static Exception UniqueAndExpression() { }

	// RVA: 0x13DE930 Offset: 0x13DCF30 VA: 0x1813DE930
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x13D8AF0 Offset: 0x13D70F0 VA: 0x1813D8AF0
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x13DC1B0 Offset: 0x13DA7B0 VA: 0x1813DC1B0
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x13D88F0 Offset: 0x13D6EF0 VA: 0x1813D88F0
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x13D8850 Offset: 0x13D6E50 VA: 0x1813D8850
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x13D89D0 Offset: 0x13D6FD0 VA: 0x1813D89D0
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x13D8A60 Offset: 0x13D7060 VA: 0x1813D8A60
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x13D8370 Offset: 0x13D6970 VA: 0x1813D8370
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x13DAFA0 Offset: 0x13D95A0 VA: 0x1813DAFA0
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x13D77E0 Offset: 0x13D5DE0 VA: 0x1813D77E0
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x13DB0D0 Offset: 0x13D96D0 VA: 0x1813DB0D0
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x13DB040 Offset: 0x13D9640 VA: 0x1813DB040
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x13DF690 Offset: 0x13DDC90 VA: 0x1813DF690
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x13DB4A0 Offset: 0x13D9AA0 VA: 0x1813DB4A0
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x13D87D0 Offset: 0x13D6DD0 VA: 0x1813D87D0
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x13DB550 Offset: 0x13D9B50 VA: 0x1813DB550
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x13D8CA0 Offset: 0x13D72A0 VA: 0x1813D8CA0
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x13D9360 Offset: 0x13D7960 VA: 0x1813D9360
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x13DE8A0 Offset: 0x13DCEA0 VA: 0x1813DE8A0
	public static Exception SetFailed(string name) { }

	// RVA: 0x13D7D80 Offset: 0x13D6380 VA: 0x1813D7D80
	public static Exception CanNotUse() { }

	// RVA: 0x13DEA70 Offset: 0x13DD070 VA: 0x1813DEA70
	public static Exception SetIListObject() { }

	// RVA: 0x13D72F0 Offset: 0x13D58F0 VA: 0x1813D72F0
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x13DCDD0 Offset: 0x13DB3D0 VA: 0x1813DCDD0
	public static Exception NotOpen() { }

	// RVA: 0x13D9A30 Offset: 0x13D8030 VA: 0x1813D9A30
	public static Exception CreateChildView() { }

	// RVA: 0x13D7A80 Offset: 0x13D6080 VA: 0x1813D7A80
	public static Exception CanNotDelete() { }

	// RVA: 0x13DAE50 Offset: 0x13D9450 VA: 0x1813DAE50
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x13D7270 Offset: 0x13D5870 VA: 0x1813D7270
	public static Exception AddExternalObject() { }

	// RVA: 0x13D7A00 Offset: 0x13D6000 VA: 0x1813D7A00
	public static Exception CanNotClear() { }

	// RVA: 0x13DB2F0 Offset: 0x13D98F0 VA: 0x1813DB2F0
	public static Exception InsertExternalObject() { }

	// RVA: 0x13DDE80 Offset: 0x13DC480 VA: 0x1813DDE80
	public static Exception RemoveExternalObject() { }

	// RVA: 0x13DBF70 Offset: 0x13DA570 VA: 0x1813DBF70
	public static Exception KeyTableMismatch() { }

	// RVA: 0x13DBEF0 Offset: 0x13DA4F0 VA: 0x1813DBEF0
	public static Exception KeyNoColumns() { }

	// RVA: 0x13DBFF0 Offset: 0x13DA5F0 VA: 0x1813DBFF0
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x13DBD60 Offset: 0x13DA360 VA: 0x1813DBD60
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x13DD800 Offset: 0x13DBE00 VA: 0x1813DD800
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x13D93B0 Offset: 0x13D79B0 VA: 0x1813D93B0
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x13DBDF0 Offset: 0x13DA3F0 VA: 0x1813DBDF0
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x13DBE70 Offset: 0x13DA470 VA: 0x1813DBE70
	public static Exception KeyLengthZero() { }

	// RVA: 0x13DAD50 Offset: 0x13D9350 VA: 0x1813DAD50
	public static Exception ForeignRelation() { }

	// RVA: 0x13DBCE0 Offset: 0x13DA2E0 VA: 0x1813DBCE0
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x13DDA00 Offset: 0x13DC000 VA: 0x1813DDA00
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x13DAF10 Offset: 0x13D9510 VA: 0x1813DAF10
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x13DEAF0 Offset: 0x13DD0F0 VA: 0x1813DEAF0
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x13DD980 Offset: 0x13DBF80 VA: 0x1813DD980
	public static Exception RelationForeignRow() { }

	// RVA: 0x13DDA90 Offset: 0x13DC090 VA: 0x1813DDA90
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x13DEE00 Offset: 0x13DD400 VA: 0x1813DEE00
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x13DC250 Offset: 0x13DA850 VA: 0x1813DC250
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x13DD900 Offset: 0x13DBF00 VA: 0x1813DD900
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x13DD070 Offset: 0x13DB670 VA: 0x1813DD070
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x13DB160 Offset: 0x13D9760 VA: 0x1813DB160
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x13DB7C0 Offset: 0x13D9DC0 VA: 0x1813DB7C0
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x13DE440 Offset: 0x13DCA40 VA: 0x1813DE440
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x13DE4C0 Offset: 0x13DCAC0 VA: 0x1813DE4C0
	public static Exception RowNotInTheTable() { }

	// RVA: 0x13DA570 Offset: 0x13D8B70 VA: 0x1813DA570
	public static Exception EditInRowChanging() { }

	// RVA: 0x13DA680 Offset: 0x13D8C80 VA: 0x1813DA680
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x13D7980 Offset: 0x13D5F80 VA: 0x1813D7980
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x13D7E00 Offset: 0x13D6400 VA: 0x1813D7E00
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x13D9F60 Offset: 0x13D8560 VA: 0x1813D9F60
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x13DFA30 Offset: 0x13DE030 VA: 0x1813DFA30
	public static Exception ValueArrayLength() { }

	// RVA: 0x13DCB00 Offset: 0x13DB100 VA: 0x1813DCB00
	public static Exception NoCurrentData() { }

	// RVA: 0x13DCB80 Offset: 0x13DB180 VA: 0x1813DCB80
	public static Exception NoOriginalData() { }

	// RVA: 0x13DCC00 Offset: 0x13DB200 VA: 0x1813DCC00
	public static Exception NoProposedData() { }

	// RVA: 0x13DE680 Offset: 0x13DCC80 VA: 0x1813DE680
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x13D9FE0 Offset: 0x13D85E0 VA: 0x1813D9FE0
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x13DE060 Offset: 0x13DC660 VA: 0x1813DE060
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x13DE260 Offset: 0x13DC860 VA: 0x1813DE260
	public static Exception RowEmpty() { }

	// RVA: 0x13DB9E0 Offset: 0x13D9FE0 VA: 0x1813DB9E0
	public static Exception InvalidRowVersion() { }

	// RVA: 0x13DE600 Offset: 0x13DCC00 VA: 0x1813DE600
	public static Exception RowOutOfRange() { }

	// RVA: 0x13DE540 Offset: 0x13DCB40 VA: 0x1813DE540
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x13DE370 Offset: 0x13DC970 VA: 0x1813DE370
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x13DE2E0 Offset: 0x13DC8E0 VA: 0x1813DE2E0
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x13DE1E0 Offset: 0x13DC7E0 VA: 0x1813DE1E0
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x13DC710 Offset: 0x13DAD10 VA: 0x1813DC710
	public static Exception MultipleParents() { }

	// RVA: 0x13DB9A0 Offset: 0x13D9FA0 VA: 0x1813DB9A0
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x13DB920 Offset: 0x13D9F20 VA: 0x1813DB920
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x13DE820 Offset: 0x13DCE20 VA: 0x1813DE820
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x13DE790 Offset: 0x13DCD90 VA: 0x1813DE790
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x13D9AB0 Offset: 0x13D80B0 VA: 0x1813D9AB0
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x13DC380 Offset: 0x13DA980 VA: 0x1813DC380
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x13DF230 Offset: 0x13DD830 VA: 0x1813DF230
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x13DD560 Offset: 0x13DBB60 VA: 0x1813DD560
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x13DE0E0 Offset: 0x13DC6E0 VA: 0x1813DE0E0
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x13DE160 Offset: 0x13DC760 VA: 0x1813DE160
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x13DD4E0 Offset: 0x13DBAE0 VA: 0x1813DD4E0
	public static Exception RecordStateRange() { }

	// RVA: 0x13DB1F0 Offset: 0x13D97F0 VA: 0x1813DB1F0
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x13DDFB0 Offset: 0x13DC5B0 VA: 0x1813DDFB0
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x13DD5E0 Offset: 0x13DBBE0 VA: 0x1813DD5E0
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x13DD660 Offset: 0x13DBC60 VA: 0x1813DD660
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x13DDB10 Offset: 0x13DC110 VA: 0x1813DDB10
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x13DDBA0 Offset: 0x13DC1A0 VA: 0x1813DDBA0
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x13DA3B0 Offset: 0x13D89B0 VA: 0x1813DA3B0
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x13DDD80 Offset: 0x13DC380 VA: 0x1813DDD80
	public static Exception RelationTableNull() { }

	// RVA: 0x13DD880 Offset: 0x13DBE80 VA: 0x1813DD880
	public static Exception RelationDataSetNull() { }

	// RVA: 0x13DDE00 Offset: 0x13DC400 VA: 0x1813DDE00
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x13DD0F0 Offset: 0x13DB6F0 VA: 0x1813DD0F0
	public static Exception ParentTableMismatch() { }

	// RVA: 0x13D8EE0 Offset: 0x13D74E0 VA: 0x1813D8EE0
	public static Exception ChildTableMismatch() { }

	// RVA: 0x13DA700 Offset: 0x13D8D00 VA: 0x1813DA700
	public static Exception EnforceConstraint() { }

	// RVA: 0x13D8E60 Offset: 0x13D7460 VA: 0x1813D8E60
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x13D82F0 Offset: 0x13D68F0 VA: 0x1813D82F0
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x13D8260 Offset: 0x13D6860 VA: 0x1813D8260
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x13DB8E0 Offset: 0x13D9EE0 VA: 0x1813DB8E0
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x13DEE90 Offset: 0x13DD490 VA: 0x1813DEE90
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x13DED80 Offset: 0x13DD380 VA: 0x1813DED80
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x13DCC80 Offset: 0x13DB280 VA: 0x1813DCC80
	public static Exception NoTableName() { }

	// RVA: 0x13DC790 Offset: 0x13DAD90 VA: 0x1813DC790
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x13DBAF0 Offset: 0x13DA0F0 VA: 0x1813DBAF0
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x13DA4E0 Offset: 0x13D8AE0 VA: 0x1813DA4E0
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x13DA440 Offset: 0x13D8A40 VA: 0x1813DA440
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x13DE700 Offset: 0x13DCD00 VA: 0x1813DE700
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x13D9BC0 Offset: 0x13D81C0 VA: 0x1813D9BC0
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x13DEC80 Offset: 0x13DD280 VA: 0x1813DEC80
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x13DED00 Offset: 0x13DD300 VA: 0x1813DED00
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x13DF170 Offset: 0x13DD770 VA: 0x1813DF170
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x13DF0E0 Offset: 0x13DD6E0 VA: 0x1813DF0E0
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x13DEFD0 Offset: 0x13DD5D0 VA: 0x1813DEFD0
	public static Exception TableInRelation() { }

	// RVA: 0x13DEF10 Offset: 0x13DD510 VA: 0x1813DEF10
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x13D7C00 Offset: 0x13D6200 VA: 0x1813D7C00
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x13D7B80 Offset: 0x13D6180 VA: 0x1813D7B80
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x13D7D00 Offset: 0x13D6300 VA: 0x1813D7D00
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x13D7C80 Offset: 0x13D6280 VA: 0x1813D7C80
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x13DF050 Offset: 0x13DD650 VA: 0x1813DF050
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x13D73F0 Offset: 0x13D59F0 VA: 0x1813D73F0
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x13DBB80 Offset: 0x13DA180 VA: 0x1813DBB80
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x13DD2E0 Offset: 0x13DB8E0 VA: 0x1813DD2E0
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x13DCF60 Offset: 0x13DB560 VA: 0x1813DCF60
	public static Exception NullRange() { }

	// RVA: 0x13DC970 Offset: 0x13DAF70 VA: 0x1813DC970
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x13DD200 Offset: 0x13DB800 VA: 0x1813DD200
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x13DEC00 Offset: 0x13DD200 VA: 0x1813DEC00
	public static Exception StorageSetFailed() { }

	// RVA: 0x13DEB80 Offset: 0x13DD180 VA: 0x1813DEB80
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x13DC520 Offset: 0x13DAB20 VA: 0x1813DC520
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x13DC490 Offset: 0x13DAA90 VA: 0x1813DC490
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x13DB410 Offset: 0x13D9A10 VA: 0x1813DB410
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x13D7630 Offset: 0x13D5C30 VA: 0x1813D7630
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x13DA5F0 Offset: 0x13D8BF0 VA: 0x1813DA5F0
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x13DDC60 Offset: 0x13DC260 VA: 0x1813DDC60
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x13DD770 Offset: 0x13DBD70 VA: 0x1813DD770
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x13DDCF0 Offset: 0x13DC2F0 VA: 0x1813DDCF0
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x13DD6E0 Offset: 0x13DBCE0 VA: 0x1813DD6E0
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x13DF720 Offset: 0x13DDD20 VA: 0x1813DF720
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x13D9C50 Offset: 0x13D8250 VA: 0x1813D9C50
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x13DC410 Offset: 0x13DAA10 VA: 0x1813DC410
	public static Exception MismatchKeyLength() { }

	// RVA: 0x13DB620 Offset: 0x13D9C20 VA: 0x1813DB620
	public static Exception InvalidField(string name) { }

	// RVA: 0x13DBA60 Offset: 0x13DA060 VA: 0x1813DBA60
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x13D8F60 Offset: 0x13D7560 VA: 0x1813D8F60
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x13D8490 Offset: 0x13D6A90 VA: 0x1813D8490
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x13DB6B0 Offset: 0x13D9CB0 VA: 0x1813DB6B0
	public static Exception InvalidKey(string name) { }

	// RVA: 0x13DA0E0 Offset: 0x13D86E0 VA: 0x1813DA0E0
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x13DA060 Offset: 0x13D8660 VA: 0x1813DA060
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x13DA200 Offset: 0x13D8800 VA: 0x1813DA200
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x13D92D0 Offset: 0x13D78D0 VA: 0x1813D92D0
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x13D8400 Offset: 0x13D6A00 VA: 0x1813D8400
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x13DC5E0 Offset: 0x13DABE0 VA: 0x1813DC5E0
	public static Exception MissingRefer(string name) { }

	// RVA: 0x13DB850 Offset: 0x13D9E50 VA: 0x1813DB850
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x13D7B00 Offset: 0x13D6100 VA: 0x1813D7B00
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x13DBC60 Offset: 0x13DA260 VA: 0x1813DBC60
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x13DF370 Offset: 0x13DD970 VA: 0x1813DF370
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x13DC9F0 Offset: 0x13DAFF0 VA: 0x1813DC9F0
	public static Exception NestedCircular(string name) { }

	// RVA: 0x13DC680 Offset: 0x13DAC80 VA: 0x1813DC680
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x13DD170 Offset: 0x13DB770 VA: 0x1813DD170
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x13D9B40 Offset: 0x13D8140 VA: 0x1813D9B40
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x13DF320 Offset: 0x13DD920 VA: 0x1813DF320
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x13DA320 Offset: 0x13D8920 VA: 0x1813DA320
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x13DADD0 Offset: 0x13D93D0 VA: 0x1813DADD0
	public static Exception FoundEntity() { }

	// RVA: 0x13DC320 Offset: 0x13DA920 VA: 0x1813DC320
	public static Exception MergeFailed(string name) { }

	// RVA: 0x13D9960 Offset: 0x13D7F60 VA: 0x1813D9960
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x13DB590 Offset: 0x13D9B90 VA: 0x1813DB590
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x13DB370 Offset: 0x13D9970 VA: 0x1813DB370
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x13DA780 Offset: 0x13D8D80 VA: 0x1813DA780
	public static Exception EnumeratorModified() { }

}

