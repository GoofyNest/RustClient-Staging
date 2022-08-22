internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 2158
{	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x7ED390 Offset: 0x7EB990 VA: 0x1807ED390
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0xB11BD0 Offset: 0xB101D0 VA: 0x180B11BD0 Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0xB118D0 Offset: 0xB0FED0 VA: 0x180B118D0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xB11880 Offset: 0xB0FE80 VA: 0x180B11880 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xB11C00 Offset: 0xB10200 VA: 0x180B11C00 Slot: 6
	public override bool get_IsNullable() { }

}

