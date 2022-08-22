internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 876
{	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x149B8A0 Offset: 0x1499EA0 VA: 0x18149B8A0
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x149B790 Offset: 0x1499D90 VA: 0x18149B790 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

