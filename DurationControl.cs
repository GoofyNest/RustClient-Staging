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

	// RVA: 0x1E5570 Offset: 0x1E4970 VA: 0x1801E5570 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5560 Offset: 0x1E4960 VA: 0x1801E5560 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13700D0 Offset: 0x136E6D0 VA: 0x1813700D0
	private static void .cctor() { }

}

public struct DurationControl // TypeDefIndex: 5549
{	// Fields
	internal DurationControl_t _inner; // 0x0

}

