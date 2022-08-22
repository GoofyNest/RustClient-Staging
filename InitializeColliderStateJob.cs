internal struct InitializeColliderStateJob : IJobParallelForTransform // TypeDefIndex: 7319
{	[ReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<ColliderData> Data; // 0x0
	[WriteOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<ColliderState> State; // 0x10


	public void Execute(int index, TransformAccess transform) { }

}

