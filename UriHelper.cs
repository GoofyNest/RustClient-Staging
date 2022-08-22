internal static class UriHelper // TypeDefIndex: 2581
{	// Fields
	private static readonly char[] HexUpperChars; // 0x2B10914

	// Methods

	// RVA: 0x22B7E00 Offset: 0x22B6400 VA: 0x1822B7E00
	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	// RVA: 0x22B7B80 Offset: 0x22B6180 VA: 0x1822B7B80
	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x22B8DF0 Offset: 0x22B73F0 VA: 0x1822B8DF0
	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B8ED0 Offset: 0x22B74D0 VA: 0x1822B8ED0
	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x22B88D0 Offset: 0x22B6ED0 VA: 0x1822B88D0
	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x22B7C90 Offset: 0x22B6290 VA: 0x1822B7C90
	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	// RVA: 0x22B8500 Offset: 0x22B6B00 VA: 0x1822B8500
	internal static char EscapedAscii(char digit, char next) { }

	// RVA: 0x22B8620 Offset: 0x22B6C20 VA: 0x1822B8620
	internal static bool IsNotSafeForUnescape(char ch) { }

	// RVA: 0x22B8670 Offset: 0x22B6C70 VA: 0x1822B8670
	private static bool IsReservedUnreservedOrHash(char c) { }

	// RVA: 0x22B87A0 Offset: 0x22B6DA0 VA: 0x1822B87A0
	internal static bool IsUnreserved(char c) { }

	// RVA: 0x22B85A0 Offset: 0x22B6BA0 VA: 0x1822B85A0
	internal static bool Is3986Unreserved(char c) { }

	// RVA: 0x22B98A0 Offset: 0x22B7EA0 VA: 0x1822B98A0
	private static void .cctor() { }

}

