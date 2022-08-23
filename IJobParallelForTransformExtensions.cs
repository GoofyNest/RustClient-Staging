public static class IJobParallelForTransformExtensions // TypeDefIndex: 3586
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, TransformAccessArray transforms, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38D10 Offset: 0x1A37310 VA: 0x181A38D10
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
	|-RVA: 0x19B3830 Offset: 0x19B1E30 VA: 0x1819B3830
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Initialize
	|
	|-RVA: 0x19B3A70 Offset: 0x19B2070 VA: 0x1819B3A70
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Initialize
	|
	|-RVA: 0x19B35F0 Offset: 0x19B1BF0 VA: 0x1819B35F0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<UpdateTransformsJob>.Initialize
	*/

	public static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B3230 Offset: 0x19B1830 VA: 0x1819B3230
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Execute
	|
	|-RVA: 0x19B34B0 Offset: 0x19B1AB0 VA: 0x1819B34B0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Execute
	|
	|-RVA: 0x19B3370 Offset: 0x19B1970 VA: 0x1819B3370
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
	|-RVA: 0x17ADB10 Offset: 0x17AC110 VA: 0x1817ADB10
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.Invoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.Invoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19A9D90 Offset: 0x19A8390 VA: 0x1819A9D90
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.BeginInvoke
	|
	|-RVA: 0x19A9E70 Offset: 0x19A8470 VA: 0x1819A9E70
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.BeginInvoke
	|
	|-RVA: 0x19A9BD0 Offset: 0x19A81D0 VA: 0x1819A9BD0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADAF0 Offset: 0x17AC0F0 VA: 0x1817ADAF0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.EndInvoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.EndInvoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.EndInvoke
	*/

}

