public sealed class X509StoreManager // TypeDefIndex: 1722
{	// Fields
	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static X509Stores _userStore; // 0x10
	private static X509Stores _machineStore; // 0x18

	// Properties
	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }

	// Methods

	// RVA: 0x2281EC0 Offset: 0x22804C0 VA: 0x182281EC0
	internal static string get_CurrentUserPath() { }

	// RVA: 0x2282130 Offset: 0x2280730 VA: 0x182282130
	internal static string get_LocalMachinePath() { }

	// RVA: 0x2281FB0 Offset: 0x22805B0 VA: 0x182281FB0
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x2282230 Offset: 0x2280830 VA: 0x182282230
	public static X509Stores get_LocalMachine() { }

}

