internal class Variable : AstNode // TypeDefIndex: 1799
{	// Fields
	private string localname; // 0x10
	private string prefix; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string name, string prefix) { }

	// RVA: 0xB9F990 Offset: 0xB9DF90 VA: 0x180B9F990 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x6F3500 Offset: 0x6F1B00 VA: 0x1806F3500 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

