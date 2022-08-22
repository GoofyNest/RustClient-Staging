internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 2019
{	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0xE4F3D0 Offset: 0xE4D9D0 VA: 0x180E4F3D0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0xE4F3E0 Offset: 0xE4D9E0 VA: 0x180E4F3E0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE4F170 Offset: 0xE4D770 VA: 0x180E4F170 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0xE4F5C0 Offset: 0xE4DBC0 VA: 0x180E4F5C0
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0xE4E990 Offset: 0xE4CF90 VA: 0x180E4E990
	protected void .ctor() { }

}

