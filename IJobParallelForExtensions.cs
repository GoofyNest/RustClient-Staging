public static class IJobParallelForExtensions // TypeDefIndex: 3303
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38B30 Offset: 0x1A37130 VA: 0x181A38B30
	|-IJobParallelForExtensions.Schedule<MeshPaintable3D.DrawTextureJob>
	*/

}

internal struct IJobParallelForExtensions.ParallelForJobStruct<T> // TypeDefIndex: 3304
{	// Fields
	public static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AFF80 Offset: 0x17AE580 VA: 0x1817AFF80
	|-IJobParallelForExtensions.ParallelForJobStruct<MeshPaintable3D.DrawTextureJob>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AFED0 Offset: 0x17AE4D0 VA: 0x1817AFED0
	|-IJobParallelForExtensions.ParallelForJobStruct<MeshPaintable3D.DrawTextureJob>.Execute
	*/

}

public sealed class IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3305
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADA10 Offset: 0x17AC010 VA: 0x1817ADA10
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD830 Offset: 0x17ABE30 VA: 0x1817AD830
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD9F0 Offset: 0x17ABFF0 VA: 0x1817AD9F0
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.EndInvoke
	*/

}

