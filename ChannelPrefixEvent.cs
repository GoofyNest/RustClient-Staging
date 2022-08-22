public sealed class ChannelPrefixEvent : MetaEvent // TypeDefIndex: 7532
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte <Channel>k__BackingField; // 0x20

	// Properties
	public byte Channel { get; set; }

	// Methods

	// RVA: 0x1396DE0 Offset: 0x13953E0 VA: 0x181396DE0
	public void .ctor() { }

	// RVA: 0x1396E00 Offset: 0x1395400 VA: 0x181396E00
	public void .ctor(byte channel) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public byte get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_Channel(byte value) { }

	// RVA: 0x1396D50 Offset: 0x1395350 VA: 0x181396D50 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x1396CF0 Offset: 0x13952F0 VA: 0x181396CF0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1396D80 Offset: 0x1395380 VA: 0x181396D80 Slot: 3
	public override string ToString() { }

}

