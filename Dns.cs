public static class Dns // TypeDefIndex: 2995
{	// Methods

	// RVA: 0x152E370 Offset: 0x152C970 VA: 0x18152E370
	private static bool GetHostByName_internal(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x152E240 Offset: 0x152C840 VA: 0x18152E240
	private static bool GetHostByAddr_internal(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x152E890 Offset: 0x152CE90 VA: 0x18152E890
	private static bool GetHostName_internal(out string h_name) { }

	// RVA: 0x152E1D0 Offset: 0x152C7D0 VA: 0x18152E1D0
	private static void Error_11001(string hostName) { }

	// RVA: 0x152E8E0 Offset: 0x152CEE0 VA: 0x18152E8E0
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x152E250 Offset: 0x152C850 VA: 0x18152E250
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x152E470 Offset: 0x152CA70 VA: 0x18152E470
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x152E740 Offset: 0x152CD40 VA: 0x18152E740
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	[ObsoleteAttribute] // RVA: 0xB6740 Offset: 0xB5B40 VA: 0x1800B6740
	// RVA: 0x152E380 Offset: 0x152C980 VA: 0x18152E380
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x152E8A0 Offset: 0x152CEA0 VA: 0x18152E8A0
	public static string GetHostName() { }

}

