internal struct GSGameplayStats_t : ICallbackData // TypeDefIndex: 5495
{	// Fields
	internal Result Result; // 0x0
	internal int Rank; // 0x4
	internal uint TotalConnects; // 0x8
	internal uint TotalMinutesPlayed; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7660 Offset: 0x1E6A60 VA: 0x1801E7660 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7650 Offset: 0x1E6A50 VA: 0x1801E7650 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370B10 Offset: 0x136F110 VA: 0x181370B10
	private static void .cctor() { }

}

