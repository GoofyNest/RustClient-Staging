internal sealed class LikeNode : BinaryNode // TypeDefIndex: 4245
{	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0xE8D1F0 Offset: 0xE8B7F0 VA: 0x180E8D1F0
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xE8C8C0 Offset: 0xE8AEC0 VA: 0x180E8C8C0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xE8C540 Offset: 0xE8AB40 VA: 0x180E8C540
	internal string AnalyzePattern(string pat) { }

}

