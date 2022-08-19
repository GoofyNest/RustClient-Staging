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

	// RVA: 0x1DC990 Offset: 0x1DBD90 VA: 0x1801DC990 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC980 Offset: 0x1DBD80 VA: 0x1801DC980 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291FF0 Offset: 0x12905F0 VA: 0x181291FF0
	private static void .cctor() { }

}

