internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 809
{	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x160BFA0 Offset: 0x160A5A0 VA: 0x18160BFA0
	public void .ctor() { }

	// RVA: 0x160BD50 Offset: 0x160A350 VA: 0x18160BD50
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x160BDE0 Offset: 0x160A3E0 VA: 0x18160BDE0
	internal void EnsureThreadRequested() { }

	// RVA: 0x160BEE0 Offset: 0x160A4E0 VA: 0x18160BEE0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x160BB30 Offset: 0x160A130 VA: 0x18160BB30
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x160BE80 Offset: 0x160A480 VA: 0x18160BE80
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x160B310 Offset: 0x1609910 VA: 0x18160B310
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x160B660 Offset: 0x1609C60 VA: 0x18160B660
	internal static bool Dispatch() { }

	// RVA: 0x160BF30 Offset: 0x160A530 VA: 0x18160BF30
	private static void .cctor() { }

}

internal class ThreadPoolWorkQueue.SparseArray<T> // TypeDefIndex: 810
{	// Fields
	private T[] m_array; // 0x0

	// Properties
	internal T[] Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53D40 Offset: 0x1A52340 VA: 0x181A53D40
	|-ThreadPoolWorkQueue.SparseArray<object>..ctor
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368D70 Offset: 0x1367370 VA: 0x181368D70
	|-ThreadPoolWorkQueue.SparseArray<object>.get_Current
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal int Add(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53960 Offset: 0x1A51F60 VA: 0x181A53960
	|-ThreadPoolWorkQueue.SparseArray<object>.Add
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Add
	*/

	// RVA: -1 Offset: -1
	internal void Remove(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53BC0 Offset: 0x1A521C0 VA: 0x181A53BC0
	|-ThreadPoolWorkQueue.SparseArray<object>.Remove
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Remove
	*/

}

internal class ThreadPoolWorkQueue.WorkStealingQueue // TypeDefIndex: 811
{	// Fields
	internal IThreadPoolWorkItem[] m_array; // 0x10
	private int m_mask; // 0x18
	private int m_headIndex; // 0x1C
	private int m_tailIndex; // 0x20
	private SpinLock m_foreignLock; // 0x24

	// Methods

	// RVA: 0x161DFF0 Offset: 0x161C5F0 VA: 0x18161DFF0
	public void LocalPush(IThreadPoolWorkItem obj) { }

	// RVA: 0x161D9A0 Offset: 0x161BFA0 VA: 0x18161D9A0
	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	// RVA: 0x161DCA0 Offset: 0x161C2A0 VA: 0x18161DCA0
	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	// RVA: 0x161E760 Offset: 0x161CD60 VA: 0x18161E760
	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	// RVA: 0x161E4A0 Offset: 0x161CAA0 VA: 0x18161E4A0
	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	// RVA: 0x161E780 Offset: 0x161CD80 VA: 0x18161E780
	public void .ctor() { }

}

internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 812
{	// Fields
	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20

	// Methods

	// RVA: 0x16061C0 Offset: 0x16047C0 VA: 0x1816061C0
	private void GetIndexes(out int upper, out int lower) { }

	// RVA: 0x1606140 Offset: 0x1604740 VA: 0x181606140
	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x1606480 Offset: 0x1604A80 VA: 0x181606480
	public void .ctor() { }

	// RVA: 0x1606200 Offset: 0x1604800 VA: 0x181606200
	public bool IsUsedUp() { }

	// RVA: 0x16063A0 Offset: 0x16049A0 VA: 0x1816063A0
	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	// RVA: 0x1606260 Offset: 0x1604860 VA: 0x181606260
	public bool TryDequeue(out IThreadPoolWorkItem node) { }

}

