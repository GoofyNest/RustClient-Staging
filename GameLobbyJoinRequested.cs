internal struct GameLobbyJoinRequested_t : ICallbackData // TypeDefIndex: 5310
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDFriend; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7A50 Offset: 0x1E6E50 VA: 0x1801E7A50 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7A40 Offset: 0x1E6E40 VA: 0x1801E7A40 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13710D0 Offset: 0x136F6D0 VA: 0x1813710D0
	private static void .cctor() { }

}

