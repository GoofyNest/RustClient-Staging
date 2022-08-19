internal struct P2PSessionConnectFail_t : ICallbackData // TypeDefIndex: 5405
{	// Fields
	internal ulong SteamIDRemote; // 0x0
	internal byte P2PSessionError; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EC440 Offset: 0x1EB840 VA: 0x1801EC440 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EC430 Offset: 0x1EB830 VA: 0x1801EC430 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1375420 Offset: 0x1373A20 VA: 0x181375420
	private static void .cctor() { }

}

