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

	// RVA: 0xB11440 Offset: 0xB0FA40 VA: 0x180B11440
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0xB11490 Offset: 0xB0FA90 VA: 0x180B11490
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0xB114E0 Offset: 0xB0FAE0 VA: 0x180B114E0
	public Decimal get_Max() { }

	// RVA: 0xB114F0 Offset: 0xB0FAF0 VA: 0x180B114F0
	public Decimal get_Min() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public BitSet get_NextIteration() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0xB11400 Offset: 0xB0FA00 VA: 0x180B11400 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

}

