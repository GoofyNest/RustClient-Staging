internal struct ClanOfficerListResponse_t : ICallbackData // TypeDefIndex: 5312
{	// Fields
	internal ulong SteamIDClan; // 0x0
	internal int COfficers; // 0x8
	internal byte Success; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4AB0 Offset: 0x1E3EB0 VA: 0x1801E4AB0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4AA0 Offset: 0x1E3EA0 VA: 0x1801E4AA0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D610 Offset: 0x136BC10 VA: 0x18136D610
	private static void .cctor() { }

}

