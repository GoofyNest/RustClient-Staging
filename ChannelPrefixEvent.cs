public sealed class ChannelPrefixEvent : MetaEvent // TypeDefIndex: 7532
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte <Channel>k__BackingField; // 0x20

	// Properties
	public byte Channel { get; set; }

	// Methods

	// RVA: 0x1396B20 Offset: 0x1395120 VA: 0x181396B20
	public void .ctor() { }

	// RVA: 0x1396B40 Offset: 0x1395140 VA: 0x181396B40
	public void .ctor(byte channel) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public byte get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void set_Channel(byte value) { }

	// RVA: 0x1396A90 Offset: 0x1395090 VA: 0x181396A90 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x1396A30 Offset: 0x1395030 VA: 0x181396A30 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1396AC0 Offset: 0x13950C0 VA: 0x181396AC0 Slot: 3
	public override string ToString() { }

}

