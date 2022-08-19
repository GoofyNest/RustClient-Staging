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

	// RVA: 0xB11180 Offset: 0xB0F780 VA: 0x180B11180
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0xB111D0 Offset: 0xB0F7D0 VA: 0x180B111D0
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0xB11220 Offset: 0xB0F820 VA: 0x180B11220
	public Decimal get_Max() { }

	// RVA: 0xB11230 Offset: 0xB0F830 VA: 0x180B11230
	public Decimal get_Min() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public BitSet get_NextIteration() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0xB11140 Offset: 0xB0F740 VA: 0x180B11140 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

}

