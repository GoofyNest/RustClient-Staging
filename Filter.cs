internal class Filter : AstNode // TypeDefIndex: 1791
{	// Fields
	private AstNode input; // 0x10
	private AstNode condition; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xAC2530 Offset: 0xAC0B30 VA: 0x180AC2530 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

