public static class IJobExtensions // TypeDefIndex: 3299
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38AB0 Offset: 0x1A370B0 VA: 0x181A38AB0
	|-IJobExtensions.Schedule<SimulatePositionsJob>
	*/

}

internal struct IJobExtensions.JobStruct<T> // TypeDefIndex: 3300
{	public static IntPtr jobReflectionData; // 0x0


	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF610 Offset: 0x17ADC10 VA: 0x1817AF610
	|-IJobExtensions.JobStruct<SimulatePositionsJob>.Initialize
	*/

	public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF600 Offset: 0x17ADC00 VA: 0x1817AF600
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
	|-RVA: 0x17ADA50 Offset: 0x17AC050 VA: 0x1817ADA50
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD950 Offset: 0x17ABF50 VA: 0x1817AD950
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADA30 Offset: 0x17AC030 VA: 0x1817ADA30
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.EndInvoke
	*/

}

