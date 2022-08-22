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

	// RVA: 0x1DD060 Offset: 0x1DC460 VA: 0x1801DD060 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DD050 Offset: 0x1DC450 VA: 0x1801DD050 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1292AB0 Offset: 0x12910B0 VA: 0x181292AB0
	private static void .cctor() { }

}

