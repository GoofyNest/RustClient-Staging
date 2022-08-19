internal static class NclUtilities // TypeDefIndex: 2887
{	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x1347B60 Offset: 0x1346160 VA: 0x181347B60
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x1347B40 Offset: 0x1346140 VA: 0x181347B40
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x1347C80 Offset: 0x1346280 VA: 0x181347C80
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x1347BF0 Offset: 0x13461F0 VA: 0x181347BF0
	private static object get_LocalAddressesLock() { }

}

