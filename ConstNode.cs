internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 4246
{	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0x1226D10 Offset: 0x1225310 VA: 0x181226D10
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0x1226A10 Offset: 0x1225010 VA: 0x181226A10
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
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

	// RVA: 0x12264F0 Offset: 0x1224AF0 VA: 0x1812264F0
	private object SmallestDecimal(object constant) { }

	// RVA: 0x1226790 Offset: 0x1224D90 VA: 0x181226790
	private object SmallestNumeric(object constant) { }

}

