internal static class IPv6AddressHelper // TypeDefIndex: 2588
{	// Methods

	// RVA: 0x1534660 Offset: 0x1532C60 VA: 0x181534660
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	// RVA: 0x1533960 Offset: 0x1531F60 VA: 0x181533960
	internal static string CreateCanonicalName(ushort* numbers) { }

	// RVA: 0x15342A0 Offset: 0x15328A0 VA: 0x1815342A0
	private static KeyValuePair<int, int> FindCompressionRange(ushort* numbers) { }

	// RVA: 0x1534B10 Offset: 0x1533110 VA: 0x181534B10
	private static bool ShouldHaveIpv4Embedded(ushort* numbers) { }

	// RVA: 0x1534340 Offset: 0x1532940 VA: 0x181534340
	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	// RVA: 0x1534640 Offset: 0x1532C40 VA: 0x181534640
	internal static bool IsValid(char* name, int start, ref int end) { }

	// RVA: 0x1534620 Offset: 0x1532C20 VA: 0x181534620
	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	// RVA: 0x1534710 Offset: 0x1532D10 VA: 0x181534710
	internal static bool Parse(string address, ushort* numbers, int start, ref string scopeId) { }

}

