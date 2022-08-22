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

	// RVA: 0x13461B0 Offset: 0x13447B0 VA: 0x1813461B0
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1346010 Offset: 0x1344610 VA: 0x181346010
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal object get_AsyncObject() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x13460E0 Offset: 0x13446E0 VA: 0x1813460E0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1345A00 Offset: 0x1344000 VA: 0x181345A00
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x1346180 Offset: 0x1344780 VA: 0x181346180 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1346240 Offset: 0x1344840 VA: 0x181346240 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1346230 Offset: 0x1344830 VA: 0x181346230
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x1345B70 Offset: 0x1344170 VA: 0x181345B70
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x13459B0 Offset: 0x1343FB0 VA: 0x1813459B0
	internal void InvokeCallback(object result) { }

	// RVA: 0x13457D0 Offset: 0x1343DD0 VA: 0x1813457D0 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x1345F50 Offset: 0x1344550 VA: 0x181345F50
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x13459A0 Offset: 0x1343FA0 VA: 0x1813459A0
	internal object InternalWaitForCompletion() { }

	// RVA: 0x1345CF0 Offset: 0x13442F0 VA: 0x181345CF0
	private object WaitForCompletion(bool snap) { }

}

private class LazyAsyncResult.ThreadContext // TypeDefIndex: 2920
{	// Fields
	internal int m_NestedIOCount; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

