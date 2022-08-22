internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 881
{	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x148FED0 Offset: 0x148E4D0 VA: 0x18148FED0
	internal void .ctor(Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x148FE30 Offset: 0x148E430 VA: 0x18148FE30
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x148F470 Offset: 0x148DA70 VA: 0x18148F470
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x148FB50 Offset: 0x148E150 VA: 0x18148FB50 Slot: 4
	internal override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x148FF80 Offset: 0x148E580 VA: 0x18148FF80
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x148F5B0 Offset: 0x148DBB0 VA: 0x18148F5B0
	private void ExecuteWorkItemHelper() { }

	// RVA: 0x148FC10 Offset: 0x148E210 VA: 0x18148FC10 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x148F800 Offset: 0x148DE00 VA: 0x18148F800
	private static void InvokeAction(object state) { }

	// RVA: 0x148F6C0 Offset: 0x148DCC0 VA: 0x18148F6C0
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x148F860 Offset: 0x148DE60 VA: 0x18148F860
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x148F9F0 Offset: 0x148DFF0 VA: 0x18148F9F0
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x148FDA0 Offset: 0x148E3A0 VA: 0x18148FDA0
	internal static void UnsafeScheduleAction(Action action, Task task) { }

	// RVA: 0x148FC40 Offset: 0x148E240 VA: 0x18148FC40
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

}

private sealed class AwaitTaskContinuation.<>c // TypeDefIndex: 882
{	// Fields
	public static readonly AwaitTaskContinuation.<>c <>9; // 0x0
	public static WaitCallback <>9__17_0; // 0x8

	// Methods

	// RVA: 0x14A4610 Offset: 0x14A2C10 VA: 0x1814A4610
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14A4490 Offset: 0x14A2A90 VA: 0x1814A4490
	internal void <ThrowAsyncIfNecessary>b__17_0(object s) { }

}

