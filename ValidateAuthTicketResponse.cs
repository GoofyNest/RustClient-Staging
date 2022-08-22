internal struct ValidateAuthTicketResponse_t : ICallbackData // TypeDefIndex: 5299
{	// Fields
	internal ulong SteamID; // 0x0
	internal AuthResponse AuthSessionResponse; // 0x8
	internal ulong OwnerSteamID; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DCF80 Offset: 0x1DC380 VA: 0x1801DCF80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DCF70 Offset: 0x1DC370 VA: 0x1801DCF70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1292950 Offset: 0x1290F50 VA: 0x181292950
	private static void .cctor() { }

}

