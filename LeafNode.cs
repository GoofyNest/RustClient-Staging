internal class LeafNode : SyntaxTreeNode // TypeDefIndex: 2157
{	// Fields
	private int pos; // 0x10

	// Properties
	public int Pos { get; set; }
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0xB118A0 Offset: 0xB0FEA0 VA: 0x180B118A0
	public void .ctor(int pos) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Pos() { }

	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	public void set_Pos(int value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xB11850 Offset: 0xB0FE50 VA: 0x180B11850 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 6
	public override bool get_IsNullable() { }

}

