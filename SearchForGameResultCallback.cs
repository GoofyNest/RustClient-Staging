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

	// RVA: 0x1D7EB0 Offset: 0x1D72B0 VA: 0x1801D7EB0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7EA0 Offset: 0x1D72A0 VA: 0x1801D7EA0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EDF0 Offset: 0x128D3F0 VA: 0x18128EDF0
	private static void .cctor() { }

}

