public struct InventoryItem : IEquatable<InventoryItem> // TypeDefIndex: 5241
{	// Fields
	internal InventoryItemId _id; // 0x0
	internal InventoryDefId _def; // 0x8
	internal SteamItemFlags _flags; // 0xC
	internal ushort _quantity; // 0x10
	internal Dictionary<string, string> _properties; // 0x18

	// Properties
	public InventoryItemId Id { get; }
	public InventoryDefId DefId { get; }
	public int Quantity { get; }
	public InventoryDef Def { get; }
	public Dictionary<string, string> Properties { get; }
	public DateTime Acquired { get; }

	// Methods

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public InventoryItemId get_Id() { }

	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10
	public InventoryDefId get_DefId() { }

	// RVA: 0x10AB20 Offset: 0x109F20 VA: 0x18010AB20
	public int get_Quantity() { }

	// RVA: 0x122E20 Offset: 0x122220 VA: 0x180122E20
	public InventoryDef get_Def() { }

	// RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	public Dictionary<string, string> get_Properties() { }

	[AsyncStateMachineAttribute] // RVA: 0x97D70 Offset: 0x97170 VA: 0x180097D70
	// RVA: 0x122B20 Offset: 0x121F20 VA: 0x180122B20
	public Task<Nullable<InventoryResult>> ConsumeAsync(int amount = 1) { }

	[AsyncStateMachineAttribute] // RVA: 0x98040 Offset: 0x97440 VA: 0x180098040
	// RVA: 0x122CF0 Offset: 0x1220F0 VA: 0x180122CF0
	public Task<Nullable<InventoryResult>> SplitStackAsync(int quantity = 1) { }

	[AsyncStateMachineAttribute] // RVA: 0x981A0 Offset: 0x975A0 VA: 0x1800981A0
	// RVA: 0x1229F0 Offset: 0x121DF0 VA: 0x1801229F0
	public Task<Nullable<InventoryResult>> AddAsync(InventoryItem add, int quantity = 1) { }

	// RVA: 0xDE1500 Offset: 0xDDFB00 VA: 0x180DE1500
	internal static InventoryItem From(SteamItemDetails_t details) { }

	// RVA: 0xDE1570 Offset: 0xDDFB70 VA: 0x180DE1570
	internal static Dictionary<string, string> GetProperties(SteamInventoryResult_t result, int index) { }

	// RVA: 0x122E00 Offset: 0x122200 VA: 0x180122E00
	public DateTime get_Acquired() { }

	// RVA: 0xDE1B20 Offset: 0xDE0120 VA: 0x180DE1B20
	public static bool op_Equality(InventoryItem a, InventoryItem b) { }

	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x122CE0 Offset: 0x1220E0 VA: 0x180122CE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122CB0 Offset: 0x1220B0 VA: 0x180122CB0 Slot: 4
	public bool Equals(InventoryItem p) { }

}

public struct InventoryItem.Amount // TypeDefIndex: 5242
{	// Fields
	public InventoryItem Item; // 0x0
	public int Quantity; // 0x20

}

private struct InventoryItem.<ConsumeAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 5243
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryItem <>4__this; // 0x20
	public int amount; // 0x40
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x48

	// Methods

	// RVA: 0x123240 Offset: 0x122640 VA: 0x180123240 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123250 Offset: 0x122650 VA: 0x180123250 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct InventoryItem.<SplitStackAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 5244
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryItem <>4__this; // 0x20
	public int quantity; // 0x40
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x48

	// Methods

	// RVA: 0x123790 Offset: 0x122B90 VA: 0x180123790 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1237A0 Offset: 0x122BA0 VA: 0x1801237A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct InventoryItem.<AddAsync>d__23 : IAsyncStateMachine // TypeDefIndex: 5245
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryItem add; // 0x20
	public int quantity; // 0x40
	public InventoryItem <>4__this; // 0x48
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x68

	// Methods

	// RVA: 0x1231D0 Offset: 0x1225D0 VA: 0x1801231D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1231E0 Offset: 0x1225E0 VA: 0x1801231E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

