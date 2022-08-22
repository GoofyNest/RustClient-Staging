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

	// RVA: 0x1E9100 Offset: 0x1E8500 VA: 0x1801E9100 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E90F0 Offset: 0x1E84F0 VA: 0x1801E90F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370AB0 Offset: 0x136F0B0 VA: 0x181370AB0
	private static void .cctor() { }

}

