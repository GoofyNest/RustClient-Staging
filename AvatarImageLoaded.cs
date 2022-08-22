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

	// RVA: 0x1E4960 Offset: 0x1E3D60 VA: 0x1801E4960 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4950 Offset: 0x1E3D50 VA: 0x1801E4950 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136A400 Offset: 0x1368A00 VA: 0x18136A400
	private static void .cctor() { }

}

