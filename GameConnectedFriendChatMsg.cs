internal struct GameConnectedFriendChatMsg_t : ICallbackData // TypeDefIndex: 5320
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal int MessageID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7E00 Offset: 0x1E7200 VA: 0x1801E7E00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7DF0 Offset: 0x1E71F0 VA: 0x1801E7DF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13703E0 Offset: 0x136E9E0 VA: 0x1813703E0
	private static void .cctor() { }

}

