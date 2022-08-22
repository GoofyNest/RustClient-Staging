internal sealed class SequenceNode : InteriorNode // TypeDefIndex: 2160
{	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0xEF00A0 Offset: 0xEEE6A0 VA: 0x180EF00A0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xEF0550 Offset: 0xEEEB50 VA: 0x180EF0550 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0xEF0540 Offset: 0xEEEB40 VA: 0x180EF0540 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x5177F0 Offset: 0x515DF0 VA: 0x1805177F0
	public void .ctor() { }

}

private struct SequenceNode.SequenceConstructPosContext // TypeDefIndex: 2161
{	// Fields
	public SequenceNode this_; // 0x0
	public BitSet firstpos; // 0x8
	public BitSet lastpos; // 0x10
	public BitSet lastposLeft; // 0x18
	public BitSet firstposRight; // 0x20

	// Methods

	// RVA: 0x13AD00 Offset: 0x13A100 VA: 0x18013AD00
	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

