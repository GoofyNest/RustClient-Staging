internal static class IPv6AddressHelper // TypeDefIndex: 2588
{	// Methods

	// RVA: 0x1535590 Offset: 0x1533B90 VA: 0x181535590
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	// RVA: 0x1534890 Offset: 0x1532E90 VA: 0x181534890
	internal static string CreateCanonicalName(ushort* numbers) { }

	// RVA: 0x15351D0 Offset: 0x15337D0 VA: 0x1815351D0
	private static KeyValuePair<int, int> FindCompressionRange(ushort* numbers) { }

	// RVA: 0x1535A40 Offset: 0x1534040 VA: 0x181535A40
	private static bool ShouldHaveIpv4Embedded(ushort* numbers) { }

	// RVA: 0x1535270 Offset: 0x1533870 VA: 0x181535270
	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	// RVA: 0x1535570 Offset: 0x1533B70 VA: 0x181535570
	internal static bool IsValid(char* name, int start, ref int end) { }

	// RVA: 0x1535550 Offset: 0x1533B50 VA: 0x181535550
	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	// RVA: 0x1535640 Offset: 0x1533C40 VA: 0x181535640
	internal static bool Parse(string address, ushort* numbers, int start, ref string scopeId) { }

}

