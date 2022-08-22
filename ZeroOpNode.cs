internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 4267
{	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0x1AE1AF0 Offset: 0x1AE00F0 VA: 0x181AE1AF0
	internal void .ctor(int op) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1AE1A50 Offset: 0x1AE0050 VA: 0x181AE1A50 Slot: 6
	internal override object Eval() { }

	// RVA: 0x95FF30 Offset: 0x95E530 VA: 0x18095FF30 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x95FF30 Offset: 0x95E530 VA: 0x18095FF30 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 13
	internal override ExpressionNode Optimize() { }

}

