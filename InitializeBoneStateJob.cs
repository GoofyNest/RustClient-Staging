internal struct InitializeBoneStateJob : IJobParallelForTransform // TypeDefIndex: 7318
{
	[ReadOnlyAttribute] 
	[NativeMatchesParallelForLengthAttribute] 
	public NativeArray<BoneData> Data; 
	[WriteOnlyAttribute] 
	[NativeMatchesParallelForLengthAttribute] 
	public NativeArray<BoneState> State; 


	public void Execute(int index, TransformAccess transform) { }

}

