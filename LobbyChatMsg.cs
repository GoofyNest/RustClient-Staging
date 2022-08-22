internal struct LobbyChatMsg_t : ICallbackData // TypeDefIndex: 5340
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDUser; // 0x8
	internal byte ChatEntryType; // 0x10
	internal uint ChatID; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB7F0 Offset: 0x1EABF0 VA: 0x1801EB7F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB7E0 Offset: 0x1EABE0 VA: 0x1801EB7E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372B20 Offset: 0x1371120 VA: 0x181372B20
	private static void .cctor() { }

}

