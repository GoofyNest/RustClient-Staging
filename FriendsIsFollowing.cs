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

	// RVA: 0x1E63C0 Offset: 0x1E57C0 VA: 0x1801E63C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E63B0 Offset: 0x1E57B0 VA: 0x1801E63B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370750 Offset: 0x136ED50 VA: 0x181370750
	private static void .cctor() { }

}

