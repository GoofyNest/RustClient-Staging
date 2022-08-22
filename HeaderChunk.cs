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

	// RVA: 0x1399330 Offset: 0x1397930 VA: 0x181399330
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1399370 Offset: 0x1397970 VA: 0x181399370
	public ushort get_FileFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1399390 Offset: 0x1397990 VA: 0x181399390
	public void set_FileFormat(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1399380 Offset: 0x1397980 VA: 0x181399380
	public ushort get_TracksNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13993A0 Offset: 0x13979A0 VA: 0x1813993A0
	public void set_TracksNumber(ushort value) { }

	// RVA: 0x1399290 Offset: 0x1397890 VA: 0x181399290 Slot: 3
	public override string ToString() { }

	// RVA: 0x1398F80 Offset: 0x1397580 VA: 0x181398F80 Slot: 4
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

}

