internal sealed class HeaderChunk : MidiChunk // TypeDefIndex: 7508
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ushort <FileFormat>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TimeDivision <TimeDivision>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ushort <TracksNumber>k__BackingField; // 0x28

	public ushort FileFormat { get; set; }
	public TimeDivision TimeDivision { get; set; }
	public ushort TracksNumber { get; set; }


	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ushort get_FileFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_FileFormat(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ushort get_TracksNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_TracksNumber(ushort value) { }

	public override string ToString() { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

}

