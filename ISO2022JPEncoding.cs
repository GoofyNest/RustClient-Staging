public class ISO2022JPEncoding : MonoEncoding // TypeDefIndex: 7803
{	// Fields
	private readonly bool allow_1byte_kana; // 0x40
	private readonly bool allow_shift_io; // 0x41

	// Properties
	public override string BodyName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x2253370 Offset: 0x2251970 VA: 0x182253370
	public void .ctor(int codePage, bool allow1ByteKana, bool allowShiftIO) { }

	// RVA: 0x22533B0 Offset: 0x22519B0 VA: 0x1822533B0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x22533E0 Offset: 0x22519E0 VA: 0x1822533E0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x2253410 Offset: 0x2251A10 VA: 0x182253410 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x2253360 Offset: 0x2251960 VA: 0x182253360 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x79A140 Offset: 0x798740 VA: 0x18079A140 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2253090 Offset: 0x2251690 VA: 0x182253090 Slot: 19
	public override int GetByteCount(char[] chars, int charIndex, int charCount) { }

	// RVA: 0x2252FE0 Offset: 0x22515E0 VA: 0x182252FE0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x2253150 Offset: 0x2251750 VA: 0x182253150 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2253220 Offset: 0x2251820 VA: 0x182253220 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22532C0 Offset: 0x22518C0 VA: 0x1822532C0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

