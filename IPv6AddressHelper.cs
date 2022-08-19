internal static class IPv6AddressHelper // TypeDefIndex: 2588
{	// Methods

	// RVA: 0x15352D0 Offset: 0x15338D0 VA: 0x1815352D0
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	// RVA: 0x15345D0 Offset: 0x1532BD0 VA: 0x1815345D0
	internal static string CreateCanonicalName(ushort* numbers) { }

	// RVA: 0x1534F10 Offset: 0x1533510 VA: 0x181534F10
	private static KeyValuePair<int, int> FindCompressionRange(ushort* numbers) { }

	// RVA: 0x1535780 Offset: 0x1533D80 VA: 0x181535780
	private static bool ShouldHaveIpv4Embedded(ushort* numbers) { }

	// RVA: 0x1534FB0 Offset: 0x15335B0 VA: 0x181534FB0
	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	// RVA: 0x15352B0 Offset: 0x15338B0 VA: 0x1815352B0
	internal static bool IsValid(char* name, int start, ref int end) { }

	// RVA: 0x1535290 Offset: 0x1533890 VA: 0x181535290
	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	// RVA: 0x1535380 Offset: 0x1533980 VA: 0x181535380
	internal static bool Parse(string address, ushort* numbers, int start, ref string scopeId) { }

}

