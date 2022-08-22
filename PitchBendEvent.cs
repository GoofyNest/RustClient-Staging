public sealed class PitchBendEvent : ChannelEvent // TypeDefIndex: 7528
{	// Properties
	public ushort PitchValue { get; }

	// Methods

	// RVA: 0x13A41E0 Offset: 0x13A27E0 VA: 0x1813A41E0
	public void .ctor() { }

	// RVA: 0x13A4200 Offset: 0x13A2800 VA: 0x1813A4200
	public ushort get_PitchValue() { }

	// RVA: 0x1396500 Offset: 0x1394B00 VA: 0x181396500 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A40E0 Offset: 0x13A26E0 VA: 0x1813A40E0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A4150 Offset: 0x13A2750 VA: 0x1813A4150 Slot: 3
	public override string ToString() { }

}

