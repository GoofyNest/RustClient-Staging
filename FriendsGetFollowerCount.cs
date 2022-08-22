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

	// RVA: 0x1E66C0 Offset: 0x1E5AC0 VA: 0x1801E66C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E66B0 Offset: 0x1E5AB0 VA: 0x1801E66B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136FA60 Offset: 0x136E060 VA: 0x18136FA60
	private static void .cctor() { }

}

