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

	// RVA: 0x1267C80 Offset: 0x1266280 VA: 0x181267C80
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x1267B30 Offset: 0x1266130 VA: 0x181267B30
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x1267360 Offset: 0x1265960 VA: 0x181267360 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1267200 Offset: 0x1265800 VA: 0x181267200
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0xCCDC40 Offset: 0xCCC240 VA: 0x180CCDC40 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1267760 Offset: 0x1265D60 VA: 0x181267760 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1267A70 Offset: 0x1266070 VA: 0x181267A70 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1267B20 Offset: 0x1266120 VA: 0x181267B20 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x12676F0 Offset: 0x1265CF0 VA: 0x1812676F0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 13
	internal override ExpressionNode Optimize() { }

}

