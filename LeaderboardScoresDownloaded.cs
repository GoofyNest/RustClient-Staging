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

	// RVA: 0x1EB6A0 Offset: 0x1EAAA0 VA: 0x1801EB6A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB690 Offset: 0x1EAA90 VA: 0x1801EB690 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372930 Offset: 0x1370F30 VA: 0x181372930
	private static void .cctor() { }

}

