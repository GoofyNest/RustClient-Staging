public static class IParticleSystemJobExtensions // TypeDefIndex: 4547
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38E00 Offset: 0x1A37400 VA: 0x181A38E00
	|-IParticleSystemJobExtensions.Schedule<ParticleSystemIK.ParticleSystemIKJob>
	*/

	private static JobsUtility.JobScheduleParameters CreateScheduleParams<T>(ref T jobData, ParticleSystem ps, JobHandle dependsOn, IntPtr jobReflectionData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38CF0 Offset: 0x1A372F0 VA: 0x181A38CF0
	|-IParticleSystemJobExtensions.CreateScheduleParams<ParticleSystemIK.ParticleSystemIKJob>
	*/

}

