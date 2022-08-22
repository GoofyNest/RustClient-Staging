internal struct P2PSessionConnectFail_t : ICallbackData // TypeDefIndex: 5405
{	// Fields
	internal ulong SteamIDRemote; // 0x0
	internal byte P2PSessionError; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EC3C0 Offset: 0x1EB7C0 VA: 0x1801EC3C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EC3B0 Offset: 0x1EB7B0 VA: 0x1801EC3B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13756E0 Offset: 0x1373CE0 VA: 0x1813756E0
	private static void .cctor() { }

}

