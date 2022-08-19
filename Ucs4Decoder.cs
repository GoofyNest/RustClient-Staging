internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 2019
{	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0xE4E660 Offset: 0xE4CC60 VA: 0x180E4E660 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0xE4E670 Offset: 0xE4CC70 VA: 0x180E4E670 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE4E400 Offset: 0xE4CA00 VA: 0x180E4E400 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0xE4E850 Offset: 0xE4CE50 VA: 0x180E4E850
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0xE4DC20 Offset: 0xE4C220 VA: 0x180E4DC20
	protected void .ctor() { }

}

