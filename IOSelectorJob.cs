internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 2595
{	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x12FADE0 Offset: 0x12F93E0 VA: 0x1812FADE0
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x1532CC0 Offset: 0x15312C0 VA: 0x181532CC0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1532C90 Offset: 0x1531290 VA: 0x181532C90
	public void MarkDisposed() { }

}

