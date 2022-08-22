public static class IJobExtensions // TypeDefIndex: 3299
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38A70 Offset: 0x1A37070 VA: 0x181A38A70
	|-IJobExtensions.Schedule<SimulatePositionsJob>
	*/

}

internal struct IJobExtensions.JobStruct<T> // TypeDefIndex: 3300
{	public static IntPtr jobReflectionData; // 0x0


	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF5D0 Offset: 0x17ADBD0 VA: 0x1817AF5D0
	|-IJobExtensions.JobStruct<SimulatePositionsJob>.Initialize
	*/

	public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF5C0 Offset: 0x17ADBC0 VA: 0x1817AF5C0
	|-IJobExtensions.JobStruct<SimulatePositionsJob>.Execute
	*/

}

public sealed class IJobExtensions.JobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3301
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>..ctor
	*/

	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADA10 Offset: 0x17AC010 VA: 0x1817ADA10
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD910 Offset: 0x17ABF10 VA: 0x1817AD910
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD9F0 Offset: 0x17ABFF0 VA: 0x1817AD9F0
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.EndInvoke
	*/

}

