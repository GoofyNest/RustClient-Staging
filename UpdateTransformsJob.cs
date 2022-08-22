internal struct UpdateTransformsJob : IJobParallelForTransform // TypeDefIndex: 7321
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<BoneData> Data; // 0x0
	[ReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<BoneState> State; // 0x10

	// Methods

	// RVA: 0x237FA0 Offset: 0x2373A0 VA: 0x180237FA0 Slot: 4
	public void Execute(int index, TransformAccess transform) { }

}

