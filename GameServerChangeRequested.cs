internal struct GameServerChangeRequested_t : ICallbackData // TypeDefIndex: 5309
{	// Fields
	internal byte[] Server; // 0x0
	internal byte[] Password; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7DE0 Offset: 0x1E71E0 VA: 0x1801E7DE0
	internal string ServerUTF8() { }

	// RVA: 0x1E7D60 Offset: 0x1E7160 VA: 0x1801E7D60
	internal string PasswordUTF8() { }

	// RVA: 0x1E7E70 Offset: 0x1E7270 VA: 0x1801E7E70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7E60 Offset: 0x1E7260 VA: 0x1801E7E60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371460 Offset: 0x136FA60 VA: 0x181371460
	private static void .cctor() { }

}

