public struct JobHandle // TypeDefIndex: 3306
{	// Fields
	internal IntPtr jobGroup; // 0x0
	internal int version; // 0x8

	// Methods

	// RVA: 0x213560 Offset: 0x212960 VA: 0x180213560
	public void Complete() { }

	// RVA: 0x1830670 Offset: 0x182EC70 VA: 0x181830670
	public static void CompleteAll(NativeArray<JobHandle> jobs) { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x18307E0 Offset: 0x182EDE0 VA: 0x1818307E0
	public static void ScheduleBatchedJobs() { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x18307A0 Offset: 0x182EDA0 VA: 0x1818307A0
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x1830760 Offset: 0x182ED60 VA: 0x181830760
	private static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count) { }

	// RVA: 0x1830600 Offset: 0x182EC00 VA: 0x181830600
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x18305A0 Offset: 0x182EBA0 VA: 0x1818305A0
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	// RVA: 0x1830540 Offset: 0x182EB40 VA: 0x181830540
	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

}

