internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 4267
{	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0x1AE1200 Offset: 0x1ADF800 VA: 0x181AE1200
	internal void .ctor(int op) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1AE1160 Offset: 0x1ADF760 VA: 0x181AE1160 Slot: 6
	internal override object Eval() { }

	// RVA: 0x95F920 Offset: 0x95DF20 VA: 0x18095F920 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x95F920 Offset: 0x95DF20 VA: 0x18095F920 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 13
	internal override ExpressionNode Optimize() { }

}

