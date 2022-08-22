public static class Leaderboard // TypeDefIndex: 6196
{	// Methods

	// RVA: 0x14B3EC0 Offset: 0x14B24C0 VA: 0x1814B3EC0
	public static void Insert(string board, float score, bool OnlyIfLower = False, bool OnlyIfHigher = False, string extra = "", Action<string> result) { }

	// RVA: 0x14B3BA0 Offset: 0x14B21A0 VA: 0x1814B3BA0
	public static void GetRank(string board, string userid, bool desc = True, string[] friends, Action<Rank> result) { }

	// RVA: 0x14B37D0 Offset: 0x14B1DD0 VA: 0x1814B37D0
	public static void GetPage(string board, string country, string city, int skip = 0, int take = 20, bool desc = True, string[] friends, Action<Entry[]> result) { }

}

private sealed class Leaderboard.<>c__DisplayClass1_0 // TypeDefIndex: 6197
{	// Fields
	public Action<Rank> result; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BBE90 Offset: 0x14BA490 VA: 0x1814BBE90
	internal void <GetRank>b__0(string txt) { }

}

private sealed class Leaderboard.<>c__DisplayClass2_0 // TypeDefIndex: 6198
{	// Fields
	public Action<Entry[]> result; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BC010 Offset: 0x14BA610 VA: 0x1814BC010
	internal void <GetPage>b__0(string txt) { }

}

