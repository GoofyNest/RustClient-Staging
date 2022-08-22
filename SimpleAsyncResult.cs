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

	// RVA: 0x10001A0 Offset: 0xFFE7A0 VA: 0x1810001A0
	private void .ctor(SimpleAsyncCallback cb) { }

	// RVA: 0x1000080 Offset: 0xFFE680 VA: 0x181000080
	protected void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0xFFFCF0 Offset: 0xFFE2F0 VA: 0x180FFFCF0
	public static void Run(Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0xFFFBE0 Offset: 0xFFE1E0 VA: 0x180FFFBE0
	public static void RunWithLock(object locker, Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0xFFFB10 Offset: 0xFFE110 VA: 0x180FFFB10
	protected void Reset_internal() { }

	// RVA: 0xFFFF70 Offset: 0xFFE570 VA: 0x180FFFF70
	internal void SetCompleted(bool synch, Exception e) { }

	// RVA: 0xFFFF30 Offset: 0xFFE530 VA: 0x180FFFF30
	internal void SetCompleted(bool synch) { }

	// RVA: 0xFFFE50 Offset: 0xFFE450 VA: 0x180FFFE50
	private void SetCompleted_internal(bool synch, Exception e) { }

	// RVA: 0xFFFF20 Offset: 0xFFE520 VA: 0x180FFFF20
	protected void SetCompleted_internal(bool synch) { }

	// RVA: 0xFFFAE0 Offset: 0xFFE0E0 VA: 0x180FFFAE0
	private void DoCallback_private() { }

	// RVA: 0xFFFAB0 Offset: 0xFFE0B0 VA: 0x180FFFAB0
	protected void DoCallback_internal() { }

	// RVA: 0x1000030 Offset: 0xFFE630 VA: 0x181000030
	internal void WaitUntilComplete() { }

	// RVA: 0xFFFFB0 Offset: 0xFFE5B0 VA: 0x180FFFFB0
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1000220 Offset: 0xFFE820 VA: 0x181000220 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1000340 Offset: 0xFFE940 VA: 0x181000340 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	internal bool get_CompletedSynchronouslyPeek() { }

	// RVA: 0x10003B0 Offset: 0xFFE9B0 VA: 0x1810003B0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x74DD60 Offset: 0x74C360 VA: 0x18074DD60
	internal bool get_GotException() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal Exception get_Exception() { }

}

private sealed class SimpleAsyncResult.<>c__DisplayClass9_0 // TypeDefIndex: 3023
{	// Fields
	public AsyncCallback cb; // 0x10
	public SimpleAsyncResult <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100EC40 Offset: 0x100D240 VA: 0x18100EC40
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

	// RVA: 0x100E960 Offset: 0x100CF60 VA: 0x18100E960
	internal bool <RunWithLock>b__0(SimpleAsyncResult inner) { }

	// RVA: 0x100E9E0 Offset: 0x100CFE0 VA: 0x18100E9E0
	internal void <RunWithLock>b__1(SimpleAsyncResult inner) { }

}

