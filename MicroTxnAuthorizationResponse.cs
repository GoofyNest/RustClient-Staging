internal struct MicroTxnAuthorizationResponse_t : ICallbackData // TypeDefIndex: 5300
{	// Fields
	internal uint AppID; // 0x0
	internal ulong OrderID; // 0x8
	internal byte Authorized; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB9B0 Offset: 0x1EADB0 VA: 0x1801EB9B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB9A0 Offset: 0x1EADA0 VA: 0x1801EB9A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373ED0 Offset: 0x13724D0 VA: 0x181373ED0
	private static void .cctor() { }

}

