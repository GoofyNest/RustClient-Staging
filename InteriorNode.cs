internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 2159
{	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0xB10C20 Offset: 0xB0F220 VA: 0x180B10C20
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xB10DD0 Offset: 0xB0F3D0 VA: 0x180B10DD0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	protected void .ctor() { }

}

