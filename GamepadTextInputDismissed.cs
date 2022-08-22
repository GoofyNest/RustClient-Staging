internal struct GamepadTextInputDismissed_t : ICallbackData // TypeDefIndex: 5332
{	// Fields
	internal bool Submitted; // 0x0
	internal uint SubmittedText; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9090 Offset: 0x1E8490 VA: 0x1801E9090 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9080 Offset: 0x1E8480 VA: 0x1801E9080 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	private static void .cctor() { }

}

