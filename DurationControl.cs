internal struct DurationControl_t : ICallbackData // TypeDefIndex: 5306
{	// Fields
	internal Result Result; // 0x0
	internal AppId Appid; // 0x4
	internal bool Applicable; // 0x8
	internal int CsecsLast5h; // 0xC
	internal DurationControlProgress Progress; // 0x10
	internal DurationControlNotification Otification; // 0x14
	internal int CsecsToday; // 0x18
	internal int CsecsRemaining; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E5910 Offset: 0x1E4D10 VA: 0x1801E5910 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5900 Offset: 0x1E4D00 VA: 0x1801E5900 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136F490 Offset: 0x136DA90 VA: 0x18136F490
	private static void .cctor() { }

}

public struct DurationControl // TypeDefIndex: 5549
{	// Fields
	internal DurationControl_t _inner; // 0x0

}

