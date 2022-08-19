internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 860
{	// Fields
	private readonly ITaskCompletionAction m_action; // 0x10
	private readonly Task m_completingTask; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

	// RVA: 0x1492510 Offset: 0x1490B10 VA: 0x181492510 Slot: 4
	public void ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void MarkAborted(ThreadAbortException tae) { }

}

