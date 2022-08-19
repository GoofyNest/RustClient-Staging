internal class ISteamUserStats : SteamInterface // TypeDefIndex: 5132
{	// Methods

	// RVA: 0xDD8440 Offset: 0xDD6A40 VA: 0x180DD8440
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDD820 Offset: 0xDDBE20 VA: 0x180DDD820
	internal static extern IntPtr SteamAPI_SteamUserStats_v012() { }

	// RVA: 0xDDD820 Offset: 0xDDBE20 VA: 0x180DDD820 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDE1A0 Offset: 0xDDC7A0 VA: 0x180DDE1A0
	private static extern bool _RequestCurrentStats(IntPtr self) { }

	// RVA: 0xDDD890 Offset: 0xDDBE90 VA: 0x180DDD890
	internal bool RequestCurrentStats() { }

	// RVA: 0xDDE040 Offset: 0xDDC640 VA: 0x180DDE040
	private static extern bool _GetStat(IntPtr self, string pchName, ref int pData) { }

	// RVA: 0xDDD760 Offset: 0xDDBD60 VA: 0x180DDD760
	internal bool GetStat(string pchName, ref int pData) { }

	// RVA: 0xDDE0F0 Offset: 0xDDC6F0 VA: 0x180DDE0F0
	private static extern bool _GetStat(IntPtr self, string pchName, ref float pData) { }

	// RVA: 0xDDD6A0 Offset: 0xDDBCA0 VA: 0x180DDD6A0
	internal bool GetStat(string pchName, ref float pData) { }

	// RVA: 0xDDE360 Offset: 0xDDC960 VA: 0x180DDE360
	private static extern bool _SetStat(IntPtr self, string pchName, int nData) { }

	// RVA: 0xDDDB10 Offset: 0xDDC110 VA: 0x180DDDB10
	internal bool SetStat(string pchName, int nData) { }

	// RVA: 0xDDE410 Offset: 0xDDCA10 VA: 0x180DDE410
	private static extern bool _SetStat(IntPtr self, string pchName, float fData) { }

	// RVA: 0xDDDA50 Offset: 0xDDC050 VA: 0x180DDDA50
	internal bool SetStat(string pchName, float fData) { }

	// RVA: 0xDDDDB0 Offset: 0xDDC3B0 VA: 0x180DDDDB0
	private static extern bool _GetAchievement(IntPtr self, string pchName, ref bool pbAchieved) { }

	// RVA: 0xDDD3E0 Offset: 0xDDB9E0 VA: 0x180DDD3E0
	internal bool GetAchievement(string pchName, ref bool pbAchieved) { }

	// RVA: 0xDDE2B0 Offset: 0xDDC8B0 VA: 0x180DDE2B0
	private static extern bool _SetAchievement(IntPtr self, string pchName) { }

	// RVA: 0xDDD9A0 Offset: 0xDDBFA0 VA: 0x180DDD9A0
	internal bool SetAchievement(string pchName) { }

	// RVA: 0xDDE4D0 Offset: 0xDDCAD0 VA: 0x180DDE4D0
	private static extern bool _StoreStats(IntPtr self) { }

	// RVA: 0xDDDBD0 Offset: 0xDDC1D0 VA: 0x180DDDBD0
	internal bool StoreStats() { }

	// RVA: 0xDDDC50 Offset: 0xDDC250 VA: 0x180DDDC50
	private static extern Utf8StringPointer _GetAchievementDisplayAttribute(IntPtr self, string pchName, string pchKey) { }

	// RVA: 0xDDD270 Offset: 0xDDB870 VA: 0x180DDD270
	internal string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	// RVA: 0xDDDFC0 Offset: 0xDDC5C0 VA: 0x180DDDFC0
	private static extern uint _GetNumAchievements(IntPtr self) { }

	// RVA: 0xDDD620 Offset: 0xDDBC20 VA: 0x180DDD620
	internal uint GetNumAchievements() { }

	// RVA: 0xDDDD20 Offset: 0xDDC320 VA: 0x180DDDD20
	private static extern Utf8StringPointer _GetAchievementName(IntPtr self, uint iAchievement) { }

	// RVA: 0xDDD350 Offset: 0xDDB950 VA: 0x180DDD350
	internal string GetAchievementName(uint iAchievement) { }

	// RVA: 0xDDE220 Offset: 0xDDC820 VA: 0x180DDE220
	private static extern bool _ResetAllStats(IntPtr self, bool bAchievementsToo) { }

	// RVA: 0xDDD910 Offset: 0xDDBF10 VA: 0x180DDD910
	internal bool ResetAllStats(bool bAchievementsToo) { }

	// RVA: 0xDDDE60 Offset: 0xDDC460 VA: 0x180DDDE60
	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref long pData) { }

	// RVA: 0xDDD560 Offset: 0xDDBB60 VA: 0x180DDD560
	internal bool GetGlobalStat(string pchStatName, ref long pData) { }

	// RVA: 0xDDDF10 Offset: 0xDDC510 VA: 0x180DDDF10
	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref double pData) { }

	// RVA: 0xDDD4A0 Offset: 0xDDBAA0 VA: 0x180DDD4A0
	internal bool GetGlobalStat(string pchStatName, ref double pData) { }

}

