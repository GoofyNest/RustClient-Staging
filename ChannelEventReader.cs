internal sealed class ChannelEventReader : IEventReader // TypeDefIndex: 7552
{	// Methods

	// RVA: 0x1396840 Offset: 0x1394E40 VA: 0x181396840 Slot: 4
	public MidiEvent Read(MidiReader reader, ReadingSettings settings, byte currentStatusByte) { }

	// RVA: 0x1396650 Offset: 0x1394C50 VA: 0x181396650
	private void ReactOnUnknownChannelEvent(FourBitNumber statusByte, FourBitNumber channel, MidiReader reader, ReadingSettings settings) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

