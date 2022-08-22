public abstract class ChannelEvent : MidiEvent // TypeDefIndex: 7515
{	// Fields
	internal byte _dataByte1; // 0x20
	internal byte _dataByte2; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FourBitNumber <Channel>k__BackingField; // 0x22

	// Properties
	public FourBitNumber Channel { get; set; }

	// Methods

	// RVA: 0x1396390 Offset: 0x1394990 VA: 0x181396390
	protected void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106D0 Offset: 0xB0ECD0 VA: 0x180B106D0
	public FourBitNumber get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE302E0 Offset: 0xE2E8E0 VA: 0x180E302E0
	public void set_Channel(FourBitNumber value) { }

	// RVA: 0x1396B90 Offset: 0x1395190 VA: 0x181396B90
	protected byte ReadDataByte(MidiReader reader, ReadingSettings settings) { }

}

