internal struct PSNGameBootInviteResult_t : ICallbackData // TypeDefIndex: 5345
{	// Fields
	internal bool GameBootInviteExists; // 0x0
	internal ulong SteamIDLobby; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EC520 Offset: 0x1EB920 VA: 0x1801EC520 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EC510 Offset: 0x1EB910 VA: 0x1801EC510 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1375580 Offset: 0x1373B80 VA: 0x181375580
	private static void .cctor() { }

}

