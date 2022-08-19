public struct InventoryResult : IDisposable // TypeDefIndex: 5250
{	// Fields
	internal SteamInventoryResult_t _id; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <Expired>k__BackingField; // 0x4

	// Properties
	internal bool Expired { set; }
	public int ItemCount { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x123230 Offset: 0x122630 VA: 0x180123230
	internal void set_Expired(bool value) { }

	// RVA: 0xFD220 Offset: 0xFC620 VA: 0x1800FD220
	internal void .ctor(SteamInventoryResult_t id, bool expired) { }

	// RVA: 0x1231D0 Offset: 0x1225D0 VA: 0x1801231D0
	public int get_ItemCount() { }

	// RVA: 0x123050 Offset: 0x122450 VA: 0x180123050
	public bool BelongsTo(SteamId steamId) { }

	// RVA: 0x1230D0 Offset: 0x1224D0 VA: 0x1801230D0
	public InventoryItem[] GetItems(bool includeProperties = False) { }

	// RVA: 0x123090 Offset: 0x122490 VA: 0x180123090 Slot: 4
	public void Dispose() { }

	[AsyncStateMachineAttribute] // RVA: 0x98BF0 Offset: 0x97FF0 VA: 0x180098BF0
	// RVA: 0xDE2050 Offset: 0xDE0650 VA: 0x180DE2050
	internal static Task<Nullable<InventoryResult>> GetAsync(SteamInventoryResult_t sresult) { }

	// RVA: 0x1230E0 Offset: 0x1224E0 VA: 0x1801230E0
	public byte[] Serialize() { }

}

private struct InventoryResult.<GetAsync>d__11 : IAsyncStateMachine // TypeDefIndex: 5251
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public SteamInventoryResult_t sresult; // 0x20
	private Result <_result>5__2; // 0x24
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x123440 Offset: 0x122840 VA: 0x180123440 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x123450 Offset: 0x122850 VA: 0x180123450 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

