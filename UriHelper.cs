internal static class UriHelper // TypeDefIndex: 2581
{	// Fields
	private static readonly char[] HexUpperChars; // 0x14380

	// Methods

	// RVA: 0x22B74E0 Offset: 0x22B5AE0 VA: 0x1822B74E0
	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	// RVA: 0x22B7260 Offset: 0x22B5860 VA: 0x1822B7260
	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x22B84D0 Offset: 0x22B6AD0 VA: 0x1822B84D0
	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B85B0 Offset: 0x22B6BB0 VA: 0x1822B85B0
	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B7FB0 Offset: 0x22B65B0 VA: 0x1822B7FB0
	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x22B7370 Offset: 0x22B5970 VA: 0x1822B7370
	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	// RVA: 0x22B7BE0 Offset: 0x22B61E0 VA: 0x1822B7BE0
	internal static char EscapedAscii(char digit, char next) { }

	// RVA: 0x22B7D00 Offset: 0x22B6300 VA: 0x1822B7D00
	internal static bool IsNotSafeForUnescape(char ch) { }

	// RVA: 0x22B7D50 Offset: 0x22B6350 VA: 0x1822B7D50
	private static bool IsReservedUnreservedOrHash(char c) { }

	// RVA: 0x22B7E80 Offset: 0x22B6480 VA: 0x1822B7E80
	internal static bool IsUnreserved(char c) { }

	// RVA: 0x22B7C80 Offset: 0x22B6280 VA: 0x1822B7C80
	internal static bool Is3986Unreserved(char c) { }

	// RVA: 0x22B8F80 Offset: 0x22B7580 VA: 0x1822B8F80
	private static void .cctor() { }

}

