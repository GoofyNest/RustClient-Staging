internal struct GameConnectedFriendChatMsg_t : ICallbackData // TypeDefIndex: 5320
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal int MessageID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7A60 Offset: 0x1E6E60 VA: 0x1801E7A60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7A50 Offset: 0x1E6E50 VA: 0x1801E7A50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371020 Offset: 0x136F620 VA: 0x181371020
	private static void .cctor() { }

}

