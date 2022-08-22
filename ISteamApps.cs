internal class ISteamApps : SteamInterface // TypeDefIndex: 5115
{	// Methods

	// RVA: 0x1286190 Offset: 0x1284790 VA: 0x181286190
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1285E60 Offset: 0x1284460 VA: 0x181285E60
	internal static extern IntPtr SteamAPI_SteamApps_v008() { }

	// RVA: 0x1285E60 Offset: 0x1284460 VA: 0x181285E60 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1286110 Offset: 0x1284710 VA: 0x181286110
	private static extern Utf8StringPointer _GetCurrentGameLanguage(IntPtr self) { }

	// RVA: 0x1285DD0 Offset: 0x12843D0 VA: 0x181285DD0
	internal string GetCurrentGameLanguage() { }

	// RVA: 0x1285F60 Offset: 0x1284560 VA: 0x181285F60
	private static extern bool _BIsSubscribedApp(IntPtr self, AppId appID) { }

	// RVA: 0x1285AC0 Offset: 0x12840C0 VA: 0x181285AC0
	internal bool BIsSubscribedApp(AppId appID) { }

	// RVA: 0x1285ED0 Offset: 0x12844D0 VA: 0x181285ED0
	private static extern bool _BIsDlcInstalled(IntPtr self, AppId appID) { }

	// RVA: 0x1285A30 Offset: 0x1284030 VA: 0x181285A30
	internal bool BIsDlcInstalled(AppId appID) { }

	// RVA: 0x1286070 Offset: 0x1284670 VA: 0x181286070
	private static extern bool _GetCurrentBetaName(IntPtr self, IntPtr pchName, int cchNameBufferSize) { }

	// RVA: 0x1285BD0 Offset: 0x12841D0 VA: 0x181285BD0
	internal bool GetCurrentBetaName(out string pchName) { }

	// RVA: 0x1285FF0 Offset: 0x12845F0 VA: 0x181285FF0
	private static extern int _GetAppBuildId(IntPtr self) { }

	// RVA: 0x1285B50 Offset: 0x1284150 VA: 0x181285B50
	internal int GetAppBuildId() { }

}

