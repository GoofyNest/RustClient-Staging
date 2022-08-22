public sealed class NoteAftertouchEvent : ChannelEvent // TypeDefIndex: 7524
{	// Properties
	public SevenBitNumber NoteNumber { get; }
	public SevenBitNumber AftertouchValue { get; }

	// Methods

	// RVA: 0x13A4020 Offset: 0x13A2620 VA: 0x1813A4020
	public void .ctor() { }

	// RVA: 0x13A40E0 Offset: 0x13A26E0 VA: 0x1813A40E0
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x13A4040 Offset: 0x13A2640 VA: 0x1813A4040
	public SevenBitNumber get_AftertouchValue() { }

	// RVA: 0x1397400 Offset: 0x1395A00 VA: 0x181397400 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A3E10 Offset: 0x13A2410 VA: 0x1813A3E10 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A3E80 Offset: 0x13A2480 VA: 0x1813A3E80 Slot: 3
	public override string ToString() { }

}

