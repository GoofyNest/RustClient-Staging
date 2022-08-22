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

	// RVA: 0x1E7970 Offset: 0x1E6D70 VA: 0x1801E7970 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7960 Offset: 0x1E6D60 VA: 0x1801E7960 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370F70 Offset: 0x136F570 VA: 0x181370F70
	private static void .cctor() { }

}

