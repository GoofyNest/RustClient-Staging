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

	// RVA: 0x12E4920 Offset: 0x12E2F20 VA: 0x1812E4920 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x12E4720 Offset: 0x12E2D20 VA: 0x1812E4720 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x12E4380 Offset: 0x12E2980 VA: 0x1812E4380
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x12E4590 Offset: 0x12E2B90 VA: 0x1812E4590
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

}

