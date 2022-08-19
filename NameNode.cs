internal sealed class NameNode : ExpressionNode // TypeDefIndex: 4264
{	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0xE90EE0 Offset: 0xE8F4E0 VA: 0x180E90EE0
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0xE90EA0 Offset: 0xE8F4A0 VA: 0x180E90EA0
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xE90F30 Offset: 0xE8F530 VA: 0x180E90F30 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0xE90740 Offset: 0xE8ED40 VA: 0x180E90740 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xE909D0 Offset: 0xE8EFD0 VA: 0x180E909D0 Slot: 6
	internal override object Eval() { }

	// RVA: 0xE90A10 Offset: 0xE8F010 VA: 0x180E90A10 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xE90980 Offset: 0xE8EF80 VA: 0x180E90980 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xE90BB0 Offset: 0xE8F1B0 VA: 0x180E90BB0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xE90B10 Offset: 0xE8F110 VA: 0x180E90B10 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0xE90B60 Offset: 0xE8F160 VA: 0x180E90B60 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xE90910 Offset: 0xE8EF10 VA: 0x180E90910 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0xE90C00 Offset: 0xE8F200 VA: 0x180E90C00
	internal static string ParseName(char[] text, int start, int pos) { }

}

