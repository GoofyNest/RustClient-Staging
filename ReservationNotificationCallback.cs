internal struct ReservationNotificationCallback_t : ICallbackData // TypeDefIndex: 5357
{	// Fields
	internal ulong BeaconID; // 0x0
	internal ulong SteamIDJoiner; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D81E0 Offset: 0x1D75E0 VA: 0x1801D81E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D81D0 Offset: 0x1D75D0 VA: 0x1801D81D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128F4B0 Offset: 0x128DAB0 VA: 0x18128F4B0
	private static void .cctor() { }

}

