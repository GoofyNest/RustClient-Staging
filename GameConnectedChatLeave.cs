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

	// RVA: 0x1E7D20 Offset: 0x1E7120 VA: 0x1801E7D20 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7D10 Offset: 0x1E7110 VA: 0x1801E7D10 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370290 Offset: 0x136E890 VA: 0x181370290
	private static void .cctor() { }

}

