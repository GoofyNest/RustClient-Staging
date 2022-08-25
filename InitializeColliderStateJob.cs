internal struct InitializeColliderStateJob : IJobParallelForTransform // TypeDefIndex: 7320
{
	[ReadOnlyAttribute] 
	[NativeMatchesParallelForLengthAttribute] 
	public NativeArray<ColliderData> Data; 
	[WriteOnlyAttribute] 
	[NativeMatchesParallelForLengthAttribute] 
	public NativeArray<ColliderState> State; 


	public void Execute(int index, TransformAccess transform) { }

}

