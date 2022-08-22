public static class JobsUtility // TypeDefIndex: 3313
{	// Methods

	// RVA: 0x1830BF0 Offset: 0x182F1F0 VA: 0x181830BF0
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[NativeMethodAttribute] // RVA: 0xEA9B0 Offset: 0xE9DB0 VA: 0x1800EA9B0
	// RVA: 0x1830C40 Offset: 0x182F240 VA: 0x181830C40
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEAAE0 Offset: 0xE9EE0 VA: 0x1800EAAE0
	// RVA: 0x1830E80 Offset: 0x182F480 VA: 0x181830E80
	public static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters) { }

	[FreeFunctionAttribute] // RVA: 0xEAC00 Offset: 0xEA000 VA: 0x1800EAC00
	// RVA: 0x1830DC0 Offset: 0x182F3C0 VA: 0x181830DC0
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunctionAttribute] // RVA: 0xEAD50 Offset: 0xEA150 VA: 0x1800EAD50
	// RVA: 0x1830D00 Offset: 0x182F300 VA: 0x181830D00
	public static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x1830B80 Offset: 0x182F180 VA: 0x181830B80
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x1830B10 Offset: 0x182F110 VA: 0x181830B10
	public static IntPtr CreateJobReflectionData(Type type, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x1830E30 Offset: 0x182F430 VA: 0x181830E30
	private static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret) { }

	// RVA: 0x1830D60 Offset: 0x182F360 VA: 0x181830D60
	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	// RVA: 0x1830CA0 Offset: 0x182F2A0 VA: 0x181830CA0
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

