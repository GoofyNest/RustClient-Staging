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

	// RVA: 0x1EA7B0 Offset: 0x1E9BB0 VA: 0x1801EA7B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA7A0 Offset: 0x1E9BA0 VA: 0x1801EA7A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372D40 Offset: 0x1371340 VA: 0x181372D40
	private static void .cctor() { }

}

