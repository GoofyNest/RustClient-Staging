internal class DomainNameHelper // TypeDefIndex: 2586
{	// Methods

	// RVA: 0x172BC10 Offset: 0x172A210 VA: 0x18172BC10
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	// RVA: 0x172BA90 Offset: 0x172A090 VA: 0x18172BA90
	internal static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x172B880 Offset: 0x1729E80 VA: 0x18172B880
	internal static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x172B3F0 Offset: 0x17299F0 VA: 0x18172B3F0
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x172B620 Offset: 0x1729C20 VA: 0x18172B620
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	// RVA: 0x172B7D0 Offset: 0x1729DD0 VA: 0x18172B7D0
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x172B850 Offset: 0x1729E50 VA: 0x18172B850
	private static bool IsIdnAce(char* input, int index) { }

	// RVA: 0x172BD80 Offset: 0x172A380 VA: 0x18172BD80
	internal static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) { }

	// RVA: 0x172BE40 Offset: 0x172A440 VA: 0x18172BE40
	internal static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x172B7A0 Offset: 0x1729DA0 VA: 0x18172B7A0
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	// RVA: 0x172BA50 Offset: 0x172A050 VA: 0x18172BA50
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }

}

