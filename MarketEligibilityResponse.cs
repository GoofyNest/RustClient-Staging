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

	// RVA: 0x1EB830 Offset: 0x1EAC30 VA: 0x1801EB830 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB820 Offset: 0x1EAC20 VA: 0x1801EB820 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373E30 Offset: 0x1372430 VA: 0x181373E30
	private static void .cctor() { }

}

