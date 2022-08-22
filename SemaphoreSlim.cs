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

	// RVA: 0x149A7B0 Offset: 0x1498DB0 VA: 0x18149A7B0
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x149A6E0 Offset: 0x1498CE0 VA: 0x18149A6E0
	public void Wait() { }

	// RVA: 0x149A1C0 Offset: 0x14987C0 VA: 0x18149A1C0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x149A110 Offset: 0x1498710 VA: 0x18149A110
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x1499FC0 Offset: 0x14985C0 VA: 0x181499FC0
	public Task WaitAsync() { }

	// RVA: 0x1499FB0 Offset: 0x14985B0 VA: 0x181499FB0
	public Task<bool> WaitAsync(int millisecondsTimeout) { }

	// RVA: 0x1499A90 Offset: 0x1498090 VA: 0x181499A90
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14993E0 Offset: 0x14979E0 VA: 0x1814993E0
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x14999A0 Offset: 0x1497FA0 VA: 0x1814999A0
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachineAttribute] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	// RVA: 0x1499FD0 Offset: 0x14985D0 VA: 0x181499FD0
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1499610 Offset: 0x1497C10 VA: 0x181499610
	public int Release() { }

	// RVA: 0x1499620 Offset: 0x1497C20 VA: 0x181499620
	public int Release(int releaseCount) { }

	// RVA: 0x1499600 Offset: 0x1497C00 VA: 0x181499600
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x1499580 Offset: 0x1497B80 VA: 0x181499580 Slot: 4
	public void Dispose() { }

	// RVA: 0x14994D0 Offset: 0x1497AD0 VA: 0x1814994D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1499110 Offset: 0x1497710 VA: 0x181499110
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x1499340 Offset: 0x1497940 VA: 0x181499340
	private void CheckDispose() { }

	// RVA: 0x14995F0 Offset: 0x1497BF0 VA: 0x1814995F0
	private static string GetResourceString(string str) { }

	// RVA: 0x149A6F0 Offset: 0x1498CF0 VA: 0x18149A6F0
	private static void .cctor() { }

}

private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 760
{	// Fields
	internal SemaphoreSlim.TaskNode Prev; // 0x58
	internal SemaphoreSlim.TaskNode Next; // 0x60

	// Methods

	// RVA: 0x149BFE0 Offset: 0x149A5E0 VA: 0x18149BFE0
	internal void .ctor() { }

	// RVA: 0x149BFA0 Offset: 0x149A5A0 VA: 0x18149BFA0 Slot: 4
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

	// RVA: 0x1F0AF0 Offset: 0x1EFEF0 VA: 0x1801F0AF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F0B00 Offset: 0x1EFF00 VA: 0x1801F0B00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

