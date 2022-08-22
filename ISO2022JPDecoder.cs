internal class ISO2022JPDecoder : Decoder // TypeDefIndex: 7806
{	// Fields
	private static JISConvert convert; // 0x0
	private readonly bool allow_shift_io; // 0x20
	private ISO2022JPMode m; // 0x24
	private bool shifted_in_conv; // 0x28
	private bool shifted_in_count; // 0x29

	// Methods

	// RVA: 0x2251860 Offset: 0x224FE60 VA: 0x182251860
	public void .ctor(bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x22517F0 Offset: 0x224FDF0 VA: 0x1822517F0
	private static void .cctor() { }

	// RVA: 0x22510F0 Offset: 0x224F6F0 VA: 0x1822510F0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22516E0 Offset: 0x224FCE0 VA: 0x1822516E0
	private int ToChar(int value) { }

	// RVA: 0x2251270 Offset: 0x224F870 VA: 0x182251270 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22516D0 Offset: 0x224FCD0 VA: 0x1822516D0 Slot: 4
	public override void Reset() { }

}

