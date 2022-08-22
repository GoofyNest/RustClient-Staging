private sealed class TaskFactory.FromAsyncTrimPromise<TResult, TInstance> : Task<TResult> // TypeDefIndex: 846
{	internal static readonly AsyncCallback s_completeFromAsyncResult; // 0x0
	private TInstance m_thisRef; // 0x0
	private Func<TInstance, IAsyncResult, TResult> m_endMethod; // 0x0


	internal void .ctor(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A83BC0 Offset: 0x1A821C0 VA: 0x181A83BC0
	|-TaskFactory.FromAsyncTrimPromise<int, object>..ctor
	|-TaskFactory.FromAsyncTrimPromise<object, object>..ctor
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..ctor
	*/

	internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A83340 Offset: 0x1A81940 VA: 0x181A83340
	|-TaskFactory.FromAsyncTrimPromise<int, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x1A83120 Offset: 0x1A81720 VA: 0x181A83120
	|-TaskFactory.FromAsyncTrimPromise<object, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x1A82F00 Offset: 0x1A81500 VA: 0x181A82F00
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.CompleteFromAsyncResult
	*/

	internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A836C0 Offset: 0x1A81CC0 VA: 0x181A836C0
	|-TaskFactory.FromAsyncTrimPromise<int, object>.Complete
	|
	|-RVA: 0x1A83820 Offset: 0x1A81E20 VA: 0x181A83820
	|-TaskFactory.FromAsyncTrimPromise<object, object>.Complete
	|
	|-RVA: 0x1A83560 Offset: 0x1A81B60 VA: 0x181A83560
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.Complete
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A83980 Offset: 0x1A81F80 VA: 0x181A83980
	|-TaskFactory.FromAsyncTrimPromise<int, object>..cctor
	|
	|-RVA: 0x1A83A40 Offset: 0x1A82040 VA: 0x181A83A40
	|-TaskFactory.FromAsyncTrimPromise<object, object>..cctor
	|
	|-RVA: 0x1A83B00 Offset: 0x1A82100 VA: 0x181A83B00
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..cctor
	*/

}

private sealed class TaskFactory.<>c__DisplayClass35_0<TResult> // TypeDefIndex: 847
{	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-TaskFactory.<>c__DisplayClass35_0<PublishResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<bool>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<int>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<UdpReceiveResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<ServerInfo>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Image>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<InventoryResult>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Item>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<ResultPage>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Int32Enum>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<object>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>..ctor
	*/

	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13688C0 Offset: 0x1366EC0 VA: 0x1813688C0
	|-TaskFactory.<>c__DisplayClass35_0<PublishResult>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<bool>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<int>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<UdpReceiveResult>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<ServerInfo>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Image>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<InventoryPurchaseResult>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<InventoryResult>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Item>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<ResultPage>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<Int32Enum>>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<object>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>.<FromAsyncImpl>b__0
	*/

}

private sealed class TaskFactory.<>c__DisplayClass35_1<TResult> // TypeDefIndex: 848
{	public AtomicBoolean invoked; // 0x0
	public TaskFactory.<>c__DisplayClass35_0<TResult> CS$<>8__locals1; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-TaskFactory.<>c__DisplayClass35_1<PublishResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<bool>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<int>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<UdpReceiveResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<ServerInfo>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Image>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<InventoryResult>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Item>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<ResultPage>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<int>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Int32Enum>>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<object>..ctor
	|-TaskFactory.<>c__DisplayClass35_1<VoidTaskResult>..ctor
	*/

	internal void <FromAsyncImpl>b__1(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368900 Offset: 0x1366F00 VA: 0x181368900
	|-TaskFactory.<>c__DisplayClass35_1<PublishResult>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<bool>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<int>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<UdpReceiveResult>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<ServerInfo>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Image>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<InventoryPurchaseResult>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<InventoryResult>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Item>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<ResultPage>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<int>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<Nullable<Int32Enum>>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<object>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass35_1<VoidTaskResult>.<FromAsyncImpl>b__1
	*/

}

private sealed class TaskFactory.<>c__DisplayClass41_0<TResult, TArg1, TArg2> // TypeDefIndex: 849
{	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-TaskFactory.<>c__DisplayClass41_0<int, object, int>..ctor
	|-TaskFactory.<>c__DisplayClass41_0<object, object, object>..ctor
	*/

	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13688C0 Offset: 0x1366EC0 VA: 0x1813688C0
	|-TaskFactory.<>c__DisplayClass41_0<int, object, int>.<FromAsyncImpl>b__0
	|-TaskFactory.<>c__DisplayClass41_0<object, object, object>.<FromAsyncImpl>b__0
	*/

}

private sealed class TaskFactory.<>c__DisplayClass41_1<TResult, TArg1, TArg2> // TypeDefIndex: 850
{	public AtomicBoolean invoked; // 0x0
	public TaskFactory.<>c__DisplayClass41_0<TResult, TArg1, TArg2> CS$<>8__locals1; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-TaskFactory.<>c__DisplayClass41_1<int, object, int>..ctor
	|-TaskFactory.<>c__DisplayClass41_1<object, object, object>..ctor
	*/

	internal void <FromAsyncImpl>b__1(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368900 Offset: 0x1366F00 VA: 0x181368900
	|-TaskFactory.<>c__DisplayClass41_1<int, object, int>.<FromAsyncImpl>b__1
	|-TaskFactory.<>c__DisplayClass41_1<object, object, object>.<FromAsyncImpl>b__1
	*/

}

public class TaskFactory // TypeDefIndex: 884
{	private CancellationToken m_defaultCancellationToken; // 0x10
	private TaskScheduler m_defaultScheduler; // 0x18
	private TaskCreationOptions m_defaultCreationOptions; // 0x20
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x24


	public void .ctor() { }

	public void .ctor(CancellationToken cancellationToken) { }

	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state) { }

	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions) { }

	public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B410 Offset: 0x1579A10 VA: 0x18157B410
	|-TaskFactory.FromAsync<ISocket>
	|-TaskFactory.FromAsync<object>
	*/

	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }

}

internal sealed class TaskFactory.CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction // TypeDefIndex: 885
{	private IList<Task> _tasks; // 0x58
	private int m_firstTaskAlreadyCompleted; // 0x60


	public void .ctor(IList<Task> tasks) { }

	public void Invoke(Task completingTask) { }

}

