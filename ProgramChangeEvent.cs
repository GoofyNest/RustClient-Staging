public sealed class ProgramChangeEvent : ChannelEvent // TypeDefIndex: 7529
{	// Properties
	public SevenBitNumber ProgramNumber { get; }

	// Methods

	// RVA: 0x13A53C0 Offset: 0x13A39C0 VA: 0x1813A53C0
	public void .ctor() { }

	// RVA: 0x13A53E0 Offset: 0x13A39E0 VA: 0x1813A53E0
	public SevenBitNumber get_ProgramNumber() { }

	// RVA: 0x1396470 Offset: 0x1394A70 VA: 0x181396470 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A5250 Offset: 0x13A3850 VA: 0x1813A5250 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A52C0 Offset: 0x13A38C0 VA: 0x1813A52C0 Slot: 3
	public override string ToString() { }

}

