internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 813
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x15F8710 Offset: 0x15F6D10 VA: 0x1815F8710
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x15F8490 Offset: 0x15F6A90 VA: 0x1815F8490
	private void CleanUp() { }

	// RVA: 0x15F8650 Offset: 0x15F6C50 VA: 0x1815F8650 Slot: 1
	protected override void Finalize() { }

}

