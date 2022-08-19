public sealed class SetTempoEvent : MetaEvent // TypeDefIndex: 7546
{	// Fields
	private long _microsecondsPerBeat; // 0x20

	// Properties
	public long MicrosecondsPerQuarterNote { get; set; }

	// Methods

	// RVA: 0x13A5B90 Offset: 0x13A4190 VA: 0x1813A5B90
	public void .ctor() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public long get_MicrosecondsPerQuarterNote() { }

	// RVA: 0x13A5BC0 Offset: 0x13A41C0 VA: 0x1813A5BC0
	public void set_MicrosecondsPerQuarterNote(long value) { }

	// RVA: 0x13A5960 Offset: 0x13A3F60 VA: 0x1813A5960 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A58F0 Offset: 0x13A3EF0 VA: 0x1813A58F0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A5B30 Offset: 0x13A4130 VA: 0x1813A5B30 Slot: 3
	public override string ToString() { }

}

