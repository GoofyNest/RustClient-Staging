internal struct GetAppDependenciesResult_t : ICallbackData // TypeDefIndex: 5445
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal AppId[] GAppIDs; // 0x10
	internal uint NumAppDependencies; // 0x18
	internal uint TotalNumAppDependencies; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E8D60 Offset: 0x1E8160 VA: 0x1801E8D60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E8D50 Offset: 0x1E8150 VA: 0x1801E8D50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13716F0 Offset: 0x136FCF0 VA: 0x1813716F0
	private static void .cctor() { }

}
