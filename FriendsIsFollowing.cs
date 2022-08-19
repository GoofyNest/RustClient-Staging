internal struct FriendsIsFollowing_t : ICallbackData // TypeDefIndex: 5322
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamID; // 0x4
	internal bool IsFollowing; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E6440 Offset: 0x1E5840 VA: 0x1801E6440 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E6430 Offset: 0x1E5830 VA: 0x1801E6430 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370750 Offset: 0x136ED50 VA: 0x181370750
	private static void .cctor() { }

}

