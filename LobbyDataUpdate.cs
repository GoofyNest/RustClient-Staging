internal struct LobbyDataUpdate_t : ICallbackData // TypeDefIndex: 5338
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDMember; // 0x8
	internal byte Success; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB940 Offset: 0x1EAD40 VA: 0x1801EB940 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB930 Offset: 0x1EAD30 VA: 0x1801EB930 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372D30 Offset: 0x1371330 VA: 0x181372D30
	private static void .cctor() { }

}

