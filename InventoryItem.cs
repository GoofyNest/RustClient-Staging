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

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public InventoryItemId get_Id() { }

	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public InventoryDefId get_DefId() { }

	// RVA: 0x10ABA0 Offset: 0x109FA0 VA: 0x18010ABA0
	public int get_Quantity() { }

	// RVA: 0x122EA0 Offset: 0x1222A0 VA: 0x180122EA0
	public InventoryDef get_Def() { }

	// RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
	public Dictionary<string, string> get_Properties() { }

	[AsyncStateMachineAttribute] // RVA: 0x97CE0 Offset: 0x970E0 VA: 0x180097CE0
	// RVA: 0x122BA0 Offset: 0x121FA0 VA: 0x180122BA0
	public Task<Nullable<InventoryResult>> ConsumeAsync(int amount = 1) { }

	[AsyncStateMachineAttribute] // RVA: 0x97EC0 Offset: 0x972C0 VA: 0x180097EC0
	// RVA: 0x122D70 Offset: 0x122170 VA: 0x180122D70
	public Task<Nullable<InventoryResult>> SplitStackAsync(int quantity = 1) { }

	[AsyncStateMachineAttribute] // RVA: 0x98110 Offset: 0x97510 VA: 0x180098110
	// RVA: 0x122A70 Offset: 0x121E70 VA: 0x180122A70
	public Task<Nullable<InventoryResult>> AddAsync(InventoryItem add, int quantity = 1) { }

	// RVA: 0xDE1500 Offset: 0xDDFB00 VA: 0x180DE1500
	internal static InventoryItem From(SteamItemDetails_t details) { }

	// RVA: 0xDE1570 Offset: 0xDDFB70 VA: 0x180DE1570
	internal static Dictionary<string, string> GetProperties(SteamInventoryResult_t result, int index) { }

	// RVA: 0x122E80 Offset: 0x122280 VA: 0x180122E80
	public DateTime get_Acquired() { }

	// RVA: 0xDE1B20 Offset: 0xDE0120 VA: 0x180DE1B20
	public static bool op_Equality(InventoryItem a, InventoryItem b) { }

	// RVA: 0x122CB0 Offset: 0x1220B0 VA: 0x180122CB0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x122D60 Offset: 0x122160 VA: 0x180122D60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122D30 Offset: 0x122130 VA: 0x180122D30 Slot: 4
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

	// RVA: 0x1232C0 Offset: 0x1226C0 VA: 0x1801232C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1232D0 Offset: 0x1226D0 VA: 0x1801232D0 Slot: 5
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

	// RVA: 0x123810 Offset: 0x122C10 VA: 0x180123810 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x123820 Offset: 0x122C20 VA: 0x180123820 Slot: 5
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

	// RVA: 0x123250 Offset: 0x122650 VA: 0x180123250 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x123260 Offset: 0x122660 VA: 0x180123260 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

