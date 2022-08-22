internal static class NclUtilities // TypeDefIndex: 2887
{	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x1346F20 Offset: 0x1345520 VA: 0x181346F20
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x1346F00 Offset: 0x1345500 VA: 0x181346F00
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x1347040 Offset: 0x1345640 VA: 0x181347040
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x1346FB0 Offset: 0x13455B0 VA: 0x181346FB0
	private static object get_LocalAddressesLock() { }

}

