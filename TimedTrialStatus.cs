internal struct TimedTrialStatus_t : ICallbackData // TypeDefIndex: 5403
{	// Fields
	internal AppId AppID; // 0x0
	internal bool IsOffline; // 0x4
	internal uint SecondsAllowed; // 0x8
	internal uint SecondsPlayed; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DB7B0 Offset: 0x1DABB0 VA: 0x1801DB7B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DB7A0 Offset: 0x1DABA0 VA: 0x1801DB7A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291B20 Offset: 0x1290120 VA: 0x181291B20
	private static void .cctor() { }

}

