internal struct GSStatsReceived_t : ICallbackData // TypeDefIndex: 5500
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamIDUser; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7830 Offset: 0x1E6C30 VA: 0x1801E7830 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7820 Offset: 0x1E6C20 VA: 0x1801E7820 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370CF0 Offset: 0x136F2F0 VA: 0x181370CF0
	private static void .cctor() { }

}

