internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 4266
{	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0xCCDE40 Offset: 0xCCC440 VA: 0x180CCDE40
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0xCCCF00 Offset: 0xCCB500 VA: 0x180CCCF00 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCCDC40 Offset: 0xCCC240 VA: 0x180CCDC40 Slot: 6
	internal override object Eval() { }

	// RVA: 0xCCDBF0 Offset: 0xCCC1F0 VA: 0x180CCDBF0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xCCDC60 Offset: 0xCCC260 VA: 0x180CCDC60 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xCCCF90 Offset: 0xCCB590 VA: 0x180CCCF90
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0xCCDCF0 Offset: 0xCCC2F0 VA: 0x180CCDCF0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xCCDD20 Offset: 0xCCC320 VA: 0x180CCDD20 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xCCDC90 Offset: 0xCCC290 VA: 0x180CCDC90 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0xCCDCC0 Offset: 0xCCC2C0 VA: 0x180CCDCC0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xCCCF60 Offset: 0xCCB560 VA: 0x180CCCF60 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xCCDD50 Offset: 0xCCC350 VA: 0x180CCDD50 Slot: 13
	internal override ExpressionNode Optimize() { }

}

