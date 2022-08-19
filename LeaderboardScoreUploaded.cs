internal struct LeaderboardScoreUploaded_t : ICallbackData // TypeDefIndex: 5391
{	// Fields
	internal byte Success; // 0x0
	internal ulong SteamLeaderboard; // 0x8
	internal int Score; // 0x10
	internal byte ScoreChanged; // 0x14
	internal int GlobalRankNew; // 0x18
	internal int GlobalRankPrevious; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB290 Offset: 0x1EA690 VA: 0x1801EB290 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB280 Offset: 0x1EA680 VA: 0x1801EB280 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13734D0 Offset: 0x1371AD0 VA: 0x1813734D0
	private static void .cctor() { }

}
