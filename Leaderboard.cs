public static class Leaderboard // TypeDefIndex: 6196
{	// Methods

	// RVA: 0x14B4DF0 Offset: 0x14B33F0 VA: 0x1814B4DF0
	public static void Insert(string board, float score, bool OnlyIfLower = False, bool OnlyIfHigher = False, string extra = "", Action<string> result) { }

	// RVA: 0x14B4AD0 Offset: 0x14B30D0 VA: 0x1814B4AD0
	public static void GetRank(string board, string userid, bool desc = True, string[] friends, Action<Rank> result) { }

	// RVA: 0x14B4700 Offset: 0x14B2D00 VA: 0x1814B4700
	public static void GetPage(string board, string country, string city, int skip = 0, int take = 20, bool desc = True, string[] friends, Action<Entry[]> result) { }

}

private sealed class Leaderboard.<>c__DisplayClass1_0 // TypeDefIndex: 6197
{	// Fields
	public Action<Rank> result; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCDC0 Offset: 0x14BB3C0 VA: 0x1814BCDC0
	internal void <GetRank>b__0(string txt) { }

}

private sealed class Leaderboard.<>c__DisplayClass2_0 // TypeDefIndex: 6198
{	// Fields
	public Action<Entry[]> result; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCF40 Offset: 0x14BB540 VA: 0x1814BCF40
	internal void <GetPage>b__0(string txt) { }

}

