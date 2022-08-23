public sealed class ParticleSystemJobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 4556
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>..ctor
	*/

	public virtual void Invoke(ref T data, IntPtr listDataPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADB50 Offset: 0x17AC150 VA: 0x1817ADB50
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr listDataPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19A9CF0 Offset: 0x19A82F0 VA: 0x1819A9CF0
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADB30 Offset: 0x17AC130 VA: 0x1817ADB30
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.EndInvoke
	*/

}

