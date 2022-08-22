internal struct FriendsGetFollowerCount_t : ICallbackData // TypeDefIndex: 5321
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamID; // 0x4
	internal int Count; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E62A0 Offset: 0x1E56A0 VA: 0x1801E62A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E6290 Offset: 0x1E5690 VA: 0x1801E6290 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370960 Offset: 0x136EF60 VA: 0x181370960
	private static void .cctor() { }

}

