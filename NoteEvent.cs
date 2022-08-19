public abstract class NoteEvent : ChannelEvent // TypeDefIndex: 7525
{	// Properties
	public SevenBitNumber NoteNumber { get; set; }
	public SevenBitNumber Velocity { get; set; }

	// Methods

	// RVA: 0x13960D0 Offset: 0x13946D0 VA: 0x1813960D0
	protected void .ctor(MidiEventType eventType) { }

	// RVA: 0x13A4000 Offset: 0x13A2600 VA: 0x1813A4000
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x13A4140 Offset: 0x13A2740 VA: 0x1813A4140
	public void set_NoteNumber(SevenBitNumber value) { }

	// RVA: 0x13A40A0 Offset: 0x13A26A0 VA: 0x1813A40A0
	public SevenBitNumber get_Velocity() { }

	// RVA: 0x13A41A0 Offset: 0x13A27A0 VA: 0x1813A41A0
	public void set_Velocity(SevenBitNumber value) { }

	// RVA: 0x1397140 Offset: 0x1395740 VA: 0x181397140 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

}

