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

	// RVA: 0x1E47F0 Offset: 0x1E3BF0 VA: 0x1801E47F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E47E0 Offset: 0x1E3BE0 VA: 0x1801E47E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E3A0 Offset: 0x136C9A0 VA: 0x18136E3A0
	private static void .cctor() { }

}

