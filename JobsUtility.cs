public static class JobsUtility // TypeDefIndex: 3313
{	// Methods

	// RVA: 0x1830930 Offset: 0x182EF30 VA: 0x181830930
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[NativeMethodAttribute] // RVA: 0xEA9B0 Offset: 0xE9DB0 VA: 0x1800EA9B0
	// RVA: 0x1830980 Offset: 0x182EF80 VA: 0x181830980
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEAAE0 Offset: 0xE9EE0 VA: 0x1800EAAE0
	// RVA: 0x1830BC0 Offset: 0x182F1C0 VA: 0x181830BC0
	public static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters) { }

	[FreeFunctionAttribute] // RVA: 0xEAC00 Offset: 0xEA000 VA: 0x1800EAC00
	// RVA: 0x1830B00 Offset: 0x182F100 VA: 0x181830B00
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunctionAttribute] // RVA: 0xEAD50 Offset: 0xEA150 VA: 0x1800EAD50
	// RVA: 0x1830A40 Offset: 0x182F040 VA: 0x181830A40
	public static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18308C0 Offset: 0x182EEC0 VA: 0x1818308C0
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x1830850 Offset: 0x182EE50 VA: 0x181830850
	public static IntPtr CreateJobReflectionData(Type type, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x1830B70 Offset: 0x182F170 VA: 0x181830B70
	private static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret) { }

	// RVA: 0x1830AA0 Offset: 0x182F0A0 VA: 0x181830AA0
	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	// RVA: 0x18309E0 Offset: 0x182EFE0 VA: 0x1818309E0
	private static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }

}

public struct JobsUtility.JobScheduleParameters // TypeDefIndex: 3314
{	// Fields
	public JobHandle Dependency; // 0x0
	public int ScheduleMode; // 0x10
	public IntPtr ReflectionData; // 0x18
	public IntPtr JobDataPtr; // 0x20

	// Methods

	// RVA: 0x2135D0 Offset: 0x2129D0 VA: 0x1802135D0
	public void .ctor(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

