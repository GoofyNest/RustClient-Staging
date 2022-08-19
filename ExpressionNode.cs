internal abstract class ExpressionNode // TypeDefIndex: 4248
{	// Fields
	private DataTable _table; // 0x10

	// Properties
	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	protected void .ctor(DataTable table) { }

	// RVA: 0x13E2000 Offset: 0x13E0600 VA: 0x1813E2000
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 4
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	protected DataTable get_table() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	protected void BindTable(DataTable table) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void Bind(DataTable table, List<DataColumn> list);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract object Eval();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract object Eval(DataRow row, DataRowVersion version);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract object Eval(int[] recordNos);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool IsConstant();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool IsTableConstant();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool HasLocalAggregate();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool HasRemoteAggregate();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract ExpressionNode Optimize();

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0x13E1ED0 Offset: 0x13E04D0 VA: 0x1813E1ED0
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x13E1EB0 Offset: 0x13E04B0 VA: 0x1813E1EB0
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x13E1FA0 Offset: 0x13E05A0 VA: 0x1813E1FA0
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x13E1F60 Offset: 0x13E0560 VA: 0x1813E1F60
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x13E1FE0 Offset: 0x13E05E0 VA: 0x1813E1FE0
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x13E1FC0 Offset: 0x13E05C0 VA: 0x1813E1FC0
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x13E1F30 Offset: 0x13E0530 VA: 0x1813E1F30
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x13E1EF0 Offset: 0x13E04F0 VA: 0x1813E1EF0
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x13E1E90 Offset: 0x13E0490 VA: 0x1813E1E90
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x13E1E70 Offset: 0x13E0470 VA: 0x1813E1E70
	internal static bool IsFloatSql(StorageType type) { }

}

