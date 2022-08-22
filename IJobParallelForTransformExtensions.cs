public static class IJobParallelForTransformExtensions // TypeDefIndex: 3586
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, TransformAccessArray transforms, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A39230 Offset: 0x1A37830 VA: 0x181A39230
	|-IJobParallelForTransformExtensions.Schedule<InitializeBoneStateJob>
	|-IJobParallelForTransformExtensions.Schedule<InitializeColliderStateJob>
	|-IJobParallelForTransformExtensions.Schedule<UpdateTransformsJob>
	*/

}

internal struct IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T> // TypeDefIndex: 3587
{	// Fields
	public static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6070 Offset: 0x19C4670 VA: 0x1819C6070
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Initialize
	|
	|-RVA: 0x19C62B0 Offset: 0x19C48B0 VA: 0x1819C62B0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Initialize
	|
	|-RVA: 0x19C5E30 Offset: 0x19C4430 VA: 0x1819C5E30
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<UpdateTransformsJob>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C5A70 Offset: 0x19C4070 VA: 0x1819C5A70
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeBoneStateJob>.Execute
	|
	|-RVA: 0x19C5CF0 Offset: 0x19C42F0 VA: 0x1819C5CF0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<InitializeColliderStateJob>.Execute
	|
	|-RVA: 0x19C5BB0 Offset: 0x19C41B0 VA: 0x1819C5BB0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<UpdateTransformsJob>.Execute
	*/

}

public sealed class IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3588
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>..ctor
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>..ctor
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB340 Offset: 0x17A9940 VA: 0x1817AB340
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.Invoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.Invoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BC5D0 Offset: 0x19BABD0 VA: 0x1819BC5D0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.BeginInvoke
	|
	|-RVA: 0x19BC6B0 Offset: 0x19BACB0 VA: 0x1819BC6B0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.BeginInvoke
	|
	|-RVA: 0x19BC410 Offset: 0x19BAA10 VA: 0x1819BC410
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB320 Offset: 0x17A9920 VA: 0x1817AB320
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeBoneStateJob>.EndInvoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<InitializeColliderStateJob>.EndInvoke
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<UpdateTransformsJob>.EndInvoke
	*/

}

