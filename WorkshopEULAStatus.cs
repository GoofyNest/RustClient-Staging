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

	// RVA: 0x1DCA70 Offset: 0x1DBE70 VA: 0x1801DCA70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DCA60 Offset: 0x1DBE60 VA: 0x1801DCA60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1292150 Offset: 0x1290750 VA: 0x181292150
	private static void .cctor() { }

}

