internal struct UserAchievementIconFetched_t : ICallbackData // TypeDefIndex: 5394
{	// Fields
	internal GameId GameID; // 0x0
	internal byte[] AchievementName; // 0x8
	internal bool Achieved; // 0x10
	internal int IconHandle; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DBB10 Offset: 0x1DAF10 VA: 0x1801DBB10
	internal string AchievementNameUTF8() { }

	// RVA: 0x1DBBA0 Offset: 0x1DAFA0 VA: 0x1801DBBA0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DBB90 Offset: 0x1DAF90 VA: 0x1801DBB90 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1292420 Offset: 0x1290A20 VA: 0x181292420
	private static void .cctor() { }

}

