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

	// RVA: 0x1EABD0 Offset: 0x1E9FD0 VA: 0x1801EABD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EABC0 Offset: 0x1E9FC0 VA: 0x1801EABC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371E40 Offset: 0x1370440 VA: 0x181371E40
	private static void .cctor() { }

}

