internal abstract class IOAsyncResult : IAsyncResult // TypeDefIndex: 2594
{	// Fields
	private AsyncCallback async_callback; // 0x10
	private object async_state; // 0x18
	private ManualResetEvent wait_handle; // 0x20
	private bool completed_synchronously; // 0x28
	private bool completed; // 0x29

	// Properties
	public AsyncCallback AsyncCallback { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; set; }
	public bool IsCompleted { get; set; }

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x15336C0 Offset: 0x1531CC0 VA: 0x1815336C0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x9974F0 Offset: 0x995AF0 VA: 0x1809974F0
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x73ABF0 Offset: 0x7391F0 VA: 0x18073ABF0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x15337D0 Offset: 0x1531DD0 VA: 0x1815337D0
	protected void set_IsCompleted(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void CompleteDisposed();

}
