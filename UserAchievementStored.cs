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

	// RVA: 0x1DBDB0 Offset: 0x1DB1B0 VA: 0x1801DBDB0
	internal string AchievementNameUTF8() { }

	// RVA: 0x1DBE40 Offset: 0x1DB240 VA: 0x1801DBE40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DBE30 Offset: 0x1DB230 VA: 0x1801DBE30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291EB0 Offset: 0x12904B0 VA: 0x181291EB0
	private static void .cctor() { }

}

