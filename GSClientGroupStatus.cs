internal struct GSClientGroupStatus_t : ICallbackData // TypeDefIndex: 5496
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal ulong SteamIDGroup; // 0x8
	internal bool Member; // 0x10
	internal bool Officer; // 0x11
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7580 Offset: 0x1E6980 VA: 0x1801E7580 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7570 Offset: 0x1E6970 VA: 0x1801E7570 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13709D0 Offset: 0x136EFD0 VA: 0x1813709D0
	private static void .cctor() { }

}

