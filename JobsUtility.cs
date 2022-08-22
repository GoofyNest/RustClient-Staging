public static class JobsUtility // TypeDefIndex: 3313
{	// Methods

	// RVA: 0x181E030 Offset: 0x181C630 VA: 0x18181E030
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[NativeMethodAttribute] // RVA: 0xEA9B0 Offset: 0xE9DB0 VA: 0x1800EA9B0
	// RVA: 0x181E080 Offset: 0x181C680 VA: 0x18181E080
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEAAE0 Offset: 0xE9EE0 VA: 0x1800EAAE0
	// RVA: 0x181E2C0 Offset: 0x181C8C0 VA: 0x18181E2C0
	public static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters) { }

	[FreeFunctionAttribute] // RVA: 0xEAC00 Offset: 0xEA000 VA: 0x1800EAC00
	// RVA: 0x181E200 Offset: 0x181C800 VA: 0x18181E200
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunctionAttribute] // RVA: 0xEAD50 Offset: 0xEA150 VA: 0x1800EAD50
	// RVA: 0x181E140 Offset: 0x181C740 VA: 0x18181E140
	public static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x181DFC0 Offset: 0x181C5C0 VA: 0x18181DFC0
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x181DF50 Offset: 0x181C550 VA: 0x18181DF50
	public static IntPtr CreateJobReflectionData(Type type, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x181E270 Offset: 0x181C870 VA: 0x18181E270
	private static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret) { }

	// RVA: 0x181E1A0 Offset: 0x181C7A0 VA: 0x18181E1A0
	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	// RVA: 0x181E0E0 Offset: 0x181C6E0 VA: 0x18181E0E0
	private static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }

}

public struct JobsUtility.JobScheduleParameters // TypeDefIndex: 3314
{	// Fields
	public JobHandle Dependency; // 0x0
	public int ScheduleMode; // 0x10
	public IntPtr ReflectionData; // 0x18
	public IntPtr JobDataPtr; // 0x20

	// Methods

	// RVA: 0x212A00 Offset: 0x211E00 VA: 0x180212A00
	public void .ctor(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

