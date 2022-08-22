public sealed class SongPositionPointerEvent : SystemCommonEvent // TypeDefIndex: 7563
{	// Fields
	private SevenBitNumber _lsb; // 0x20
	private SevenBitNumber _msb; // 0x21

	// Properties
	public ushort PointerValue { get; set; }

	// Methods

	// RVA: 0x13A7DC0 Offset: 0x13A63C0 VA: 0x1813A7DC0
	public void .ctor() { }

	// RVA: 0x13A7C60 Offset: 0x13A6260 VA: 0x1813A7C60
	public void .ctor(ushort pointerValue) { }

	// RVA: 0x13A7DE0 Offset: 0x13A63E0 VA: 0x1813A7DE0
	public ushort get_PointerValue() { }

	// RVA: 0x13A7E40 Offset: 0x13A6440 VA: 0x1813A7E40
	public void set_PointerValue(ushort value) { }

	// RVA: 0x13A7990 Offset: 0x13A5F90 VA: 0x1813A7990
	private SevenBitNumber ProcessValue(byte value, string property, InvalidSystemCommonEventParameterValuePolicy policy) { }

	// RVA: 0x13A7B00 Offset: 0x13A6100 VA: 0x1813A7B00 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A77C0 Offset: 0x13A5DC0 VA: 0x1813A77C0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A7BB0 Offset: 0x13A61B0 VA: 0x1813A7BB0 Slot: 3
	public override string ToString() { }

}

