public class ISO2022JPEncoding : MonoEncoding // TypeDefIndex: 7803
{	// Fields
	private readonly bool allow_1byte_kana; // 0x40
	private readonly bool allow_shift_io; // 0x41

	// Properties
	public override string BodyName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x2252A50 Offset: 0x2251050 VA: 0x182252A50
	public void .ctor(int codePage, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x2252A90 Offset: 0x2251090 VA: 0x182252A90 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2252AC0 Offset: 0x22510C0 VA: 0x182252AC0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x2252AF0 Offset: 0x22510F0 VA: 0x182252AF0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x2252A40 Offset: 0x2251040 VA: 0x182252A40 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x79A120 Offset: 0x798720 VA: 0x18079A120 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2252770 Offset: 0x2250D70 VA: 0x182252770 Slot: 19
	public override int GetByteCount(char[] chars, int charIndex, int charCount) { }

	// RVA: 0x22526C0 Offset: 0x2250CC0 VA: 0x1822526C0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x2252830 Offset: 0x2250E30 VA: 0x182252830 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2252900 Offset: 0x2250F00 VA: 0x182252900 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22529A0 Offset: 0x2250FA0 VA: 0x1822529A0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

