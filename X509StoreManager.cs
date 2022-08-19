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

	// RVA: 0x2282080 Offset: 0x2280680 VA: 0x182282080
	internal static string get_CurrentUserPath() { }

	// RVA: 0x22822F0 Offset: 0x22808F0 VA: 0x1822822F0
	internal static string get_LocalMachinePath() { }

	// RVA: 0x2282170 Offset: 0x2280770 VA: 0x182282170
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x22823F0 Offset: 0x22809F0 VA: 0x1822823F0
	public static X509Stores get_LocalMachine() { }

}

