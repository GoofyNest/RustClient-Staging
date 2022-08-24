public static class IParticleSystemJobExtensions // TypeDefIndex: 4547
{
	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-IParticleSystemJobExtensions.Schedule<ParticleSystemIK.ParticleSystemIKJob>
	*/

	private static JobsUtility.JobScheduleParameters CreateScheduleParams<T>(ref T jobData, ParticleSystem ps, JobHandle dependsOn, IntPtr jobReflectionData) { }
	/* GenericInstMethod :
	|
	|-IParticleSystemJobExtensions.CreateScheduleParams<ParticleSystemIK.ParticleSystemIKJob>
	*/

}

