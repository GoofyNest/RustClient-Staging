internal struct UserStatsReceived_t : ICallbackData // TypeDefIndex: 5386
{	// Fields
	internal ulong GameID; // 0x0
	internal Result Result; // 0x8
	internal ulong SteamIDUser; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DC750 Offset: 0x1DBB50 VA: 0x1801DC750 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC740 Offset: 0x1DBB40 VA: 0x1801DC740 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291D40 Offset: 0x1290340 VA: 0x181291D40
	private static void .cctor() { }

}

