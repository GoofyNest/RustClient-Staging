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

	// RVA: 0x1E4690 Offset: 0x1E3A90 VA: 0x1801E4690 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4680 Offset: 0x1E3A80 VA: 0x1801E4680 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E250 Offset: 0x136C850 VA: 0x18136E250
	private static void .cctor() { }

}

