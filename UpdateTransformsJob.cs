internal struct UpdateTransformsJob : IJobParallelForTransform // TypeDefIndex: 7321
{	[ReadOnlyAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	public NativeArray<BoneData> Data; // 0x0
	[ReadOnlyAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	public NativeArray<BoneState> State; // 0x10


	public void Execute(int index, TransformAccess transform) { }

}

