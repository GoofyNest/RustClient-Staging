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

	// RVA: 0x1E7D90 Offset: 0x1E7190 VA: 0x1801E7D90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7D80 Offset: 0x1E7180 VA: 0x1801E7D80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370330 Offset: 0x136E930 VA: 0x181370330
	private static void .cctor() { }

}

