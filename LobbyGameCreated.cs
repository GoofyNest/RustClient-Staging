internal struct LobbyGameCreated_t : ICallbackData // TypeDefIndex: 5341
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDGameServer; // 0x8
	internal uint IP; // 0x10
	internal ushort Port; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB680 Offset: 0x1EAA80 VA: 0x1801EB680 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB670 Offset: 0x1EAA70 VA: 0x1801EB670 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373AD0 Offset: 0x13720D0 VA: 0x181373AD0
	private static void .cctor() { }

}

