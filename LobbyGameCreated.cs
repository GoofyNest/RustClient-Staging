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

	// RVA: 0x1EBA20 Offset: 0x1EAE20 VA: 0x1801EBA20 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EBA10 Offset: 0x1EAE10 VA: 0x1801EBA10 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372E90 Offset: 0x1371490 VA: 0x181372E90
	private static void .cctor() { }

}

