internal static class TaskToApm // TypeDefIndex: 890
{	// Methods

	// RVA: 0x1609ED0 Offset: 0x16084D0 VA: 0x181609ED0
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x160A090 Offset: 0x1608690 VA: 0x18160A090
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAE50 Offset: 0x15B9450 VA: 0x1815BAE50
	|-TaskToApm.End<int>
	|
	|-RVA: 0x15BAF10 Offset: 0x15B9510 VA: 0x1815BAF10
	|-TaskToApm.End<object>
	*/

	// RVA: 0x160A150 Offset: 0x1608750 VA: 0x18160A150
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

	// RVA: 0xFFBD50 Offset: 0xFFA350 VA: 0x180FFBD50
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0 Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x4B3C10 Offset: 0x4B2210 VA: 0x1804B3C10 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x160A240 Offset: 0x1608840 VA: 0x18160A240 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

}

private sealed class TaskToApm.<>c__DisplayClass3_0 // TypeDefIndex: 892
{	// Fields
	public AsyncCallback callback; // 0x10
	public IAsyncResult asyncResult; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x161BD30 Offset: 0x161A330 VA: 0x18161BD30
	internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

}

