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

	// RVA: 0x1DC6E0 Offset: 0x1DBAE0 VA: 0x1801DC6E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC6D0 Offset: 0x1DBAD0 VA: 0x1801DC6D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291F60 Offset: 0x1290560 VA: 0x181291F60
	private static void .cctor() { }

}

