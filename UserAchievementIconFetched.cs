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

	// RVA: 0x1DB520 Offset: 0x1DA920 VA: 0x1801DB520
	internal string AchievementNameUTF8() { }

	// RVA: 0x1DB5B0 Offset: 0x1DA9B0 VA: 0x1801DB5B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DB5A0 Offset: 0x1DA9A0 VA: 0x1801DB5A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291AC0 Offset: 0x12900C0 VA: 0x181291AC0
	private static void .cctor() { }

}

