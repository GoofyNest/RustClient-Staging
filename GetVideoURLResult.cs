internal struct GetVideoURLResult_t : ICallbackData // TypeDefIndex: 5480
{	// Fields
	internal Result Result; // 0x0
	internal AppId VideoAppID; // 0x4
	internal byte[] URL; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9260 Offset: 0x1E8660 VA: 0x1801E9260 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9250 Offset: 0x1E8650 VA: 0x1801E9250 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371980 Offset: 0x136FF80 VA: 0x181371980
	private static void .cctor() { }

}

