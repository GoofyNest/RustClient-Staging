private sealed class Task.<>c<TResult> // TypeDefIndex: 843
{	public static readonly Task.<>c<TResult> <>9; // 0x0


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD663D0 Offset: 0xD649D0 VA: 0x180D663D0
	|-Task.<>c<PublishResult>..cctor
	|-Task.<>c<bool>..cctor
	|-Task.<>c<int>..cctor
	|-Task.<>c<UdpReceiveResult>..cctor
	|-Task.<>c<Nullable<ServerInfo>>..cctor
	|-Task.<>c<Nullable<Image>>..cctor
	|-Task.<>c<Nullable<InventoryPurchaseResult>>..cctor
	|-Task.<>c<Nullable<InventoryResult>>..cctor
	|-Task.<>c<Nullable<Item>>..cctor
	|-Task.<>c<Nullable<ResultPage>>..cctor
	|-Task.<>c<Nullable<int>>..cctor
	|-Task.<>c<Nullable<Int32Enum>>..cctor
	|-Task.<>c<object>..cctor
	|-Task.<>c<VoidTaskResult>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-Task.<>c<PublishResult>..ctor
	|-Task.<>c<bool>..ctor
	|-Task.<>c<int>..ctor
	|-Task.<>c<UdpReceiveResult>..ctor
	|-Task.<>c<Nullable<ServerInfo>>..ctor
	|-Task.<>c<Nullable<Image>>..ctor
	|-Task.<>c<Nullable<InventoryPurchaseResult>>..ctor
	|-Task.<>c<Nullable<InventoryResult>>..ctor
	|-Task.<>c<Nullable<Item>>..ctor
	|-Task.<>c<Nullable<ResultPage>>..ctor
	|-Task.<>c<Nullable<int>>..ctor
	|-Task.<>c<Nullable<Int32Enum>>..ctor
	|-Task.<>c<object>..ctor
	|-Task.<>c<VoidTaskResult>..ctor
	*/

	internal Task<TResult> <.cctor>b__64_0(Task<Task> completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A98DF0 Offset: 0x1A973F0 VA: 0x181A98DF0
	|-Task.<>c<PublishResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98B30 Offset: 0x1A97130 VA: 0x181A98B30
	|-Task.<>c<bool>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98F50 Offset: 0x1A97550 VA: 0x181A98F50
	|-Task.<>c<int>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98870 Offset: 0x1A96E70 VA: 0x181A98870
	|-Task.<>c<UdpReceiveResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98BE0 Offset: 0x1A971E0 VA: 0x181A98BE0
	|-Task.<>c<Nullable<ServerInfo>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A990B0 Offset: 0x1A976B0 VA: 0x181A990B0
	|-Task.<>c<Nullable<Image>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98A80 Offset: 0x1A97080 VA: 0x181A98A80
	|-Task.<>c<Nullable<InventoryPurchaseResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A99160 Offset: 0x1A97760 VA: 0x181A99160
	|-Task.<>c<Nullable<InventoryResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A989D0 Offset: 0x1A96FD0 VA: 0x181A989D0
	|-Task.<>c<Nullable<Item>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98920 Offset: 0x1A96F20 VA: 0x181A98920
	|-Task.<>c<Nullable<ResultPage>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98D40 Offset: 0x1A97340 VA: 0x181A98D40
	|-Task.<>c<Nullable<int>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A99000 Offset: 0x1A97600 VA: 0x181A99000
	|-Task.<>c<Nullable<Int32Enum>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98C90 Offset: 0x1A97290 VA: 0x181A98C90
	|-Task.<>c<object>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98EA0 Offset: 0x1A974A0 VA: 0x181A98EA0
	|-Task.<>c<VoidTaskResult>.<.cctor>b__64_0
	*/

}

public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 853
{	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private const int OptionsMask = 65535;
	internal const int TASK_STATE_STARTED = 65536;
	internal const int TASK_STATE_DELEGATE_INVOKED = 131072;
	internal const int TASK_STATE_DISPOSED = 262144;
	internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;
	internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;
	internal const int TASK_STATE_FAULTED = 2097152;
	internal const int TASK_STATE_CANCELED = 4194304;
	internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;
	internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;
	internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;
	internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;
	internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;
	internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;
	internal const int TASK_STATE_EXECUTIONCONTEXT_IS_NULL = 536870912;
	internal const int TASK_STATE_TASKSCHEDULED_WAS_FIRED = 1073741824;
	private const int TASK_STATE_COMPLETED_MASK = 23068672;
	private const int CANCELLATION_REQUESTED = 1;
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }


	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void RemoveFromActiveTasks(int taskId) { }

	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	internal void .ctor() { }

	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	private static void TaskCancelCallback(object o) { }

	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	internal TaskCreationOptions get_Options() { }

	internal static TaskCreationOptions OptionsMethod(int flags) { }

	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	internal void SetNotificationForWaitCompletion(bool enabled) { }

	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks) { }

	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	internal bool get_IsWaitNotificationEnabled() { }

	private void NotifyDebuggerOfWaitCompletion() { }

	internal bool MarkStarted() { }

	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	internal void AddNewChild() { }

	internal void DisregardChild() { }

	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	internal static int NewId() { }

	public int get_Id() { }

	internal static Task get_InternalCurrent() { }

	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	internal static StackGuard get_CurrentStackGuard() { }

	public AggregateException get_Exception() { }

	public TaskStatus get_Status() { }

	public bool get_IsCanceled() { }

	internal bool get_IsCancellationRequested() { }

	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	internal CancellationToken get_CancellationToken() { }

	internal bool get_IsCancellationAcknowledged() { }

	public bool get_IsCompleted() { }

	private static bool IsCompletedMethod(int flags) { }

	internal bool get_IsRanToCompletion() { }

	public TaskCreationOptions get_CreationOptions() { }

	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	public object get_AsyncState() { }

	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	internal TaskScheduler get_ExecutingTaskScheduler() { }

	public static TaskFactory get_Factory() { }

	public static Task get_CompletedTask() { }

	internal ManualResetEventSlim get_CompletedEvent() { }

	internal bool get_IsSelfReplicatingRoot() { }

	internal bool get_IsChildReplica() { }

	internal bool get_ExceptionRecorded() { }

	public bool get_IsFaulted() { }

	internal ExecutionContext get_CapturedContext() { }

	internal void set_CapturedContext(ExecutionContext value) { }

	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	internal void ScheduleAndStart(bool needsProtection) { }

	internal void AddException(object exceptionObject) { }

	internal void AddException(object exceptionObject, bool representsCancellation) { }

	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	internal void UpdateExceptionObservedStatus() { }

	internal bool get_IsExceptionObservedByParent() { }

	internal bool get_IsDelegateInvoked() { }

	internal void Finish(bool bUserDelegateExecuted) { }

	internal void FinishStageTwo() { }

	internal void FinishStageThree() { }

	internal void ProcessChildCompletion(Task childTask) { }

	internal void AddExceptionsFromChildren() { }

	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	private void Execute() { }

	internal virtual bool ShouldReplicate() { }

	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	internal virtual object get_SavedStateForNextReplica() { }

	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	internal virtual Task get_HandedOverChildReplica() { }

	internal virtual void set_HandedOverChildReplica(Task value) { }

	private static void ExecuteSelfReplicating(Task root) { }

	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	private static void ExecutionContextCallback(object obj) { }

	internal virtual void InnerInvoke() { }

	internal void InnerInvokeWithArg(Task childTask) { }

	private void HandleException(Exception unhandledException) { }

	public TaskAwaiter GetAwaiter() { }

	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	public void Wait() { }

	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	private bool WrappedTryRunInline() { }

	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	private bool SpinWait(int millisecondsTimeout) { }

	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	internal void RecordInternalCancellationRequest() { }

	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	internal void CancellationCleanupLogic() { }

	private void SetCancellationAcknowledged() { }

	internal void FinishContinuations() { }

	private void LogFinishCompletionNotification() { }

	public Task ContinueWith(Action<Task> continuationAction) { }

	public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions) { }

	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	internal void AddCompletionAction(ITaskCompletionAction action) { }

	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	internal void RemoveContinuation(object continuationObject) { }

	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B9B0 Offset: 0x1579FB0 VA: 0x18157B9B0
	|-Task.FromResult<bool>
	|
	|-RVA: 0x157BA70 Offset: 0x157A070 VA: 0x18157BA70
	|-Task.FromResult<Stream>
	|-Task.FromResult<Tuple<int, int, int, bool>>
	|-Task.FromResult<object>
	|
	|-RVA: 0x157BA10 Offset: 0x157A010 VA: 0x18157BA10
	|-Task.FromResult<int>
	*/

	public static Task FromException(Exception exception) { }

	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B740 Offset: 0x1579D40 VA: 0x18157B740
	|-Task.FromException<int>
	|
	|-RVA: 0x157B810 Offset: 0x1579E10 VA: 0x18157B810
	|-Task.FromException<object>
	|
	|-RVA: 0x157B8E0 Offset: 0x1579EE0 VA: 0x18157B8E0
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA130 Offset: 0xED8730 VA: 0x180EDA130
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0xEDA2E0 Offset: 0xED88E0 VA: 0x180EDA2E0
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x157B590 Offset: 0x1579B90 VA: 0x18157B590
	|-Task.FromCancellation<object>
	*/

	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA200 Offset: 0xED8800 VA: 0x180EDA200
	|-Task.FromCancellation<int>
	|
	|-RVA: 0xEDA3B0 Offset: 0xED89B0 VA: 0x180EDA3B0
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x157B660 Offset: 0x1579C60 VA: 0x18157B660
	|-Task.FromCancellation<VoidTaskResult>
	*/

	public static Task Run(Action action) { }

	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C130 Offset: 0x157A730 VA: 0x18157C130
	|-Task.Run<Stream>
	|-Task.Run<object>
	|
	|-RVA: 0x157BBD0 Offset: 0x157A1D0 VA: 0x18157BBD0
	|-Task.Run<int>
	*/

	public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BFD0 Offset: 0x157A5D0 VA: 0x18157BFD0
	|-Task.Run<MP3Stream>
	|-Task.Run<object>
	*/

	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BF60 Offset: 0x157A560 VA: 0x18157BF60
	|-Task.Run<Stream>
	|-Task.Run<WebResponse>
	|-Task.Run<object>
	*/

	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BD40 Offset: 0x157A340 VA: 0x18157BD40
	|-Task.Run<object>
	*/

	public static Task Delay(TimeSpan delay) { }

	public static Task Delay(TimeSpan delay, CancellationToken cancellationToken) { }

	public static Task Delay(int millisecondsDelay) { }

	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C2A0 Offset: 0x157A8A0 VA: 0x18157C2A0
	|-Task.WhenAll<IPlayerInventory>
	|-Task.WhenAll<object>
	*/

	public static Task<TResult[]> WhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C7D0 Offset: 0x157ADD0 VA: 0x18157C7D0
	|-Task.WhenAll<object>
	*/

	private static Task<TResult[]> InternalWhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BAD0 Offset: 0x157A0D0 VA: 0x18157BAD0
	|-Task.InternalWhenAll<object>
	*/

	public static Task<Task> WhenAny(Task[] tasks) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA0C0 Offset: 0xED86C0 VA: 0x180EDA0C0
	|-Task.CreateUnwrapPromise<object>
	*/

	private static void .cctor() { }

}

