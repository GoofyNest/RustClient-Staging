internal sealed class NameNode : ExpressionNode // TypeDefIndex: 4264
{	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0xE91C50 Offset: 0xE90250 VA: 0x180E91C50
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0xE91C10 Offset: 0xE90210 VA: 0x180E91C10
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xE91CA0 Offset: 0xE902A0 VA: 0x180E91CA0 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0xE914B0 Offset: 0xE8FAB0 VA: 0x180E914B0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xE91740 Offset: 0xE8FD40 VA: 0x180E91740 Slot: 6
	internal override object Eval() { }

	// RVA: 0xE91780 Offset: 0xE8FD80 VA: 0x180E91780 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xE916F0 Offset: 0xE8FCF0 VA: 0x180E916F0 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xE91920 Offset: 0xE8FF20 VA: 0x180E91920 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xE91880 Offset: 0xE8FE80 VA: 0x180E91880 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0xE918D0 Offset: 0xE8FED0 VA: 0x180E918D0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xE91680 Offset: 0xE8FC80 VA: 0x180E91680 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0xE91970 Offset: 0xE8FF70 VA: 0x180E91970
	internal static string ParseName(char[] text, int start, int pos) { }

}

