public sealed class SongPositionPointerEvent : SystemCommonEvent // TypeDefIndex: 7563
{	// Fields
	private SevenBitNumber _lsb; // 0x20
	private SevenBitNumber _msb; // 0x21

	// Properties
	public ushort PointerValue { get; set; }

	// Methods

	// RVA: 0x13A7B00 Offset: 0x13A6100 VA: 0x1813A7B00
	public void .ctor() { }

	// RVA: 0x13A79A0 Offset: 0x13A5FA0 VA: 0x1813A79A0
	public void .ctor(ushort pointerValue) { }

	// RVA: 0x13A7B20 Offset: 0x13A6120 VA: 0x1813A7B20
	public ushort get_PointerValue() { }

	// RVA: 0x13A7B80 Offset: 0x13A6180 VA: 0x1813A7B80
	public void set_PointerValue(ushort value) { }

	// RVA: 0x13A76D0 Offset: 0x13A5CD0 VA: 0x1813A76D0
	private SevenBitNumber ProcessValue(byte value, string property, InvalidSystemCommonEventParameterValuePolicy policy) { }

	// RVA: 0x13A7840 Offset: 0x13A5E40 VA: 0x1813A7840 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A7500 Offset: 0x13A5B00 VA: 0x1813A7500 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A78F0 Offset: 0x13A5EF0 VA: 0x1813A78F0 Slot: 3
	public override string ToString() { }

}

