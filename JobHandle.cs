public struct JobHandle // TypeDefIndex: 3306
{	internal IntPtr jobGroup; // 0x0
	internal int version; // 0x8


	public void Complete() { }

	public static void CompleteAll(NativeArray<JobHandle> jobs) { }

	[NativeMethodAttribute] // RVA: 0x97A10 Offset: 0x96E10 VA: 0x180097A10
	public static void ScheduleBatchedJobs() { }

	[NativeMethodAttribute] // RVA: 0x97A10 Offset: 0x96E10 VA: 0x180097A10
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethodAttribute] // RVA: 0x97A10 Offset: 0x96E10 VA: 0x180097A10
	private static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count) { }

	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[NativeMethodAttribute] // RVA: 0x97A10 Offset: 0x96E10 VA: 0x180097A10
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

}

