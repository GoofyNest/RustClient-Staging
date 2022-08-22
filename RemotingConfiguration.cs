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

	// RVA: 0x1486950 Offset: 0x1484F50 VA: 0x181486950
	public static string get_ApplicationName() { }

	// RVA: 0x1486AA0 Offset: 0x14850A0 VA: 0x181486AA0
	public static void set_ApplicationName(string value) { }

	// RVA: 0x14869B0 Offset: 0x1484FB0 VA: 0x1814869B0
	public static string get_ProcessId() { }

	// RVA: 0x1484C90 Offset: 0x1483290 VA: 0x181484C90
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x1484950 Offset: 0x1482F50 VA: 0x181484950
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x1484AF0 Offset: 0x14830F0 VA: 0x181484AF0
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x1484F40 Offset: 0x1483540 VA: 0x181484F40
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x14851E0 Offset: 0x14837E0 VA: 0x1814851E0
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x14861B0 Offset: 0x14847B0 VA: 0x1814861B0
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1486450 Offset: 0x1484A50 VA: 0x181486450
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x1485340 Offset: 0x1483940 VA: 0x181485340
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x1485C60 Offset: 0x1484260 VA: 0x181485C60
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x1485CF0 Offset: 0x14842F0 VA: 0x181485CF0
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x14853D0 Offset: 0x14839D0 VA: 0x1814853D0
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x1485D80 Offset: 0x1484380 VA: 0x181485D80
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x1484880 Offset: 0x1482E80 VA: 0x181484880
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x14865F0 Offset: 0x1484BF0 VA: 0x1814865F0
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x1486730 Offset: 0x1484D30 VA: 0x181486730
	private static void .cctor() { }

}

