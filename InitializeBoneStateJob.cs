internal struct InitializeBoneStateJob : IJobParallelForTransform // TypeDefIndex: 7318
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	public NativeArray<BoneData> Data; // 0x0
	[WriteOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	public NativeArray<BoneState> State; // 0x10

	// Methods

	// RVA: 0x237F00 Offset: 0x237300 VA: 0x180237F00 Slot: 4
	public void Execute(int index, TransformAccess transform) { }

}
