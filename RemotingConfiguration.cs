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

	// RVA: 0x1485A20 Offset: 0x1484020 VA: 0x181485A20
	public static string get_ApplicationName() { }

	// RVA: 0x1485B70 Offset: 0x1484170 VA: 0x181485B70
	public static void set_ApplicationName(string value) { }

	// RVA: 0x1485A80 Offset: 0x1484080 VA: 0x181485A80
	public static string get_ProcessId() { }

	// RVA: 0x1483D60 Offset: 0x1482360 VA: 0x181483D60
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x1483A20 Offset: 0x1482020 VA: 0x181483A20
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x1483BC0 Offset: 0x14821C0 VA: 0x181483BC0
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x1484010 Offset: 0x1482610 VA: 0x181484010
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x14842B0 Offset: 0x14828B0 VA: 0x1814842B0
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x1485280 Offset: 0x1483880 VA: 0x181485280
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1485520 Offset: 0x1483B20 VA: 0x181485520
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x1484410 Offset: 0x1482A10 VA: 0x181484410
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x1484D30 Offset: 0x1483330 VA: 0x181484D30
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x1484DC0 Offset: 0x14833C0 VA: 0x181484DC0
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x14844A0 Offset: 0x1482AA0 VA: 0x1814844A0
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x1484E50 Offset: 0x1483450 VA: 0x181484E50
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x1483950 Offset: 0x1481F50 VA: 0x181483950
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x14856C0 Offset: 0x1483CC0 VA: 0x1814856C0
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x1485800 Offset: 0x1483E00 VA: 0x181485800
	private static void .cctor() { }

}

