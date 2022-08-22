public sealed class SongSelectEvent : SystemCommonEvent // TypeDefIndex: 7564
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SevenBitNumber <Number>k__BackingField; // 0x20

	// Properties
	public SevenBitNumber Number { get; set; }

	// Methods

	// RVA: 0x13A72F0 Offset: 0x13A58F0 VA: 0x1813A72F0
	public void .ctor() { }

	// RVA: 0x13A7310 Offset: 0x13A5910 VA: 0x1813A7310
	public void .ctor(SevenBitNumber number) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public SevenBitNumber get_Number() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_Number(SevenBitNumber value) { }

	// RVA: 0x13A70F0 Offset: 0x13A56F0 VA: 0x1813A70F0 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A7090 Offset: 0x13A5690 VA: 0x1813A7090 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A7290 Offset: 0x13A5890 VA: 0x1813A7290 Slot: 3
	public override string ToString() { }

}

