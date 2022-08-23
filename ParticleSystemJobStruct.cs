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
	|-RVA: 0x17ADA50 Offset: 0x17AC050 VA: 0x1817ADA50
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr listDataPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19A9BF0 Offset: 0x19A81F0 VA: 0x1819A9BF0
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.BeginInvoke
	*/

	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADA30 Offset: 0x17AC030 VA: 0x1817ADA30
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.EndInvoke
	*/

}

