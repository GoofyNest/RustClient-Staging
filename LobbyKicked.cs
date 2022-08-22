internal struct LobbyKicked_t : ICallbackData // TypeDefIndex: 5343
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDAdmin; // 0x8
	internal byte KickedDueToDisconnect; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EBB00 Offset: 0x1EAF00 VA: 0x1801EBB00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EBAF0 Offset: 0x1EAEF0 VA: 0x1801EBAF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372FF0 Offset: 0x13715F0 VA: 0x181372FF0
	private static void .cctor() { }

}

