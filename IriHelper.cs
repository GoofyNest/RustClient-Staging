internal static class IriHelper // TypeDefIndex: 2567
{	// Methods

	// RVA: 0x1536170 Offset: 0x1534770 VA: 0x181536170
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	// RVA: 0x1535D60 Offset: 0x1534360 VA: 0x181535D60
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	// RVA: 0x15361E0 Offset: 0x15347E0 VA: 0x1815361E0
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	// RVA: 0x1536300 Offset: 0x1534900 VA: 0x181536300
	internal static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) { }

}

