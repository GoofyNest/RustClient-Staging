internal struct GameConnectedClanChatMsg_t : ICallbackData // TypeDefIndex: 5315
{	// Fields
	internal ulong SteamIDClanChat; // 0x0
	internal ulong SteamIDUser; // 0x8
	internal int MessageID; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E79F0 Offset: 0x1E6DF0 VA: 0x1801E79F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E79E0 Offset: 0x1E6DE0 VA: 0x1801E79E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370F70 Offset: 0x136F570 VA: 0x181370F70
	private static void .cctor() { }

}

