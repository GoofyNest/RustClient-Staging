internal struct SearchForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5347
{	// Fields
	internal ulong LSearchID; // 0x0
	internal Result Result; // 0x8
	internal ulong LobbyID; // 0xC
	internal ulong SteamIDEndedSearch; // 0x14
	internal int SecondsRemainingEstimate; // 0x1C
	internal int CPlayersSearching; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7E40 Offset: 0x1D7240 VA: 0x1801D7E40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7E30 Offset: 0x1D7230 VA: 0x1801D7E30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128ED50 Offset: 0x128D350 VA: 0x18128ED50
	private static void .cctor() { }

}

