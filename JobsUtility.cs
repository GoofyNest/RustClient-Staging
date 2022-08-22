public static class JobsUtility // TypeDefIndex: 3313
{
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[NativeMethodAttribute] // RVA: 0xEA9B0 Offset: 0xE9DB0 VA: 0x1800EA9B0
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEAAE0 Offset: 0xE9EE0 VA: 0x1800EAAE0
	public static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters) { }

	[FreeFunctionAttribute] // RVA: 0xEAC00 Offset: 0xEA000 VA: 0x1800EAC00
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunctionAttribute] // RVA: 0xEAD50 Offset: 0xEA150 VA: 0x1800EAD50
	public static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	public static IntPtr CreateJobReflectionData(Type type, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	private static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret) { }

	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	private static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }

}

public struct JobsUtility.JobScheduleParameters // TypeDefIndex: 3314
{	public JobHandle Dependency; // 0x0
	public int ScheduleMode; // 0x10
	public IntPtr ReflectionData; // 0x18
	public IntPtr JobDataPtr; // 0x20


	public void .ctor(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

