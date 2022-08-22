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

	// RVA: 0x1E8CE0 Offset: 0x1E80E0 VA: 0x1801E8CE0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E8CD0 Offset: 0x1E80D0 VA: 0x1801E8CD0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13719B0 Offset: 0x136FFB0 VA: 0x1813719B0
	private static void .cctor() { }

}

