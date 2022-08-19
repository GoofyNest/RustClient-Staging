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

	// RVA: 0x1E6320 Offset: 0x1E5720 VA: 0x1801E6320 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E6310 Offset: 0x1E5710 VA: 0x1801E6310 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13706A0 Offset: 0x136ECA0 VA: 0x1813706A0
	private static void .cctor() { }

}

