internal class ISO2022JPDecoder : Decoder // TypeDefIndex: 7806
{	// Fields
	private static JISConvert convert; // 0x0
	private readonly bool allow_shift_io; // 0x20
	private ISO2022JPMode m; // 0x24
	private bool shifted_in_conv; // 0x28
	private bool shifted_in_count; // 0x29

	// Methods

	// RVA: 0x2251A20 Offset: 0x2250020 VA: 0x182251A20
	public void .ctor(bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x22519B0 Offset: 0x224FFB0 VA: 0x1822519B0
	private static void .cctor() { }

	// RVA: 0x22512B0 Offset: 0x224F8B0 VA: 0x1822512B0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22518A0 Offset: 0x224FEA0 VA: 0x1822518A0
	private int ToChar(int value) { }

	// RVA: 0x2251430 Offset: 0x224FA30 VA: 0x182251430 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2251890 Offset: 0x224FE90 VA: 0x182251890 Slot: 4
	public override void Reset() { }

}

