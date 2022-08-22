internal static class TaskToApm // TypeDefIndex: 890
{	// Methods

	// RVA: 0x15F74B0 Offset: 0x15F5AB0 VA: 0x1815F74B0
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x15F7670 Offset: 0x15F5C70 VA: 0x1815F7670
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA1E0 Offset: 0x15B87E0 VA: 0x1815BA1E0
	|-TaskToApm.End<int>
	|
	|-RVA: 0x15BA2A0 Offset: 0x15B88A0 VA: 0x1815BA2A0
	|-TaskToApm.End<object>
	*/

	// RVA: 0x15F7730 Offset: 0x15F5D30 VA: 0x1815F7730
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

	// RVA: 0xFFCAB0 Offset: 0xFFB0B0 VA: 0x180FFCAB0
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80 Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x4B3BA0 Offset: 0x4B21A0 VA: 0x1804B3BA0 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x15F7820 Offset: 0x15F5E20 VA: 0x1815F7820 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

}

private sealed class TaskToApm.<>c__DisplayClass3_0 // TypeDefIndex: 892
{	// Fields
	public AsyncCallback callback; // 0x10
	public IAsyncResult asyncResult; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1609310 Offset: 0x1607910 VA: 0x181609310
	internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

}

