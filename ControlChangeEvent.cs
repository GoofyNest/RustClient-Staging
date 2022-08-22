public sealed class ControlChangeEvent : ChannelEvent // TypeDefIndex: 7523
{	// Properties
	public SevenBitNumber ControlNumber { get; }
	public SevenBitNumber ControlValue { get; }

	// Methods

	// RVA: 0x13966F0 Offset: 0x1394CF0 VA: 0x1813966F0
	public void .ctor() { }

	// RVA: 0x1396710 Offset: 0x1394D10 VA: 0x181396710
	public SevenBitNumber get_ControlNumber() { }

	// RVA: 0x13967B0 Offset: 0x1394DB0 VA: 0x1813967B0
	public SevenBitNumber get_ControlValue() { }

	// RVA: 0x1396500 Offset: 0x1394B00 VA: 0x181396500 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x1396490 Offset: 0x1394A90 VA: 0x181396490 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1396550 Offset: 0x1394B50 VA: 0x181396550 Slot: 3
	public override string ToString() { }

}

