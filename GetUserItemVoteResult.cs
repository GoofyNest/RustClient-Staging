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

	// RVA: 0x1E9610 Offset: 0x1E8A10 VA: 0x1801E9610 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9600 Offset: 0x1E8A00 VA: 0x1801E9600 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370CA0 Offset: 0x136F2A0 VA: 0x181370CA0
	private static void .cctor() { }

}

