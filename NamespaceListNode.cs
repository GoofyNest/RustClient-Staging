internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 2158
{	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x7ED280 Offset: 0x7EB880 VA: 0x1807ED280
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0xB11910 Offset: 0xB0FF10 VA: 0x180B11910 Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0xB11610 Offset: 0xB0FC10 VA: 0x180B11610 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xB115C0 Offset: 0xB0FBC0 VA: 0x180B115C0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xB11940 Offset: 0xB0FF40 VA: 0x180B11940 Slot: 6
	public override bool get_IsNullable() { }

}

