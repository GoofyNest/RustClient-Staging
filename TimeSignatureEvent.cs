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

	// RVA: 0x13A8EA0 Offset: 0x13A74A0 VA: 0x1813A8EA0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10B90 Offset: 0xB0F190 VA: 0x180B10B90
	public byte get_Numerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A2B40 Offset: 0x13A1140 VA: 0x1813A2B40
	public void set_Numerator(byte value) { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public byte get_Denominator() { }

	// RVA: 0x13A8EE0 Offset: 0x13A74E0 VA: 0x1813A8EE0
	public void set_Denominator(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10BA0 Offset: 0xB0F1A0 VA: 0x180B10BA0
	public byte get_ClocksPerClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE30D90 Offset: 0xE2F390 VA: 0x180E30D90
	public void set_ClocksPerClick(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A8ED0 Offset: 0x13A74D0 VA: 0x1813A8ED0
	public byte get_ThirtySecondNotesPerBeat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A9000 Offset: 0x13A7600 VA: 0x1813A9000
	public void set_ThirtySecondNotesPerBeat(byte value) { }

	// RVA: 0x13A8AA0 Offset: 0x13A70A0 VA: 0x1813A8AA0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A8A20 Offset: 0x13A7020 VA: 0x1813A8A20 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A8C70 Offset: 0x13A7270 VA: 0x1813A8C70 Slot: 3
	public override string ToString() { }

}

