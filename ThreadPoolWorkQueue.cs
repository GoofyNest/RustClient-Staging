internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 809
{	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x15F9580 Offset: 0x15F7B80 VA: 0x1815F9580
	public void .ctor() { }

	// RVA: 0x15F9330 Offset: 0x15F7930 VA: 0x1815F9330
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x15F93C0 Offset: 0x15F79C0 VA: 0x1815F93C0
	internal void EnsureThreadRequested() { }

	// RVA: 0x15F94C0 Offset: 0x15F7AC0 VA: 0x1815F94C0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x15F9110 Offset: 0x15F7710 VA: 0x1815F9110
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x15F9460 Offset: 0x15F7A60 VA: 0x1815F9460
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x15F88F0 Offset: 0x15F6EF0 VA: 0x1815F88F0
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x15F8C40 Offset: 0x15F7240 VA: 0x1815F8C40
	internal static bool Dispatch() { }

	// RVA: 0x15F9510 Offset: 0x15F7B10 VA: 0x1815F9510
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
	|-RVA: 0x1A404F0 Offset: 0x1A3EAF0 VA: 0x181A404F0
	|-ThreadPoolWorkQueue.SparseArray<object>..ctor
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368130 Offset: 0x1366730 VA: 0x181368130
	|-ThreadPoolWorkQueue.SparseArray<object>.get_Current
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal int Add(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A40110 Offset: 0x1A3E710 VA: 0x181A40110
	|-ThreadPoolWorkQueue.SparseArray<object>.Add
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Add
	*/

	// RVA: -1 Offset: -1
	internal void Remove(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A40370 Offset: 0x1A3E970 VA: 0x181A40370
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

	// RVA: 0x160B5D0 Offset: 0x1609BD0 VA: 0x18160B5D0
	public void LocalPush(IThreadPoolWorkItem obj) { }

	// RVA: 0x160AF80 Offset: 0x1609580 VA: 0x18160AF80
	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	// RVA: 0x160B280 Offset: 0x1609880 VA: 0x18160B280
	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	// RVA: 0x160BD40 Offset: 0x160A340 VA: 0x18160BD40
	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	// RVA: 0x160BA80 Offset: 0x160A080 VA: 0x18160BA80
	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	// RVA: 0x160BD60 Offset: 0x160A360 VA: 0x18160BD60
	public void .ctor() { }

}

internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 812
{	// Fields
	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20

	// Methods

	// RVA: 0x15F37A0 Offset: 0x15F1DA0 VA: 0x1815F37A0
	private void GetIndexes(out int upper, out int lower) { }

	// RVA: 0x15F3720 Offset: 0x15F1D20 VA: 0x1815F3720
	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x15F3A60 Offset: 0x15F2060 VA: 0x1815F3A60
	public void .ctor() { }

	// RVA: 0x15F37E0 Offset: 0x15F1DE0 VA: 0x1815F37E0
	public bool IsUsedUp() { }

	// RVA: 0x15F3980 Offset: 0x15F1F80 VA: 0x1815F3980
	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	// RVA: 0x15F3840 Offset: 0x15F1E40 VA: 0x1815F3840
	public bool TryDequeue(out IThreadPoolWorkItem node) { }

}

