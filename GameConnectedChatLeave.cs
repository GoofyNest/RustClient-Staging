internal struct GameConnectedChatLeave_t : ICallbackData // TypeDefIndex: 5317
{	// Fields
	internal ulong SteamIDClanChat; // 0x0
	internal ulong SteamIDUser; // 0x8
	internal bool Kicked; // 0x10
	internal bool Dropped; // 0x11
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7900 Offset: 0x1E6D00 VA: 0x1801E7900 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E78F0 Offset: 0x1E6CF0 VA: 0x1801E78F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371190 Offset: 0x136F790 VA: 0x181371190
	private static void .cctor() { }

}

