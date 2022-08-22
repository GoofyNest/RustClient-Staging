internal struct LobbyChatMsg_t : ICallbackData // TypeDefIndex: 5340
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDUser; // 0x8
	internal byte ChatEntryType; // 0x10
	internal uint ChatID; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB3D0 Offset: 0x1EA7D0 VA: 0x1801EB3D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB3C0 Offset: 0x1EA7C0 VA: 0x1801EB3C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373A20 Offset: 0x1372020 VA: 0x181373A20
	private static void .cctor() { }

}

