public sealed class ChannelPrefixEvent : MetaEvent // TypeDefIndex: 7532
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private byte <Channel>k__BackingField; // 0x20

	public byte Channel { get; set; }


	public void .ctor() { }

	public void .ctor(byte channel) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public byte get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_Channel(byte value) { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

