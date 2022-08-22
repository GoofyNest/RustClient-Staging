public abstract class ChannelEvent : MidiEvent // TypeDefIndex: 7515
{	// Fields
	internal byte _dataByte1; // 0x20
	internal byte _dataByte2; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FourBitNumber <Channel>k__BackingField; // 0x22

	// Properties
	public FourBitNumber Channel { get; set; }

	// Methods

	// RVA: 0x1395490 Offset: 0x1393A90 VA: 0x181395490
	protected void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10BA0 Offset: 0xB0F1A0 VA: 0x180B10BA0
	public FourBitNumber get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE30D90 Offset: 0xE2F390 VA: 0x180E30D90
	public void set_Channel(FourBitNumber value) { }

	// RVA: 0x1395C90 Offset: 0x1394290 VA: 0x181395C90
	protected byte ReadDataByte(MidiReader reader, ReadingSettings settings) { }

}

