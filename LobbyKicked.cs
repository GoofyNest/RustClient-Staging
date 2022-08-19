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

	// RVA: 0x1EB760 Offset: 0x1EAB60 VA: 0x1801EB760 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB750 Offset: 0x1EAB50 VA: 0x1801EB750 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373C30 Offset: 0x1372230 VA: 0x181373C30
	private static void .cctor() { }

}

