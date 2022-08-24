internal struct InitializeColliderStateJob : IJobParallelForTransform // TypeDefIndex: 7319
{	[ReadOnlyAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	public NativeArray<ColliderData> Data; // 0x0
	[WriteOnlyAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	public NativeArray<ColliderState> State; // 0x10


	public void Execute(int index, TransformAccess transform) { }

}

