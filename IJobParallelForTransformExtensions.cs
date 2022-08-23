public static class IJobParallelForTransformExtensions // TypeDefIndex: 3586
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, TransformAccessArray transforms, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38D50 Offset: 0x1A37350 VA: 0x181A38D50
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
	|-RVA: 0x19B3870 Offset: 0x19B1E70 VA: 0x1819B3870
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Initialize
	|
	|-RVA: 0x19B3AB0 Offset: 0x19B20B0 VA: 0x1819B3AB0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Initialize
	|
	|-RVA: 0x19B3630 Offset: 0x19B1C30 VA: 0x1819B3630
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<UpdateTransformsJob>.Initialize
	*/

	public static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B3270 Offset: 0x19B1870 VA: 0x1819B3270
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Execute
	|
	|-RVA: 0x19B34F0 Offset: 0x19B1AF0 VA: 0x1819B34F0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Execute
	|
	|-RVA: 0x19B33B0 Offset: 0x19B19B0 VA: 0x1819B33B0
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
	|-RVA: 0x17ADB50 Offset: 0x17AC150 VA: 0x1817ADB50
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.Invoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.Invoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19A9DD0 Offset: 0x19A83D0 VA: 0x1819A9DD0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.BeginInvoke
	|
	|-RVA: 0x19A9EB0 Offset: 0x19A84B0 VA: 0x1819A9EB0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.BeginInvoke
	|
	|-RVA: 0x19A9C10 Offset: 0x19A8210 VA: 0x1819A9C10
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADB30 Offset: 0x17AC130 VA: 0x1817ADB30
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.EndInvoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.EndInvoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.EndInvoke
	*/

}

