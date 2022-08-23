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
	|-RVA: 0x17ADB10 Offset: 0x17AC110 VA: 0x1817ADB10
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr listDataPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19A9CB0 Offset: 0x19A82B0 VA: 0x1819A9CB0
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADAF0 Offset: 0x17AC0F0 VA: 0x1817ADAF0
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.EndInvoke
	*/

}

