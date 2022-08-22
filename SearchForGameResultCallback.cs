internal struct SearchForGameResultCallback_t : ICallbackData // TypeDefIndex: 5348
{	// Fields
	internal ulong LSearchID; // 0x0
	internal Result Result; // 0x8
	internal int CountPlayersInGame; // 0xC
	internal int CountAcceptedGame; // 0x10
	internal ulong SteamIDHost; // 0x14
	internal bool FinalCallback; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D84A0 Offset: 0x1D78A0 VA: 0x1801D84A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8490 Offset: 0x1D7890 VA: 0x1801D8490 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128F750 Offset: 0x128DD50 VA: 0x18128F750
	private static void .cctor() { }

}

