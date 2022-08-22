public class ISO2022JPEncoding : MonoEncoding // TypeDefIndex: 7803
{	// Fields
	private readonly bool allow_1byte_kana; // 0x40
	private readonly bool allow_shift_io; // 0x41

	// Properties
	public override string BodyName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x2252B50 Offset: 0x2251150 VA: 0x182252B50
	public void .ctor(int codePage, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x2252B90 Offset: 0x2251190 VA: 0x182252B90 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2252BC0 Offset: 0x22511C0 VA: 0x182252BC0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x2252BF0 Offset: 0x22511F0 VA: 0x182252BF0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x2252B40 Offset: 0x2251140 VA: 0x182252B40 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x79A230 Offset: 0x798830 VA: 0x18079A230 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2252870 Offset: 0x2250E70 VA: 0x182252870 Slot: 19
	public override int GetByteCount(char[] chars, int charIndex, int charCount) { }

	// RVA: 0x22527C0 Offset: 0x2250DC0 VA: 0x1822527C0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x2252930 Offset: 0x2250F30 VA: 0x182252930 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2252A00 Offset: 0x2251000 VA: 0x182252A00 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2252AA0 Offset: 0x22510A0 VA: 0x182252AA0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

