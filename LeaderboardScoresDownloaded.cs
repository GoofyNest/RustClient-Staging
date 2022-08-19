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

	// RVA: 0x1EB300 Offset: 0x1EA700 VA: 0x1801EB300 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB2F0 Offset: 0x1EA6F0 VA: 0x1801EB2F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373570 Offset: 0x1371B70 VA: 0x181373570
	private static void .cctor() { }

}

