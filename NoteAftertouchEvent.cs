public sealed class NoteAftertouchEvent : ChannelEvent // TypeDefIndex: 7524
{	// Properties
	public SevenBitNumber NoteNumber { get; }
	public SevenBitNumber AftertouchValue { get; }

	// Methods

	// RVA: 0x13A3D60 Offset: 0x13A2360 VA: 0x1813A3D60
	public void .ctor() { }

	// RVA: 0x13A3E20 Offset: 0x13A2420 VA: 0x1813A3E20
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x13A3D80 Offset: 0x13A2380 VA: 0x1813A3D80
	public SevenBitNumber get_AftertouchValue() { }

	// RVA: 0x1397140 Offset: 0x1395740 VA: 0x181397140 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A3B50 Offset: 0x13A2150 VA: 0x1813A3B50 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A3BC0 Offset: 0x13A21C0 VA: 0x1813A3BC0 Slot: 3
	public override string ToString() { }

}

