public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1290
{	// Fields
	private readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	internal void .ctor(Task task) { }

	// RVA: 0x14C0C0 Offset: 0x14B4C0 VA: 0x18014C0C0
	public bool get_IsCompleted() { }

	// RVA: 0x14CA00 Offset: 0x14BE00 VA: 0x18014CA00 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x14CA30 Offset: 0x14BE30 VA: 0x18014CA30 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x14C050 Offset: 0x14B450 VA: 0x18014C050
	public void GetResult() { }

	// RVA: 0xFF5FB0 Offset: 0xFF45B0 VA: 0x180FF5FB0
	internal static void ValidateEnd(Task task) { }

	// RVA: 0xFF5C00 Offset: 0xFF4200 VA: 0x180FF5C00
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	// RVA: 0xFF5E60 Offset: 0xFF4460 VA: 0x180FF5E60
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0xFF5D60 Offset: 0xFF4360 VA: 0x180FF5D60
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

}

