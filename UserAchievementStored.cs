internal struct UserAchievementStored_t : ICallbackData // TypeDefIndex: 5388
{	// Fields
	internal ulong GameID; // 0x0
	internal bool GroupAchievement; // 0x8
	internal byte[] AchievementName; // 0x10
	internal uint CurProgress; // 0x18
	internal uint MaxProgress; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DBE30 Offset: 0x1DB230 VA: 0x1801DBE30
	internal string AchievementNameUTF8() { }

	// RVA: 0x1DBEC0 Offset: 0x1DB2C0 VA: 0x1801DBEC0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DBEB0 Offset: 0x1DB2B0 VA: 0x1801DBEB0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291BF0 Offset: 0x12901F0 VA: 0x181291BF0
	private static void .cctor() { }

}

