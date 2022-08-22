public sealed class PitchBendEvent : ChannelEvent // TypeDefIndex: 7528
{	// Properties
	public ushort PitchValue { get; }

	// Methods

	// RVA: 0x13A50E0 Offset: 0x13A36E0 VA: 0x1813A50E0
	public void .ctor() { }

	// RVA: 0x13A5100 Offset: 0x13A3700 VA: 0x1813A5100
	public ushort get_PitchValue() { }

	// RVA: 0x1397400 Offset: 0x1395A00 VA: 0x181397400 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A4FE0 Offset: 0x13A35E0 VA: 0x1813A4FE0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A5050 Offset: 0x13A3650 VA: 0x1813A5050 Slot: 3
	public override string ToString() { }

}

