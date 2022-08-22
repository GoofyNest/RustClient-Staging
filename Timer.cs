public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40
	private const long MaxValue = 4294967294;

	// Methods

	// RVA: 0x1608200 Offset: 0x1606800 VA: 0x181608200
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x16082D0 Offset: 0x16068D0 VA: 0x1816082D0
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1608090 Offset: 0x1606690 VA: 0x181608090
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x1607F50 Offset: 0x1606550 VA: 0x181607F50
	public bool Change(int dueTime, int period) { }

	// RVA: 0x1607F70 Offset: 0x1606570 VA: 0x181607F70
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1607FF0 Offset: 0x16065F0 VA: 0x181607FF0 Slot: 6
	public void Dispose() { }

	// RVA: 0x1607D10 Offset: 0x1606310 VA: 0x181607D10
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x1608080 Offset: 0x1606680 VA: 0x181608080
	private static long GetTimeMonotonic() { }

	// RVA: 0x1608150 Offset: 0x1606750 VA: 0x181608150
	private static void .cctor() { }

}

private sealed class Timer.TimerComparer : IComparer // TypeDefIndex: 833
{	// Methods

	// RVA: 0x1607C70 Offset: 0x1606270 VA: 0x181607C70 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class Timer.Scheduler // TypeDefIndex: 834
{	// Fields
	private static Timer.Scheduler instance; // 0x0
	private SortedList list; // 0x10
	private ManualResetEvent changed; // 0x18

	// Properties
	public static Timer.Scheduler Instance { get; }

	// Methods

	// RVA: 0x15F4740 Offset: 0x15F2D40 VA: 0x1815F4740
	private static void .cctor() { }

	// RVA: 0x15F4970 Offset: 0x15F2F70 VA: 0x1815F4970
	public static Timer.Scheduler get_Instance() { }

	// RVA: 0x15F47A0 Offset: 0x15F2DA0 VA: 0x1815F47A0
	private void .ctor() { }

	// RVA: 0x15F3F90 Offset: 0x15F2590 VA: 0x1815F3F90
	public void Remove(Timer timer) { }

	// RVA: 0x15F3C10 Offset: 0x15F2210 VA: 0x1815F3C10
	public void Change(Timer timer, long new_next_run) { }

	// RVA: 0x15F3DD0 Offset: 0x15F23D0 VA: 0x1815F3DD0
	private int FindByDueTime(long nr) { }

	// RVA: 0x15F3AC0 Offset: 0x15F20C0 VA: 0x1815F3AC0
	private void Add(Timer timer) { }

	// RVA: 0x15F3F30 Offset: 0x15F2530 VA: 0x1815F3F30
	private int InternalRemove(Timer timer) { }

	// RVA: 0x15F46D0 Offset: 0x15F2CD0 VA: 0x1815F46D0
	private static void TimerCB(object o) { }

	// RVA: 0x15F4070 Offset: 0x15F2670 VA: 0x1815F4070
	private void SchedulerThread() { }

	// RVA: 0x15F4650 Offset: 0x15F2C50 VA: 0x1815F4650
	private void ShrinkIfNeeded(List<Timer> list, int initial) { }

}

