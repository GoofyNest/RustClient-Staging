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

	// RVA: 0x1E64B0 Offset: 0x1E58B0 VA: 0x1801E64B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E64A0 Offset: 0x1E58A0 VA: 0x1801E64A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13707F0 Offset: 0x136EDF0 VA: 0x1813707F0
	private static void .cctor() { }

}

