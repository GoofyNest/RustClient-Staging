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

	// RVA: 0x1DC910 Offset: 0x1DBD10 VA: 0x1801DC910 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC900 Offset: 0x1DBD00 VA: 0x1801DC900 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12922B0 Offset: 0x12908B0 VA: 0x1812922B0
	private static void .cctor() { }

}

