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

	// RVA: 0x1DCD50 Offset: 0x1DC150 VA: 0x1801DCD50 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DCD40 Offset: 0x1DC140 VA: 0x1801DCD40 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1292600 Offset: 0x1290C00 VA: 0x181292600
	private static void .cctor() { }

}

