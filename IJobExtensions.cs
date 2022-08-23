public static class IJobExtensions // TypeDefIndex: 3299
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38BB0 Offset: 0x1A371B0 VA: 0x181A38BB0
	|-IJobExtensions.Schedule<SimulatePositionsJob>
	*/

}

internal struct IJobExtensions.JobStruct<T> // TypeDefIndex: 3300
{	public static IntPtr jobReflectionData; // 0x0


	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF710 Offset: 0x17ADD10 VA: 0x1817AF710
	|-IJobExtensions.JobStruct<SimulatePositionsJob>.Initialize
	*/

	public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF700 Offset: 0x17ADD00 VA: 0x1817AF700
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
	|-RVA: 0x17ADB50 Offset: 0x17AC150 VA: 0x1817ADB50
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADA50 Offset: 0x17AC050 VA: 0x1817ADA50
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADB30 Offset: 0x17AC130 VA: 0x1817ADB30
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.EndInvoke
	*/

}

