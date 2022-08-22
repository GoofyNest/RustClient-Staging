internal struct JoinPartyCallback_t : ICallbackData // TypeDefIndex: 5355
{	// Fields
	internal Result Result; // 0x0
	internal ulong BeaconID; // 0x8
	internal ulong SteamIDBeaconOwner; // 0x10
	internal byte[] ConnectString; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EAFD0 Offset: 0x1EA3D0 VA: 0x1801EAFD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EAFC0 Offset: 0x1EA3C0 VA: 0x1801EAFC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373650 Offset: 0x1371C50 VA: 0x181373650
	private static void .cctor() { }

}

