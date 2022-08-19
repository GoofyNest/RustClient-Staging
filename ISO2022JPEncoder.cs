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

	// RVA: 0x2252680 Offset: 0x2250C80 VA: 0x182252680
	public void .ctor(MonoEncoding owner, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x22525D0 Offset: 0x2250BD0 VA: 0x1822525D0
	private static void .cctor() { }

	// RVA: 0x2251A50 Offset: 0x2250050 VA: 0x182251A50 Slot: 11
	public override int GetByteCountImpl(char* chars, int charCount, bool flush) { }

	// RVA: 0x22524F0 Offset: 0x2250AF0 VA: 0x1822524F0
	private void SwitchMode(byte* bytes, ref int byteIndex, ref int byteCount, ref ISO2022JPMode cur, ISO2022JPMode next) { }

	// RVA: 0x2251DE0 Offset: 0x22503E0 VA: 0x182251DE0 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x22524E0 Offset: 0x2250AE0 VA: 0x1822524E0 Slot: 4
	public override void Reset() { }

}

