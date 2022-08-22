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

	// RVA: 0x1E67E0 Offset: 0x1E5BE0 VA: 0x1801E67E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E67D0 Offset: 0x1E5BD0 VA: 0x1801E67D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136FB10 Offset: 0x136E110 VA: 0x18136FB10
	private static void .cctor() { }

}

