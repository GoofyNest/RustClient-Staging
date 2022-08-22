internal struct GameLobbyJoinRequested_t : ICallbackData // TypeDefIndex: 5310
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDFriend; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7E70 Offset: 0x1E7270 VA: 0x1801E7E70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7E60 Offset: 0x1E7260 VA: 0x1801E7E60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370490 Offset: 0x136EA90 VA: 0x181370490
	private static void .cctor() { }

}

