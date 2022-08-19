internal class GAThreading // TypeDefIndex: 5667
{	// Fields
	private static bool endThread; // 0x0
	private static DateTime threadDeadline; // 0x8
	private static readonly GAThreading _instance; // 0x10
	private readonly PriorityQueue<long, TimedBlock> blocks; // 0x10
	private readonly object threadLock; // 0x18
	private TimedBlock scheduledBlock; // 0x20
	private bool hasScheduledBlockRun; // 0x28
	private Thread thread; // 0x30

	// Properties
	private static GAThreading Instance { get; }

	// Methods

	// RVA: 0x13C4E10 Offset: 0x13C3410 VA: 0x1813C4E10
	private void .ctor() { }

	// RVA: 0x13C34E0 Offset: 0x13C1AE0 VA: 0x1813C34E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13C4F10 Offset: 0x13C3510 VA: 0x1813C4F10
	private static GAThreading get_Instance() { }

	// RVA: 0x13C4280 Offset: 0x13C2880 VA: 0x1813C4280
	private static void RunBlocks() { }

	// RVA: 0x13C4330 Offset: 0x13C2930 VA: 0x1813C4330
	public static void Run() { }

	// RVA: 0x13C4210 Offset: 0x13C2810 VA: 0x1813C4210
	public static void PerformTaskOnGAThread(string blockName, Action taskBlock) { }

	// RVA: 0x13C3DF0 Offset: 0x13C23F0 VA: 0x1813C3DF0
	public static void PerformTaskOnGAThread(string blockName, Action taskBlock, long delayInSeconds) { }

	// RVA: 0x13C44C0 Offset: 0x13C2AC0 VA: 0x1813C44C0
	public static void ScheduleTimer(double interval, string blockName, Action callback) { }

	// RVA: 0x13C3460 Offset: 0x13C1A60 VA: 0x1813C3460
	private void AddTimedBlock(TimedBlock timedBlock) { }

	// RVA: 0x13C35F0 Offset: 0x13C1BF0 VA: 0x1813C35F0
	private static TimedBlock GetNextBlock() { }

	// RVA: 0x13C3960 Offset: 0x13C1F60 VA: 0x1813C3960
	private static TimedBlock GetScheduledBlock() { }

	// RVA: 0x13C4900 Offset: 0x13C2F00 VA: 0x1813C4900
	public static void StartThread() { }

	// RVA: 0x13C4AE0 Offset: 0x13C30E0 VA: 0x1813C4AE0
	public static void StopThread() { }

	// RVA: 0x13C4B40 Offset: 0x13C3140 VA: 0x1813C4B40
	public static void WaitForThreadFinish() { }

	// RVA: 0x13C3CB0 Offset: 0x13C22B0 VA: 0x1813C3CB0
	public static bool IsThreadFinished() { }

	// RVA: 0x13C4CC0 Offset: 0x13C32C0 VA: 0x1813C4CC0
	private static void .cctor() { }

}

