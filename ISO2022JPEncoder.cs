internal class ISO2022JPEncoder : MonoEncoder // TypeDefIndex: 7805
{	// Fields
	private static JISConvert convert; // 0x0
	private readonly bool allow_1byte_kana; // 0x28
	private readonly bool allow_shift_io; // 0x29
	private ISO2022JPMode m; // 0x2C
	private bool shifted_in_count; // 0x30
	private bool shifted_in_conv; // 0x31
	private static readonly char[] full_width_map; // 0x8

	// Methods

	// RVA: 0x22524C0 Offset: 0x2250AC0 VA: 0x1822524C0
	public void .ctor(MonoEncoding owner, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x2252410 Offset: 0x2250A10 VA: 0x182252410
	private static void .cctor() { }

	// RVA: 0x2251890 Offset: 0x224FE90 VA: 0x182251890 Slot: 11
	public override int GetByteCountImpl(char* chars, int charCount, bool flush) { }

	// RVA: 0x2252330 Offset: 0x2250930 VA: 0x182252330
	private void SwitchMode(byte* bytes, ref int byteIndex, ref int byteCount, ref ISO2022JPMode cur, ISO2022JPMode next) { }

	// RVA: 0x2251C20 Offset: 0x2250220 VA: 0x182251C20 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x2252320 Offset: 0x2250920 VA: 0x182252320 Slot: 4
	public override void Reset() { }

}

