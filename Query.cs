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

	// RVA: 0x224A70 Offset: 0x223E70 VA: 0x180224A70
	public void .ctor(UgcType type) { }

	// RVA: 0x19D7080 Offset: 0x19D5680 VA: 0x1819D7080
	public static Query get_All() { }

	// RVA: 0x224740 Offset: 0x223B40 VA: 0x180224740
	public Query RankedByPublicationDate() { }

	// RVA: 0x2246E0 Offset: 0x223AE0 VA: 0x1802246E0
	public Query RankedByAcceptanceDate() { }

	// RVA: 0x2247A0 Offset: 0x223BA0 VA: 0x1802247A0
	public Query RankedByTrend() { }

	// RVA: 0x224610 Offset: 0x223A10 VA: 0x180224610
	internal Query LimitUser(SteamId steamid) { }

	// RVA: 0x224800 Offset: 0x223C00 VA: 0x180224800
	public Query WhereUserPublished(SteamId user) { }

	// RVA: 0x224890 Offset: 0x223C90 VA: 0x180224890
	public Query WithFileId(PublishedFileId[] files) { }

	[AsyncStateMachineAttribute] // RVA: 0x9F740 Offset: 0x9EB40 VA: 0x18009F740
	// RVA: 0x224600 Offset: 0x223A00 VA: 0x180224600
	public Task<Nullable<ResultPage>> GetPageAsync(int page) { }

	// RVA: 0x2249B0 Offset: 0x223DB0 VA: 0x1802249B0
	public Query WithTrendDays(int days) { }

	// RVA: 0x224630 Offset: 0x223A30 VA: 0x180224630
	public Query MatchAllTags() { }

	// RVA: 0x2248B0 Offset: 0x223CB0 VA: 0x1802248B0
	public Query WithTag(string tag) { }

	// RVA: 0x2245E0 Offset: 0x2239E0 VA: 0x1802245E0
	private void ApplyConstraints(UGCQueryHandle_t handle) { }

	// RVA: 0x2245F0 Offset: 0x2239F0 VA: 0x1802245F0
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

	// RVA: 0x224E10 Offset: 0x224210 VA: 0x180224E10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224E20 Offset: 0x224220 VA: 0x180224E20 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

