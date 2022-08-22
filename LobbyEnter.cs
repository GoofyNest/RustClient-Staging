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

	// RVA: 0x1EB590 Offset: 0x1EA990 VA: 0x1801EB590 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB580 Offset: 0x1EA980 VA: 0x1801EB580 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373CE0 Offset: 0x13722E0 VA: 0x181373CE0
	private static void .cctor() { }

}

