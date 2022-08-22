internal struct GameServerChangeRequested_t : ICallbackData // TypeDefIndex: 5309
{	// Fields
	internal byte[] Server; // 0x0
	internal byte[] Password; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E8200 Offset: 0x1E7600 VA: 0x1801E8200
	internal string ServerUTF8() { }

	// RVA: 0x1E8180 Offset: 0x1E7580 VA: 0x1801E8180
	internal string PasswordUTF8() { }

	// RVA: 0x1E8290 Offset: 0x1E7690 VA: 0x1801E8290 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E8280 Offset: 0x1E7680 VA: 0x1801E8280 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370820 Offset: 0x136EE20 VA: 0x181370820
	private static void .cctor() { }

}

