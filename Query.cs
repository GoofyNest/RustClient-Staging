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

	// RVA: 0x21FFF0 Offset: 0x21F3F0 VA: 0x18021FFF0
	public void .ctor(UgcType type) { }

	// RVA: 0x19C4480 Offset: 0x19C2A80 VA: 0x1819C4480
	public static Query get_All() { }

	// RVA: 0x21FCC0 Offset: 0x21F0C0 VA: 0x18021FCC0
	public Query RankedByPublicationDate() { }

	// RVA: 0x21FC60 Offset: 0x21F060 VA: 0x18021FC60
	public Query RankedByAcceptanceDate() { }

	// RVA: 0x21FD20 Offset: 0x21F120 VA: 0x18021FD20
	public Query RankedByTrend() { }

	// RVA: 0x21FB90 Offset: 0x21EF90 VA: 0x18021FB90
	internal Query LimitUser(SteamId steamid) { }

	// RVA: 0x21FD80 Offset: 0x21F180 VA: 0x18021FD80
	public Query WhereUserPublished(SteamId user) { }

	// RVA: 0x21FE10 Offset: 0x21F210 VA: 0x18021FE10
	public Query WithFileId(PublishedFileId[] files) { }

	[AsyncStateMachineAttribute] // RVA: 0x9F740 Offset: 0x9EB40 VA: 0x18009F740
	// RVA: 0x21FB80 Offset: 0x21EF80 VA: 0x18021FB80
	public Task<Nullable<ResultPage>> GetPageAsync(int page) { }

	// RVA: 0x21FF30 Offset: 0x21F330 VA: 0x18021FF30
	public Query WithTrendDays(int days) { }

	// RVA: 0x21FBB0 Offset: 0x21EFB0 VA: 0x18021FBB0
	public Query MatchAllTags() { }

	// RVA: 0x21FE30 Offset: 0x21F230 VA: 0x18021FE30
	public Query WithTag(string tag) { }

	// RVA: 0x21FB60 Offset: 0x21EF60 VA: 0x18021FB60
	private void ApplyConstraints(UGCQueryHandle_t handle) { }

	// RVA: 0x21FB70 Offset: 0x21EF70 VA: 0x18021FB70
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

	// RVA: 0x220390 Offset: 0x21F790 VA: 0x180220390 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2203A0 Offset: 0x21F7A0 VA: 0x1802203A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

