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

	// RVA: 0x1DC420 Offset: 0x1DB820 VA: 0x1801DC420
	internal string AchievementNameUTF8() { }

	// RVA: 0x1DC4B0 Offset: 0x1DB8B0 VA: 0x1801DC4B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC4A0 Offset: 0x1DB8A0 VA: 0x1801DC4A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1292550 Offset: 0x1290B50 VA: 0x181292550
	private static void .cctor() { }

}

