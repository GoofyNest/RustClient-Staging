internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 813
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x160B3F0 Offset: 0x16099F0 VA: 0x18160B3F0
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x160B170 Offset: 0x1609770 VA: 0x18160B170
	private void CleanUp() { }

	// RVA: 0x160B330 Offset: 0x1609930 VA: 0x18160B330 Slot: 1
	protected override void Finalize() { }

}

