public static class Dns // TypeDefIndex: 2995
{	// Methods

	// RVA: 0x152EFE0 Offset: 0x152D5E0 VA: 0x18152EFE0
	private static bool GetHostByName_internal(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x152EEB0 Offset: 0x152D4B0 VA: 0x18152EEB0
	private static bool GetHostByAddr_internal(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x152F500 Offset: 0x152DB00 VA: 0x18152F500
	private static bool GetHostName_internal(out string h_name) { }

	// RVA: 0x152EE40 Offset: 0x152D440 VA: 0x18152EE40
	private static void Error_11001(string hostName) { }

	// RVA: 0x152F550 Offset: 0x152DB50 VA: 0x18152F550
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x152EEC0 Offset: 0x152D4C0 VA: 0x18152EEC0
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x152F0E0 Offset: 0x152D6E0 VA: 0x18152F0E0
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x152F3B0 Offset: 0x152D9B0 VA: 0x18152F3B0
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	[ObsoleteAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	// RVA: 0x152EFF0 Offset: 0x152D5F0 VA: 0x18152EFF0
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x152F510 Offset: 0x152DB10 VA: 0x18152F510
	public static string GetHostName() { }

}

