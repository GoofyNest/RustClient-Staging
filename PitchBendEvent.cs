public sealed class PitchBendEvent : ChannelEvent // TypeDefIndex: 7528
{	// Properties
	public ushort PitchValue { get; }

	// Methods

	// RVA: 0x13A4E20 Offset: 0x13A3420 VA: 0x1813A4E20
	public void .ctor() { }

	// RVA: 0x13A4E40 Offset: 0x13A3440 VA: 0x1813A4E40
	public ushort get_PitchValue() { }

	// RVA: 0x1397140 Offset: 0x1395740 VA: 0x181397140 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A4D20 Offset: 0x13A3320 VA: 0x1813A4D20 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A4D90 Offset: 0x13A3390 VA: 0x1813A4D90 Slot: 3
	public override string ToString() { }

}

