internal struct GSClientGroupStatus_t : ICallbackData // TypeDefIndex: 5496
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal ulong SteamIDGroup; // 0x8
	internal bool Member; // 0x10
	internal bool Officer; // 0x11
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E79A0 Offset: 0x1E6DA0 VA: 0x1801E79A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7990 Offset: 0x1E6D90 VA: 0x1801E7990 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136FD90 Offset: 0x136E390 VA: 0x18136FD90
	private static void .cctor() { }

}

