internal struct MarketEligibilityResponse_t : ICallbackData // TypeDefIndex: 5305
{	// Fields
	internal bool Allowed; // 0x0
	internal MarketNotAllowedReasonFlags NotAllowedReason; // 0x4
	internal uint TAllowedAtTime; // 0x8
	internal int CdaySteamGuardRequiredDays; // 0xC
	internal int CdayNewDeviceCooldown; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EBC50 Offset: 0x1EB050 VA: 0x1801EBC50 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EBC40 Offset: 0x1EB040 VA: 0x1801EBC40 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13731F0 Offset: 0x13717F0 VA: 0x1813731F0
	private static void .cctor() { }

}

