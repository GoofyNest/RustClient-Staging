internal sealed class LikeNode : BinaryNode // TypeDefIndex: 4245
{	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0xE8D4B0 Offset: 0xE8BAB0 VA: 0x180E8D4B0
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xE8CB80 Offset: 0xE8B180 VA: 0x180E8CB80 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xE8C800 Offset: 0xE8AE00 VA: 0x180E8C800
	internal string AnalyzePattern(string pat) { }

}

