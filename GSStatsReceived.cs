internal struct GSStatsReceived_t : ICallbackData // TypeDefIndex: 5500
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamIDUser; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7BD0 Offset: 0x1E6FD0 VA: 0x1801E7BD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7BC0 Offset: 0x1E6FC0 VA: 0x1801E7BC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13700B0 Offset: 0x136E6B0 VA: 0x1813700B0
	private static void .cctor() { }

}

