internal struct GetVideoURLResult_t : ICallbackData // TypeDefIndex: 5480
{	// Fields
	internal Result Result; // 0x0
	internal AppId VideoAppID; // 0x4
	internal byte[] URL; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9680 Offset: 0x1E8A80 VA: 0x1801E9680 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9670 Offset: 0x1E8A70 VA: 0x1801E9670 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370D40 Offset: 0x136F340 VA: 0x181370D40
	private static void .cctor() { }

}

