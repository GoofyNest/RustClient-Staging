public sealed class ChannelPrefixEvent : MetaEvent // TypeDefIndex: 7532
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte <Channel>k__BackingField; // 0x20

	// Properties
	public byte Channel { get; set; }

	// Methods

	// RVA: 0x1395EE0 Offset: 0x13944E0 VA: 0x181395EE0
	public void .ctor() { }

	// RVA: 0x1395F00 Offset: 0x1394500 VA: 0x181395F00
	public void .ctor(byte channel) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public byte get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_Channel(byte value) { }

	// RVA: 0x1395E50 Offset: 0x1394450 VA: 0x181395E50 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x1395DF0 Offset: 0x13943F0 VA: 0x181395DF0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1395E80 Offset: 0x1394480 VA: 0x181395E80 Slot: 3
	public override string ToString() { }

}

