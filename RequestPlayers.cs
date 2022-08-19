internal struct RequestPlayersForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5349
{	// Fields
	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7B10 Offset: 0x1D6F10 VA: 0x1801D7B10 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7B00 Offset: 0x1D6F00 VA: 0x1801D7B00 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EA10 Offset: 0x128D010 VA: 0x18128EA10
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

	// RVA: 0x1D7B80 Offset: 0x1D6F80 VA: 0x1801D7B80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7B70 Offset: 0x1D6F70 VA: 0x1801D7B70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EAB0 Offset: 0x128D0B0 VA: 0x18128EAB0
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

	// RVA: 0x1D7AA0 Offset: 0x1D6EA0 VA: 0x1801D7AA0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7A90 Offset: 0x1D6E90 VA: 0x1801D7A90 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E970 Offset: 0x128CF70 VA: 0x18128E970
	private static void .cctor() { }

}

