internal struct HTTPRequestCompleted_t : ICallbackData // TypeDefIndex: 5424
{	// Fields
	internal uint Request; // 0x0
	internal ulong ContextValue; // 0x8
	internal bool RequestSuccessful; // 0x10
	internal HTTPStatusCode StatusCode; // 0x14
	internal uint BodySize; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA7C0 Offset: 0x1E9BC0 VA: 0x1801EA7C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA7B0 Offset: 0x1E9BB0 VA: 0x1801EA7B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13729E0 Offset: 0x1370FE0 VA: 0x1813729E0
	private static void .cctor() { }

}

