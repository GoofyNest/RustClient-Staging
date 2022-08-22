internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 2595
{	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x12F4930 Offset: 0x12F2F30 VA: 0x1812F4930
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x1533BF0 Offset: 0x15321F0 VA: 0x181533BF0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1533BC0 Offset: 0x15321C0 VA: 0x181533BC0
	public void MarkDisposed() { }

}

