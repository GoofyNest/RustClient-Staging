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

	// RVA: 0x1DB1C0 Offset: 0x1DA5C0 VA: 0x1801DB1C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DB1B0 Offset: 0x1DA5B0 VA: 0x1801DB1B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12911C0 Offset: 0x128F7C0 VA: 0x1812911C0
	private static void .cctor() { }

}

