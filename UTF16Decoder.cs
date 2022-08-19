internal class UTF16Decoder : Decoder // TypeDefIndex: 2012
{	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0xE4D970 Offset: 0xE4BF70 VA: 0x180E4D970
	public void .ctor(bool bigEndian) { }

	// RVA: 0xE4D640 Offset: 0xE4BC40 VA: 0x180E4D640 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0xE4D550 Offset: 0xE4BB50 VA: 0x180E4D550 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0xE4D670 Offset: 0xE4BC70 VA: 0x180E4D670 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE4D1E0 Offset: 0xE4B7E0 VA: 0x180E4D1E0 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

