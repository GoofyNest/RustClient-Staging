public struct JobHandle // TypeDefIndex: 3306
{	// Fields
	internal IntPtr jobGroup; // 0x0
	internal int version; // 0x8

	// Methods

	// RVA: 0x212990 Offset: 0x211D90 VA: 0x180212990
	public void Complete() { }

	// RVA: 0x181DD70 Offset: 0x181C370 VA: 0x18181DD70
	public static void CompleteAll(NativeArray<JobHandle> jobs) { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x181DEE0 Offset: 0x181C4E0 VA: 0x18181DEE0
	public static void ScheduleBatchedJobs() { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x181DEA0 Offset: 0x181C4A0 VA: 0x18181DEA0
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x181DE60 Offset: 0x181C460 VA: 0x18181DE60
	private static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count) { }

	// RVA: 0x181DD00 Offset: 0x181C300 VA: 0x18181DD00
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x181DCA0 Offset: 0x181C2A0 VA: 0x18181DCA0
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	// RVA: 0x181DC40 Offset: 0x181C240 VA: 0x18181DC40
	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

}

