internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 4242
{	// Fields
	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48

	// Methods

	// RVA: 0x12675E0 Offset: 0x1265BE0 VA: 0x1812675E0
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x1267490 Offset: 0x1265A90 VA: 0x181267490
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x1266CC0 Offset: 0x12652C0 VA: 0x181266CC0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1266B60 Offset: 0x1265160 VA: 0x181266B60
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0xCCD7A0 Offset: 0xCCBDA0 VA: 0x180CCD7A0 Slot: 6
	internal override object Eval() { }

	// RVA: 0x12670C0 Offset: 0x12656C0 VA: 0x1812670C0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x12673D0 Offset: 0x12659D0 VA: 0x1812673D0 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1267480 Offset: 0x1265A80 VA: 0x181267480 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1267050 Offset: 0x1265650 VA: 0x181267050 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 13
	internal override ExpressionNode Optimize() { }

}

