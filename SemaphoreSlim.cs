public class SemaphoreSlim : IDisposable // TypeDefIndex: 759
{	// Fields
	private int m_currentCount; // 0x10
	private readonly int m_maxCount; // 0x14
	private int m_waitCount; // 0x18
	private object m_lockObj; // 0x20
	private ManualResetEvent m_waitHandle; // 0x28
	private SemaphoreSlim.TaskNode m_asyncHead; // 0x30
	private SemaphoreSlim.TaskNode m_asyncTail; // 0x38
	private static readonly Task<bool> s_trueTask; // 0x0
	private const int NO_MAXIMUM = 2147483647;
	private static Action<object> s_cancellationTokenCanceledEventHandler; // 0x8

	// Methods

	// RVA: 0x1499B40 Offset: 0x1498140 VA: 0x181499B40
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x1499A70 Offset: 0x1498070 VA: 0x181499A70
	public void Wait() { }

	// RVA: 0x1499550 Offset: 0x1497B50 VA: 0x181499550
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14994A0 Offset: 0x1497AA0 VA: 0x1814994A0
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x1499350 Offset: 0x1497950 VA: 0x181499350
	public Task WaitAsync() { }

	// RVA: 0x1499340 Offset: 0x1497940 VA: 0x181499340
	public Task<bool> WaitAsync(int millisecondsTimeout) { }

	// RVA: 0x1498E20 Offset: 0x1497420 VA: 0x181498E20
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1498770 Offset: 0x1496D70 VA: 0x181498770
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x1498D30 Offset: 0x1497330 VA: 0x181498D30
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachineAttribute] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	// RVA: 0x1499360 Offset: 0x1497960 VA: 0x181499360
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14989A0 Offset: 0x1496FA0 VA: 0x1814989A0
	public int Release() { }

	// RVA: 0x14989B0 Offset: 0x1496FB0 VA: 0x1814989B0
	public int Release(int releaseCount) { }

	// RVA: 0x1498990 Offset: 0x1496F90 VA: 0x181498990
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x1498910 Offset: 0x1496F10 VA: 0x181498910 Slot: 4
	public void Dispose() { }

	// RVA: 0x1498860 Offset: 0x1496E60 VA: 0x181498860 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14984A0 Offset: 0x1496AA0 VA: 0x1814984A0
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x14986D0 Offset: 0x1496CD0 VA: 0x1814986D0
	private void CheckDispose() { }

	// RVA: 0x1498980 Offset: 0x1496F80 VA: 0x181498980
	private static string GetResourceString(string str) { }

	// RVA: 0x1499A80 Offset: 0x1498080 VA: 0x181499A80
	private static void .cctor() { }

}

private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 760
{	// Fields
	internal SemaphoreSlim.TaskNode Prev; // 0x58
	internal SemaphoreSlim.TaskNode Next; // 0x60

	// Methods

	// RVA: 0x149B370 Offset: 0x1499970 VA: 0x18149B370
	internal void .ctor() { }

	// RVA: 0x149B330 Offset: 0x1499930 VA: 0x18149B330 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

private struct SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31 : IAsyncStateMachine // TypeDefIndex: 761
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public SemaphoreSlim.TaskNode asyncWaiter; // 0x28
	public int millisecondsTimeout; // 0x30
	private CancellationTokenSource <cts>5__1; // 0x38
	public SemaphoreSlim <>4__this; // 0x40
	private object <>7__wrap1; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x60

	// Methods

	// RVA: 0x1F0F10 Offset: 0x1F0310 VA: 0x1801F0F10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F0F20 Offset: 0x1F0320 VA: 0x1801F0F20 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

