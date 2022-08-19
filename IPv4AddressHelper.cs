internal static class IPv4AddressHelper // TypeDefIndex: 2587
{	// Methods

	// RVA: 0x1533C70 Offset: 0x1532270 VA: 0x181533C70
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	// RVA: 0x15340E0 Offset: 0x15326E0 VA: 0x1815340E0
	internal static int ParseHostNumber(string str, int start, int end) { }

	// RVA: 0x1533AD0 Offset: 0x15320D0 VA: 0x181533AD0
	internal static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x1533970 Offset: 0x1531F70 VA: 0x181533970
	internal static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x15341B0 Offset: 0x15327B0 VA: 0x1815341B0
	internal static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) { }

	// RVA: 0x1534540 Offset: 0x1532B40 VA: 0x181534540
	private static bool Parse(string name, byte* numbers, int start, int end) { }

	// RVA: 0x1534040 Offset: 0x1532640 VA: 0x181534040
	private static bool ParseCanonical(string name, byte* numbers, int start, int end) { }

}

