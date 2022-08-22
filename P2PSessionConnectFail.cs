internal struct P2PSessionConnectFail_t : ICallbackData // TypeDefIndex: 5405
{	// Fields
	internal ulong SteamIDRemote; // 0x0
	internal byte P2PSessionError; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EC7E0 Offset: 0x1EBBE0 VA: 0x1801EC7E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EC7D0 Offset: 0x1EBBD0 VA: 0x1801EC7D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13747E0 Offset: 0x1372DE0 VA: 0x1813747E0
	private static void .cctor() { }

}

