public struct JobHandle // TypeDefIndex: 3306
{	// Fields
	internal IntPtr jobGroup; // 0x0
	internal int version; // 0x8

	// Methods

	// RVA: 0x213560 Offset: 0x212960 VA: 0x180213560
	public void Complete() { }

	// RVA: 0x1830930 Offset: 0x182EF30 VA: 0x181830930
	public static void CompleteAll(NativeArray<JobHandle> jobs) { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x1830AA0 Offset: 0x182F0A0 VA: 0x181830AA0
	public static void ScheduleBatchedJobs() { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x1830A60 Offset: 0x182F060 VA: 0x181830A60
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x1830A20 Offset: 0x182F020 VA: 0x181830A20
	private static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count) { }

	// RVA: 0x18308C0 Offset: 0x182EEC0 VA: 0x1818308C0
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[NativeMethodAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x1830860 Offset: 0x182EE60 VA: 0x181830860
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	// RVA: 0x1830800 Offset: 0x182EE00 VA: 0x181830800
	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

}

