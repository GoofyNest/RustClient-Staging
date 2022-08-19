internal class ISteamApps : SteamInterface // TypeDefIndex: 5115
{	// Methods

	// RVA: 0x1285ED0 Offset: 0x12844D0 VA: 0x181285ED0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1285BA0 Offset: 0x12841A0 VA: 0x181285BA0
	internal static extern IntPtr SteamAPI_SteamApps_v008() { }

	// RVA: 0x1285BA0 Offset: 0x12841A0 VA: 0x181285BA0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1285E50 Offset: 0x1284450 VA: 0x181285E50
	private static extern Utf8StringPointer _GetCurrentGameLanguage(IntPtr self) { }

	// RVA: 0x1285B10 Offset: 0x1284110 VA: 0x181285B10
	internal string GetCurrentGameLanguage() { }

	// RVA: 0x1285CA0 Offset: 0x12842A0 VA: 0x181285CA0
	private static extern bool _BIsSubscribedApp(IntPtr self, AppId appID) { }

	// RVA: 0x1285800 Offset: 0x1283E00 VA: 0x181285800
	internal bool BIsSubscribedApp(AppId appID) { }

	// RVA: 0x1285C10 Offset: 0x1284210 VA: 0x181285C10
	private static extern bool _BIsDlcInstalled(IntPtr self, AppId appID) { }

	// RVA: 0x1285770 Offset: 0x1283D70 VA: 0x181285770
	internal bool BIsDlcInstalled(AppId appID) { }

	// RVA: 0x1285DB0 Offset: 0x12843B0 VA: 0x181285DB0
	private static extern bool _GetCurrentBetaName(IntPtr self, IntPtr pchName, int cchNameBufferSize) { }

	// RVA: 0x1285910 Offset: 0x1283F10 VA: 0x181285910
	internal bool GetCurrentBetaName(out string pchName) { }

	// RVA: 0x1285D30 Offset: 0x1284330 VA: 0x181285D30
	private static extern int _GetAppBuildId(IntPtr self) { }

	// RVA: 0x1285890 Offset: 0x1283E90 VA: 0x181285890
	internal int GetAppBuildId() { }

}

