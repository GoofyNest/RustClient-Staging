internal sealed class LeafRangeNode : LeafNode // TypeDefIndex: 2166
{	// Fields
	private Decimal min; // 0x18
	private Decimal max; // 0x28
	private BitSet nextIteration; // 0x38

	// Properties
	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }
	public override bool IsRangeNode { get; }

	// Methods

	// RVA: 0xB11910 Offset: 0xB0FF10 VA: 0x180B11910
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0xB11960 Offset: 0xB0FF60 VA: 0x180B11960
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0xB119B0 Offset: 0xB0FFB0 VA: 0x180B119B0
	public Decimal get_Max() { }

	// RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0
	public Decimal get_Min() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public BitSet get_NextIteration() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0xB118D0 Offset: 0xB0FED0 VA: 0x180B118D0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

}

