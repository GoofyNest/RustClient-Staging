private sealed class Task.<>c<TResult> // TypeDefIndex: 843
{	// Fields
	public static readonly Task.<>c<TResult> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD65280 Offset: 0xD63880 VA: 0x180D65280
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

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
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

	// RVA: -1 Offset: -1
	internal Task<TResult> <.cctor>b__64_0(Task<Task> completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9DB50 Offset: 0x1A9C150 VA: 0x181A9DB50
	|-Task.<>c<PublishResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9D890 Offset: 0x1A9BE90 VA: 0x181A9D890
	|-Task.<>c<bool>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9DCB0 Offset: 0x1A9C2B0 VA: 0x181A9DCB0
	|-Task.<>c<int>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9D5D0 Offset: 0x1A9BBD0 VA: 0x181A9D5D0
	|-Task.<>c<UdpReceiveResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9D940 Offset: 0x1A9BF40 VA: 0x181A9D940
	|-Task.<>c<Nullable<ServerInfo>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9DE10 Offset: 0x1A9C410 VA: 0x181A9DE10
	|-Task.<>c<Nullable<Image>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9D7E0 Offset: 0x1A9BDE0 VA: 0x181A9D7E0
	|-Task.<>c<Nullable<InventoryPurchaseResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9DEC0 Offset: 0x1A9C4C0 VA: 0x181A9DEC0
	|-Task.<>c<Nullable<InventoryResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9D730 Offset: 0x1A9BD30 VA: 0x181A9D730
	|-Task.<>c<Nullable<Item>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9D680 Offset: 0x1A9BC80 VA: 0x181A9D680
	|-Task.<>c<Nullable<ResultPage>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9DAA0 Offset: 0x1A9C0A0 VA: 0x181A9DAA0
	|-Task.<>c<Nullable<int>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9DD60 Offset: 0x1A9C360 VA: 0x181A9DD60
	|-Task.<>c<Nullable<Int32Enum>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9D9F0 Offset: 0x1A9BFF0 VA: 0x181A9D9F0
	|-Task.<>c<object>.<.cctor>b__64_0
	|
	|-RVA: 0x1A9DC00 Offset: 0x1A9C200 VA: 0x181A9DC00
	|-Task.<>c<VoidTaskResult>.<.cctor>b__64_0
	*/

}

public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 853
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// Properties
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

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x149CB40 Offset: 0x149B140 VA: 0x18149CB40
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14A15A0 Offset: 0x149FBA0 VA: 0x1814A15A0
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x14A3430 Offset: 0x14A1A30 VA: 0x1814A3430
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x14A3500 Offset: 0x14A1B00 VA: 0x1814A3500
	internal void .ctor() { }

	// RVA: 0x14A3300 Offset: 0x14A1900 VA: 0x1814A3300
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x14A31F0 Offset: 0x14A17F0 VA: 0x1814A31F0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x14A2640 Offset: 0x14A0C40 VA: 0x1814A2640
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x149CDB0 Offset: 0x149B3B0 VA: 0x18149CDB0
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x14A2550 Offset: 0x14A0B50 VA: 0x1814A2550
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x14A0E50 Offset: 0x149F450 VA: 0x1814A0E50
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x14A3FB0 Offset: 0x14A25B0 VA: 0x1814A3FB0
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x149D140 Offset: 0x149B740 VA: 0x18149D140
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x149D270 Offset: 0x149B870 VA: 0x18149D270
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x14A1DB0 Offset: 0x14A03B0 VA: 0x1814A1DB0
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x14A0DC0 Offset: 0x149F3C0 VA: 0x1814A0DC0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x149CD10 Offset: 0x149B310 VA: 0x18149CD10
	internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks) { }

	// RVA: 0x14A3F60 Offset: 0x14A2560 VA: 0x1814A3F60
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x14A3F90 Offset: 0x14A2590 VA: 0x1814A3F90 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x14A3F90 Offset: 0x14A2590 VA: 0x1814A3F90
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x14A0E20 Offset: 0x149F420 VA: 0x1814A0E20
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x14A0D40 Offset: 0x149F340 VA: 0x1814A0D40
	internal bool MarkStarted() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x149C620 Offset: 0x149AC20 VA: 0x18149C620
	internal void AddNewChild() { }

	// RVA: 0x149EAE0 Offset: 0x149D0E0 VA: 0x18149EAE0
	internal void DisregardChild() { }

	// RVA: 0x14A0AA0 Offset: 0x149F0A0 VA: 0x1814A0AA0
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x14A0D60 Offset: 0x149F360 VA: 0x1814A0D60
	internal static int NewId() { }

	// RVA: 0x14A3B50 Offset: 0x14A2150 VA: 0x1814A3B50
	public int get_Id() { }

	// RVA: 0x14A3C30 Offset: 0x14A2230 VA: 0x1814A3C30
	internal static Task get_InternalCurrent() { }

	// RVA: 0x14A09F0 Offset: 0x149EFF0 VA: 0x1814A09F0
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x14A3980 Offset: 0x14A1F80 VA: 0x1814A3980
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x14A3AA0 Offset: 0x14A20A0 VA: 0x1814A3AA0
	public AggregateException get_Exception() { }

	// RVA: 0x14A4010 Offset: 0x14A2610 VA: 0x1814A4010
	public TaskStatus get_Status() { }

	// RVA: 0x14A3CF0 Offset: 0x14A22F0 VA: 0x1814A3CF0
	public bool get_IsCanceled() { }

	// RVA: 0x14A3D40 Offset: 0x14A2340 VA: 0x1814A3D40
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x149EC50 Offset: 0x149D250 VA: 0x18149EC50
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x149EB90 Offset: 0x149D190 VA: 0x18149EB90
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x14A3530 Offset: 0x14A1B30 VA: 0x1814A3530
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x14A3D20 Offset: 0x14A2320 VA: 0x1814A3D20
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x14A3E10 Offset: 0x14A2410 VA: 0x1814A3E10 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x14A0D30 Offset: 0x149F330 VA: 0x1814A0D30
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x14A3ED0 Offset: 0x14A24D0 VA: 0x1814A3ED0
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x14A3920 Offset: 0x14A1F20 VA: 0x1814A3920
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x14A2390 Offset: 0x14A0990 VA: 0x1814A2390 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x14A3AF0 Offset: 0x14A20F0 VA: 0x1814A3AF0
	public static TaskFactory get_Factory() { }

	// RVA: 0x14A3830 Offset: 0x14A1E30 VA: 0x1814A3830
	public static Task get_CompletedTask() { }

	// RVA: 0x14A3650 Offset: 0x14A1C50 VA: 0x1814A3650
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x14A3F00 Offset: 0x14A2500 VA: 0x1814A3F00
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x14A3DB0 Offset: 0x14A23B0 VA: 0x1814A3DB0
	internal bool get_IsChildReplica() { }

	// RVA: 0x14A3A40 Offset: 0x14A2040 VA: 0x1814A3A40
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x14A3EB0 Offset: 0x14A24B0 VA: 0x1814A3EB0
	public bool get_IsFaulted() { }

	// RVA: 0x14A3560 Offset: 0x14A1B60 VA: 0x1814A3560
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x14A40A0 Offset: 0x14A26A0 VA: 0x1814A40A0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x149DF10 Offset: 0x149C510 VA: 0x18149DF10
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x149E8E0 Offset: 0x149CEE0 VA: 0x18149E8E0 Slot: 10
	public void Dispose() { }

	// RVA: 0x149E950 Offset: 0x149CF50 VA: 0x18149E950 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14A1950 Offset: 0x149FF50 VA: 0x1814A1950
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x149C190 Offset: 0x149A790 VA: 0x18149C190
	internal void AddException(object exceptionObject) { }

	// RVA: 0x149C1A0 Offset: 0x149A7A0 VA: 0x18149C1A0
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x14A0420 Offset: 0x149EA20 VA: 0x1814A0420
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x14A0320 Offset: 0x149E920 VA: 0x1814A0320
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x14A02E0 Offset: 0x149E8E0 VA: 0x1814A02E0
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x14A28F0 Offset: 0x14A0EF0 VA: 0x1814A28F0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x14A2960 Offset: 0x14A0F60 VA: 0x1814A2960
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x14A3E90 Offset: 0x14A2490 VA: 0x1814A3E90
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x14A3E70 Offset: 0x14A2470 VA: 0x1814A3E70
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x149FFE0 Offset: 0x149E5E0 VA: 0x18149FFE0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x149FDE0 Offset: 0x149E3E0 VA: 0x18149FDE0
	internal void FinishStageTwo() { }

	// RVA: 0x149FD30 Offset: 0x149E330 VA: 0x18149FD30
	internal void FinishStageThree() { }

	// RVA: 0x14A0EC0 Offset: 0x149F4C0 VA: 0x1814A0EC0
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x149C3B0 Offset: 0x149A9B0 VA: 0x18149C3B0
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x149FF50 Offset: 0x149E550 VA: 0x18149FF50
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x149F4B0 Offset: 0x149DAB0 VA: 0x18149F4B0
	private void Execute() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x149DF80 Offset: 0x149C580 VA: 0x18149DF80 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x149EFB0 Offset: 0x149D5B0 VA: 0x18149EFB0
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x14A2460 Offset: 0x14A0A60 VA: 0x1814A2460 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x14A2470 Offset: 0x14A0A70 VA: 0x1814A2470 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x149ED40 Offset: 0x149D340 VA: 0x18149ED40
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x149F0F0 Offset: 0x149D6F0 VA: 0x18149F0F0
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x149F700 Offset: 0x149DD00 VA: 0x18149F700
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x14A0710 Offset: 0x149ED10 VA: 0x1814A0710 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x14A06E0 Offset: 0x149ECE0 VA: 0x1814A06E0
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x14A05B0 Offset: 0x149EBB0 VA: 0x1814A05B0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x14A02C0 Offset: 0x149E8C0 VA: 0x1814A02C0
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x149D490 Offset: 0x149BA90 VA: 0x18149D490
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x14A1B40 Offset: 0x14A0140 VA: 0x1814A1B40
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x14A2A90 Offset: 0x14A1090 VA: 0x1814A2A90
	public void Wait() { }

	// RVA: 0x14A2B60 Offset: 0x14A1160 VA: 0x1814A2B60
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14A2E90 Offset: 0x14A1490 VA: 0x1814A2E90
	private bool WrappedTryRunInline() { }

	// RVA: 0x14A0BC0 Offset: 0x149F1C0 VA: 0x1814A0BC0
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14A1EF0 Offset: 0x14A04F0 VA: 0x1814A1EF0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14A2250 Offset: 0x14A0850 VA: 0x1814A2250
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x14A07A0 Offset: 0x149EDA0 VA: 0x1814A07A0
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x14A1180 Offset: 0x149F780 VA: 0x1814A1180
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x14A1230 Offset: 0x149F830 VA: 0x1814A1230
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x14A10B0 Offset: 0x149F6B0 VA: 0x1814A10B0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x149D3A0 Offset: 0x149B9A0 VA: 0x18149D3A0
	internal void CancellationCleanupLogic() { }

	// RVA: 0x14A1B10 Offset: 0x14A0110 VA: 0x1814A1B10
	private void SetCancellationAcknowledged() { }

	// RVA: 0x149F7B0 Offset: 0x149DDB0 VA: 0x18149F7B0
	internal void FinishContinuations() { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	private void LogFinishCompletionNotification() { }

	// RVA: 0x149DD70 Offset: 0x149C370 VA: 0x18149DD70
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x149DBB0 Offset: 0x149C1B0 VA: 0x18149DBB0
	public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x149D890 Offset: 0x149BE90 VA: 0x18149D890
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x149D6F0 Offset: 0x149BCF0 VA: 0x18149D6F0
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x149DA20 Offset: 0x149C020 VA: 0x18149DA20
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x149E0C0 Offset: 0x149C6C0 VA: 0x18149E0C0
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x149D4B0 Offset: 0x149BAB0 VA: 0x18149D4B0
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x149C120 Offset: 0x149A720 VA: 0x18149C120
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x149C0A0 Offset: 0x149A6A0 VA: 0x18149C0A0
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x149C750 Offset: 0x149AD50 VA: 0x18149C750
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x149CA70 Offset: 0x149B070 VA: 0x18149CA70
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x14A12D0 Offset: 0x149F8D0 VA: 0x1814A12D0
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C4E0 Offset: 0x157AAE0 VA: 0x18157C4E0
	|-Task.FromResult<bool>
	|
	|-RVA: 0x157C5A0 Offset: 0x157ABA0 VA: 0x18157C5A0
	|-Task.FromResult<Stream>
	|-Task.FromResult<Tuple<int, int, int, bool>>
	|-Task.FromResult<object>
	|
	|-RVA: 0x157C540 Offset: 0x157AB40 VA: 0x18157C540
	|-Task.FromResult<int>
	*/

	// RVA: 0x14A0260 Offset: 0x149E860 VA: 0x1814A0260
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C270 Offset: 0x157A870 VA: 0x18157C270
	|-Task.FromException<int>
	|
	|-RVA: 0x157C340 Offset: 0x157A940 VA: 0x18157C340
	|-Task.FromException<object>
	|
	|-RVA: 0x157C410 Offset: 0x157AA10 VA: 0x18157C410
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14A01B0 Offset: 0x149E7B0 VA: 0x1814A01B0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9280 Offset: 0xED7880 VA: 0x180ED9280
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0xED9430 Offset: 0xED7A30 VA: 0x180ED9430
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x157C0C0 Offset: 0x157A6C0 VA: 0x18157C0C0
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9350 Offset: 0xED7950 VA: 0x180ED9350
	|-Task.FromCancellation<int>
	|
	|-RVA: 0xED9500 Offset: 0xED7B00 VA: 0x180ED9500
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x157C190 Offset: 0x157A790 VA: 0x18157C190
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x14A1750 Offset: 0x149FD50 VA: 0x1814A1750
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CC60 Offset: 0x157B260 VA: 0x18157CC60
	|-Task.Run<Stream>
	|-Task.Run<object>
	|
	|-RVA: 0x157C700 Offset: 0x157AD00 VA: 0x18157C700
	|-Task.Run<int>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CB00 Offset: 0x157B100 VA: 0x18157CB00
	|-Task.Run<MP3Stream>
	|-Task.Run<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CA90 Offset: 0x157B090 VA: 0x18157CA90
	|-Task.Run<Stream>
	|-Task.Run<WebResponse>
	|-Task.Run<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C870 Offset: 0x157AE70 VA: 0x18157C870
	|-Task.Run<object>
	*/

	// RVA: 0x149E330 Offset: 0x149C930 VA: 0x18149E330
	public static Task Delay(TimeSpan delay) { }

	// RVA: 0x149E260 Offset: 0x149C860 VA: 0x18149E260
	public static Task Delay(TimeSpan delay, CancellationToken cancellationToken) { }

	// RVA: 0x149E200 Offset: 0x149C800 VA: 0x18149E200
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x149E430 Offset: 0x149CA30 VA: 0x18149E430
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CDD0 Offset: 0x157B3D0 VA: 0x18157CDD0
	|-Task.WhenAll<IPlayerInventory>
	|-Task.WhenAll<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult[]> WhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D300 Offset: 0x157B900 VA: 0x18157D300
	|-Task.WhenAll<object>
	*/

	// RVA: -1 Offset: -1
	private static Task<TResult[]> InternalWhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C600 Offset: 0x157AC00 VA: 0x18157C600
	|-Task.InternalWhenAll<object>
	*/

	// RVA: 0x14A2CC0 Offset: 0x14A12C0 VA: 0x1814A2CC0
	public static Task<Task> WhenAny(Task[] tasks) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9210 Offset: 0xED7810 VA: 0x180ED9210
	|-Task.CreateUnwrapPromise<object>
	*/

	// RVA: 0x14A2F70 Offset: 0x14A1570 VA: 0x1814A2F70
	private static void .cctor() { }

}

