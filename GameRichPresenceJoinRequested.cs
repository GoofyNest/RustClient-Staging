internal struct GameRichPresenceJoinRequested_t : ICallbackData // TypeDefIndex: 5314
{	// Fields
	internal ulong SteamIDFriend; // 0x0
	internal byte[] Connect; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7B20 Offset: 0x1E6F20 VA: 0x1801E7B20
	internal string ConnectUTF8() { }

	// RVA: 0x1E7BB0 Offset: 0x1E6FB0 VA: 0x1801E7BB0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7BA0 Offset: 0x1E6FA0 VA: 0x1801E7BA0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13712B0 Offset: 0x136F8B0 VA: 0x1813712B0
	private static void .cctor() { }

}

