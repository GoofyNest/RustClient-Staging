internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 877
{	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x149BB20 Offset: 0x149A120 VA: 0x18149BB20
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x149B850 Offset: 0x1499E50 VA: 0x18149B850 Slot: 4
	internal sealed override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x149B7A0 Offset: 0x1499DA0 VA: 0x18149B7A0
	private static void PostAction(object state) { }

	// RVA: 0x149B6C0 Offset: 0x1499CC0 VA: 0x18149B6C0
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x149BA70 Offset: 0x149A070 VA: 0x18149BA70
	private static void .cctor() { }

}

private sealed class SynchronizationContextAwaitTaskContinuation.<>c // TypeDefIndex: 878
{	// Fields
	public static readonly SynchronizationContextAwaitTaskContinuation.<>c <>9; // 0x13EA0

	// Methods

	// RVA: 0x14A4290 Offset: 0x14A2890 VA: 0x1814A4290
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14A4230 Offset: 0x14A2830 VA: 0x1814A4230
	internal void <.cctor>b__7_0(object state) { }

}

