internal struct HTTPRequestDataReceived_t : ICallbackData // TypeDefIndex: 5426
{	// Fields
	internal uint Request; // 0x0
	internal ulong ContextValue; // 0x8
	internal uint COffset; // 0x10
	internal uint CBytesReceived; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA830 Offset: 0x1E9C30 VA: 0x1801EA830 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA820 Offset: 0x1E9C20 VA: 0x1801EA820 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372A80 Offset: 0x1371080 VA: 0x181372A80
	private static void .cctor() { }

}

