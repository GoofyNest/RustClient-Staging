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

	// RVA: 0x1EAB60 Offset: 0x1E9F60 VA: 0x1801EAB60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EAB50 Offset: 0x1E9F50 VA: 0x1801EAB50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371DA0 Offset: 0x13703A0 VA: 0x181371DA0
	private static void .cctor() { }

}

