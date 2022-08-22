internal struct GSClientKick_t : ICallbackData // TypeDefIndex: 5492
{	// Fields
	internal ulong SteamID; // 0x0
	internal DenyReason DenyReason; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E75F0 Offset: 0x1E69F0 VA: 0x1801E75F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E75E0 Offset: 0x1E69E0 VA: 0x1801E75E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370D30 Offset: 0x136F330 VA: 0x181370D30
	private static void .cctor() { }

}

