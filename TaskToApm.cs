internal static class TaskToApm // TypeDefIndex: 890
{
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	public static void End(IAsyncResult asyncResult) { }

	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA220 Offset: 0x15B8820 VA: 0x1815BA220
	|-TaskToApm.End<int>
	|
	|-RVA: 0x15BA2E0 Offset: 0x15B88E0 VA: 0x1815BA2E0
	|-TaskToApm.End<object>
	*/

	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }

}

private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 891
{	internal readonly Task Task; // 0x10
	private readonly object m_state; // 0x18
	private readonly bool m_completedSynchronously; // 0x20

	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }


	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	private object System.IAsyncResult.get_AsyncState() { }

	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	private bool System.IAsyncResult.get_IsCompleted() { }

	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

}

private sealed class TaskToApm.<>c__DisplayClass3_0 // TypeDefIndex: 892
{	public AsyncCallback callback; // 0x10
	public IAsyncResult asyncResult; // 0x18


	public void .ctor() { }

	internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

}

