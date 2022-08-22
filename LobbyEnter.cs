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

	// RVA: 0x1EB9B0 Offset: 0x1EADB0 VA: 0x1801EB9B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB9A0 Offset: 0x1EADA0 VA: 0x1801EB9A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372DE0 Offset: 0x13713E0 VA: 0x181372DE0
	private static void .cctor() { }

}

