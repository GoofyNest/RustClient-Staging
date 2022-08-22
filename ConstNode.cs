internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 4246
{	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0x1226670 Offset: 0x1224C70 VA: 0x181226670
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0x1226370 Offset: 0x1224970 VA: 0x181226370
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	internal override object Eval() { }

	// RVA: 0x95FA30 Offset: 0x95E030 VA: 0x18095FA30 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x95FA30 Offset: 0x95E030 VA: 0x18095FA30 Slot: 8
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

	// RVA: 0x1225E50 Offset: 0x1224450 VA: 0x181225E50
	private object SmallestDecimal(object constant) { }

	// RVA: 0x12260F0 Offset: 0x12246F0 VA: 0x1812260F0
	private object SmallestNumeric(object constant) { }

}

