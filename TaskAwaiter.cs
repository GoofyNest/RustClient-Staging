public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1290
{	// Fields
	private readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	internal void .ctor(Task task) { }

	// RVA: 0x14BEE0 Offset: 0x14B2E0 VA: 0x18014BEE0
	public bool get_IsCompleted() { }

	// RVA: 0x14C820 Offset: 0x14BC20 VA: 0x18014C820 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x14C850 Offset: 0x14BC50 VA: 0x18014C850 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x14BE70 Offset: 0x14B270 VA: 0x18014BE70
	public void GetResult() { }

	// RVA: 0xFF6D10 Offset: 0xFF5310 VA: 0x180FF6D10
	internal static void ValidateEnd(Task task) { }

	// RVA: 0xFF6960 Offset: 0xFF4F60 VA: 0x180FF6960
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	// RVA: 0xFF6BC0 Offset: 0xFF51C0 VA: 0x180FF6BC0
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0xFF6AC0 Offset: 0xFF50C0 VA: 0x180FF6AC0
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

}

