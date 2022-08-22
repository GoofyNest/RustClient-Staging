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

	// RVA: 0x1DCDC0 Offset: 0x1DC1C0 VA: 0x1801DCDC0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DCDB0 Offset: 0x1DC1B0 VA: 0x1801DCDB0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12926A0 Offset: 0x1290CA0 VA: 0x1812926A0
	private static void .cctor() { }

}

