internal struct LobbyInvite_t : ICallbackData // TypeDefIndex: 5336
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal ulong SteamIDLobby; // 0x8
	internal ulong GameID; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB6F0 Offset: 0x1EAAF0 VA: 0x1801EB6F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB6E0 Offset: 0x1EAAE0 VA: 0x1801EB6E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373B80 Offset: 0x1372180 VA: 0x181373B80
	private static void .cctor() { }

}

