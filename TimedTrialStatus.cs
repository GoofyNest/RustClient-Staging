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

	// RVA: 0x1DB140 Offset: 0x1DA540 VA: 0x1801DB140 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DB130 Offset: 0x1DA530 VA: 0x1801DB130 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291480 Offset: 0x128FA80 VA: 0x181291480
	private static void .cctor() { }

}

