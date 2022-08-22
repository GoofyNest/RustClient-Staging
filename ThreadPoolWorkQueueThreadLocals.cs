internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 813
{	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20


	public void .ctor(ThreadPoolWorkQueue tpq) { }

	private void CleanUp() { }

	protected override void Finalize() { }

}

