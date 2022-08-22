internal class Variable : AstNode // TypeDefIndex: 1799
{	// Fields
	private string localname; // 0x10
	private string prefix; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(string name, string prefix) { }

	// RVA: 0xBA0120 Offset: 0xB9E720 VA: 0x180BA0120 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x6F35A0 Offset: 0x6F1BA0 VA: 0x1806F35A0 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

