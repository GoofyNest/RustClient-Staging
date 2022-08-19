internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 813
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x160B130 Offset: 0x1609730 VA: 0x18160B130
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x160AEB0 Offset: 0x16094B0 VA: 0x18160AEB0
	private void CleanUp() { }

	// RVA: 0x160B070 Offset: 0x1609670 VA: 0x18160B070 Slot: 1
	protected override void Finalize() { }

}

