public static class IJobExtensions // TypeDefIndex: 3299
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A39350 Offset: 0x1A37950 VA: 0x181A39350
	|-IJobExtensions.Schedule<SimulatePositionsJob>
	*/

}

internal struct IJobExtensions.JobStruct<T> // TypeDefIndex: 3300
{	// Fields
	public static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD1C0 Offset: 0x17AB7C0 VA: 0x1817AD1C0
	|-IJobExtensions.JobStruct<SimulatePositionsJob>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD1B0 Offset: 0x17AB7B0 VA: 0x1817AD1B0
	|-IJobExtensions.JobStruct<SimulatePositionsJob>.Execute
	*/

}

public sealed class IJobExtensions.JobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3301
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB600 Offset: 0x17A9C00 VA: 0x1817AB600
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB500 Offset: 0x17A9B00 VA: 0x1817AB500
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB5E0 Offset: 0x17A9BE0 VA: 0x1817AB5E0
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.EndInvoke
	*/

}

