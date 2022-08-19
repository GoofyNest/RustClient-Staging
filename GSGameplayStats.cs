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

	// RVA: 0x1E76E0 Offset: 0x1E6AE0 VA: 0x1801E76E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E76D0 Offset: 0x1E6AD0 VA: 0x1801E76D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370B10 Offset: 0x136F110 VA: 0x181370B10
	private static void .cctor() { }

}

