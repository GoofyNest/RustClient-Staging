internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 4266
{	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0xCCD9A0 Offset: 0xCCBFA0 VA: 0x180CCD9A0
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0xCCCA60 Offset: 0xCCB060 VA: 0x180CCCA60 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCCD7A0 Offset: 0xCCBDA0 VA: 0x180CCD7A0 Slot: 6
	internal override object Eval() { }

	// RVA: 0xCCD750 Offset: 0xCCBD50 VA: 0x180CCD750 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xCCD7C0 Offset: 0xCCBDC0 VA: 0x180CCD7C0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xCCCAF0 Offset: 0xCCB0F0 VA: 0x180CCCAF0
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0xCCD850 Offset: 0xCCBE50 VA: 0x180CCD850 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xCCD880 Offset: 0xCCBE80 VA: 0x180CCD880 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xCCD7F0 Offset: 0xCCBDF0 VA: 0x180CCD7F0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0xCCD820 Offset: 0xCCBE20 VA: 0x180CCD820 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xCCCAC0 Offset: 0xCCB0C0 VA: 0x180CCCAC0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xCCD8B0 Offset: 0xCCBEB0 VA: 0x180CCD8B0 Slot: 13
	internal override ExpressionNode Optimize() { }

}

