internal static class TimerThread // TypeDefIndex: 2924
{	// Fields
	private static LinkedList<WeakReference> s_Queues; // 0x0
	private static LinkedList<WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static Hashtable s_QueuesCache; // 0x30

	// Methods

	// RVA: 0x100C6B0 Offset: 0x100ACB0 VA: 0x18100C6B0
	private static void .cctor() { }

	// RVA: 0x100C2A0 Offset: 0x100A8A0 VA: 0x18100C2A0
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x100C620 Offset: 0x100AC20 VA: 0x18100C620
	private static void StopTimerThread() { }

	// RVA: 0x100C540 Offset: 0x100AB40 VA: 0x18100C540
	private static void OnDomainUnload(object sender, EventArgs e) { }

}

internal abstract class TimerThread.Queue // TypeDefIndex: 2925
{	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Methods

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	internal void .ctor(int durationMilliseconds) { }

}

internal abstract class TimerThread.Timer : IDisposable // TypeDefIndex: 2926
{	// Fields
	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Methods

	// RVA: 0x100C960 Offset: 0x100AF60 VA: 0x18100C960
	internal void .ctor(int durationMilliseconds) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Cancel();

	// RVA: 0x95F940 Offset: 0x95DF40 VA: 0x18095F940 Slot: 4
	public void Dispose() { }

}

internal sealed class TimerThread.Callback : MulticastDelegate // TypeDefIndex: 2927
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF7280 Offset: 0xFF5880 VA: 0x180FF7280 Slot: 12
	public virtual void Invoke(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0xFF71F0 Offset: 0xFF57F0 VA: 0x180FF71F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(TimerThread.Timer timer, int timeNoticed, object context, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private class TimerThread.TimerQueue : TimerThread.Queue // TypeDefIndex: 2928
{	// Fields
	private readonly TimerThread.TimerNode m_Timers; // 0x18

	// Methods

	// RVA: 0x100C1E0 Offset: 0x100A7E0 VA: 0x18100C1E0
	internal void .ctor(int durationMilliseconds) { }

}

private class TimerThread.InfiniteTimerQueue : TimerThread.Queue // TypeDefIndex: 2929
{	// Methods

	// RVA: 0xFF95A0 Offset: 0xFF7BA0 VA: 0x180FF95A0
	internal void .ctor() { }

}

private class TimerThread.TimerNode : TimerThread.Timer // TypeDefIndex: 2930
{	// Fields
	private TimerThread.TimerNode.TimerState m_TimerState; // 0x18
	private TimerThread.Callback m_Callback; // 0x20
	private object m_Context; // 0x28
	private object m_QueueLock; // 0x30
	private TimerThread.TimerNode next; // 0x38
	private TimerThread.TimerNode prev; // 0x40

	// Properties
	internal TimerThread.TimerNode Next { get; set; }
	internal TimerThread.TimerNode Prev { get; set; }

	// Methods

	// RVA: 0x100C1B0 Offset: 0x100A7B0 VA: 0x18100C1B0
	internal void .ctor() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal TimerThread.TimerNode get_Next() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	internal void set_Next(TimerThread.TimerNode value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal TimerThread.TimerNode get_Prev() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_Prev(TimerThread.TimerNode value) { }

	// RVA: 0x100C030 Offset: 0x100A630 VA: 0x18100C030 Slot: 5
	internal override bool Cancel() { }

}

private enum TimerThread.TimerNode.TimerState // TypeDefIndex: 2931
{	// Fields
	public int value__; // 0x0
	public const TimerThread.TimerNode.TimerState Ready = 0;
	public const TimerThread.TimerNode.TimerState Fired = 1;
	public const TimerThread.TimerNode.TimerState Cancelled = 2;
	public const TimerThread.TimerNode.TimerState Sentinel = 3;

}

