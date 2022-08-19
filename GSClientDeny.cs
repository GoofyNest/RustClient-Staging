internal struct GSClientDeny_t : ICallbackData // TypeDefIndex: 5491
{	// Fields
	internal ulong SteamID; // 0x0
	internal DenyReason DenyReason; // 0x8
	internal byte[] OptionalText; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E6D90 Offset: 0x1E6190 VA: 0x1801E6D90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E6D80 Offset: 0x1E6180 VA: 0x1801E6D80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370930 Offset: 0x136EF30 VA: 0x181370930
	private static void .cctor() { }

}

