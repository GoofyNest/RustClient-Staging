internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 876
{	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x149A970 Offset: 0x1498F70 VA: 0x18149A970
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x149A860 Offset: 0x1498E60 VA: 0x18149A860 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

