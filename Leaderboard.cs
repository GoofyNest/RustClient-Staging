public static class Leaderboard // TypeDefIndex: 6196
{	// Methods

	// RVA: 0x14B4B30 Offset: 0x14B3130 VA: 0x1814B4B30
	public static void Insert(string board, float score, bool OnlyIfLower = False, bool OnlyIfHigher = False, string extra = "", Action<string> result) { }

	// RVA: 0x14B4810 Offset: 0x14B2E10 VA: 0x1814B4810
	public static void GetRank(string board, string userid, bool desc = True, string[] friends, Action<Rank> result) { }

	// RVA: 0x14B4440 Offset: 0x14B2A40 VA: 0x1814B4440
	public static void GetPage(string board, string country, string city, int skip = 0, int take = 20, bool desc = True, string[] friends, Action<Entry[]> result) { }

}

private sealed class Leaderboard.<>c__DisplayClass1_0 // TypeDefIndex: 6197
{	// Fields
	public Action<Rank> result; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCB00 Offset: 0x14BB100 VA: 0x1814BCB00
	internal void <GetRank>b__0(string txt) { }

}

private sealed class Leaderboard.<>c__DisplayClass2_0 // TypeDefIndex: 6198
{	// Fields
	public Action<Entry[]> result; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCC80 Offset: 0x14BB280 VA: 0x1814BCC80
	internal void <GetPage>b__0(string txt) { }

}

