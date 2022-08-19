internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 1816
{	// Fields
	private byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private byte cachedHalfByte; // 0x21

	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x12DE1B0 Offset: 0x12DC7B0 VA: 0x1812DE1B0 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x12DDFB0 Offset: 0x12DC5B0 VA: 0x1812DDFB0 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x12DDC10 Offset: 0x12DC210 VA: 0x1812DDC10
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x12DDE20 Offset: 0x12DC420 VA: 0x1812DDE20
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

}

