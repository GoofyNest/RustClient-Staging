internal struct DownloadItemResult_t : ICallbackData // TypeDefIndex: 5435
{	// Fields
	internal AppId AppID; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal Result Result; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E5480 Offset: 0x1E4880 VA: 0x1801E5480 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5470 Offset: 0x1E4870 VA: 0x1801E5470 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370020 Offset: 0x136E620 VA: 0x181370020
	private static void .cctor() { }

}

