internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 4263
{	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0xE8D900 Offset: 0xE8BF00 VA: 0x180E8D900
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0xE8D4C0 Offset: 0xE8BAC0 VA: 0x180E8D4C0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xE8D750 Offset: 0xE8BD50 VA: 0x180E8D750 Slot: 6
	internal override object Eval() { }

	// RVA: 0xE8D7E0 Offset: 0xE8BDE0 VA: 0x180E8D7E0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xE8D790 Offset: 0xE8BD90 VA: 0x180E8D790 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xE8D740 Offset: 0xE8BD40 VA: 0x180E8D740 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 13
	internal override ExpressionNode Optimize() { }

}

