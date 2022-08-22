internal struct AvatarImageLoaded_t : ICallbackData // TypeDefIndex: 5311
{	// Fields
	internal ulong SteamID; // 0x0
	internal int Image; // 0x8
	internal int Wide; // 0xC
	internal int Tall; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4540 Offset: 0x1E3940 VA: 0x1801E4540 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4530 Offset: 0x1E3930 VA: 0x1801E4530 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B300 Offset: 0x1369900 VA: 0x18136B300
	private static void .cctor() { }

}

