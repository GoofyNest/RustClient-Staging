internal sealed class NameNode : ExpressionNode // TypeDefIndex: 4264
{	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0xE911A0 Offset: 0xE8F7A0 VA: 0x180E911A0
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0xE91160 Offset: 0xE8F760 VA: 0x180E91160
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xE911F0 Offset: 0xE8F7F0 VA: 0x180E911F0 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0xE90A00 Offset: 0xE8F000 VA: 0x180E90A00 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xE90C90 Offset: 0xE8F290 VA: 0x180E90C90 Slot: 6
	internal override object Eval() { }

	// RVA: 0xE90CD0 Offset: 0xE8F2D0 VA: 0x180E90CD0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xE90C40 Offset: 0xE8F240 VA: 0x180E90C40 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xE90E70 Offset: 0xE8F470 VA: 0x180E90E70 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xE90DD0 Offset: 0xE8F3D0 VA: 0x180E90DD0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0xE90E20 Offset: 0xE8F420 VA: 0x180E90E20 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xE90BD0 Offset: 0xE8F1D0 VA: 0x180E90BD0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0xE90EC0 Offset: 0xE8F4C0 VA: 0x180E90EC0
	internal static string ParseName(char[] text, int start, int pos) { }

}

