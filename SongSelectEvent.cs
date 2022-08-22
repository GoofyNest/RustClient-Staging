public sealed class SongSelectEvent : SystemCommonEvent // TypeDefIndex: 7564
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SevenBitNumber <Number>k__BackingField; // 0x20

	// Properties
	public SevenBitNumber Number { get; set; }

	// Methods

	// RVA: 0x13A7F30 Offset: 0x13A6530 VA: 0x1813A7F30
	public void .ctor() { }

	// RVA: 0x13A7F50 Offset: 0x13A6550 VA: 0x1813A7F50
	public void .ctor(SevenBitNumber number) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public SevenBitNumber get_Number() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void set_Number(SevenBitNumber value) { }

	// RVA: 0x13A7D30 Offset: 0x13A6330 VA: 0x1813A7D30 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A7CD0 Offset: 0x13A62D0 VA: 0x1813A7CD0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A7ED0 Offset: 0x13A64D0 VA: 0x1813A7ED0 Slot: 3
	public override string ToString() { }

}

