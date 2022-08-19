internal struct InitializeColliderStateJob : IJobParallelForTransform // TypeDefIndex: 7319
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	public NativeArray<ColliderData> Data; // 0x0
	[WriteOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	public NativeArray<ColliderState> State; // 0x10

	// Methods

	// RVA: 0x237F20 Offset: 0x237320 VA: 0x180237F20 Slot: 4
	public void Execute(int index, TransformAccess transform) { }

}

