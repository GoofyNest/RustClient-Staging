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

	// RVA: 0x13C50D0 Offset: 0x13C36D0 VA: 0x1813C50D0
	private void .ctor() { }

	// RVA: 0x13C37A0 Offset: 0x13C1DA0 VA: 0x1813C37A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13C51D0 Offset: 0x13C37D0 VA: 0x1813C51D0
	private static GAThreading get_Instance() { }

	// RVA: 0x13C4540 Offset: 0x13C2B40 VA: 0x1813C4540
	private static void RunBlocks() { }

	// RVA: 0x13C45F0 Offset: 0x13C2BF0 VA: 0x1813C45F0
	public static void Run() { }

	// RVA: 0x13C44D0 Offset: 0x13C2AD0 VA: 0x1813C44D0
	public static void PerformTaskOnGAThread(string blockName, Action taskBlock) { }

	// RVA: 0x13C40B0 Offset: 0x13C26B0 VA: 0x1813C40B0
	public static void PerformTaskOnGAThread(string blockName, Action taskBlock, long delayInSeconds) { }

	// RVA: 0x13C4780 Offset: 0x13C2D80 VA: 0x1813C4780
	public static void ScheduleTimer(double interval, string blockName, Action callback) { }

	// RVA: 0x13C3720 Offset: 0x13C1D20 VA: 0x1813C3720
	private void AddTimedBlock(TimedBlock timedBlock) { }

	// RVA: 0x13C38B0 Offset: 0x13C1EB0 VA: 0x1813C38B0
	private static TimedBlock GetNextBlock() { }

	// RVA: 0x13C3C20 Offset: 0x13C2220 VA: 0x1813C3C20
	private static TimedBlock GetScheduledBlock() { }

	// RVA: 0x13C4BC0 Offset: 0x13C31C0 VA: 0x1813C4BC0
	public static void StartThread() { }

	// RVA: 0x13C4DA0 Offset: 0x13C33A0 VA: 0x1813C4DA0
	public static void StopThread() { }

	// RVA: 0x13C4E00 Offset: 0x13C3400 VA: 0x1813C4E00
	public static void WaitForThreadFinish() { }

	// RVA: 0x13C3F70 Offset: 0x13C2570 VA: 0x1813C3F70
	public static bool IsThreadFinished() { }

	// RVA: 0x13C4F80 Offset: 0x13C3580 VA: 0x1813C4F80
	private static void .cctor() { }

}

