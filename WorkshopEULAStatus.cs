internal struct WorkshopEULAStatus_t : ICallbackData // TypeDefIndex: 5448
{	// Fields
	internal Result Result; // 0x0
	internal AppId AppID; // 0x4
	internal uint Version; // 0x8
	internal uint TAction; // 0xC
	internal bool Accepted; // 0x10
	internal bool NeedsAction; // 0x11
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DC9F0 Offset: 0x1DBDF0 VA: 0x1801DC9F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC9E0 Offset: 0x1DBDE0 VA: 0x1801DC9E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1292410 Offset: 0x1290A10 VA: 0x181292410
	private static void .cctor() { }

}

