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

	// RVA: 0x1EB3F0 Offset: 0x1EA7F0 VA: 0x1801EB3F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB3E0 Offset: 0x1EA7E0 VA: 0x1801EB3E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372750 Offset: 0x1370D50 VA: 0x181372750
	private static void .cctor() { }

}

