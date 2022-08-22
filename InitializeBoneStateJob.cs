internal struct InitializeBoneStateJob : IJobParallelForTransform // TypeDefIndex: 7318
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<BoneData> Data; // 0x0
	[WriteOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<BoneState> State; // 0x10

	// Methods

	// RVA: 0x237E80 Offset: 0x237280 VA: 0x180237E80 Slot: 4
	public void Execute(int index, TransformAccess transform) { }

}

