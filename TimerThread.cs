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

	// RVA: 0x100C3F0 Offset: 0x100A9F0 VA: 0x18100C3F0
	private static void .cctor() { }

	// RVA: 0x100BFE0 Offset: 0x100A5E0 VA: 0x18100BFE0
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x100C360 Offset: 0x100A960 VA: 0x18100C360
	private static void StopTimerThread() { }

	// RVA: 0x100C280 Offset: 0x100A880 VA: 0x18100C280
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

	// RVA: 0x100C6A0 Offset: 0x100ACA0 VA: 0x18100C6A0
	internal void .ctor(int durationMilliseconds) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Cancel();

	// RVA: 0x95F830 Offset: 0x95DE30 VA: 0x18095F830 Slot: 4
	public void Dispose() { }

}

internal sealed class TimerThread.Callback : MulticastDelegate // TypeDefIndex: 2927
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF6FC0 Offset: 0xFF55C0 VA: 0x180FF6FC0 Slot: 12
	public virtual void Invoke(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0xFF6F30 Offset: 0xFF5530 VA: 0x180FF6F30 Slot: 13
	public virtual IAsyncResult BeginInvoke(TimerThread.Timer timer, int timeNoticed, object context, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private class TimerThread.TimerQueue : TimerThread.Queue // TypeDefIndex: 2928
{	// Fields
	private readonly TimerThread.TimerNode m_Timers; // 0x18

	// Methods

	// RVA: 0x100BF20 Offset: 0x100A520 VA: 0x18100BF20
	internal void .ctor(int durationMilliseconds) { }

}

private class TimerThread.InfiniteTimerQueue : TimerThread.Queue // TypeDefIndex: 2929
{	// Methods

	// RVA: 0xFF92E0 Offset: 0xFF78E0 VA: 0x180FF92E0
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

	// RVA: 0x100BEF0 Offset: 0x100A4F0 VA: 0x18100BEF0
	internal void .ctor() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal TimerThread.TimerNode get_Next() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	internal void set_Next(TimerThread.TimerNode value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal TimerThread.TimerNode get_Prev() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_Prev(TimerThread.TimerNode value) { }

	// RVA: 0x100BD70 Offset: 0x100A370 VA: 0x18100BD70 Slot: 5
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

