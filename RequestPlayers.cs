internal struct RequestPlayersForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5349
{	// Fields
	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8100 Offset: 0x1D7500 VA: 0x1801D8100 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D80F0 Offset: 0x1D74F0 VA: 0x1801D80F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128F370 Offset: 0x128D970 VA: 0x18128F370
	private static void .cctor() { }

}

internal struct RequestPlayersForGameResultCallback_t : ICallbackData // TypeDefIndex: 5350
{	// Fields
	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x4
	internal ulong SteamIDPlayerFound; // 0xC
	internal ulong SteamIDLobby; // 0x14
	internal RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerAcceptState; // 0x1C
	internal int PlayerIndex; // 0x20
	internal int TotalPlayersFound; // 0x24
	internal int TotalPlayersAcceptedGame; // 0x28
	internal int SuggestedTeamIndex; // 0x2C
	internal ulong LUniqueGameID; // 0x30
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8170 Offset: 0x1D7570 VA: 0x1801D8170 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8160 Offset: 0x1D7560 VA: 0x1801D8160 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128F410 Offset: 0x128DA10 VA: 0x18128F410
	private static void .cctor() { }

}

internal enum RequestPlayersForGameResultCallback_t.PlayerAcceptState_t // TypeDefIndex: 5351
{	// Fields
	public int value__; // 0x0
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t Unknown = 0;
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerAccepted = 1;
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerDeclined = 2;

}

internal struct RequestPlayersForGameFinalResultCallback_t : ICallbackData // TypeDefIndex: 5352
{	// Fields
	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x8
	internal ulong LUniqueGameID; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8090 Offset: 0x1D7490 VA: 0x1801D8090 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8080 Offset: 0x1D7480 VA: 0x1801D8080 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128F2D0 Offset: 0x128D8D0 VA: 0x18128F2D0
	private static void .cctor() { }

}

