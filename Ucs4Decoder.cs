internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 2019
{	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0xE4E920 Offset: 0xE4CF20 VA: 0x180E4E920 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0xE4E930 Offset: 0xE4CF30 VA: 0x180E4E930 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE4E6C0 Offset: 0xE4CCC0 VA: 0x180E4E6C0 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0xE4EB10 Offset: 0xE4D110 VA: 0x180E4EB10
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0xE4DEE0 Offset: 0xE4C4E0 VA: 0x180E4DEE0
	protected void .ctor() { }

}

