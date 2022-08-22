public class ISO2022JPEncoding : MonoEncoding // TypeDefIndex: 7803
{	// Fields
	private readonly bool allow_1byte_kana; // 0x40
	private readonly bool allow_shift_io; // 0x41

	// Properties
	public override string BodyName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x2252890 Offset: 0x2250E90 VA: 0x182252890
	public void .ctor(int codePage, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x22528D0 Offset: 0x2250ED0 VA: 0x1822528D0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2252900 Offset: 0x2250F00 VA: 0x182252900 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x2252930 Offset: 0x2250F30 VA: 0x182252930 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x2252880 Offset: 0x2250E80 VA: 0x182252880 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x79A120 Offset: 0x798720 VA: 0x18079A120 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x22525B0 Offset: 0x2250BB0 VA: 0x1822525B0 Slot: 19
	public override int GetByteCount(char[] chars, int charIndex, int charCount) { }

	// RVA: 0x2252500 Offset: 0x2250B00 VA: 0x182252500 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x2252670 Offset: 0x2250C70 VA: 0x182252670 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2252740 Offset: 0x2250D40 VA: 0x182252740 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22527E0 Offset: 0x2250DE0 VA: 0x1822527E0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

