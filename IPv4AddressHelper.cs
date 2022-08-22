internal static class IPv4AddressHelper // TypeDefIndex: 2587
{	// Methods

	// RVA: 0x1533000 Offset: 0x1531600 VA: 0x181533000
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	// RVA: 0x1533470 Offset: 0x1531A70 VA: 0x181533470
	internal static int ParseHostNumber(string str, int start, int end) { }

	// RVA: 0x1532E60 Offset: 0x1531460 VA: 0x181532E60
	internal static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x1532D00 Offset: 0x1531300 VA: 0x181532D00
	internal static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x1533540 Offset: 0x1531B40 VA: 0x181533540
	internal static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) { }

	// RVA: 0x15338D0 Offset: 0x1531ED0 VA: 0x1815338D0
	private static bool Parse(string name, byte* numbers, int start, int end) { }

	// RVA: 0x15333D0 Offset: 0x15319D0 VA: 0x1815333D0
	private static bool ParseCanonical(string name, byte* numbers, int start, int end) { }

}

