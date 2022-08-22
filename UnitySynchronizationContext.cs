internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3536
{	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x2181560 Offset: 0x217FB60 VA: 0x182181560
	private void .ctor(int mainThreadID) { }

	// RVA: 0x21814B0 Offset: 0x217FAB0 VA: 0x1821814B0
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x2181250 Offset: 0x217F850 VA: 0x182181250 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x2181100 Offset: 0x217F700 VA: 0x182181100 Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x21810F0 Offset: 0x217F6F0 VA: 0x1821810F0 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x2181110 Offset: 0x217F710 VA: 0x182181110 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x2180B70 Offset: 0x217F170 VA: 0x182180B70 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x2180C40 Offset: 0x217F240 VA: 0x182180C40
	private void Exec() { }

	// RVA: 0x2180F80 Offset: 0x217F580 VA: 0x182180F80
	private bool HasPendingTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2180FE0 Offset: 0x217F5E0 VA: 0x182180FE0
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2180F30 Offset: 0x217F530 VA: 0x182180F30
	private static void ExecuteTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2180DF0 Offset: 0x217F3F0 VA: 0x182180DF0
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

