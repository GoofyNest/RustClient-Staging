public sealed class SetTempoEvent : MetaEvent // TypeDefIndex: 7546
{	// Fields
	private long _microsecondsPerBeat; // 0x20

	// Properties
	public long MicrosecondsPerQuarterNote { get; set; }

	// Methods

	// RVA: 0x13A4F50 Offset: 0x13A3550 VA: 0x1813A4F50
	public void .ctor() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public long get_MicrosecondsPerQuarterNote() { }

	// RVA: 0x13A4F80 Offset: 0x13A3580 VA: 0x1813A4F80
	public void set_MicrosecondsPerQuarterNote(long value) { }

	// RVA: 0x13A4D20 Offset: 0x13A3320 VA: 0x1813A4D20 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A4CB0 Offset: 0x13A32B0 VA: 0x1813A4CB0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A4EF0 Offset: 0x13A34F0 VA: 0x1813A4EF0 Slot: 3
	public override string ToString() { }

}

