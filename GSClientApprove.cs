internal struct GSClientApprove_t : ICallbackData // TypeDefIndex: 5490
{	// Fields
	internal ulong SteamID; // 0x0
	internal ulong OwnerSteamID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E70C0 Offset: 0x1E64C0 VA: 0x1801E70C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E70B0 Offset: 0x1E64B0 VA: 0x1801E70B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136FC50 Offset: 0x136E250 VA: 0x18136FC50
	private static void .cctor() { }

}

