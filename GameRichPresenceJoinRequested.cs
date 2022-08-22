internal struct GameRichPresenceJoinRequested_t : ICallbackData // TypeDefIndex: 5314
{	// Fields
	internal ulong SteamIDFriend; // 0x0
	internal byte[] Connect; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7F40 Offset: 0x1E7340 VA: 0x1801E7F40
	internal string ConnectUTF8() { }

	// RVA: 0x1E7FD0 Offset: 0x1E73D0 VA: 0x1801E7FD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7FC0 Offset: 0x1E73C0 VA: 0x1801E7FC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370670 Offset: 0x136EC70 VA: 0x181370670
	private static void .cctor() { }

}

