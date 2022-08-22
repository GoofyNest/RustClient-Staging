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

	// RVA: 0x149AA70 Offset: 0x1499070 VA: 0x18149AA70
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x149A9A0 Offset: 0x1498FA0 VA: 0x18149A9A0
	public void Wait() { }

	// RVA: 0x149A480 Offset: 0x1498A80 VA: 0x18149A480
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x149A3D0 Offset: 0x14989D0 VA: 0x18149A3D0
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x149A280 Offset: 0x1498880 VA: 0x18149A280
	public Task WaitAsync() { }

	// RVA: 0x149A270 Offset: 0x1498870 VA: 0x18149A270
	public Task<bool> WaitAsync(int millisecondsTimeout) { }

	// RVA: 0x1499D50 Offset: 0x1498350 VA: 0x181499D50
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14996A0 Offset: 0x1497CA0 VA: 0x1814996A0
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x1499C60 Offset: 0x1498260 VA: 0x181499C60
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachineAttribute] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	// RVA: 0x149A290 Offset: 0x1498890 VA: 0x18149A290
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14998D0 Offset: 0x1497ED0 VA: 0x1814998D0
	public int Release() { }

	// RVA: 0x14998E0 Offset: 0x1497EE0 VA: 0x1814998E0
	public int Release(int releaseCount) { }

	// RVA: 0x14998C0 Offset: 0x1497EC0 VA: 0x1814998C0
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x1499840 Offset: 0x1497E40 VA: 0x181499840 Slot: 4
	public void Dispose() { }

	// RVA: 0x1499790 Offset: 0x1497D90 VA: 0x181499790 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14993D0 Offset: 0x14979D0 VA: 0x1814993D0
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x1499600 Offset: 0x1497C00 VA: 0x181499600
	private void CheckDispose() { }

	// RVA: 0x14998B0 Offset: 0x1497EB0 VA: 0x1814998B0
	private static string GetResourceString(string str) { }

	// RVA: 0x149A9B0 Offset: 0x1498FB0 VA: 0x18149A9B0
	private static void .cctor() { }

}

private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 760
{	// Fields
	internal SemaphoreSlim.TaskNode Prev; // 0x58
	internal SemaphoreSlim.TaskNode Next; // 0x60

	// Methods

	// RVA: 0x149C2A0 Offset: 0x149A8A0 VA: 0x18149C2A0
	internal void .ctor() { }

	// RVA: 0x149C260 Offset: 0x149A860 VA: 0x18149C260 Slot: 4
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

