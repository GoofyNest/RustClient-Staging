internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 2919
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_UserEvent; // 0x34
	private object m_Event; // 0x38

	// Properties
	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }

	// Methods

	// RVA: 0x1345EF0 Offset: 0x13444F0 VA: 0x181345EF0
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1345D50 Offset: 0x1344350 VA: 0x181345D50
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal object get_AsyncObject() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1345E20 Offset: 0x1344420 VA: 0x181345E20 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1345740 Offset: 0x1343D40 VA: 0x181345740
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x1345EC0 Offset: 0x13444C0 VA: 0x181345EC0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1345F80 Offset: 0x1344580 VA: 0x181345F80 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1345F70 Offset: 0x1344570 VA: 0x181345F70
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x13458B0 Offset: 0x1343EB0 VA: 0x1813458B0
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x13456F0 Offset: 0x1343CF0 VA: 0x1813456F0
	internal void InvokeCallback(object result) { }

	// RVA: 0x1345510 Offset: 0x1343B10 VA: 0x181345510 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x1345C90 Offset: 0x1344290 VA: 0x181345C90
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x13456E0 Offset: 0x1343CE0 VA: 0x1813456E0
	internal object InternalWaitForCompletion() { }

	// RVA: 0x1345A30 Offset: 0x1344030 VA: 0x181345A30
	private object WaitForCompletion(bool snap) { }

}

private class LazyAsyncResult.ThreadContext // TypeDefIndex: 2920
{	// Fields
	internal int m_NestedIOCount; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

