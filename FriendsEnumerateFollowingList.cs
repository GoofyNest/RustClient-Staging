internal struct FriendsEnumerateFollowingList_t : ICallbackData // TypeDefIndex: 5323
{	// Fields
	internal Result Result; // 0x0
	internal ulong[] GSteamID; // 0x8
	internal int ResultsReturned; // 0x10
	internal int TotalResultCount; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E5F10 Offset: 0x1E5310 VA: 0x1801E5F10 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5F00 Offset: 0x1E5300 VA: 0x1801E5F00 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136F9C0 Offset: 0x136DFC0 VA: 0x18136F9C0
	private static void .cctor() { }

}

