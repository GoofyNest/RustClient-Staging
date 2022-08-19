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

	// RVA: 0x1E5B70 Offset: 0x1E4F70 VA: 0x1801E5B70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5B60 Offset: 0x1E4F60 VA: 0x1801E5B60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370600 Offset: 0x136EC00 VA: 0x181370600
	private static void .cctor() { }

}

