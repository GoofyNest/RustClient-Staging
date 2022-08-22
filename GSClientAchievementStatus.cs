internal struct GSClientAchievementStatus_t : ICallbackData // TypeDefIndex: 5493
{	// Fields
	internal ulong SteamID; // 0x0
	internal byte[] PchAchievement; // 0x8
	internal bool Unlocked; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E6850 Offset: 0x1E5C50 VA: 0x1801E6850 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E6840 Offset: 0x1E5C40 VA: 0x1801E6840 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136FBB0 Offset: 0x136E1B0 VA: 0x18136FBB0
	private static void .cctor() { }

}

