internal class ISO2022JPDecoder : Decoder // TypeDefIndex: 7806
{	// Fields
	private static JISConvert convert; // 0x0
	private readonly bool allow_shift_io; // 0x20
	private ISO2022JPMode m; // 0x24
	private bool shifted_in_conv; // 0x28
	private bool shifted_in_count; // 0x29

	// Methods

	// RVA: 0x2251B20 Offset: 0x2250120 VA: 0x182251B20
	public void .ctor(bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x2251AB0 Offset: 0x22500B0 VA: 0x182251AB0
	private static void .cctor() { }

	// RVA: 0x22513B0 Offset: 0x224F9B0 VA: 0x1822513B0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22519A0 Offset: 0x224FFA0 VA: 0x1822519A0
	private int ToChar(int value) { }

	// RVA: 0x2251530 Offset: 0x224FB30 VA: 0x182251530 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2251990 Offset: 0x224FF90 VA: 0x182251990 Slot: 4
	public override void Reset() { }

}

