internal abstract class ExpressionNode // TypeDefIndex: 4248
{	// Fields
	private DataTable _table; // 0x10

	// Properties
	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	protected void .ctor(DataTable table) { }

	// RVA: 0x13E13C0 Offset: 0x13DF9C0 VA: 0x1813E13C0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 4
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	protected DataTable get_table() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
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

	// RVA: 0x13E1290 Offset: 0x13DF890 VA: 0x1813E1290
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x13E1270 Offset: 0x13DF870 VA: 0x1813E1270
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x13E1360 Offset: 0x13DF960 VA: 0x1813E1360
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x13E1320 Offset: 0x13DF920 VA: 0x1813E1320
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x13E13A0 Offset: 0x13DF9A0 VA: 0x1813E13A0
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x13E1380 Offset: 0x13DF980 VA: 0x1813E1380
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x13E12F0 Offset: 0x13DF8F0 VA: 0x1813E12F0
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x13E12B0 Offset: 0x13DF8B0 VA: 0x1813E12B0
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x13E1250 Offset: 0x13DF850 VA: 0x1813E1250
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x13E1230 Offset: 0x13DF830 VA: 0x1813E1230
	internal static bool IsFloatSql(StorageType type) { }

}