internal class Task.ContingentProperties // TypeDefIndex: 854
{	internal ExecutionContext m_capturedContext; // 0x10
	internal ManualResetEventSlim m_completionEvent; // 0x18
	internal TaskExceptionHolder m_exceptionsHolder; // 0x20
	internal CancellationToken m_cancellationToken; // 0x28
	internal Shared<CancellationTokenRegistration> m_cancellationRegistration; // 0x30
	internal int m_internalCancellationRequested; // 0x38
	internal int m_completionCountdown; // 0x3C
	internal List<Task> m_exceptionalChildren; // 0x40


	internal void SetCompleted() { }

	internal void DeregisterCancellationCallback() { }

	public void .ctor() { }

}

private sealed class Task.SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction // TypeDefIndex: 855
{
	internal void .ctor() { }

	public void Invoke(Task completingTask) { }

}

private sealed class Task.DelayPromise : Task<VoidTaskResult> // TypeDefIndex: 856
{	internal readonly CancellationToken Token; // 0x58
	internal CancellationTokenRegistration Registration; // 0x60
	internal Timer Timer; // 0x78


	internal void .ctor(CancellationToken token) { }

	internal void Complete() { }

}

private sealed class Task.WhenAllPromise<T> : Task<T[]>, ITaskCompletionAction // TypeDefIndex: 857
{	private readonly Task<T>[] m_tasks; // 0x0
	private int m_count; // 0x0

