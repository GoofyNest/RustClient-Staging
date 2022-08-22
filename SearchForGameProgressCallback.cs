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

	// RVA: 0x1D8430 Offset: 0x1D7830 VA: 0x1801D8430 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8420 Offset: 0x1D7820 VA: 0x1801D8420 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128F6B0 Offset: 0x128DCB0 VA: 0x18128F6B0
	private static void .cctor() { }

}

