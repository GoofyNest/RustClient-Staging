internal struct RequestPlayersForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5349
{	// Fields
	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7A90 Offset: 0x1D6E90 VA: 0x1801D7A90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7A80 Offset: 0x1D6E80 VA: 0x1801D7A80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128ECD0 Offset: 0x128D2D0 VA: 0x18128ECD0
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

	// RVA: 0x1D7B00 Offset: 0x1D6F00 VA: 0x1801D7B00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7AF0 Offset: 0x1D6EF0 VA: 0x1801D7AF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128ED70 Offset: 0x128D370 VA: 0x18128ED70
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

	// RVA: 0x1D7A20 Offset: 0x1D6E20 VA: 0x1801D7A20 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7A10 Offset: 0x1D6E10 VA: 0x1801D7A10 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EC30 Offset: 0x128D230 VA: 0x18128EC30
	private static void .cctor() { }

}

