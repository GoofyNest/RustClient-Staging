internal class FtpAsyncResult : IAsyncResult // TypeDefIndex: 2996
{	// Fields
	private FtpWebResponse response; // 0x10
	private ManualResetEvent waitHandle; // 0x18
	private Exception exception; // 0x20
	private AsyncCallback callback; // 0x28
	private Stream stream; // 0x30
	private object state; // 0x38
	private bool completed; // 0x40
	private bool synch; // 0x41
	private object locker; // 0x48

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool GotException { get; }
	internal Exception Exception { get; }
	internal FtpWebResponse Response { get; }
	internal Stream Stream { get; set; }

	// Methods

	// RVA: 0x1330230 Offset: 0x132E830 VA: 0x181330230
	public void .ctor(AsyncCallback callback, object state) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x13302D0 Offset: 0x132E8D0 VA: 0x1813302D0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0xEE7C00 Offset: 0xEE6200 VA: 0x180EE7C00 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x13303E0 Offset: 0x132E9E0 VA: 0x1813303E0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1235F40 Offset: 0x1234540 VA: 0x181235F40
	internal bool get_GotException() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal Exception get_Exception() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal FtpWebResponse get_Response() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal Stream get_Stream() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_Stream(Stream value) { }

	// RVA: 0x13301B0 Offset: 0x132E7B0 VA: 0x1813301B0
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x13300C0 Offset: 0x132E6C0 VA: 0x1813300C0
	internal void SetCompleted(bool synch, Exception exc, FtpWebResponse response) { }

	// RVA: 0x1330080 Offset: 0x132E680 VA: 0x181330080
	internal void SetCompleted(bool synch, FtpWebResponse response) { }

	// RVA: 0x13300A0 Offset: 0x132E6A0 VA: 0x1813300A0
	internal void SetCompleted(bool synch, Exception exc) { }

	// RVA: 0x1330010 Offset: 0x132E610 VA: 0x181330010
	internal void DoCallback() { }

}

