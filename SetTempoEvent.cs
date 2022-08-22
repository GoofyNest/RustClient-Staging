public sealed class SetTempoEvent : MetaEvent // TypeDefIndex: 7546
{	// Fields
	private long _microsecondsPerBeat; // 0x20

	// Properties
	public long MicrosecondsPerQuarterNote { get; set; }

	// Methods

	// RVA: 0x13A5E50 Offset: 0x13A4450 VA: 0x1813A5E50
	public void .ctor() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public long get_MicrosecondsPerQuarterNote() { }

	// RVA: 0x13A5E80 Offset: 0x13A4480 VA: 0x1813A5E80
	public void set_MicrosecondsPerQuarterNote(long value) { }

	// RVA: 0x13A5C20 Offset: 0x13A4220 VA: 0x1813A5C20 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A5BB0 Offset: 0x13A41B0 VA: 0x1813A5BB0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A5DF0 Offset: 0x13A43F0 VA: 0x1813A5DF0 Slot: 3
	public override string ToString() { }

}

