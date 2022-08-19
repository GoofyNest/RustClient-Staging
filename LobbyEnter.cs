internal struct LobbyEnter_t : ICallbackData // TypeDefIndex: 5337
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal uint GfChatPermissions; // 0x8
	internal bool Locked; // 0xC
	internal uint EChatRoomEnterResponse; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB610 Offset: 0x1EAA10 VA: 0x1801EB610 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB600 Offset: 0x1EAA00 VA: 0x1801EB600 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373A20 Offset: 0x1372020 VA: 0x181373A20
	private static void .cctor() { }

}

