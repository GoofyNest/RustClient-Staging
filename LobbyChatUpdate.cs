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

	// RVA: 0x1EB4C0 Offset: 0x1EA8C0 VA: 0x1801EB4C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB4B0 Offset: 0x1EA8B0 VA: 0x1801EB4B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373810 Offset: 0x1371E10 VA: 0x181373810
	private static void .cctor() { }

}
