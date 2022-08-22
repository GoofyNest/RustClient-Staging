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

	// RVA: 0x13A9DA0 Offset: 0x13A83A0 VA: 0x1813A9DA0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106C0 Offset: 0xB0ECC0 VA: 0x180B106C0
	public byte get_Numerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A3A40 Offset: 0x13A2040 VA: 0x1813A3A40
	public void set_Numerator(byte value) { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public byte get_Denominator() { }

	// RVA: 0x13A9DE0 Offset: 0x13A83E0 VA: 0x1813A9DE0
	public void set_Denominator(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106D0 Offset: 0xB0ECD0 VA: 0x180B106D0
	public byte get_ClocksPerClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE302E0 Offset: 0xE2E8E0 VA: 0x180E302E0
	public void set_ClocksPerClick(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A9DD0 Offset: 0x13A83D0 VA: 0x1813A9DD0
	public byte get_ThirtySecondNotesPerBeat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A9F00 Offset: 0x13A8500 VA: 0x1813A9F00
	public void set_ThirtySecondNotesPerBeat(byte value) { }

	// RVA: 0x13A99A0 Offset: 0x13A7FA0 VA: 0x1813A99A0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A9920 Offset: 0x13A7F20 VA: 0x1813A9920 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A9B70 Offset: 0x13A8170 VA: 0x1813A9B70 Slot: 3
	public override string ToString() { }

}

