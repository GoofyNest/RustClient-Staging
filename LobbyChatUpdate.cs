internal struct LobbyChatUpdate_t : ICallbackData // TypeDefIndex: 5339
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDUserChanged; // 0x8
	internal ulong SteamIDMakingChange; // 0x10
	internal uint GfChatMemberStateChange; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB860 Offset: 0x1EAC60 VA: 0x1801EB860 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB850 Offset: 0x1EAC50 VA: 0x1801EB850 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372BD0 Offset: 0x13711D0 VA: 0x181372BD0
	private static void .cctor() { }

}

