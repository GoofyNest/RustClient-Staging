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

	// RVA: 0x12DE470 Offset: 0x12DCA70 VA: 0x1812DE470 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x12DE270 Offset: 0x12DC870 VA: 0x1812DE270 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x12DDED0 Offset: 0x12DC4D0 VA: 0x1812DDED0
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x12DE0E0 Offset: 0x12DC6E0 VA: 0x1812DE0E0
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

}