internal class Task.ContingentProperties // TypeDefIndex: 854
{	// Fields
	internal ExecutionContext m_capturedContext; // 0x10
	internal ManualResetEventSlim m_completionEvent; // 0x18
	internal TaskExceptionHolder m_exceptionsHolder; // 0x20
	internal CancellationToken m_cancellationToken; // 0x28
	internal Shared<CancellationTokenRegistration> m_cancellationRegistration; // 0x30
	internal int m_internalCancellationRequested; // 0x38
	internal int m_completionCountdown; // 0x3C
	internal List<Task> m_exceptionalChildren; // 0x40

	// Methods

	// RVA: 0x1605E50 Offset: 0x1604450 VA: 0x181605E50
	internal void SetCompleted() { }

	// RVA: 0x1605DD0 Offset: 0x16043D0 VA: 0x181605DD0
	internal void DeregisterCancellationCallback() { }

	// RVA: 0x1605E80 Offset: 0x1604480 VA: 0x181605E80
	public void .ctor() { }

}

private sealed class Task.SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction // TypeDefIndex: 855
{	// Methods

	// RVA: 0x1607400 Offset: 0x1605A00 VA: 0x181607400
	internal void .ctor() { }

	// RVA: 0x16073F0 Offset: 0x16059F0 VA: 0x1816073F0 Slot: 6
	public void Invoke(Task completingTask) { }

}

