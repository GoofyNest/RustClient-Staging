internal static class UriHelper // TypeDefIndex: 2581
{	// Fields
	private static readonly char[] HexUpperChars; // 0x14380

	// Methods

	// RVA: 0x22B7320 Offset: 0x22B5920 VA: 0x1822B7320
	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	// RVA: 0x22B70A0 Offset: 0x22B56A0 VA: 0x1822B70A0
	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x22B8310 Offset: 0x22B6910 VA: 0x1822B8310
	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B83F0 Offset: 0x22B69F0 VA: 0x1822B83F0
	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B7DF0 Offset: 0x22B63F0 VA: 0x1822B7DF0
	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x22B71B0 Offset: 0x22B57B0 VA: 0x1822B71B0
	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	// RVA: 0x22B7A20 Offset: 0x22B6020 VA: 0x1822B7A20
	internal static char EscapedAscii(char digit, char next) { }

	// RVA: 0x22B7B40 Offset: 0x22B6140 VA: 0x1822B7B40
	internal static bool IsNotSafeForUnescape(char ch) { }

	// RVA: 0x22B7B90 Offset: 0x22B6190 VA: 0x1822B7B90
	private static bool IsReservedUnreservedOrHash(char c) { }

	// RVA: 0x22B7CC0 Offset: 0x22B62C0 VA: 0x1822B7CC0
	internal static bool IsUnreserved(char c) { }

	// RVA: 0x22B7AC0 Offset: 0x22B60C0 VA: 0x1822B7AC0
	internal static bool Is3986Unreserved(char c) { }

	// RVA: 0x22B8DC0 Offset: 0x22B73C0 VA: 0x1822B8DC0
	private static void .cctor() { }

}

