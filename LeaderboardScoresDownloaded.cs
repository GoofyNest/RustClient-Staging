internal struct LeaderboardScoresDownloaded_t : ICallbackData // TypeDefIndex: 5390
{	// Fields
	internal ulong SteamLeaderboard; // 0x0
	internal ulong SteamLeaderboardEntries; // 0x8
	internal int CEntryCount; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB280 Offset: 0x1EA680 VA: 0x1801EB280 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB270 Offset: 0x1EA670 VA: 0x1801EB270 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373570 Offset: 0x1371B70 VA: 0x181373570
	private static void .cctor() { }

}

