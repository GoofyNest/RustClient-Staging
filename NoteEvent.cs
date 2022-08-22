public abstract class NoteEvent : ChannelEvent // TypeDefIndex: 7525
{	// Properties
	public SevenBitNumber NoteNumber { get; set; }
	public SevenBitNumber Velocity { get; set; }

	// Methods

	// RVA: 0x1396390 Offset: 0x1394990 VA: 0x181396390
	protected void .ctor(MidiEventType eventType) { }

	// RVA: 0x13A42C0 Offset: 0x13A28C0 VA: 0x1813A42C0
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x13A4400 Offset: 0x13A2A00 VA: 0x1813A4400
	public void set_NoteNumber(SevenBitNumber value) { }

	// RVA: 0x13A4360 Offset: 0x13A2960 VA: 0x1813A4360
	public SevenBitNumber get_Velocity() { }

	// RVA: 0x13A4460 Offset: 0x13A2A60 VA: 0x1813A4460
	public void set_Velocity(SevenBitNumber value) { }

	// RVA: 0x1397400 Offset: 0x1395A00 VA: 0x181397400 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

}

