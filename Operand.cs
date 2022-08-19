internal class Operand : AstNode // TypeDefIndex: 1795
{	// Fields
	private XPathResultType type; // 0x10
	private object val; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x12F4550 Offset: 0x12F2B50 VA: 0x1812F4550
	public void .ctor(string val) { }

	// RVA: 0x12F4590 Offset: 0x12F2B90 VA: 0x1812F4590
	public void .ctor(double val) { }

	// RVA: 0xAC1DA0 Offset: 0xAC03A0 VA: 0x180AC1DA0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

