public static class Dns // TypeDefIndex: 2995
{	// Methods

	// RVA: 0x152F2A0 Offset: 0x152D8A0 VA: 0x18152F2A0
	private static bool GetHostByName_internal(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x152F170 Offset: 0x152D770 VA: 0x18152F170
	private static bool GetHostByAddr_internal(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x152F7C0 Offset: 0x152DDC0 VA: 0x18152F7C0
	private static bool GetHostName_internal(out string h_name) { }

	// RVA: 0x152F100 Offset: 0x152D700 VA: 0x18152F100
	private static void Error_11001(string hostName) { }

	// RVA: 0x152F810 Offset: 0x152DE10 VA: 0x18152F810
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x152F180 Offset: 0x152D780 VA: 0x18152F180
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x152F3A0 Offset: 0x152D9A0 VA: 0x18152F3A0
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x152F670 Offset: 0x152DC70 VA: 0x18152F670
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	[ObsoleteAttribute] // RVA: 0xB6740 Offset: 0xB5B40 VA: 0x1800B6740
	// RVA: 0x152F2B0 Offset: 0x152D8B0 VA: 0x18152F2B0
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x152F7D0 Offset: 0x152DDD0 VA: 0x18152F7D0
	public static string GetHostName() { }

}

