internal struct JoinClanChatRoomCompletionResult_t : ICallbackData // TypeDefIndex: 5319
{	// Fields
	internal ulong SteamIDClanChat; // 0x0
	internal RoomEnter ChatRoomEnterResponse; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EAFE0 Offset: 0x1EA3E0 VA: 0x1801EAFE0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EAFD0 Offset: 0x1EA3D0 VA: 0x1801EAFD0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13732F0 Offset: 0x13718F0 VA: 0x1813732F0
	private static void .cctor() { }

}
