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

	// RVA: 0x22829A0 Offset: 0x2280FA0 VA: 0x1822829A0
	internal static string get_CurrentUserPath() { }

	// RVA: 0x2282C10 Offset: 0x2281210 VA: 0x182282C10
	internal static string get_LocalMachinePath() { }

	// RVA: 0x2282A90 Offset: 0x2281090 VA: 0x182282A90
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x2282D10 Offset: 0x2281310 VA: 0x182282D10
	public static X509Stores get_LocalMachine() { }

}

