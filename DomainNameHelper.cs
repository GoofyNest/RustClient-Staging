internal class DomainNameHelper // TypeDefIndex: 2586
{	// Methods

	// RVA: 0x172B950 Offset: 0x1729F50 VA: 0x18172B950
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	// RVA: 0x172B7D0 Offset: 0x1729DD0 VA: 0x18172B7D0
	internal static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x172B5C0 Offset: 0x1729BC0 VA: 0x18172B5C0
	internal static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x172B130 Offset: 0x1729730 VA: 0x18172B130
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x172B360 Offset: 0x1729960 VA: 0x18172B360
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	// RVA: 0x172B510 Offset: 0x1729B10 VA: 0x18172B510
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x172B590 Offset: 0x1729B90 VA: 0x18172B590
	private static bool IsIdnAce(char* input, int index) { }

	// RVA: 0x172BAC0 Offset: 0x172A0C0 VA: 0x18172BAC0
	internal static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) { }

	// RVA: 0x172BB80 Offset: 0x172A180 VA: 0x18172BB80
	internal static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x172B4E0 Offset: 0x1729AE0 VA: 0x18172B4E0
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	// RVA: 0x172B790 Offset: 0x1729D90 VA: 0x18172B790
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }

}

