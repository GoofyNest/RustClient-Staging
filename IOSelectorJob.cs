internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 2595
{	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x12F4670 Offset: 0x12F2C70 VA: 0x1812F4670
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x1533930 Offset: 0x1531F30 VA: 0x181533930 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1533900 Offset: 0x1531F00 VA: 0x181533900
	public void MarkDisposed() { }

}

