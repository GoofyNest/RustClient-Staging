public sealed class SongSelectEvent : SystemCommonEvent // TypeDefIndex: 7564
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SevenBitNumber <Number>k__BackingField; // 0x20

	// Properties
	public SevenBitNumber Number { get; set; }

	// Methods

	// RVA: 0x13A81F0 Offset: 0x13A67F0 VA: 0x1813A81F0
	public void .ctor() { }

	// RVA: 0x13A8210 Offset: 0x13A6810 VA: 0x1813A8210
	public void .ctor(SevenBitNumber number) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public SevenBitNumber get_Number() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_Number(SevenBitNumber value) { }

	// RVA: 0x13A7FF0 Offset: 0x13A65F0 VA: 0x1813A7FF0 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A7F90 Offset: 0x13A6590 VA: 0x1813A7F90 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A8190 Offset: 0x13A6790 VA: 0x1813A8190 Slot: 3
	public override string ToString() { }

}

