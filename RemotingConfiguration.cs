public static class RemotingConfiguration // TypeDefIndex: 1137
{	// Fields
	private static string applicationID; // 0x0
	private static string applicationName; // 0x8
	private static string processGuid; // 0x10
	private static bool defaultConfigRead; // 0x18
	private static bool defaultDelayedConfigRead; // 0x19
	private static string _errorMode; // 0x20
	private static Hashtable wellKnownClientEntries; // 0x28
	private static Hashtable activatedClientEntries; // 0x30
	private static Hashtable wellKnownServiceEntries; // 0x38
	private static Hashtable activatedServiceEntries; // 0x40
	private static Hashtable channelTemplates; // 0x48
	private static Hashtable clientProviderTemplates; // 0x50
	private static Hashtable serverProviderTemplates; // 0x58

	// Properties
	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }

	// Methods

	// RVA: 0x1486690 Offset: 0x1484C90 VA: 0x181486690
	public static string get_ApplicationName() { }

	// RVA: 0x14867E0 Offset: 0x1484DE0 VA: 0x1814867E0
	public static void set_ApplicationName(string value) { }

	// RVA: 0x14866F0 Offset: 0x1484CF0 VA: 0x1814866F0
	public static string get_ProcessId() { }

	// RVA: 0x14849D0 Offset: 0x1482FD0 VA: 0x1814849D0
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x1484690 Offset: 0x1482C90 VA: 0x181484690
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x1484830 Offset: 0x1482E30 VA: 0x181484830
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x1484C80 Offset: 0x1483280 VA: 0x181484C80
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x1484F20 Offset: 0x1483520 VA: 0x181484F20
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x1485EF0 Offset: 0x14844F0 VA: 0x181485EF0
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1486190 Offset: 0x1484790 VA: 0x181486190
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x1485080 Offset: 0x1483680 VA: 0x181485080
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x14859A0 Offset: 0x1483FA0 VA: 0x1814859A0
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x1485A30 Offset: 0x1484030 VA: 0x181485A30
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x1485110 Offset: 0x1483710 VA: 0x181485110
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x1485AC0 Offset: 0x14840C0 VA: 0x181485AC0
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x14845C0 Offset: 0x1482BC0 VA: 0x1814845C0
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x1486330 Offset: 0x1484930 VA: 0x181486330
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x1486470 Offset: 0x1484A70 VA: 0x181486470
	private static void .cctor() { }

}

