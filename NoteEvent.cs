public abstract class NoteEvent : ChannelEvent // TypeDefIndex: 7525
{	// Properties
	public SevenBitNumber NoteNumber { get; set; }
	public SevenBitNumber Velocity { get; set; }

	// Methods

	// RVA: 0x1395490 Offset: 0x1393A90 VA: 0x181395490
	protected void .ctor(MidiEventType eventType) { }

	// RVA: 0x13A33C0 Offset: 0x13A19C0 VA: 0x1813A33C0
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x13A3500 Offset: 0x13A1B00 VA: 0x1813A3500
	public void set_NoteNumber(SevenBitNumber value) { }

	// RVA: 0x13A3460 Offset: 0x13A1A60 VA: 0x1813A3460
	public SevenBitNumber get_Velocity() { }

	// RVA: 0x13A3560 Offset: 0x13A1B60 VA: 0x1813A3560
	public void set_Velocity(SevenBitNumber value) { }

	// RVA: 0x1396500 Offset: 0x1394B00 VA: 0x181396500 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

}

