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

	// RVA: 0x13C41D0 Offset: 0x13C27D0 VA: 0x1813C41D0
	private void .ctor() { }

	// RVA: 0x13C28A0 Offset: 0x13C0EA0 VA: 0x1813C28A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13C42D0 Offset: 0x13C28D0 VA: 0x1813C42D0
	private static GAThreading get_Instance() { }

	// RVA: 0x13C3640 Offset: 0x13C1C40 VA: 0x1813C3640
	private static void RunBlocks() { }

	// RVA: 0x13C36F0 Offset: 0x13C1CF0 VA: 0x1813C36F0
	public static void Run() { }

	// RVA: 0x13C35D0 Offset: 0x13C1BD0 VA: 0x1813C35D0
	public static void PerformTaskOnGAThread(string blockName, Action taskBlock) { }

	// RVA: 0x13C31B0 Offset: 0x13C17B0 VA: 0x1813C31B0
	public static void PerformTaskOnGAThread(string blockName, Action taskBlock, long delayInSeconds) { }

	// RVA: 0x13C3880 Offset: 0x13C1E80 VA: 0x1813C3880
	public static void ScheduleTimer(double interval, string blockName, Action callback) { }

	// RVA: 0x13C2820 Offset: 0x13C0E20 VA: 0x1813C2820
	private void AddTimedBlock(TimedBlock timedBlock) { }

	// RVA: 0x13C29B0 Offset: 0x13C0FB0 VA: 0x1813C29B0
	private static TimedBlock GetNextBlock() { }

	// RVA: 0x13C2D20 Offset: 0x13C1320 VA: 0x1813C2D20
	private static TimedBlock GetScheduledBlock() { }

	// RVA: 0x13C3CC0 Offset: 0x13C22C0 VA: 0x1813C3CC0
	public static void StartThread() { }

	// RVA: 0x13C3EA0 Offset: 0x13C24A0 VA: 0x1813C3EA0
	public static void StopThread() { }

	// RVA: 0x13C3F00 Offset: 0x13C2500 VA: 0x1813C3F00
	public static void WaitForThreadFinish() { }

	// RVA: 0x13C3070 Offset: 0x13C1670 VA: 0x1813C3070
	public static bool IsThreadFinished() { }

	// RVA: 0x13C4080 Offset: 0x13C2680 VA: 0x1813C4080
	private static void .cctor() { }

}

