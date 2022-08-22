internal static class IriHelper // TypeDefIndex: 2567
{	// Methods

	// RVA: 0x1535240 Offset: 0x1533840 VA: 0x181535240
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	// RVA: 0x1534E30 Offset: 0x1533430 VA: 0x181534E30
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	// RVA: 0x15352B0 Offset: 0x15338B0 VA: 0x1815352B0
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	// RVA: 0x15353D0 Offset: 0x15339D0 VA: 0x1815353D0
	internal static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) { }

}

