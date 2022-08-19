internal class GB18030Encoder : MonoEncoder // TypeDefIndex: 7832
{	// Fields
	private static DbcsConvert gb2312; // 0x0
	private char incomplete_byte_count; // 0x28
	private char incomplete_bytes; // 0x2A

	// Methods

	// RVA: 0x224AB90 Offset: 0x2249190 VA: 0x18224AB90
	public void .ctor(MonoEncoding owner) { }

	// RVA: 0x224F840 Offset: 0x224DE40 VA: 0x18224F840
	private static void .cctor() { }

	// RVA: 0x224F1A0 Offset: 0x224D7A0 VA: 0x18224F1A0 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x224F3B0 Offset: 0x224D9B0 VA: 0x18224F3B0 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

