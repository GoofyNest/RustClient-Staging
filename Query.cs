public struct Query // TypeDefIndex: 5279
{	// Fields
	private UgcType matchingType; // 0x0
	private UGCQuery queryType; // 0x4
	private AppId consumerApp; // 0x8
	private AppId creatorApp; // 0xC
	private string searchText; // 0x10
	private Nullable<SteamId> steamid; // 0x18
	private UserUGCList userType; // 0x28
	private UserUGCListSortOrder userSort; // 0x2C
	private PublishedFileId[] Files; // 0x30
	private Nullable<int> maxCacheAge; // 0x38
	private string language; // 0x40
	private Nullable<int> trendDays; // 0x48
	private List<string> requiredTags; // 0x50
	private Nullable<bool> matchAnyTag; // 0x58
	private List<string> excludedTags; // 0x60
	private Dictionary<string, string> requiredKv; // 0x68
	private Nullable<bool> WantsReturnOnlyIDs; // 0x70
	private Nullable<bool> WantsReturnKeyValueTags; // 0x72
	private Nullable<bool> WantsReturnLongDescription; // 0x74
	private Nullable<bool> WantsReturnMetadata; // 0x76
	private Nullable<bool> WantsReturnChildren; // 0x78
	private Nullable<bool> WantsReturnAdditionalPreviews; // 0x7A
	private Nullable<bool> WantsReturnTotalOnly; // 0x7C
	private Nullable<uint> WantsReturnPlaytimeStats; // 0x80
	private Nullable<bool> WantsDefaultStats; // 0x88

	// Properties
	public static Query All { get; }

	// Methods

	// RVA: 0x224AF0 Offset: 0x223EF0 VA: 0x180224AF0
	public void .ctor(UgcType type) { }

	// RVA: 0x19D6E00 Offset: 0x19D5400 VA: 0x1819D6E00
	public static Query get_All() { }

	// RVA: 0x2247C0 Offset: 0x223BC0 VA: 0x1802247C0
	public Query RankedByPublicationDate() { }

	// RVA: 0x224760 Offset: 0x223B60 VA: 0x180224760
	public Query RankedByAcceptanceDate() { }

	// RVA: 0x224820 Offset: 0x223C20 VA: 0x180224820
	public Query RankedByTrend() { }

	// RVA: 0x224690 Offset: 0x223A90 VA: 0x180224690
	internal Query LimitUser(SteamId steamid) { }

	// RVA: 0x224880 Offset: 0x223C80 VA: 0x180224880
	public Query WhereUserPublished(SteamId user) { }

	// RVA: 0x224910 Offset: 0x223D10 VA: 0x180224910
	public Query WithFileId(PublishedFileId[] files) { }

	[AsyncStateMachineAttribute] // RVA: 0x9F690 Offset: 0x9EA90 VA: 0x18009F690
	// RVA: 0x224680 Offset: 0x223A80 VA: 0x180224680
	public Task<Nullable<ResultPage>> GetPageAsync(int page) { }

	// RVA: 0x224A30 Offset: 0x223E30 VA: 0x180224A30
	public Query WithTrendDays(int days) { }

	// RVA: 0x2246B0 Offset: 0x223AB0 VA: 0x1802246B0
	public Query MatchAllTags() { }

	// RVA: 0x224930 Offset: 0x223D30 VA: 0x180224930
	public Query WithTag(string tag) { }

	// RVA: 0x224660 Offset: 0x223A60 VA: 0x180224660
	private void ApplyConstraints(UGCQueryHandle_t handle) { }

	// RVA: 0x224670 Offset: 0x223A70 VA: 0x180224670
	private void ApplyReturns(UGCQueryHandle_t handle) { }

}

private struct Query.<GetPageAsync>d__76 : IAsyncStateMachine // TypeDefIndex: 5280
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<ResultPage>> <>t__builder; // 0x8
	public int page; // 0x20
	public Query <>4__this; // 0x28
	private CallResult<SteamUGCQueryCompleted_t> <>u__1; // 0xB8

	// Methods

	// RVA: 0x224E90 Offset: 0x224290 VA: 0x180224E90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224EA0 Offset: 0x2242A0 VA: 0x180224EA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

