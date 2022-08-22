public sealed class ControlChangeEvent : ChannelEvent // TypeDefIndex: 7523
{	// Properties
	public SevenBitNumber ControlNumber { get; }
	public SevenBitNumber ControlValue { get; }

	// Methods

	// RVA: 0x13975F0 Offset: 0x1395BF0 VA: 0x1813975F0
	public void .ctor() { }

	// RVA: 0x1397610 Offset: 0x1395C10 VA: 0x181397610
	public SevenBitNumber get_ControlNumber() { }

	// RVA: 0x13976B0 Offset: 0x1395CB0 VA: 0x1813976B0
	public SevenBitNumber get_ControlValue() { }

	// RVA: 0x1397400 Offset: 0x1395A00 VA: 0x181397400 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x1397390 Offset: 0x1395990 VA: 0x181397390 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1397450 Offset: 0x1395A50 VA: 0x181397450 Slot: 3
	public override string ToString() { }

}

