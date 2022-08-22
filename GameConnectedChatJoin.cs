internal struct GameConnectedChatJoin_t : ICallbackData // TypeDefIndex: 5316
{	// Fields
	internal ulong SteamIDClanChat; // 0x0
	internal ulong SteamIDUser; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7CB0 Offset: 0x1E70B0 VA: 0x1801E7CB0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7CA0 Offset: 0x1E70A0 VA: 0x1801E7CA0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13701F0 Offset: 0x136E7F0 VA: 0x1813701F0
	private static void .cctor() { }

}

