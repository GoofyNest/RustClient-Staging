internal struct GSClientKick_t : ICallbackData // TypeDefIndex: 5492
{	// Fields
	internal ulong SteamID; // 0x0
	internal DenyReason DenyReason; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7A10 Offset: 0x1E6E10 VA: 0x1801E7A10 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7A00 Offset: 0x1E6E00 VA: 0x1801E7A00 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136FE30 Offset: 0x136E430 VA: 0x18136FE30
	private static void .cctor() { }

}

