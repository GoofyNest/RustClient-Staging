internal struct GameConnectedFriendChatMsg_t : ICallbackData // TypeDefIndex: 5320
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal int MessageID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E79E0 Offset: 0x1E6DE0 VA: 0x1801E79E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E79D0 Offset: 0x1E6DD0 VA: 0x1801E79D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13712E0 Offset: 0x136F8E0 VA: 0x1813712E0
	private static void .cctor() { }

}

