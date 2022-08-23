public static class IJobParallelForTransformExtensions // TypeDefIndex: 3586
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, TransformAccessArray transforms, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38C50 Offset: 0x1A37250 VA: 0x181A38C50
	|-IJobParallelForTransformExtensions.Schedule<InitializeBoneStateJob>
	|-IJobParallelForTransformExtensions.Schedule<InitializeColliderStateJob>
	|-IJobParallelForTransformExtensions.Schedule<UpdateTransformsJob>
	*/

}

internal struct IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T> // TypeDefIndex: 3587
{	public static IntPtr jobReflectionData; // 0x0


	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B3770 Offset: 0x19B1D70 VA: 0x1819B3770
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Initialize
	|
	|-RVA: 0x19B39B0 Offset: 0x19B1FB0 VA: 0x1819B39B0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Initialize
	|
	|-RVA: 0x19B3530 Offset: 0x19B1B30 VA: 0x1819B3530
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<UpdateTransformsJob>.Initialize
	*/

	public static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B3170 Offset: 0x19B1770 VA: 0x1819B3170
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Execute
	|
	|-RVA: 0x19B33F0 Offset: 0x19B19F0 VA: 0x1819B33F0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Execute
	|
	|-RVA: 0x19B32B0 Offset: 0x19B18B0 VA: 0x1819B32B0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<UpdateTransformsJob>.Execute
	*/

}

public sealed class IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3588
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>..ctor
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>..ctor
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>..ctor
	*/

	public virtual void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADA50 Offset: 0x17AC050 VA: 0x1817ADA50
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.Invoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.Invoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19A9CD0 Offset: 0x19A82D0 VA: 0x1819A9CD0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.BeginInvoke
	|
	|-RVA: 0x19A9DB0 Offset: 0x19A83B0 VA: 0x1819A9DB0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.BeginInvoke
	|
	|-RVA: 0x19A9B10 Offset: 0x19A8110 VA: 0x1819A9B10
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADA30 Offset: 0x17AC030 VA: 0x1817ADA30
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.EndInvoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.EndInvoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.EndInvoke
	*/

}

