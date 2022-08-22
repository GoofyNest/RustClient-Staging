internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3536
{	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x2182040 Offset: 0x2180640 VA: 0x182182040
	private void .ctor(int mainThreadID) { }

	// RVA: 0x2181F90 Offset: 0x2180590 VA: 0x182181F90
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x2181D30 Offset: 0x2180330 VA: 0x182181D30 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x2181BE0 Offset: 0x21801E0 VA: 0x182181BE0 Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x2181BD0 Offset: 0x21801D0 VA: 0x182181BD0 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x2181BF0 Offset: 0x21801F0 VA: 0x182181BF0 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x2181650 Offset: 0x217FC50 VA: 0x182181650 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x2181720 Offset: 0x217FD20 VA: 0x182181720
	private void Exec() { }

	// RVA: 0x2181A60 Offset: 0x2180060 VA: 0x182181A60
	private bool HasPendingTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2181AC0 Offset: 0x21800C0 VA: 0x182181AC0
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2181A10 Offset: 0x2180010 VA: 0x182181A10
	private static void ExecuteTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21818D0 Offset: 0x217FED0 VA: 0x1821818D0
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }

}

private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 3537
{	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10

	// Methods

	// RVA: 0xF5FD0 Offset: 0xF53D0 VA: 0x1800F5FD0
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x236B40 Offset: 0x235F40 VA: 0x180236B40
	public void Invoke() { }

}

