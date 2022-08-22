internal class ISteamApps : SteamInterface // TypeDefIndex: 5115
{	// Methods

	// RVA: 0x1286830 Offset: 0x1284E30 VA: 0x181286830
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1286500 Offset: 0x1284B00 VA: 0x181286500
	internal static extern IntPtr SteamAPI_SteamApps_v008() { }

	// RVA: 0x1286500 Offset: 0x1284B00 VA: 0x181286500 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x12867B0 Offset: 0x1284DB0 VA: 0x1812867B0
	private static extern Utf8StringPointer _GetCurrentGameLanguage(IntPtr self) { }

	// RVA: 0x1286470 Offset: 0x1284A70 VA: 0x181286470
	internal string GetCurrentGameLanguage() { }

	// RVA: 0x1286600 Offset: 0x1284C00 VA: 0x181286600
	private static extern bool _BIsSubscribedApp(IntPtr self, AppId appID) { }

	// RVA: 0x1286160 Offset: 0x1284760 VA: 0x181286160
	internal bool BIsSubscribedApp(AppId appID) { }

	// RVA: 0x1286570 Offset: 0x1284B70 VA: 0x181286570
	private static extern bool _BIsDlcInstalled(IntPtr self, AppId appID) { }

	// RVA: 0x12860D0 Offset: 0x12846D0 VA: 0x1812860D0
	internal bool BIsDlcInstalled(AppId appID) { }

	// RVA: 0x1286710 Offset: 0x1284D10 VA: 0x181286710
	private static extern bool _GetCurrentBetaName(IntPtr self, IntPtr pchName, int cchNameBufferSize) { }

	// RVA: 0x1286270 Offset: 0x1284870 VA: 0x181286270
	internal bool GetCurrentBetaName(out string pchName) { }

	// RVA: 0x1286690 Offset: 0x1284C90 VA: 0x181286690
	private static extern int _GetAppBuildId(IntPtr self) { }

	// RVA: 0x12861F0 Offset: 0x12847F0 VA: 0x1812861F0
	internal int GetAppBuildId() { }

}

