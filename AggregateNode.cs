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

	// RVA: 0x1267320 Offset: 0x1265920 VA: 0x181267320
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x12671D0 Offset: 0x12657D0 VA: 0x1812671D0
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x1266A00 Offset: 0x1265000 VA: 0x181266A00 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x12668A0 Offset: 0x1264EA0 VA: 0x1812668A0
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0xCCD4E0 Offset: 0xCCBAE0 VA: 0x180CCD4E0 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1266E00 Offset: 0x1265400 VA: 0x181266E00 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1267110 Offset: 0x1265710 VA: 0x181267110 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x12671C0 Offset: 0x12657C0 VA: 0x1812671C0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1266D90 Offset: 0x1265390 VA: 0x181266D90 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 13
	internal override ExpressionNode Optimize() { }

}

