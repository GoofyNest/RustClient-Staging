internal struct LobbyDataUpdate_t : ICallbackData // TypeDefIndex: 5338
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDMember; // 0x8
	internal byte Success; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB5A0 Offset: 0x1EA9A0 VA: 0x1801EB5A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB590 Offset: 0x1EA990 VA: 0x1801EB590 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373970 Offset: 0x1371F70 VA: 0x181373970
	private static void .cctor() { }

}