	internal override bool ShouldNotifyDebuggerOfWaitCompletion { get; }


	internal void .ctor(Task<T>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369CD0 Offset: 0x13682D0 VA: 0x181369CD0
	|-Task.WhenAllPromise<object>..ctor
	*/

	public void Invoke(Task ignored) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369960 Offset: 0x1367F60 VA: 0x181369960
	|-Task.WhenAllPromise<object>.Invoke
	*/

	internal override bool get_ShouldNotifyDebuggerOfWaitCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369ED0 Offset: 0x13684D0 VA: 0x181369ED0
	|-Task.WhenAllPromise<object>.get_ShouldNotifyDebuggerOfWaitCompletion
	*/

}

private sealed class Task.<>c__DisplayClass178_0 // TypeDefIndex: 858
{	public Task root; // 0x10
	public bool replicasAreQuitting; // 0x18
	public Action<object> taskReplicaDelegate; // 0x20
	public TaskCreationOptions creationOptionsForReplicas; // 0x28
	public InternalTaskOptions internalOptionsForReplicas; // 0x2C


	public void .ctor() { }

	internal void <ExecuteSelfReplicating>b__0(object <p0>) { }

}

private sealed class Task.<>c // TypeDefIndex: 859
{	public static readonly Task.<>c <>9; // 0x0
	public static Action<object> <>9__276_0; // 0x8
	public static TimerCallback <>9__276_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Delay>b__276_0(object state) { }

	internal void <Delay>b__276_1(object state) { }

	internal Task.ContingentProperties <.cctor>b__295_0() { }

	internal bool <.cctor>b__295_1(Task t) { }

	internal bool <.cctor>b__295_2(object tc) { }

}

