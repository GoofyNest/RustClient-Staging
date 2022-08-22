internal class UTF16Decoder : Decoder // TypeDefIndex: 2012
{	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0xE4E6E0 Offset: 0xE4CCE0 VA: 0x180E4E6E0
	public void .ctor(bool bigEndian) { }

	// RVA: 0xE4E3B0 Offset: 0xE4C9B0 VA: 0x180E4E3B0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0xE4E2C0 Offset: 0xE4C8C0 VA: 0x180E4E2C0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0xE4E3E0 Offset: 0xE4C9E0 VA: 0x180E4E3E0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE4DF50 Offset: 0xE4C550 VA: 0x180E4DF50 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

