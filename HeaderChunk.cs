internal sealed class HeaderChunk : MidiChunk // TypeDefIndex: 7508
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ushort <FileFormat>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TimeDivision <TimeDivision>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ushort <TracksNumber>k__BackingField; // 0x28

	// Properties
	public ushort FileFormat { get; set; }
	public TimeDivision TimeDivision { get; set; }
	public ushort TracksNumber { get; set; }

	// Methods

	// RVA: 0x1399070 Offset: 0x1397670 VA: 0x181399070
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13990B0 Offset: 0x13976B0 VA: 0x1813990B0
	public ushort get_FileFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13990D0 Offset: 0x13976D0 VA: 0x1813990D0
	public void set_FileFormat(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13990C0 Offset: 0x13976C0 VA: 0x1813990C0
	public ushort get_TracksNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13990E0 Offset: 0x13976E0 VA: 0x1813990E0
	public void set_TracksNumber(ushort value) { }

	// RVA: 0x1398FD0 Offset: 0x13975D0 VA: 0x181398FD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1398CC0 Offset: 0x13972C0 VA: 0x181398CC0 Slot: 4
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

}

