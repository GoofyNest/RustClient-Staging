internal struct UpdateTransformsJob : IJobParallelForTransform // TypeDefIndex: 7321
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	public NativeArray<BoneData> Data; // 0x0
	[ReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	public NativeArray<BoneState> State; // 0x10

	// Methods

	// RVA: 0x238020 Offset: 0x237420 VA: 0x180238020 Slot: 4
	public void Execute(int index, TransformAccess transform) { }

}

