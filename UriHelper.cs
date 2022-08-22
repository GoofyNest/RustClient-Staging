internal static class UriHelper // TypeDefIndex: 2581
{	// Fields
	private static readonly char[] HexUpperChars; // 0x14380

	// Methods

	// RVA: 0x22B75E0 Offset: 0x22B5BE0 VA: 0x1822B75E0
	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	// RVA: 0x22B7360 Offset: 0x22B5960 VA: 0x1822B7360
	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x22B85D0 Offset: 0x22B6BD0 VA: 0x1822B85D0
	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B86B0 Offset: 0x22B6CB0 VA: 0x1822B86B0
	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B80B0 Offset: 0x22B66B0 VA: 0x1822B80B0
	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x22B7470 Offset: 0x22B5A70 VA: 0x1822B7470
	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	// RVA: 0x22B7CE0 Offset: 0x22B62E0 VA: 0x1822B7CE0
	internal static char EscapedAscii(char digit, char next) { }

	// RVA: 0x22B7E00 Offset: 0x22B6400 VA: 0x1822B7E00
	internal static bool IsNotSafeForUnescape(char ch) { }

	// RVA: 0x22B7E50 Offset: 0x22B6450 VA: 0x1822B7E50
	private static bool IsReservedUnreservedOrHash(char c) { }

	// RVA: 0x22B7F80 Offset: 0x22B6580 VA: 0x1822B7F80
	internal static bool IsUnreserved(char c) { }

	// RVA: 0x22B7D80 Offset: 0x22B6380 VA: 0x1822B7D80
	internal static bool Is3986Unreserved(char c) { }

	// RVA: 0x22B9080 Offset: 0x22B7680 VA: 0x1822B9080
	private static void .cctor() { }

}

