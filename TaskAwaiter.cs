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

	// RVA: 0xFF6270 Offset: 0xFF4870 VA: 0x180FF6270
	internal static void ValidateEnd(Task task) { }

	// RVA: 0xFF5EC0 Offset: 0xFF44C0 VA: 0x180FF5EC0
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	// RVA: 0xFF6120 Offset: 0xFF4720 VA: 0x180FF6120
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0xFF6020 Offset: 0xFF4620 VA: 0x180FF6020
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

}

