internal static class IPv4AddressHelper // TypeDefIndex: 2587
{	// Methods

	// RVA: 0x1533F30 Offset: 0x1532530 VA: 0x181533F30
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	// RVA: 0x15343A0 Offset: 0x15329A0 VA: 0x1815343A0
	internal static int ParseHostNumber(string str, int start, int end) { }

	// RVA: 0x1533D90 Offset: 0x1532390 VA: 0x181533D90
	internal static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x1533C30 Offset: 0x1532230 VA: 0x181533C30
	internal static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x1534470 Offset: 0x1532A70 VA: 0x181534470
	internal static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) { }

	// RVA: 0x1534800 Offset: 0x1532E00 VA: 0x181534800
	private static bool Parse(string name, byte* numbers, int start, int end) { }

	// RVA: 0x1534300 Offset: 0x1532900 VA: 0x181534300
	private static bool ParseCanonical(string name, byte* numbers, int start, int end) { }

}

