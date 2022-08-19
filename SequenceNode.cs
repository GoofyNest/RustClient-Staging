internal sealed class SequenceNode : InteriorNode // TypeDefIndex: 2160
{	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0xEEF330 Offset: 0xEED930 VA: 0x180EEF330 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0xEEF7E0 Offset: 0xEEDDE0 VA: 0x180EEF7E0 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0xEEF7D0 Offset: 0xEEDDD0 VA: 0x180EEF7D0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
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

	// RVA: 0x13AF60 Offset: 0x13A360 VA: 0x18013AF60
	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

