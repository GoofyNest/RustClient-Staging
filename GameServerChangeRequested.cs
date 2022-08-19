internal struct GameServerChangeRequested_t : ICallbackData // TypeDefIndex: 5309
{	// Fields
	internal byte[] Server; // 0x0
	internal byte[] Password; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7E60 Offset: 0x1E7260 VA: 0x1801E7E60
	internal string ServerUTF8() { }

	// RVA: 0x1E7DE0 Offset: 0x1E71E0 VA: 0x1801E7DE0
	internal string PasswordUTF8() { }

	// RVA: 0x1E7EF0 Offset: 0x1E72F0 VA: 0x1801E7EF0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7EE0 Offset: 0x1E72E0 VA: 0x1801E7EE0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371460 Offset: 0x136FA60 VA: 0x181371460
	private static void .cctor() { }

}

