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

	// RVA: 0x1E91F0 Offset: 0x1E85F0 VA: 0x1801E91F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E91E0 Offset: 0x1E85E0 VA: 0x1801E91E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371BA0 Offset: 0x13701A0 VA: 0x181371BA0
	private static void .cctor() { }

}

