internal class Operand : AstNode // TypeDefIndex: 1795
{	// Fields
	private XPathResultType type; // 0x10
	private object val; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x12FACC0 Offset: 0x12F92C0 VA: 0x1812FACC0
	public void .ctor(string val) { }

	// RVA: 0x12FAD00 Offset: 0x12F9300 VA: 0x1812FAD00
	public void .ctor(double val) { }

	// RVA: 0xAC2530 Offset: 0xAC0B30 VA: 0x180AC2530 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

