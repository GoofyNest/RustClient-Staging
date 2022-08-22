internal class ISO2022JPDecoder : Decoder // TypeDefIndex: 7806
{	// Fields
	private static JISConvert convert; // 0x0
	private readonly bool allow_shift_io; // 0x20
	private ISO2022JPMode m; // 0x24
	private bool shifted_in_conv; // 0x28
	private bool shifted_in_count; // 0x29

	// Methods

	// RVA: 0x2252340 Offset: 0x2250940 VA: 0x182252340
	public void .ctor(bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x22522D0 Offset: 0x22508D0 VA: 0x1822522D0
	private static void .cctor() { }

	// RVA: 0x2251BD0 Offset: 0x22501D0 VA: 0x182251BD0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22521C0 Offset: 0x22507C0 VA: 0x1822521C0
	private int ToChar(int value) { }

	// RVA: 0x2251D50 Offset: 0x2250350 VA: 0x182251D50 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22521B0 Offset: 0x22507B0 VA: 0x1822521B0 Slot: 4
	public override void Reset() { }

}

