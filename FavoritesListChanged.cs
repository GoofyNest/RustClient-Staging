internal struct FavoritesListChanged_t : ICallbackData // TypeDefIndex: 5335
{	// Fields
	internal uint IP; // 0x0
	internal uint QueryPort; // 0x4
	internal uint ConnPort; // 0x8
	internal uint AppID; // 0xC
	internal uint Flags; // 0x10
	internal bool Add; // 0x14
	internal uint AccountId; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E5AD0 Offset: 0x1E4ED0 VA: 0x1801E5AD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5AC0 Offset: 0x1E4EC0 VA: 0x1801E5AC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136F730 Offset: 0x136DD30 VA: 0x18136F730
	private static void .cctor() { }

}

