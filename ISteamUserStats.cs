internal class ISteamUserStats : SteamInterface // TypeDefIndex: 5132
{	// Methods

	// RVA: 0xDD8700 Offset: 0xDD6D00 VA: 0x180DD8700
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDDAE0 Offset: 0xDDC0E0 VA: 0x180DDDAE0
	internal static extern IntPtr SteamAPI_SteamUserStats_v012() { }

	// RVA: 0xDDDAE0 Offset: 0xDDC0E0 VA: 0x180DDDAE0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDE460 Offset: 0xDDCA60 VA: 0x180DDE460
	private static extern bool _RequestCurrentStats(IntPtr self) { }

	// RVA: 0xDDDB50 Offset: 0xDDC150 VA: 0x180DDDB50
	internal bool RequestCurrentStats() { }

	// RVA: 0xDDE300 Offset: 0xDDC900 VA: 0x180DDE300
	private static extern bool _GetStat(IntPtr self, string pchName, ref int pData) { }

	// RVA: 0xDDDA20 Offset: 0xDDC020 VA: 0x180DDDA20
	internal bool GetStat(string pchName, ref int pData) { }

	// RVA: 0xDDE3B0 Offset: 0xDDC9B0 VA: 0x180DDE3B0
	private static extern bool _GetStat(IntPtr self, string pchName, ref float pData) { }

	// RVA: 0xDDD960 Offset: 0xDDBF60 VA: 0x180DDD960
	internal bool GetStat(string pchName, ref float pData) { }

	// RVA: 0xDDE620 Offset: 0xDDCC20 VA: 0x180DDE620
	private static extern bool _SetStat(IntPtr self, string pchName, int nData) { }

	// RVA: 0xDDDDD0 Offset: 0xDDC3D0 VA: 0x180DDDDD0
	internal bool SetStat(string pchName, int nData) { }

	// RVA: 0xDDE6D0 Offset: 0xDDCCD0 VA: 0x180DDE6D0
	private static extern bool _SetStat(IntPtr self, string pchName, float fData) { }

	// RVA: 0xDDDD10 Offset: 0xDDC310 VA: 0x180DDDD10
	internal bool SetStat(string pchName, float fData) { }

	// RVA: 0xDDE070 Offset: 0xDDC670 VA: 0x180DDE070
	private static extern bool _GetAchievement(IntPtr self, string pchName, ref bool pbAchieved) { }

	// RVA: 0xDDD6A0 Offset: 0xDDBCA0 VA: 0x180DDD6A0
	internal bool GetAchievement(string pchName, ref bool pbAchieved) { }

	// RVA: 0xDDE570 Offset: 0xDDCB70 VA: 0x180DDE570
	private static extern bool _SetAchievement(IntPtr self, string pchName) { }

	// RVA: 0xDDDC60 Offset: 0xDDC260 VA: 0x180DDDC60
	internal bool SetAchievement(string pchName) { }

	// RVA: 0xDDE790 Offset: 0xDDCD90 VA: 0x180DDE790
	private static extern bool _StoreStats(IntPtr self) { }

	// RVA: 0xDDDE90 Offset: 0xDDC490 VA: 0x180DDDE90
	internal bool StoreStats() { }

	// RVA: 0xDDDF10 Offset: 0xDDC510 VA: 0x180DDDF10
	private static extern Utf8StringPointer _GetAchievementDisplayAttribute(IntPtr self, string pchName, string pchKey) { }

	// RVA: 0xDDD530 Offset: 0xDDBB30 VA: 0x180DDD530
	internal string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	// RVA: 0xDDE280 Offset: 0xDDC880 VA: 0x180DDE280
	private static extern uint _GetNumAchievements(IntPtr self) { }

	// RVA: 0xDDD8E0 Offset: 0xDDBEE0 VA: 0x180DDD8E0
	internal uint GetNumAchievements() { }

	// RVA: 0xDDDFE0 Offset: 0xDDC5E0 VA: 0x180DDDFE0
	private static extern Utf8StringPointer _GetAchievementName(IntPtr self, uint iAchievement) { }

	// RVA: 0xDDD610 Offset: 0xDDBC10 VA: 0x180DDD610
	internal string GetAchievementName(uint iAchievement) { }

	// RVA: 0xDDE4E0 Offset: 0xDDCAE0 VA: 0x180DDE4E0
	private static extern bool _ResetAllStats(IntPtr self, bool bAchievementsToo) { }

	// RVA: 0xDDDBD0 Offset: 0xDDC1D0 VA: 0x180DDDBD0
	internal bool ResetAllStats(bool bAchievementsToo) { }

	// RVA: 0xDDE120 Offset: 0xDDC720 VA: 0x180DDE120
	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref long pData) { }

	// RVA: 0xDDD820 Offset: 0xDDBE20 VA: 0x180DDD820
	internal bool GetGlobalStat(string pchStatName, ref long pData) { }

	// RVA: 0xDDE1D0 Offset: 0xDDC7D0 VA: 0x180DDE1D0
	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref double pData) { }

	// RVA: 0xDDD760 Offset: 0xDDBD60 VA: 0x180DDD760
	internal bool GetGlobalStat(string pchStatName, ref double pData) { }

}

