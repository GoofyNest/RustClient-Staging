internal class GB18030Encoder : MonoEncoder // TypeDefIndex: 7832
{	// Fields
	private static DbcsConvert gb2312; // 0x0
	private char incomplete_byte_count; // 0x28
	private char incomplete_bytes; // 0x2A

	// Methods

	// RVA: 0x224B4B0 Offset: 0x2249AB0 VA: 0x18224B4B0
	public void .ctor(MonoEncoding owner) { }

	// RVA: 0x2250160 Offset: 0x224E760 VA: 0x182250160
	private static void .cctor() { }

	// RVA: 0x224FAC0 Offset: 0x224E0C0 VA: 0x18224FAC0 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x224FCD0 Offset: 0x224E2D0 VA: 0x18224FCD0 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

