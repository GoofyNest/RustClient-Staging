internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 4266
{	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0xCCD6E0 Offset: 0xCCBCE0 VA: 0x180CCD6E0
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0xCCC7A0 Offset: 0xCCADA0 VA: 0x180CCC7A0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCCD4E0 Offset: 0xCCBAE0 VA: 0x180CCD4E0 Slot: 6
	internal override object Eval() { }

	// RVA: 0xCCD490 Offset: 0xCCBA90 VA: 0x180CCD490 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xCCD500 Offset: 0xCCBB00 VA: 0x180CCD500 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xCCC830 Offset: 0xCCAE30 VA: 0x180CCC830
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0xCCD590 Offset: 0xCCBB90 VA: 0x180CCD590 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xCCD5C0 Offset: 0xCCBBC0 VA: 0x180CCD5C0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xCCD530 Offset: 0xCCBB30 VA: 0x180CCD530 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0xCCD560 Offset: 0xCCBB60 VA: 0x180CCD560 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xCCC800 Offset: 0xCCAE00 VA: 0x180CCC800 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xCCD5F0 Offset: 0xCCBBF0 VA: 0x180CCD5F0 Slot: 13
	internal override ExpressionNode Optimize() { }

}

