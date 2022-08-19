internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 876
{	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x149B5E0 Offset: 0x1499BE0 VA: 0x18149B5E0
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x149B4D0 Offset: 0x1499AD0 VA: 0x18149B4D0 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

