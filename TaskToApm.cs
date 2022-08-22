internal static class TaskToApm // TypeDefIndex: 890
{	// Methods

	// RVA: 0x160A190 Offset: 0x1608790 VA: 0x18160A190
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x160A350 Offset: 0x1608950 VA: 0x18160A350
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB110 Offset: 0x15B9710 VA: 0x1815BB110
	|-TaskToApm.End<int>
	|
	|-RVA: 0x15BB1D0 Offset: 0x15B97D0 VA: 0x1815BB1D0
	|-TaskToApm.End<object>
	*/

	// RVA: 0x160A410 Offset: 0x1608A10 VA: 0x18160A410
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }

}

private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 891
{	// Fields
	internal readonly Task Task; // 0x10
	private readonly object m_state; // 0x18
	private readonly bool m_completedSynchronously; // 0x20

	// Properties
	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }

	// Methods

	// RVA: 0xFFC010 Offset: 0xFFA610 VA: 0x180FFC010
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0 Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x4B3C10 Offset: 0x4B2210 VA: 0x1804B3C10 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x160A500 Offset: 0x1608B00 VA: 0x18160A500 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

}

private sealed class TaskToApm.<>c__DisplayClass3_0 // TypeDefIndex: 892
{	// Fields
	public AsyncCallback callback; // 0x10
	public IAsyncResult asyncResult; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x161BFF0 Offset: 0x161A5F0 VA: 0x18161BFF0
	internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

}

