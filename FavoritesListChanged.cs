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

	// RVA: 0x1E5730 Offset: 0x1E4B30 VA: 0x1801E5730 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5720 Offset: 0x1E4B20 VA: 0x1801E5720 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370370 Offset: 0x136E970 VA: 0x181370370
	private static void .cctor() { }

}

