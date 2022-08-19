public static class JobsUtility // TypeDefIndex: 3313
{	// Methods

	// RVA: 0x1830970 Offset: 0x182EF70 VA: 0x181830970
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[NativeMethodAttribute] // RVA: 0xEAA00 Offset: 0xE9E00 VA: 0x1800EAA00
	// RVA: 0x18309C0 Offset: 0x182EFC0 VA: 0x1818309C0
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEAB20 Offset: 0xE9F20 VA: 0x1800EAB20
	// RVA: 0x1830C00 Offset: 0x182F200 VA: 0x181830C00
	public static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters) { }

	[FreeFunctionAttribute] // RVA: 0xEABB0 Offset: 0xE9FB0 VA: 0x1800EABB0
	// RVA: 0x1830B40 Offset: 0x182F140 VA: 0x181830B40
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunctionAttribute] // RVA: 0xEC070 Offset: 0xEB470 VA: 0x1800EC070
	// RVA: 0x1830A80 Offset: 0x182F080 VA: 0x181830A80
	public static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x1830900 Offset: 0x182EF00 VA: 0x181830900
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x1830890 Offset: 0x182EE90 VA: 0x181830890
	public static IntPtr CreateJobReflectionData(Type type, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x1830BB0 Offset: 0x182F1B0 VA: 0x181830BB0
	private static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret) { }

	// RVA: 0x1830AE0 Offset: 0x182F0E0 VA: 0x181830AE0
	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	// RVA: 0x1830A20 Offset: 0x182F020 VA: 0x181830A20
	private static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }

}

public struct JobsUtility.JobScheduleParameters // TypeDefIndex: 3314
{	// Fields
	public JobHandle Dependency; // 0x0
	public int ScheduleMode; // 0x10
	public IntPtr ReflectionData; // 0x18
	public IntPtr JobDataPtr; // 0x20

	// Methods

	// RVA: 0x213650 Offset: 0x212A50 VA: 0x180213650
	public void .ctor(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

