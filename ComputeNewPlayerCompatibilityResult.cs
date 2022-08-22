internal struct ComputeNewPlayerCompatibilityResult_t : ICallbackData // TypeDefIndex: 5499
{	// Fields
	internal Result Result; // 0x0
	internal int CPlayersThatDontLikeCandidate; // 0x4
	internal int CPlayersThatCandidateDoesntLike; // 0x8
	internal int CClanPlayersThatDontLikeCandidate; // 0xC
	internal ulong SteamIDCandidate; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4770 Offset: 0x1E3B70 VA: 0x1801E4770 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4760 Offset: 0x1E3B60 VA: 0x1801E4760 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E660 Offset: 0x136CC60 VA: 0x18136E660
	private static void .cctor() { }

}

