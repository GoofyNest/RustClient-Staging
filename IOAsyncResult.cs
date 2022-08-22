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

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1532A50 Offset: 0x1531050 VA: 0x181532A50 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x997AF0 Offset: 0x9960F0 VA: 0x180997AF0
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x73AC50 Offset: 0x739250 VA: 0x18073AC50 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1532B60 Offset: 0x1531160 VA: 0x181532B60
	protected void set_IsCompleted(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void CompleteDisposed();

}

