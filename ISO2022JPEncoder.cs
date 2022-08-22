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

	// RVA: 0x2252780 Offset: 0x2250D80 VA: 0x182252780
	public void .ctor(MonoEncoding owner, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x22526D0 Offset: 0x2250CD0 VA: 0x1822526D0
	private static void .cctor() { }

	// RVA: 0x2251B50 Offset: 0x2250150 VA: 0x182251B50 Slot: 11
	public override int GetByteCountImpl(char* chars, int charCount, bool flush) { }

	// RVA: 0x22525F0 Offset: 0x2250BF0 VA: 0x1822525F0
	private void SwitchMode(byte* bytes, ref int byteIndex, ref int byteCount, ref ISO2022JPMode cur, ISO2022JPMode next) { }

	// RVA: 0x2251EE0 Offset: 0x22504E0 VA: 0x182251EE0 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x22525E0 Offset: 0x2250BE0 VA: 0x1822525E0 Slot: 4
	public override void Reset() { }

}

