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

	// RVA: 0x13E22C0 Offset: 0x13E08C0 VA: 0x1813E22C0
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

	// RVA: 0x13E2190 Offset: 0x13E0790 VA: 0x1813E2190
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x13E2170 Offset: 0x13E0770 VA: 0x1813E2170
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x13E2260 Offset: 0x13E0860 VA: 0x1813E2260
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x13E2220 Offset: 0x13E0820 VA: 0x1813E2220
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x13E22A0 Offset: 0x13E08A0 VA: 0x1813E22A0
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x13E2280 Offset: 0x13E0880 VA: 0x1813E2280
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x13E21F0 Offset: 0x13E07F0 VA: 0x1813E21F0
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x13E21B0 Offset: 0x13E07B0 VA: 0x1813E21B0
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x13E2150 Offset: 0x13E0750 VA: 0x1813E2150
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x13E2130 Offset: 0x13E0730 VA: 0x1813E2130
	internal static bool IsFloatSql(StorageType type) { }

}

