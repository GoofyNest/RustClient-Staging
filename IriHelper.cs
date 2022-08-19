internal static class IriHelper // TypeDefIndex: 2567
{	// Methods

	// RVA: 0x1535EB0 Offset: 0x15344B0 VA: 0x181535EB0
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	// RVA: 0x1535AA0 Offset: 0x15340A0 VA: 0x181535AA0
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	// RVA: 0x1535F20 Offset: 0x1534520 VA: 0x181535F20
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	// RVA: 0x1536040 Offset: 0x1534640 VA: 0x181536040
	internal static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) { }

}

