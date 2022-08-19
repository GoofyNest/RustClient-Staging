internal struct UserFavoriteItemsListChanged_t : ICallbackData // TypeDefIndex: 5436
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal Result Result; // 0x8
	internal bool WasAddRequest; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DC760 Offset: 0x1DBB60 VA: 0x1801DC760 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC750 Offset: 0x1DBB50 VA: 0x1801DC750 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291CA0 Offset: 0x12902A0 VA: 0x181291CA0
	private static void .cctor() { }

}

