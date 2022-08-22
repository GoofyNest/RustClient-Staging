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

	// RVA: 0x1E58A0 Offset: 0x1E4CA0 VA: 0x1801E58A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5890 Offset: 0x1E4C90 VA: 0x1801E5890 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136F3E0 Offset: 0x136D9E0 VA: 0x18136F3E0
	private static void .cctor() { }

}

