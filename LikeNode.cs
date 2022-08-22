internal sealed class LikeNode : BinaryNode // TypeDefIndex: 4245
{	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0xE8DF60 Offset: 0xE8C560 VA: 0x180E8DF60
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xE8D630 Offset: 0xE8BC30 VA: 0x180E8D630 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xE8D2B0 Offset: 0xE8B8B0 VA: 0x180E8D2B0
	internal string AnalyzePattern(string pat) { }

}

