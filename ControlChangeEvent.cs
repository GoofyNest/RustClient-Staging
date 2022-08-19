public sealed class ControlChangeEvent : ChannelEvent // TypeDefIndex: 7523
{	// Properties
	public SevenBitNumber ControlNumber { get; }
	public SevenBitNumber ControlValue { get; }

	// Methods

	// RVA: 0x1397330 Offset: 0x1395930 VA: 0x181397330
	public void .ctor() { }

	// RVA: 0x1397350 Offset: 0x1395950 VA: 0x181397350
	public SevenBitNumber get_ControlNumber() { }

	// RVA: 0x13973F0 Offset: 0x13959F0 VA: 0x1813973F0
	public SevenBitNumber get_ControlValue() { }

	// RVA: 0x1397140 Offset: 0x1395740 VA: 0x181397140 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13970D0 Offset: 0x13956D0 VA: 0x1813970D0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1397190 Offset: 0x1395790 VA: 0x181397190 Slot: 3
	public override string ToString() { }

}

