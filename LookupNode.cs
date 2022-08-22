internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 4263
{	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0xE8E3B0 Offset: 0xE8C9B0 VA: 0x180E8E3B0
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0xE8DF70 Offset: 0xE8C570 VA: 0x180E8DF70 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xE8E200 Offset: 0xE8C800 VA: 0x180E8E200 Slot: 6
	internal override object Eval() { }

	// RVA: 0xE8E290 Offset: 0xE8C890 VA: 0x180E8E290 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xE8E240 Offset: 0xE8C840 VA: 0x180E8E240 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xE8E1F0 Offset: 0xE8C7F0 VA: 0x180E8E1F0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 13
	internal override ExpressionNode Optimize() { }

}

