internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 2158
{	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x7B8CB0 Offset: 0x7B72B0 VA: 0x1807B8CB0
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0xB120A0 Offset: 0xB106A0 VA: 0x180B120A0 Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0xB11DA0 Offset: 0xB103A0 VA: 0x180B11DA0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xB11D50 Offset: 0xB10350 VA: 0x180B11D50 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xB120D0 Offset: 0xB106D0 VA: 0x180B120D0 Slot: 6
	public override bool get_IsNullable() { }

}

