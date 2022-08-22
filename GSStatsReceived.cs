internal struct GSStatsReceived_t : ICallbackData // TypeDefIndex: 5500
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamIDUser; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E77B0 Offset: 0x1E6BB0 VA: 0x1801E77B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E77A0 Offset: 0x1E6BA0 VA: 0x1801E77A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370FB0 Offset: 0x136F5B0 VA: 0x181370FB0
	private static void .cctor() { }

}

