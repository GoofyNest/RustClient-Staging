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

	// RVA: 0x1EB450 Offset: 0x1EA850 VA: 0x1801EB450 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB440 Offset: 0x1EA840 VA: 0x1801EB440 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373760 Offset: 0x1371D60 VA: 0x181373760
	private static void .cctor() { }

}

