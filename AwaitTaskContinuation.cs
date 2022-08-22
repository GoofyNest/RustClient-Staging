internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 881
{	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x148EFA0 Offset: 0x148D5A0 VA: 0x18148EFA0
	internal void .ctor(Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x148EF00 Offset: 0x148D500 VA: 0x18148EF00
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x148E540 Offset: 0x148CB40 VA: 0x18148E540
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x148EC20 Offset: 0x148D220 VA: 0x18148EC20 Slot: 4
	internal override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x148F050 Offset: 0x148D650 VA: 0x18148F050
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x148E680 Offset: 0x148CC80 VA: 0x18148E680
	private void ExecuteWorkItemHelper() { }

	// RVA: 0x148ECE0 Offset: 0x148D2E0 VA: 0x18148ECE0 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x148E8D0 Offset: 0x148CED0 VA: 0x18148E8D0
	private static void InvokeAction(object state) { }

	// RVA: 0x148E790 Offset: 0x148CD90 VA: 0x18148E790
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x148E930 Offset: 0x148CF30 VA: 0x18148E930
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x148EAC0 Offset: 0x148D0C0 VA: 0x18148EAC0
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x148EE70 Offset: 0x148D470 VA: 0x18148EE70
	internal static void UnsafeScheduleAction(Action action, Task task) { }

	// RVA: 0x148ED10 Offset: 0x148D310 VA: 0x18148ED10
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

}

private sealed class AwaitTaskContinuation.<>c // TypeDefIndex: 882
{	// Fields
	public static readonly AwaitTaskContinuation.<>c <>9; // 0x0
	public static WaitCallback <>9__17_0; // 0x8

	// Methods

	// RVA: 0x14A36E0 Offset: 0x14A1CE0 VA: 0x1814A36E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14A3560 Offset: 0x14A1B60 VA: 0x1814A3560
	internal void <ThrowAsyncIfNecessary>b__17_0(object s) { }

}

