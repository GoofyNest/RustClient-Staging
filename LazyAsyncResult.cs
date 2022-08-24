internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 2919
{
	[ThreadStaticAttribute] 
	private static LazyAsyncResult.ThreadContext t_ThreadContext; 
	private object m_AsyncObject; 
	private object m_AsyncState; 
	private AsyncCallback m_AsyncCallback; 
	private object m_Result; 
	private int m_IntCompleted; 
	private bool m_UserEvent; 
	private object m_Event; 

	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }


	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	internal object get_AsyncObject() { }

	public object get_AsyncState() { }

	public WaitHandle get_AsyncWaitHandle() { }

	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	public bool get_CompletedSynchronously() { }

	public bool get_IsCompleted() { }

	internal bool get_InternalPeekCompleted() { }

	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	internal void InvokeCallback(object result) { }

	protected virtual void Complete(IntPtr userToken) { }

	private void WorkerThreadComplete(object state) { }

	protected virtual void Cleanup() { }

	internal object InternalWaitForCompletion() { }

	private object WaitForCompletion(bool snap) { }

}

private class LazyAsyncResult.ThreadContext // TypeDefIndex: 2920
{
	internal int m_NestedIOCount; 


	public void .ctor() { }

}

