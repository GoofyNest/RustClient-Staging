internal class GB18030Encoder : MonoEncoder // TypeDefIndex: 7832
{	// Fields
	private static DbcsConvert gb2312; // 0x0
	private char incomplete_byte_count; // 0x28
	private char incomplete_bytes; // 0x2A

	// Methods

	// RVA: 0x224AC90 Offset: 0x2249290 VA: 0x18224AC90
	public void .ctor(MonoEncoding owner) { }

	// RVA: 0x224F940 Offset: 0x224DF40 VA: 0x18224F940
	private static void .cctor() { }

	// RVA: 0x224F2A0 Offset: 0x224D8A0 VA: 0x18224F2A0 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x224F4B0 Offset: 0x224DAB0 VA: 0x18224F4B0 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

