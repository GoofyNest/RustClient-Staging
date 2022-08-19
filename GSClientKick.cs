internal struct GSClientKick_t : ICallbackData // TypeDefIndex: 5492
{	// Fields
	internal ulong SteamID; // 0x0
	internal DenyReason DenyReason; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7670 Offset: 0x1E6A70 VA: 0x1801E7670 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7660 Offset: 0x1E6A60 VA: 0x1801E7660 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370A70 Offset: 0x136F070 VA: 0x181370A70
	private static void .cctor() { }

}

