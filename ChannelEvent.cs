public abstract class ChannelEvent : MidiEvent // TypeDefIndex: 7515
{	// Fields
	internal byte _dataByte1; // 0x20
	internal byte _dataByte2; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FourBitNumber <Channel>k__BackingField; // 0x22

	// Properties
	public FourBitNumber Channel { get; set; }

	// Methods

	// RVA: 0x13960D0 Offset: 0x13946D0 VA: 0x1813960D0
	protected void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10410 Offset: 0xB0EA10 VA: 0x180B10410
	public FourBitNumber get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE30020 Offset: 0xE2E620 VA: 0x180E30020
	public void set_Channel(FourBitNumber value) { }

	// RVA: 0x13968D0 Offset: 0x1394ED0 VA: 0x1813968D0
	protected byte ReadDataByte(MidiReader reader, ReadingSettings settings) { }

}

