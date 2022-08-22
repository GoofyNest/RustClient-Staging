internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 809
{	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x160C260 Offset: 0x160A860 VA: 0x18160C260
	public void .ctor() { }

	// RVA: 0x160C010 Offset: 0x160A610 VA: 0x18160C010
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x160C0A0 Offset: 0x160A6A0 VA: 0x18160C0A0
	internal void EnsureThreadRequested() { }

	// RVA: 0x160C1A0 Offset: 0x160A7A0 VA: 0x18160C1A0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x160BDF0 Offset: 0x160A3F0 VA: 0x18160BDF0
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x160C140 Offset: 0x160A740 VA: 0x18160C140
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x160B5D0 Offset: 0x1609BD0 VA: 0x18160B5D0
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x160B920 Offset: 0x1609F20 VA: 0x18160B920
	internal static bool Dispatch() { }

	// RVA: 0x160C1F0 Offset: 0x160A7F0 VA: 0x18160C1F0
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
	|-RVA: 0x1A53FC0 Offset: 0x1A525C0 VA: 0x181A53FC0
	|-ThreadPoolWorkQueue.SparseArray<object>..ctor
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369030 Offset: 0x1367630 VA: 0x181369030
	|-ThreadPoolWorkQueue.SparseArray<object>.get_Current
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal int Add(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53BE0 Offset: 0x1A521E0 VA: 0x181A53BE0
	|-ThreadPoolWorkQueue.SparseArray<object>.Add
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Add
	*/

	// RVA: -1 Offset: -1
	internal void Remove(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53E40 Offset: 0x1A52440 VA: 0x181A53E40
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

	// RVA: 0x161E2B0 Offset: 0x161C8B0 VA: 0x18161E2B0
	public void LocalPush(IThreadPoolWorkItem obj) { }

	// RVA: 0x161DC60 Offset: 0x161C260 VA: 0x18161DC60
	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	// RVA: 0x161DF60 Offset: 0x161C560 VA: 0x18161DF60
	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	// RVA: 0x161EA20 Offset: 0x161D020 VA: 0x18161EA20
	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	// RVA: 0x161E760 Offset: 0x161CD60 VA: 0x18161E760
	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	// RVA: 0x161EA40 Offset: 0x161D040 VA: 0x18161EA40
	public void .ctor() { }

}

internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 812
{	// Fields
	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20

	// Methods

	// RVA: 0x1606480 Offset: 0x1604A80 VA: 0x181606480
	private void GetIndexes(out int upper, out int lower) { }

	// RVA: 0x1606400 Offset: 0x1604A00 VA: 0x181606400
	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x1606740 Offset: 0x1604D40 VA: 0x181606740
	public void .ctor() { }

	// RVA: 0x16064C0 Offset: 0x1604AC0 VA: 0x1816064C0
	public bool IsUsedUp() { }

	// RVA: 0x1606660 Offset: 0x1604C60 VA: 0x181606660
	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	// RVA: 0x1606520 Offset: 0x1604B20 VA: 0x181606520
	public bool TryDequeue(out IThreadPoolWorkItem node) { }

}