private sealed class Task.DelayPromise : Task<VoidTaskResult> // TypeDefIndex: 856
{	// Fields
	internal readonly CancellationToken Token; // 0x58
	internal CancellationTokenRegistration Registration; // 0x60
	internal Timer Timer; // 0x78

	// Methods

	// RVA: 0x1606040 Offset: 0x1604640 VA: 0x181606040
	internal void .ctor(CancellationToken token) { }

	// RVA: 0x1605EB0 Offset: 0x16044B0 VA: 0x181605EB0
	internal void Complete() { }

}

private sealed class Task.WhenAllPromise<T> : Task<T[]>, ITaskCompletionAction // TypeDefIndex: 857
{	// Fields
	private readonly Task<T>[] m_tasks; // 0x0
	private int m_count; // 0x0

	// Properties
	internal override bool ShouldNotifyDebuggerOfWaitCompletion { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<T>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x136A7D0 Offset: 0x1368DD0 VA: 0x18136A7D0
	|-Task.WhenAllPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void Invoke(Task ignored) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x136A460 Offset: 0x1368A60 VA: 0x18136A460
	|-Task.WhenAllPromise<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override bool get_ShouldNotifyDebuggerOfWaitCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x136A9D0 Offset: 0x1368FD0 VA: 0x18136A9D0
	|-Task.WhenAllPromise<object>.get_ShouldNotifyDebuggerOfWaitCompletion
	*/

}

private sealed class Task.<>c__DisplayClass178_0 // TypeDefIndex: 858
{	// Fields
	public Task root; // 0x10
	public bool replicasAreQuitting; // 0x18
	public Action<object> taskReplicaDelegate; // 0x20
	public TaskCreationOptions creationOptionsForReplicas; // 0x28
	public InternalTaskOptions internalOptionsForReplicas; // 0x2C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x161B980 Offset: 0x1619F80 VA: 0x18161B980
	internal void <ExecuteSelfReplicating>b__0(object <p0>) { }

}

private sealed class Task.<>c // TypeDefIndex: 859
{	// Fields
	public static readonly Task.<>c <>9; // 0x0
	public static Action<object> <>9__276_0; // 0x8
	public static TimerCallback <>9__276_1; // 0x10

	// Methods

	// RVA: 0x161BE20 Offset: 0x161A420 VA: 0x18161BE20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x161B7D0 Offset: 0x1619DD0 VA: 0x18161B7D0
	internal void <Delay>b__276_0(object state) { }

	// RVA: 0x161B830 Offset: 0x1619E30 VA: 0x18161B830
	internal void <Delay>b__276_1(object state) { }

	// RVA: 0x161B910 Offset: 0x1619F10 VA: 0x18161B910
	internal Task.ContingentProperties <.cctor>b__295_0() { }

	// RVA: 0x161B960 Offset: 0x1619F60 VA: 0x18161B960
	internal bool <.cctor>b__295_1(Task t) { }

	// RVA: 0xDF0010 Offset: 0xDEE610 VA: 0x180DF0010
	internal bool <.cctor>b__295_2(object tc) { }

}

