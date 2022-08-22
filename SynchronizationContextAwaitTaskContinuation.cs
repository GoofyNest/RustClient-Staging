internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 877
{	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x149BDE0 Offset: 0x149A3E0 VA: 0x18149BDE0
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x149BB10 Offset: 0x149A110 VA: 0x18149BB10 Slot: 4
	internal sealed override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x149BA60 Offset: 0x149A060 VA: 0x18149BA60
	private static void PostAction(object state) { }

	// RVA: 0x149B980 Offset: 0x1499F80 VA: 0x18149B980
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x149BD30 Offset: 0x149A330 VA: 0x18149BD30
	private static void .cctor() { }

}

private sealed class SynchronizationContextAwaitTaskContinuation.<>c // TypeDefIndex: 878
{	// Fields
	public static readonly SynchronizationContextAwaitTaskContinuation.<>c <>9; // 0x13EA0

	// Methods

	// RVA: 0x14A4550 Offset: 0x14A2B50 VA: 0x1814A4550
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14A44F0 Offset: 0x14A2AF0 VA: 0x1814A44F0
	internal void <.cctor>b__7_0(object state) { }

}

