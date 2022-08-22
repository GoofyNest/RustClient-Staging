public sealed class SongPositionPointerEvent : SystemCommonEvent // TypeDefIndex: 7563
{	// Fields
	private SevenBitNumber _lsb; // 0x20
	private SevenBitNumber _msb; // 0x21

	// Properties
	public ushort PointerValue { get; set; }

	// Methods

	// RVA: 0x13A6EC0 Offset: 0x13A54C0 VA: 0x1813A6EC0
	public void .ctor() { }

	// RVA: 0x13A6D60 Offset: 0x13A5360 VA: 0x1813A6D60
	public void .ctor(ushort pointerValue) { }

	// RVA: 0x13A6EE0 Offset: 0x13A54E0 VA: 0x1813A6EE0
	public ushort get_PointerValue() { }

	// RVA: 0x13A6F40 Offset: 0x13A5540 VA: 0x1813A6F40
	public void set_PointerValue(ushort value) { }

	// RVA: 0x13A6A90 Offset: 0x13A5090 VA: 0x1813A6A90
	private SevenBitNumber ProcessValue(byte value, string property, InvalidSystemCommonEventParameterValuePolicy policy) { }

	// RVA: 0x13A6C00 Offset: 0x13A5200 VA: 0x1813A6C00 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A68C0 Offset: 0x13A4EC0 VA: 0x1813A68C0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A6CB0 Offset: 0x13A52B0 VA: 0x1813A6CB0 Slot: 3
	public override string ToString() { }

}

