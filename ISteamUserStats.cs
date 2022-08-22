internal class ISteamUserStats : SteamInterface // TypeDefIndex: 5132
{	// Methods

	// RVA: 0xDD91B0 Offset: 0xDD77B0 VA: 0x180DD91B0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDE590 Offset: 0xDDCB90 VA: 0x180DDE590
	internal static extern IntPtr SteamAPI_SteamUserStats_v012() { }

	// RVA: 0xDDE590 Offset: 0xDDCB90 VA: 0x180DDE590 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDEF10 Offset: 0xDDD510 VA: 0x180DDEF10
	private static extern bool _RequestCurrentStats(IntPtr self) { }

	// RVA: 0xDDE600 Offset: 0xDDCC00 VA: 0x180DDE600
	internal bool RequestCurrentStats() { }

	// RVA: 0xDDEDB0 Offset: 0xDDD3B0 VA: 0x180DDEDB0
	private static extern bool _GetStat(IntPtr self, string pchName, ref int pData) { }

	// RVA: 0xDDE4D0 Offset: 0xDDCAD0 VA: 0x180DDE4D0
	internal bool GetStat(string pchName, ref int pData) { }

	// RVA: 0xDDEE60 Offset: 0xDDD460 VA: 0x180DDEE60
	private static extern bool _GetStat(IntPtr self, string pchName, ref float pData) { }

	// RVA: 0xDDE410 Offset: 0xDDCA10 VA: 0x180DDE410
	internal bool GetStat(string pchName, ref float pData) { }

	// RVA: 0xDDF0D0 Offset: 0xDDD6D0 VA: 0x180DDF0D0
	private static extern bool _SetStat(IntPtr self, string pchName, int nData) { }

	// RVA: 0xDDE880 Offset: 0xDDCE80 VA: 0x180DDE880
	internal bool SetStat(string pchName, int nData) { }

	// RVA: 0xDDF180 Offset: 0xDDD780 VA: 0x180DDF180
	private static extern bool _SetStat(IntPtr self, string pchName, float fData) { }

	// RVA: 0xDDE7C0 Offset: 0xDDCDC0 VA: 0x180DDE7C0
	internal bool SetStat(string pchName, float fData) { }

	// RVA: 0xDDEB20 Offset: 0xDDD120 VA: 0x180DDEB20
	private static extern bool _GetAchievement(IntPtr self, string pchName, ref bool pbAchieved) { }

	// RVA: 0xDDE150 Offset: 0xDDC750 VA: 0x180DDE150
	internal bool GetAchievement(string pchName, ref bool pbAchieved) { }

	// RVA: 0xDDF020 Offset: 0xDDD620 VA: 0x180DDF020
	private static extern bool _SetAchievement(IntPtr self, string pchName) { }

	// RVA: 0xDDE710 Offset: 0xDDCD10 VA: 0x180DDE710
	internal bool SetAchievement(string pchName) { }

	// RVA: 0xDDF240 Offset: 0xDDD840 VA: 0x180DDF240
	private static extern bool _StoreStats(IntPtr self) { }

	// RVA: 0xDDE940 Offset: 0xDDCF40 VA: 0x180DDE940
	internal bool StoreStats() { }

	// RVA: 0xDDE9C0 Offset: 0xDDCFC0 VA: 0x180DDE9C0
	private static extern Utf8StringPointer _GetAchievementDisplayAttribute(IntPtr self, string pchName, string pchKey) { }

	// RVA: 0xDDDFE0 Offset: 0xDDC5E0 VA: 0x180DDDFE0
	internal string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	// RVA: 0xDDED30 Offset: 0xDDD330 VA: 0x180DDED30
	private static extern uint _GetNumAchievements(IntPtr self) { }

	// RVA: 0xDDE390 Offset: 0xDDC990 VA: 0x180DDE390
	internal uint GetNumAchievements() { }

	// RVA: 0xDDEA90 Offset: 0xDDD090 VA: 0x180DDEA90
	private static extern Utf8StringPointer _GetAchievementName(IntPtr self, uint iAchievement) { }

	// RVA: 0xDDE0C0 Offset: 0xDDC6C0 VA: 0x180DDE0C0
	internal string GetAchievementName(uint iAchievement) { }

	// RVA: 0xDDEF90 Offset: 0xDDD590 VA: 0x180DDEF90
	private static extern bool _ResetAllStats(IntPtr self, bool bAchievementsToo) { }

	// RVA: 0xDDE680 Offset: 0xDDCC80 VA: 0x180DDE680
	internal bool ResetAllStats(bool bAchievementsToo) { }

	// RVA: 0xDDEBD0 Offset: 0xDDD1D0 VA: 0x180DDEBD0
	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref long pData) { }

	// RVA: 0xDDE2D0 Offset: 0xDDC8D0 VA: 0x180DDE2D0
	internal bool GetGlobalStat(string pchStatName, ref long pData) { }

	// RVA: 0xDDEC80 Offset: 0xDDD280 VA: 0x180DDEC80
	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref double pData) { }

	// RVA: 0xDDE210 Offset: 0xDDC810 VA: 0x180DDE210
	internal bool GetGlobalStat(string pchStatName, ref double pData) { }

}

