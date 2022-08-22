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

	// RVA: 0x1331130 Offset: 0x132F730 VA: 0x181331130
	public void .ctor(AsyncCallback callback, object state) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x13311D0 Offset: 0x132F7D0 VA: 0x1813311D0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0xEE7150 Offset: 0xEE5750 VA: 0x180EE7150 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x13312E0 Offset: 0x132F8E0 VA: 0x1813312E0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x12358A0 Offset: 0x1233EA0 VA: 0x1812358A0
	internal bool get_GotException() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal Exception get_Exception() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal FtpWebResponse get_Response() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal Stream get_Stream() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_Stream(Stream value) { }

	// RVA: 0x13310B0 Offset: 0x132F6B0 VA: 0x1813310B0
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x1330FC0 Offset: 0x132F5C0 VA: 0x181330FC0
	internal void SetCompleted(bool synch, Exception exc, FtpWebResponse response) { }

	// RVA: 0x1330F80 Offset: 0x132F580 VA: 0x181330F80
	internal void SetCompleted(bool synch, FtpWebResponse response) { }

	// RVA: 0x1330FA0 Offset: 0x132F5A0 VA: 0x181330FA0
	internal void SetCompleted(bool synch, Exception exc) { }

	// RVA: 0x1330F10 Offset: 0x132F510 VA: 0x181330F10
	internal void DoCallback() { }

}

