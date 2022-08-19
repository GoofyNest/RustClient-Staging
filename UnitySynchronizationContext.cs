internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3536
{	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x2181720 Offset: 0x217FD20 VA: 0x182181720
	private void .ctor(int mainThreadID) { }

	// RVA: 0x2181670 Offset: 0x217FC70 VA: 0x182181670
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x2181410 Offset: 0x217FA10 VA: 0x182181410 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x21812C0 Offset: 0x217F8C0 VA: 0x1821812C0 Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x21812B0 Offset: 0x217F8B0 VA: 0x1821812B0 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x21812D0 Offset: 0x217F8D0 VA: 0x1821812D0 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x2180D30 Offset: 0x217F330 VA: 0x182180D30 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x2180E00 Offset: 0x217F400 VA: 0x182180E00
	private void Exec() { }

	// RVA: 0x2181140 Offset: 0x217F740 VA: 0x182181140
	private bool HasPendingTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21811A0 Offset: 0x217F7A0 VA: 0x1821811A0
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21810F0 Offset: 0x217F6F0 VA: 0x1821810F0
	private static void ExecuteTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2180FB0 Offset: 0x217F5B0 VA: 0x182180FB0
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }

}

private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 3537
{	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10

	// Methods

	// RVA: 0xF5CF0 Offset: 0xF50F0 VA: 0x1800F5CF0
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x236BC0 Offset: 0x235FC0 VA: 0x180236BC0
	public void Invoke() { }

}

