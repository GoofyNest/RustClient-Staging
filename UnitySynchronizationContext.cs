internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3536
{	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x2181820 Offset: 0x217FE20 VA: 0x182181820
	private void .ctor(int mainThreadID) { }

	// RVA: 0x2181770 Offset: 0x217FD70 VA: 0x182181770
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x2181510 Offset: 0x217FB10 VA: 0x182181510 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x21813C0 Offset: 0x217F9C0 VA: 0x1821813C0 Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x21813B0 Offset: 0x217F9B0 VA: 0x1821813B0 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x21813D0 Offset: 0x217F9D0 VA: 0x1821813D0 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x2180E30 Offset: 0x217F430 VA: 0x182180E30 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x2180F00 Offset: 0x217F500 VA: 0x182180F00
	private void Exec() { }

	// RVA: 0x2181240 Offset: 0x217F840 VA: 0x182181240
	private bool HasPendingTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21812A0 Offset: 0x217F8A0 VA: 0x1821812A0
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21811F0 Offset: 0x217F7F0 VA: 0x1821811F0
	private static void ExecuteTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21810B0 Offset: 0x217F6B0 VA: 0x1821810B0
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }

}

private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 3537
{	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10

	// Methods

	// RVA: 0xF5C70 Offset: 0xF5070 VA: 0x1800F5C70
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x236B40 Offset: 0x235F40 VA: 0x180236B40
	public void Invoke() { }

}

