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

	// RVA: 0x2252FA0 Offset: 0x22515A0 VA: 0x182252FA0
	public void .ctor(MonoEncoding owner, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x2252EF0 Offset: 0x22514F0 VA: 0x182252EF0
	private static void .cctor() { }

	// RVA: 0x2252370 Offset: 0x2250970 VA: 0x182252370 Slot: 11
	public override int GetByteCountImpl(char* chars, int charCount, bool flush) { }

	// RVA: 0x2252E10 Offset: 0x2251410 VA: 0x182252E10
	private void SwitchMode(byte* bytes, ref int byteIndex, ref int byteCount, ref ISO2022JPMode cur, ISO2022JPMode next) { }

	// RVA: 0x2252700 Offset: 0x2250D00 VA: 0x182252700 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x2252E00 Offset: 0x2251400 VA: 0x182252E00 Slot: 4
	public override void Reset() { }

}

