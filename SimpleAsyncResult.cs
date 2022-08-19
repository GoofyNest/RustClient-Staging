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

	// RVA: 0xFFFEE0 Offset: 0xFFE4E0 VA: 0x180FFFEE0
	private void .ctor(SimpleAsyncCallback cb) { }

	// RVA: 0xFFFDC0 Offset: 0xFFE3C0 VA: 0x180FFFDC0
	protected void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0xFFFA30 Offset: 0xFFE030 VA: 0x180FFFA30
	public static void Run(Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0xFFF920 Offset: 0xFFDF20 VA: 0x180FFF920
	public static void RunWithLock(object locker, Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0xFFF850 Offset: 0xFFDE50 VA: 0x180FFF850
	protected void Reset_internal() { }

	// RVA: 0xFFFCB0 Offset: 0xFFE2B0 VA: 0x180FFFCB0
	internal void SetCompleted(bool synch, Exception e) { }

	// RVA: 0xFFFC70 Offset: 0xFFE270 VA: 0x180FFFC70
	internal void SetCompleted(bool synch) { }

	// RVA: 0xFFFB90 Offset: 0xFFE190 VA: 0x180FFFB90
	private void SetCompleted_internal(bool synch, Exception e) { }

	// RVA: 0xFFFC60 Offset: 0xFFE260 VA: 0x180FFFC60
	protected void SetCompleted_internal(bool synch) { }

	// RVA: 0xFFF820 Offset: 0xFFDE20 VA: 0x180FFF820
	private void DoCallback_private() { }

	// RVA: 0xFFF7F0 Offset: 0xFFDDF0 VA: 0x180FFF7F0
	protected void DoCallback_internal() { }

	// RVA: 0xFFFD70 Offset: 0xFFE370 VA: 0x180FFFD70
	internal void WaitUntilComplete() { }

	// RVA: 0xFFFCF0 Offset: 0xFFE2F0 VA: 0x180FFFCF0
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0xFFFF60 Offset: 0xFFE560 VA: 0x180FFFF60 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1000080 Offset: 0xFFE680 VA: 0x181000080 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	internal bool get_CompletedSynchronouslyPeek() { }

	// RVA: 0x10000F0 Offset: 0xFFE6F0 VA: 0x1810000F0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x74DC50 Offset: 0x74C250 VA: 0x18074DC50
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

	// RVA: 0x100E980 Offset: 0x100CF80 VA: 0x18100E980
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

	// RVA: 0x100E6A0 Offset: 0x100CCA0 VA: 0x18100E6A0
	internal bool <RunWithLock>b__0(SimpleAsyncResult inner) { }

	// RVA: 0x100E720 Offset: 0x100CD20 VA: 0x18100E720
	internal void <RunWithLock>b__1(SimpleAsyncResult inner) { }

}

