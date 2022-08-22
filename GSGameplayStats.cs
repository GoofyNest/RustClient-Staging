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

	// RVA: 0x1E7A80 Offset: 0x1E6E80 VA: 0x1801E7A80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7A70 Offset: 0x1E6E70 VA: 0x1801E7A70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136FED0 Offset: 0x136E4D0 VA: 0x18136FED0
	private static void .cctor() { }

}

