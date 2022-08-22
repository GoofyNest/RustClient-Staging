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

	// RVA: 0x1398430 Offset: 0x1396A30 VA: 0x181398430
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1398470 Offset: 0x1396A70 VA: 0x181398470
	public ushort get_FileFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1398490 Offset: 0x1396A90 VA: 0x181398490
	public void set_FileFormat(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1398480 Offset: 0x1396A80 VA: 0x181398480
	public ushort get_TracksNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13984A0 Offset: 0x1396AA0 VA: 0x1813984A0
	public void set_TracksNumber(ushort value) { }

	// RVA: 0x1398390 Offset: 0x1396990 VA: 0x181398390 Slot: 3
	public override string ToString() { }

	// RVA: 0x1398080 Offset: 0x1396680 VA: 0x181398080 Slot: 4
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

}

