internal struct LobbyInvite_t : ICallbackData // TypeDefIndex: 5336
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal ulong SteamIDLobby; // 0x8
	internal ulong GameID; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EBA90 Offset: 0x1EAE90 VA: 0x1801EBA90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EBA80 Offset: 0x1EAE80 VA: 0x1801EBA80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372F40 Offset: 0x1371540 VA: 0x181372F40
	private static void .cctor() { }

}

