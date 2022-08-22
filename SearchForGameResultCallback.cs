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

	// RVA: 0x1D7E30 Offset: 0x1D7230 VA: 0x1801D7E30 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7E20 Offset: 0x1D7220 VA: 0x1801D7E20 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128F0B0 Offset: 0x128D6B0 VA: 0x18128F0B0
	private static void .cctor() { }

}

