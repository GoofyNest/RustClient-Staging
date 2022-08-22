internal struct InitializeColliderStateJob : IJobParallelForTransform // TypeDefIndex: 7319
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<ColliderData> Data; // 0x0
	[WriteOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<ColliderState> State; // 0x10

	// Methods

	// RVA: 0x237EA0 Offset: 0x2372A0 VA: 0x180237EA0 Slot: 4
	public void Execute(int index, TransformAccess transform) { }

}

