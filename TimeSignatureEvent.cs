public sealed class TimeSignatureEvent : MetaEvent // TypeDefIndex: 7550
{	// Fields
	private byte _denominator; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte <Numerator>k__BackingField; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte <ClocksPerClick>k__BackingField; // 0x22
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte <ThirtySecondNotesPerBeat>k__BackingField; // 0x23

	// Properties
	public byte Numerator { get; set; }
	public byte Denominator { get; set; }
	public byte ClocksPerClick { get; set; }
	public byte ThirtySecondNotesPerBeat { get; set; }

	// Methods

	// RVA: 0x13A9AE0 Offset: 0x13A80E0 VA: 0x1813A9AE0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10400 Offset: 0xB0EA00 VA: 0x180B10400
	public byte get_Numerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A3780 Offset: 0x13A1D80 VA: 0x1813A3780
	public void set_Numerator(byte value) { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public byte get_Denominator() { }

	// RVA: 0x13A9B20 Offset: 0x13A8120 VA: 0x1813A9B20
	public void set_Denominator(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10410 Offset: 0xB0EA10 VA: 0x180B10410
	public byte get_ClocksPerClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE30020 Offset: 0xE2E620 VA: 0x180E30020
	public void set_ClocksPerClick(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A9B10 Offset: 0x13A8110 VA: 0x1813A9B10
	public byte get_ThirtySecondNotesPerBeat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A9C40 Offset: 0x13A8240 VA: 0x1813A9C40
	public void set_ThirtySecondNotesPerBeat(byte value) { }

	// RVA: 0x13A96E0 Offset: 0x13A7CE0 VA: 0x1813A96E0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A9660 Offset: 0x13A7C60 VA: 0x1813A9660 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A98B0 Offset: 0x13A7EB0 VA: 0x1813A98B0 Slot: 3
	public override string ToString() { }

}

