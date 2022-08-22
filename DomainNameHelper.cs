internal class DomainNameHelper // TypeDefIndex: 2586
{	// Methods

	// RVA: 0x17297D0 Offset: 0x1727DD0 VA: 0x1817297D0
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	// RVA: 0x1729650 Offset: 0x1727C50 VA: 0x181729650
	internal static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x1729440 Offset: 0x1727A40 VA: 0x181729440
	internal static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x1728FB0 Offset: 0x17275B0 VA: 0x181728FB0
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x17291E0 Offset: 0x17277E0 VA: 0x1817291E0
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	// RVA: 0x1729390 Offset: 0x1727990 VA: 0x181729390
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x1729410 Offset: 0x1727A10 VA: 0x181729410
	private static bool IsIdnAce(char* input, int index) { }

	// RVA: 0x1729940 Offset: 0x1727F40 VA: 0x181729940
	internal static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) { }

	// RVA: 0x1729A00 Offset: 0x1728000 VA: 0x181729A00
	internal static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x1729360 Offset: 0x1727960 VA: 0x181729360
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	// RVA: 0x1729610 Offset: 0x1727C10 VA: 0x181729610
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }

}

