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

	// RVA: 0x161AC20 Offset: 0x1619220 VA: 0x18161AC20
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x161ACF0 Offset: 0x16192F0 VA: 0x18161ACF0
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x161AAB0 Offset: 0x16190B0 VA: 0x18161AAB0
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x161A970 Offset: 0x1618F70 VA: 0x18161A970
	public bool Change(int dueTime, int period) { }

	// RVA: 0x161A990 Offset: 0x1618F90 VA: 0x18161A990
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x161AA10 Offset: 0x1619010 VA: 0x18161AA10 Slot: 6
	public void Dispose() { }

	// RVA: 0x161A730 Offset: 0x1618D30 VA: 0x18161A730
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x161AAA0 Offset: 0x16190A0 VA: 0x18161AAA0
	private static long GetTimeMonotonic() { }

	// RVA: 0x161AB70 Offset: 0x1619170 VA: 0x18161AB70
	private static void .cctor() { }

}

private sealed class Timer.TimerComparer : IComparer // TypeDefIndex: 833
{	// Methods

	// RVA: 0x161A690 Offset: 0x1618C90 VA: 0x18161A690 Slot: 4
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

	// RVA: 0x1607160 Offset: 0x1605760 VA: 0x181607160
	private static void .cctor() { }

	// RVA: 0x1607390 Offset: 0x1605990 VA: 0x181607390
	public static Timer.Scheduler get_Instance() { }

	// RVA: 0x16071C0 Offset: 0x16057C0 VA: 0x1816071C0
	private void .ctor() { }

	// RVA: 0x16069B0 Offset: 0x1604FB0 VA: 0x1816069B0
	public void Remove(Timer timer) { }

	// RVA: 0x1606630 Offset: 0x1604C30 VA: 0x181606630
	public void Change(Timer timer, long new_next_run) { }

	// RVA: 0x16067F0 Offset: 0x1604DF0 VA: 0x1816067F0
	private int FindByDueTime(long nr) { }

	// RVA: 0x16064E0 Offset: 0x1604AE0 VA: 0x1816064E0
	private void Add(Timer timer) { }

	// RVA: 0x1606950 Offset: 0x1604F50 VA: 0x181606950
	private int InternalRemove(Timer timer) { }

	// RVA: 0x16070F0 Offset: 0x16056F0 VA: 0x1816070F0
	private static void TimerCB(object o) { }

	// RVA: 0x1606A90 Offset: 0x1605090 VA: 0x181606A90
	private void SchedulerThread() { }

	// RVA: 0x1607070 Offset: 0x1605670 VA: 0x181607070
	private void ShrinkIfNeeded(List<Timer> list, int initial) { }

}

