public static class IJobParallelForExtensions // TypeDefIndex: 3303
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38C70 Offset: 0x1A37270 VA: 0x181A38C70
	|-IJobParallelForExtensions.Schedule<MeshPaintable3D.DrawTextureJob>
	*/

}

internal struct IJobParallelForExtensions.ParallelForJobStruct<T> // TypeDefIndex: 3304
{	public static IntPtr jobReflectionData; // 0x0


	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B00C0 Offset: 0x17AE6C0 VA: 0x1817B00C0
	|-IJobParallelForExtensions.ParallelForJobStruct<MeshPaintable3D.DrawTextureJob>.Initialize
	*/

	public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0010 Offset: 0x17AE610 VA: 0x1817B0010
	|-IJobParallelForExtensions.ParallelForJobStruct<MeshPaintable3D.DrawTextureJob>.Execute
	*/

}

public sealed class IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3305
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>..ctor
	*/

	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADB50 Offset: 0x17AC150 VA: 0x1817ADB50
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD970 Offset: 0x17ABF70 VA: 0x1817AD970
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADB30 Offset: 0x17AC130 VA: 0x1817ADB30
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.EndInvoke
	*/

}

