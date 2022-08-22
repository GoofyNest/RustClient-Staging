internal class UTF16Decoder : Decoder // TypeDefIndex: 2012
{	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0xE4DC30 Offset: 0xE4C230 VA: 0x180E4DC30
	public void .ctor(bool bigEndian) { }

	// RVA: 0xE4D900 Offset: 0xE4BF00 VA: 0x180E4D900 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0xE4D810 Offset: 0xE4BE10 VA: 0x180E4D810 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0xE4D930 Offset: 0xE4BF30 VA: 0x180E4D930 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0xE4D4A0 Offset: 0xE4BAA0 VA: 0x180E4D4A0 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

