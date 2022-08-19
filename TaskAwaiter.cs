public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1290
{	// Fields
	private readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	internal void .ctor(Task task) { }

	// RVA: 0x14C140 Offset: 0x14B540 VA: 0x18014C140
	public bool get_IsCompleted() { }

	// RVA: 0x14CA80 Offset: 0x14BE80 VA: 0x18014CA80 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x14CAB0 Offset: 0x14BEB0 VA: 0x18014CAB0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x14C0D0 Offset: 0x14B4D0 VA: 0x18014C0D0
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

