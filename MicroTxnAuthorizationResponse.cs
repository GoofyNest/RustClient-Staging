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

	// RVA: 0x1EBD50 Offset: 0x1EB150 VA: 0x1801EBD50 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EBD40 Offset: 0x1EB140 VA: 0x1801EBD40 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373290 Offset: 0x1371890 VA: 0x181373290
	private static void .cctor() { }

}

