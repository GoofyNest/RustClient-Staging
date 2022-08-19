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

	// RVA: 0x1E45C0 Offset: 0x1E39C0 VA: 0x1801E45C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E45B0 Offset: 0x1E39B0 VA: 0x1801E45B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B040 Offset: 0x1369640 VA: 0x18136B040
	private static void .cctor() { }

}

