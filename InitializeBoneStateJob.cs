internal struct InitializeBoneStateJob : IJobParallelForTransform // TypeDefIndex: 7318
{	[ReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<BoneData> Data; // 0x0
	[WriteOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<BoneState> State; // 0x10


	public void Execute(int index, TransformAccess transform) { }

}

