public static class IJobParallelForExtensions // TypeDefIndex: 3303
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38C30 Offset: 0x1A37230 VA: 0x181A38C30
	|-IJobParallelForExtensions.Schedule<MeshPaintable3D.DrawTextureJob>
	*/

}

internal struct IJobParallelForExtensions.ParallelForJobStruct<T> // TypeDefIndex: 3304
{	public static IntPtr jobReflectionData; // 0x0


	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0080 Offset: 0x17AE680 VA: 0x1817B0080
	|-IJobParallelForExtensions.ParallelForJobStruct<MeshPaintable3D.DrawTextureJob>.Initialize
	*/

	public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AFFD0 Offset: 0x17AE5D0 VA: 0x1817AFFD0
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
	|-RVA: 0x17ADB10 Offset: 0x17AC110 VA: 0x1817ADB10
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD930 Offset: 0x17ABF30 VA: 0x1817AD930
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADAF0 Offset: 0x17AC0F0 VA: 0x1817ADAF0
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.EndInvoke
	*/

}

