public static class IJobParallelForExtensions // TypeDefIndex: 3303
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38B70 Offset: 0x1A37170 VA: 0x181A38B70
	|-IJobParallelForExtensions.Schedule<MeshPaintable3D.DrawTextureJob>
	*/

}

internal struct IJobParallelForExtensions.ParallelForJobStruct<T> // TypeDefIndex: 3304
{	public static IntPtr jobReflectionData; // 0x0


	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AFFC0 Offset: 0x17AE5C0 VA: 0x1817AFFC0
	|-IJobParallelForExtensions.ParallelForJobStruct<MeshPaintable3D.DrawTextureJob>.Initialize
	*/

	public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AFF10 Offset: 0x17AE510 VA: 0x1817AFF10
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
	|-RVA: 0x17ADA50 Offset: 0x17AC050 VA: 0x1817ADA50
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD870 Offset: 0x17ABE70 VA: 0x1817AD870
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADA30 Offset: 0x17AC030 VA: 0x1817ADA30
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.EndInvoke
	*/

}

