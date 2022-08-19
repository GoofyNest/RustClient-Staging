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

	// RVA: 0x1EB050 Offset: 0x1EA450 VA: 0x1801EB050 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB040 Offset: 0x1EA440 VA: 0x1801EB040 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373390 Offset: 0x1371990 VA: 0x181373390
	private static void .cctor() { }

}

