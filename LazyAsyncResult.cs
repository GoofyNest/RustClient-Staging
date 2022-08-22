internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 2919
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x13452B0 Offset: 0x13438B0 VA: 0x1813452B0
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1345110 Offset: 0x1343710 VA: 0x181345110
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal object get_AsyncObject() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x13451E0 Offset: 0x13437E0 VA: 0x1813451E0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1344B00 Offset: 0x1343100 VA: 0x181344B00
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x1345280 Offset: 0x1343880 VA: 0x181345280 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1345340 Offset: 0x1343940 VA: 0x181345340 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1345330 Offset: 0x1343930 VA: 0x181345330
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x1344C70 Offset: 0x1343270 VA: 0x181344C70
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x1344AB0 Offset: 0x13430B0 VA: 0x181344AB0
	internal void InvokeCallback(object result) { }

	// RVA: 0x13448D0 Offset: 0x1342ED0 VA: 0x1813448D0 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x1345050 Offset: 0x1343650 VA: 0x181345050
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x1344AA0 Offset: 0x13430A0 VA: 0x181344AA0
	internal object InternalWaitForCompletion() { }

	// RVA: 0x1344DF0 Offset: 0x13433F0 VA: 0x181344DF0
	private object WaitForCompletion(bool snap) { }

}

private class LazyAsyncResult.ThreadContext // TypeDefIndex: 2920
{	// Fields
	internal int m_NestedIOCount; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

