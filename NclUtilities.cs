internal static class NclUtilities // TypeDefIndex: 2887
{	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x1347E20 Offset: 0x1346420 VA: 0x181347E20
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x1347E00 Offset: 0x1346400 VA: 0x181347E00
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x1347F40 Offset: 0x1346540 VA: 0x181347F40
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x1347EB0 Offset: 0x13464B0 VA: 0x181347EB0
	private static object get_LocalAddressesLock() { }

}

