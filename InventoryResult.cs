public struct InventoryResult : IDisposable // TypeDefIndex: 5250
{	// Fields
	internal SteamInventoryResult_t _id; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Expired>k__BackingField; // 0x4

	// Properties
	internal bool Expired { set; }
	public int ItemCount { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122FD0 Offset: 0x1223D0 VA: 0x180122FD0
	internal void set_Expired(bool value) { }

	// RVA: 0xFD1A0 Offset: 0xFC5A0 VA: 0x1800FD1A0
	internal void .ctor(SteamInventoryResult_t id, bool expired) { }

	// RVA: 0x122F70 Offset: 0x122370 VA: 0x180122F70
	public int get_ItemCount() { }

	// RVA: 0x122DF0 Offset: 0x1221F0 VA: 0x180122DF0
	public bool BelongsTo(SteamId steamId) { }

	// RVA: 0x122E70 Offset: 0x122270 VA: 0x180122E70
	public InventoryItem[] GetItems(bool includeProperties = False) { }

	// RVA: 0x122E30 Offset: 0x122230 VA: 0x180122E30 Slot: 4
	public void Dispose() { }

	[AsyncStateMachineAttribute] // RVA: 0x98C80 Offset: 0x98080 VA: 0x180098C80
	// RVA: 0xDE2DC0 Offset: 0xDE13C0 VA: 0x180DE2DC0
	internal static Task<Nullable<InventoryResult>> GetAsync(SteamInventoryResult_t sresult) { }

	// RVA: 0x122E80 Offset: 0x122280 VA: 0x180122E80
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

	// RVA: 0x1231E0 Offset: 0x1225E0 VA: 0x1801231E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1231F0 Offset: 0x1225F0 VA: 0x1801231F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

