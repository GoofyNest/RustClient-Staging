internal struct GetUserItemVoteResult_t : ICallbackData // TypeDefIndex: 5438
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal Result Result; // 0x8
	internal bool VotedUp; // 0xC
	internal bool VotedDown; // 0xD
	internal bool VoteSkipped; // 0xE
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9270 Offset: 0x1E8670 VA: 0x1801E9270 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9260 Offset: 0x1E8660 VA: 0x1801E9260 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13718E0 Offset: 0x136FEE0 VA: 0x1813718E0
	private static void .cctor() { }

}

