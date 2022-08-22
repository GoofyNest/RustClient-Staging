internal class GB18030Encoder : MonoEncoder // TypeDefIndex: 7832
{	// Fields
	private static DbcsConvert gb2312; // 0x0
	private char incomplete_byte_count; // 0x28
	private char incomplete_bytes; // 0x2A

	// Methods

	// RVA: 0x224A9D0 Offset: 0x2248FD0 VA: 0x18224A9D0
	public void .ctor(MonoEncoding owner) { }

	// RVA: 0x224F680 Offset: 0x224DC80 VA: 0x18224F680
	private static void .cctor() { }

	// RVA: 0x224EFE0 Offset: 0x224D5E0 VA: 0x18224EFE0 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x224F1F0 Offset: 0x224D7F0 VA: 0x18224F1F0 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

