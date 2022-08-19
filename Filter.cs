internal class Filter : AstNode // TypeDefIndex: 1791
{	// Fields
	private AstNode input; // 0x10
	private AstNode condition; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xAC1DA0 Offset: 0xAC03A0 VA: 0x180AC1DA0 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

