internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 2159
{	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0xB10490 Offset: 0xB0EA90 VA: 0x180B10490
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xB10640 Offset: 0xB0EC40 VA: 0x180B10640 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	protected void .ctor() { }

}

