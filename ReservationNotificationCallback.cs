internal struct ReservationNotificationCallback_t : ICallbackData // TypeDefIndex: 5357
{	// Fields
	internal ulong BeaconID; // 0x0
	internal ulong SteamIDJoiner; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7B70 Offset: 0x1D6F70 VA: 0x1801D7B70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7B60 Offset: 0x1D6F60 VA: 0x1801D7B60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EE10 Offset: 0x128D410 VA: 0x18128EE10
	private static void .cctor() { }

}

