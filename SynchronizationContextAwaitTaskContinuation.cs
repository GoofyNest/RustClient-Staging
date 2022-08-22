internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 877
{	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x149AEB0 Offset: 0x14994B0 VA: 0x18149AEB0
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x149ABE0 Offset: 0x14991E0 VA: 0x18149ABE0 Slot: 4
	internal sealed override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x149AB30 Offset: 0x1499130 VA: 0x18149AB30
	private static void PostAction(object state) { }

	// RVA: 0x149AA50 Offset: 0x1499050 VA: 0x18149AA50
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x149AE00 Offset: 0x1499400 VA: 0x18149AE00
	private static void .cctor() { }

}

private sealed class SynchronizationContextAwaitTaskContinuation.<>c // TypeDefIndex: 878
{	// Fields
	public static readonly SynchronizationContextAwaitTaskContinuation.<>c <>9; // 0x2B104DC

	// Methods

	// RVA: 0x14A3620 Offset: 0x14A1C20 VA: 0x1814A3620
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14A35C0 Offset: 0x14A1BC0 VA: 0x1814A35C0
	internal void <.cctor>b__7_0(object state) { }

}

