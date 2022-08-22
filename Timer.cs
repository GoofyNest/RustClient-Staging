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

	// RVA: 0x161AEE0 Offset: 0x16194E0 VA: 0x18161AEE0
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x161AFB0 Offset: 0x16195B0 VA: 0x18161AFB0
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x161AD70 Offset: 0x1619370 VA: 0x18161AD70
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x161AC30 Offset: 0x1619230 VA: 0x18161AC30
	public bool Change(int dueTime, int period) { }

	// RVA: 0x161AC50 Offset: 0x1619250 VA: 0x18161AC50
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x161ACD0 Offset: 0x16192D0 VA: 0x18161ACD0 Slot: 6
	public void Dispose() { }

	// RVA: 0x161A9F0 Offset: 0x1618FF0 VA: 0x18161A9F0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x161AD60 Offset: 0x1619360 VA: 0x18161AD60
	private static long GetTimeMonotonic() { }

	// RVA: 0x161AE30 Offset: 0x1619430 VA: 0x18161AE30
	private static void .cctor() { }

}

private sealed class Timer.TimerComparer : IComparer // TypeDefIndex: 833
{	// Methods

	// RVA: 0x161A950 Offset: 0x1618F50 VA: 0x18161A950 Slot: 4
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

	// RVA: 0x1607420 Offset: 0x1605A20 VA: 0x181607420
	private static void .cctor() { }

	// RVA: 0x1607650 Offset: 0x1605C50 VA: 0x181607650
	public static Timer.Scheduler get_Instance() { }

	// RVA: 0x1607480 Offset: 0x1605A80 VA: 0x181607480
	private void .ctor() { }

	// RVA: 0x1606C70 Offset: 0x1605270 VA: 0x181606C70
	public void Remove(Timer timer) { }

	// RVA: 0x16068F0 Offset: 0x1604EF0 VA: 0x1816068F0
	public void Change(Timer timer, long new_next_run) { }

	// RVA: 0x1606AB0 Offset: 0x16050B0 VA: 0x181606AB0
	private int FindByDueTime(long nr) { }

	// RVA: 0x16067A0 Offset: 0x1604DA0 VA: 0x1816067A0
	private void Add(Timer timer) { }

	// RVA: 0x1606C10 Offset: 0x1605210 VA: 0x181606C10
	private int InternalRemove(Timer timer) { }

	// RVA: 0x16073B0 Offset: 0x16059B0 VA: 0x1816073B0
	private static void TimerCB(object o) { }

	// RVA: 0x1606D50 Offset: 0x1605350 VA: 0x181606D50
	private void SchedulerThread() { }

	// RVA: 0x1607330 Offset: 0x1605930 VA: 0x181607330
	private void ShrinkIfNeeded(List<Timer> list, int initial) { }

}

