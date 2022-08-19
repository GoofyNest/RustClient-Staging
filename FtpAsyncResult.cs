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

	// RVA: 0x1330E70 Offset: 0x132F470 VA: 0x181330E70
	public void .ctor(AsyncCallback callback, object state) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1330F10 Offset: 0x132F510 VA: 0x181330F10 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0xEE6E90 Offset: 0xEE5490 VA: 0x180EE6E90 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1331020 Offset: 0x132F620 VA: 0x181331020 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x12355E0 Offset: 0x1233BE0 VA: 0x1812355E0
	internal bool get_GotException() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal Exception get_Exception() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal FtpWebResponse get_Response() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal Stream get_Stream() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_Stream(Stream value) { }

	// RVA: 0x1330DF0 Offset: 0x132F3F0 VA: 0x181330DF0
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x1330D00 Offset: 0x132F300 VA: 0x181330D00
	internal void SetCompleted(bool synch, Exception exc, FtpWebResponse response) { }

	// RVA: 0x1330CC0 Offset: 0x132F2C0 VA: 0x181330CC0
	internal void SetCompleted(bool synch, FtpWebResponse response) { }

	// RVA: 0x1330CE0 Offset: 0x132F2E0 VA: 0x181330CE0
	internal void SetCompleted(bool synch, Exception exc) { }

	// RVA: 0x1330C50 Offset: 0x132F250 VA: 0x181330C50
	internal void DoCallback() { }

}

