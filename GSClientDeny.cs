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

	// RVA: 0x1E7130 Offset: 0x1E6530 VA: 0x1801E7130 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7120 Offset: 0x1E6520 VA: 0x1801E7120 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136FCF0 Offset: 0x136E2F0 VA: 0x18136FCF0
	private static void .cctor() { }

}

