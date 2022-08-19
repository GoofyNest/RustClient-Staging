internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 881
{	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x148FC10 Offset: 0x148E210 VA: 0x18148FC10
	internal void .ctor(Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x148FB70 Offset: 0x148E170 VA: 0x18148FB70
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x148F1B0 Offset: 0x148D7B0 VA: 0x18148F1B0
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x148F890 Offset: 0x148DE90 VA: 0x18148F890 Slot: 4
	internal override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x148FCC0 Offset: 0x148E2C0 VA: 0x18148FCC0
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x148F2F0 Offset: 0x148D8F0 VA: 0x18148F2F0
	private void ExecuteWorkItemHelper() { }

	// RVA: 0x148F950 Offset: 0x148DF50 VA: 0x18148F950 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x148F540 Offset: 0x148DB40 VA: 0x18148F540
	private static void InvokeAction(object state) { }

	// RVA: 0x148F400 Offset: 0x148DA00 VA: 0x18148F400
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x148F5A0 Offset: 0x148DBA0 VA: 0x18148F5A0
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x148F730 Offset: 0x148DD30 VA: 0x18148F730
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x148FAE0 Offset: 0x148E0E0 VA: 0x18148FAE0
	internal static void UnsafeScheduleAction(Action action, Task task) { }

	// RVA: 0x148F980 Offset: 0x148DF80 VA: 0x18148F980
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

}

private sealed class AwaitTaskContinuation.<>c // TypeDefIndex: 882
{	// Fields
	public static readonly AwaitTaskContinuation.<>c <>9; // 0x0
	public static WaitCallback <>9__17_0; // 0x8

	// Methods

	// RVA: 0x14A4350 Offset: 0x14A2950 VA: 0x1814A4350
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14A41D0 Offset: 0x14A27D0 VA: 0x1814A41D0
	internal void <ThrowAsyncIfNecessary>b__17_0(object s) { }

}

