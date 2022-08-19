public struct JobHandle // TypeDefIndex: 3306
{	// Fields
	internal IntPtr jobGroup; // 0x0
	internal int version; // 0x8

	// Methods

	// RVA: 0x2135E0 Offset: 0x2129E0 VA: 0x1802135E0
	public void Complete() { }

	// RVA: 0x18306B0 Offset: 0x182ECB0 VA: 0x1818306B0
	public static void CompleteAll(NativeArray<JobHandle> jobs) { }

	[NativeMethodAttribute] // RVA: 0x97860 Offset: 0x96C60 VA: 0x180097860
	// RVA: 0x1830820 Offset: 0x182EE20 VA: 0x181830820
	public static void ScheduleBatchedJobs() { }

	[NativeMethodAttribute] // RVA: 0x97860 Offset: 0x96C60 VA: 0x180097860
	// RVA: 0x18307E0 Offset: 0x182EDE0 VA: 0x1818307E0
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethodAttribute] // RVA: 0x97860 Offset: 0x96C60 VA: 0x180097860
	// RVA: 0x18307A0 Offset: 0x182EDA0 VA: 0x1818307A0
	private static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count) { }

	// RVA: 0x1830640 Offset: 0x182EC40 VA: 0x181830640
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[NativeMethodAttribute] // RVA: 0x97860 Offset: 0x96C60 VA: 0x180097860
	// RVA: 0x18305E0 Offset: 0x182EBE0 VA: 0x1818305E0
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	// RVA: 0x1830580 Offset: 0x182EB80 VA: 0x181830580
	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

}

