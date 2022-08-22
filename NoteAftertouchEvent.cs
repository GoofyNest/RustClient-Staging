public sealed class NoteAftertouchEvent : ChannelEvent // TypeDefIndex: 7524
{	// Properties
	public SevenBitNumber NoteNumber { get; }
	public SevenBitNumber AftertouchValue { get; }

	// Methods

	// RVA: 0x13A3120 Offset: 0x13A1720 VA: 0x1813A3120
	public void .ctor() { }

	// RVA: 0x13A31E0 Offset: 0x13A17E0 VA: 0x1813A31E0
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x13A3140 Offset: 0x13A1740 VA: 0x1813A3140
	public SevenBitNumber get_AftertouchValue() { }

	// RVA: 0x1396500 Offset: 0x1394B00 VA: 0x181396500 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A2F10 Offset: 0x13A1510 VA: 0x1813A2F10 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A2F80 Offset: 0x13A1580 VA: 0x1813A2F80 Slot: 3
	public override string ToString() { }

}

