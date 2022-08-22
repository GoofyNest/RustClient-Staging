internal class SimpleAsyncResult : IAsyncResult // TypeDefIndex: 3022
{	// Fields
	private ManualResetEvent handle; // 0x10
	private bool synch; // 0x18
	private bool isCompleted; // 0x19
	private readonly SimpleAsyncCallback cb; // 0x20
	private object state; // 0x28
	private bool callbackDone; // 0x30
	private Exception exc; // 0x38
	private object locker; // 0x40
	private Nullable<bool> user_read_synch; // 0x48

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	internal bool CompletedSynchronouslyPeek { get; }
	public bool IsCompleted { get; }
	internal bool GotException { get; }
	internal Exception Exception { get; }

	// Methods

	// RVA: 0x1000C40 Offset: 0xFFF240 VA: 0x181000C40
	private void .ctor(SimpleAsyncCallback cb) { }

	// RVA: 0x1000B20 Offset: 0xFFF120 VA: 0x181000B20
	protected void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x1000790 Offset: 0xFFED90 VA: 0x181000790
	public static void Run(Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0x1000680 Offset: 0xFFEC80 VA: 0x181000680
	public static void RunWithLock(object locker, Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0x10005B0 Offset: 0xFFEBB0 VA: 0x1810005B0
	protected void Reset_internal() { }

	// RVA: 0x1000A10 Offset: 0xFFF010 VA: 0x181000A10
	internal void SetCompleted(bool synch, Exception e) { }

	// RVA: 0x10009D0 Offset: 0xFFEFD0 VA: 0x1810009D0
	internal void SetCompleted(bool synch) { }

	// RVA: 0x10008F0 Offset: 0xFFEEF0 VA: 0x1810008F0
	private void SetCompleted_internal(bool synch, Exception e) { }

	// RVA: 0x10009C0 Offset: 0xFFEFC0 VA: 0x1810009C0
	protected void SetCompleted_internal(bool synch) { }

	// RVA: 0x1000580 Offset: 0xFFEB80 VA: 0x181000580
	private void DoCallback_private() { }

	// RVA: 0x1000550 Offset: 0xFFEB50 VA: 0x181000550
	protected void DoCallback_internal() { }

	// RVA: 0x1000AD0 Offset: 0xFFF0D0 VA: 0x181000AD0
	internal void WaitUntilComplete() { }

	// RVA: 0x1000A50 Offset: 0xFFF050 VA: 0x181000A50
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1000CC0 Offset: 0xFFF2C0 VA: 0x181000CC0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1000DE0 Offset: 0xFFF3E0 VA: 0x181000DE0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	internal bool get_CompletedSynchronouslyPeek() { }

	// RVA: 0x1000E50 Offset: 0xFFF450 VA: 0x181000E50 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x74DCB0 Offset: 0x74C2B0 VA: 0x18074DCB0
	internal bool get_GotException() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal Exception get_Exception() { }

}

private sealed class SimpleAsyncResult.<>c__DisplayClass9_0 // TypeDefIndex: 3023
{	// Fields
	public AsyncCallback cb; // 0x10
	public SimpleAsyncResult <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100F6E0 Offset: 0x100DCE0 VA: 0x18100F6E0
	internal void <.ctor>b__0(SimpleAsyncResult result) { }

}

private sealed class SimpleAsyncResult.<>c__DisplayClass11_0 // TypeDefIndex: 3024
{	// Fields
	public Func<SimpleAsyncResult, bool> func; // 0x10
	public object locker; // 0x18
	public SimpleAsyncCallback callback; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100F400 Offset: 0x100DA00 VA: 0x18100F400
	internal bool <RunWithLock>b__0(SimpleAsyncResult inner) { }

	// RVA: 0x100F480 Offset: 0x100DA80 VA: 0x18100F480
	internal void <RunWithLock>b__1(SimpleAsyncResult inner) { }

}

