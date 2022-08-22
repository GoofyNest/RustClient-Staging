private sealed class Task.<>c<TResult> // TypeDefIndex: 843
{	// Fields
	public static readonly Task.<>c<TResult> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66290 Offset: 0xD64890 VA: 0x180D66290
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
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
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
	|-RVA: 0x1A98CB0 Offset: 0x1A972B0 VA: 0x181A98CB0
	|-Task.<>c<PublishResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1A989F0 Offset: 0x1A96FF0 VA: 0x181A989F0
	|-Task.<>c<bool>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98E10 Offset: 0x1A97410 VA: 0x181A98E10
	|-Task.<>c<int>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98730 Offset: 0x1A96D30 VA: 0x181A98730
	|-Task.<>c<UdpReceiveResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98AA0 Offset: 0x1A970A0 VA: 0x181A98AA0
	|-Task.<>c<Nullable<ServerInfo>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98F70 Offset: 0x1A97570 VA: 0x181A98F70
	|-Task.<>c<Nullable<Image>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98940 Offset: 0x1A96F40 VA: 0x181A98940
	|-Task.<>c<Nullable<InventoryPurchaseResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A99020 Offset: 0x1A97620 VA: 0x181A99020
	|-Task.<>c<Nullable<InventoryResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98890 Offset: 0x1A96E90 VA: 0x181A98890
	|-Task.<>c<Nullable<Item>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A987E0 Offset: 0x1A96DE0 VA: 0x181A987E0
	|-Task.<>c<Nullable<ResultPage>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98C00 Offset: 0x1A97200 VA: 0x181A98C00
	|-Task.<>c<Nullable<int>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98EC0 Offset: 0x1A974C0 VA: 0x181A98EC0
	|-Task.<>c<Nullable<Int32Enum>>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98B50 Offset: 0x1A97150 VA: 0x181A98B50
	|-Task.<>c<object>.<.cctor>b__64_0
	|
	|-RVA: 0x1A98D60 Offset: 0x1A97360 VA: 0x181A98D60
	|-Task.<>c<VoidTaskResult>.<.cctor>b__64_0
	*/

}

public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 853
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x149BED0 Offset: 0x149A4D0 VA: 0x18149BED0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A0930 Offset: 0x149EF30 VA: 0x1814A0930
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x14A27C0 Offset: 0x14A0DC0 VA: 0x1814A27C0
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x14A2890 Offset: 0x14A0E90 VA: 0x1814A2890
	internal void .ctor() { }

	// RVA: 0x14A2690 Offset: 0x14A0C90 VA: 0x1814A2690
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x14A2580 Offset: 0x14A0B80 VA: 0x1814A2580
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x14A19D0 Offset: 0x149FFD0 VA: 0x1814A19D0
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x149C140 Offset: 0x149A740 VA: 0x18149C140
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x14A18E0 Offset: 0x149FEE0 VA: 0x1814A18E0
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x14A01E0 Offset: 0x149E7E0 VA: 0x1814A01E0
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x14A3340 Offset: 0x14A1940 VA: 0x1814A3340
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x149C4D0 Offset: 0x149AAD0 VA: 0x18149C4D0
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x149C600 Offset: 0x149AC00 VA: 0x18149C600
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x14A1140 Offset: 0x149F740 VA: 0x1814A1140
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x14A0150 Offset: 0x149E750 VA: 0x1814A0150
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x149C0A0 Offset: 0x149A6A0 VA: 0x18149C0A0
	internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks) { }

	// RVA: 0x14A32F0 Offset: 0x14A18F0 VA: 0x1814A32F0
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x14A3320 Offset: 0x14A1920 VA: 0x1814A3320 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x14A3320 Offset: 0x14A1920 VA: 0x1814A3320
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x14A01B0 Offset: 0x149E7B0 VA: 0x1814A01B0
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x14A00D0 Offset: 0x149E6D0 VA: 0x1814A00D0
	internal bool MarkStarted() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x149B9B0 Offset: 0x1499FB0 VA: 0x18149B9B0
	internal void AddNewChild() { }

	// RVA: 0x149DE70 Offset: 0x149C470 VA: 0x18149DE70
	internal void DisregardChild() { }

	// RVA: 0x149FE30 Offset: 0x149E430 VA: 0x18149FE30
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x14A00F0 Offset: 0x149E6F0 VA: 0x1814A00F0
	internal static int NewId() { }

	// RVA: 0x14A2EE0 Offset: 0x14A14E0 VA: 0x1814A2EE0
	public int get_Id() { }

	// RVA: 0x14A2FC0 Offset: 0x14A15C0 VA: 0x1814A2FC0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x149FD80 Offset: 0x149E380 VA: 0x18149FD80
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x14A2D10 Offset: 0x14A1310 VA: 0x1814A2D10
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x14A2E30 Offset: 0x14A1430 VA: 0x1814A2E30
	public AggregateException get_Exception() { }

	// RVA: 0x14A33A0 Offset: 0x14A19A0 VA: 0x1814A33A0
	public TaskStatus get_Status() { }

	// RVA: 0x14A3080 Offset: 0x14A1680 VA: 0x1814A3080
	public bool get_IsCanceled() { }

	// RVA: 0x14A30D0 Offset: 0x14A16D0 VA: 0x1814A30D0
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x149DFE0 Offset: 0x149C5E0 VA: 0x18149DFE0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x149DF20 Offset: 0x149C520 VA: 0x18149DF20
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x14A28C0 Offset: 0x14A0EC0 VA: 0x1814A28C0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x14A30B0 Offset: 0x14A16B0 VA: 0x1814A30B0
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x14A31A0 Offset: 0x14A17A0 VA: 0x1814A31A0 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x14A00C0 Offset: 0x149E6C0 VA: 0x1814A00C0
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x14A3260 Offset: 0x14A1860 VA: 0x1814A3260
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x14A2CB0 Offset: 0x14A12B0 VA: 0x1814A2CB0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x14A1720 Offset: 0x149FD20 VA: 0x1814A1720 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x14A2E80 Offset: 0x14A1480 VA: 0x1814A2E80
	public static TaskFactory get_Factory() { }

	// RVA: 0x14A2BC0 Offset: 0x14A11C0 VA: 0x1814A2BC0
	public static Task get_CompletedTask() { }

	// RVA: 0x14A29E0 Offset: 0x14A0FE0 VA: 0x1814A29E0
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x14A3290 Offset: 0x14A1890 VA: 0x1814A3290
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x14A3140 Offset: 0x14A1740 VA: 0x1814A3140
	internal bool get_IsChildReplica() { }

	// RVA: 0x14A2DD0 Offset: 0x14A13D0 VA: 0x1814A2DD0
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x14A3240 Offset: 0x14A1840 VA: 0x1814A3240
	public bool get_IsFaulted() { }

	// RVA: 0x14A28F0 Offset: 0x14A0EF0 VA: 0x1814A28F0
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x14A3430 Offset: 0x14A1A30 VA: 0x1814A3430
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x149D2A0 Offset: 0x149B8A0 VA: 0x18149D2A0
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x149DC70 Offset: 0x149C270 VA: 0x18149DC70 Slot: 10
	public void Dispose() { }

	// RVA: 0x149DCE0 Offset: 0x149C2E0 VA: 0x18149DCE0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14A0CE0 Offset: 0x149F2E0 VA: 0x1814A0CE0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x149B520 Offset: 0x1499B20 VA: 0x18149B520
	internal void AddException(object exceptionObject) { }

	// RVA: 0x149B530 Offset: 0x1499B30 VA: 0x18149B530
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x149F7B0 Offset: 0x149DDB0 VA: 0x18149F7B0
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x149F6B0 Offset: 0x149DCB0 VA: 0x18149F6B0
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x149F670 Offset: 0x149DC70 VA: 0x18149F670
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x14A1C80 Offset: 0x14A0280 VA: 0x1814A1C80
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x14A1CF0 Offset: 0x14A02F0 VA: 0x1814A1CF0
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x14A3220 Offset: 0x14A1820 VA: 0x1814A3220
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x14A3200 Offset: 0x14A1800 VA: 0x1814A3200
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x149F370 Offset: 0x149D970 VA: 0x18149F370
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x149F170 Offset: 0x149D770 VA: 0x18149F170
	internal void FinishStageTwo() { }

	// RVA: 0x149F0C0 Offset: 0x149D6C0 VA: 0x18149F0C0
	internal void FinishStageThree() { }

	// RVA: 0x14A0250 Offset: 0x149E850 VA: 0x1814A0250
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x149B740 Offset: 0x1499D40 VA: 0x18149B740
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x149F2E0 Offset: 0x149D8E0 VA: 0x18149F2E0
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x149E840 Offset: 0x149CE40 VA: 0x18149E840
	private void Execute() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x149D310 Offset: 0x149B910 VA: 0x18149D310 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x149E340 Offset: 0x149C940 VA: 0x18149E340
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x14A17F0 Offset: 0x149FDF0 VA: 0x1814A17F0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x14A1800 Offset: 0x149FE00 VA: 0x1814A1800 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x149E0D0 Offset: 0x149C6D0 VA: 0x18149E0D0
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x149E480 Offset: 0x149CA80 VA: 0x18149E480
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x149EA90 Offset: 0x149D090 VA: 0x18149EA90
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x149FAA0 Offset: 0x149E0A0 VA: 0x18149FAA0 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x149FA70 Offset: 0x149E070 VA: 0x18149FA70
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x149F940 Offset: 0x149DF40 VA: 0x18149F940
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x149F650 Offset: 0x149DC50 VA: 0x18149F650
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x149C820 Offset: 0x149AE20 VA: 0x18149C820
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x14A0ED0 Offset: 0x149F4D0 VA: 0x1814A0ED0
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x14A1E20 Offset: 0x14A0420 VA: 0x1814A1E20
	public void Wait() { }

	// RVA: 0x14A1EF0 Offset: 0x14A04F0 VA: 0x1814A1EF0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14A2220 Offset: 0x14A0820 VA: 0x1814A2220
	private bool WrappedTryRunInline() { }

	// RVA: 0x149FF50 Offset: 0x149E550 VA: 0x18149FF50
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14A1280 Offset: 0x149F880 VA: 0x1814A1280
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14A15E0 Offset: 0x149FBE0 VA: 0x1814A15E0
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x149FB30 Offset: 0x149E130 VA: 0x18149FB30
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x14A0510 Offset: 0x149EB10 VA: 0x1814A0510
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x14A05C0 Offset: 0x149EBC0 VA: 0x1814A05C0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x14A0440 Offset: 0x149EA40 VA: 0x1814A0440
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x149C730 Offset: 0x149AD30 VA: 0x18149C730
	internal void CancellationCleanupLogic() { }

	// RVA: 0x14A0EA0 Offset: 0x149F4A0 VA: 0x1814A0EA0
	private void SetCancellationAcknowledged() { }

	// RVA: 0x149EB40 Offset: 0x149D140 VA: 0x18149EB40
	internal void FinishContinuations() { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	private void LogFinishCompletionNotification() { }

	// RVA: 0x149D100 Offset: 0x149B700 VA: 0x18149D100
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x149CF40 Offset: 0x149B540 VA: 0x18149CF40
	public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x149CC20 Offset: 0x149B220 VA: 0x18149CC20
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x149CA80 Offset: 0x149B080 VA: 0x18149CA80
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x149CDB0 Offset: 0x149B3B0 VA: 0x18149CDB0
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x149D450 Offset: 0x149BA50 VA: 0x18149D450
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x149C840 Offset: 0x149AE40 VA: 0x18149C840
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x149B4B0 Offset: 0x1499AB0 VA: 0x18149B4B0
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x149B430 Offset: 0x1499A30 VA: 0x18149B430
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x149BAE0 Offset: 0x149A0E0 VA: 0x18149BAE0
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x149BE00 Offset: 0x149A400 VA: 0x18149BE00
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x14A0660 Offset: 0x149EC60 VA: 0x1814A0660
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B870 Offset: 0x1579E70 VA: 0x18157B870
	|-Task.FromResult<bool>
	|
	|-RVA: 0x157B930 Offset: 0x1579F30 VA: 0x18157B930
	|-Task.FromResult<Stream>
	|-Task.FromResult<Tuple<int, int, int, bool>>
	|-Task.FromResult<object>
	|
	|-RVA: 0x157B8D0 Offset: 0x1579ED0 VA: 0x18157B8D0
	|-Task.FromResult<int>
	*/

	// RVA: 0x149F5F0 Offset: 0x149DBF0 VA: 0x18149F5F0
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B600 Offset: 0x1579C00 VA: 0x18157B600
	|-Task.FromException<int>
	|
	|-RVA: 0x157B6D0 Offset: 0x1579CD0 VA: 0x18157B6D0
	|-Task.FromException<object>
	|
	|-RVA: 0x157B7A0 Offset: 0x1579DA0 VA: 0x18157B7A0
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x149F540 Offset: 0x149DB40 VA: 0x18149F540
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9FF0 Offset: 0xED85F0 VA: 0x180ED9FF0
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0xEDA1A0 Offset: 0xED87A0 VA: 0x180EDA1A0
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x157B450 Offset: 0x1579A50 VA: 0x18157B450
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA0C0 Offset: 0xED86C0 VA: 0x180EDA0C0
	|-Task.FromCancellation<int>
	|
	|-RVA: 0xEDA270 Offset: 0xED8870 VA: 0x180EDA270
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x157B520 Offset: 0x1579B20 VA: 0x18157B520
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x14A0AE0 Offset: 0x149F0E0 VA: 0x1814A0AE0
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BFF0 Offset: 0x157A5F0 VA: 0x18157BFF0
	|-Task.Run<Stream>
	|-Task.Run<object>
	|
	|-RVA: 0x157BA90 Offset: 0x157A090 VA: 0x18157BA90
	|-Task.Run<int>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BE90 Offset: 0x157A490 VA: 0x18157BE90
	|-Task.Run<MP3Stream>
	|-Task.Run<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BE20 Offset: 0x157A420 VA: 0x18157BE20
	|-Task.Run<Stream>
	|-Task.Run<WebResponse>
	|-Task.Run<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BC00 Offset: 0x157A200 VA: 0x18157BC00
	|-Task.Run<object>
	*/

	// RVA: 0x149D6C0 Offset: 0x149BCC0 VA: 0x18149D6C0
	public static Task Delay(TimeSpan delay) { }

	// RVA: 0x149D5F0 Offset: 0x149BBF0 VA: 0x18149D5F0
	public static Task Delay(TimeSpan delay, CancellationToken cancellationToken) { }

	// RVA: 0x149D590 Offset: 0x149BB90 VA: 0x18149D590
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x149D7C0 Offset: 0x149BDC0 VA: 0x18149D7C0
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C160 Offset: 0x157A760 VA: 0x18157C160
	|-Task.WhenAll<IPlayerInventory>
	|-Task.WhenAll<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult[]> WhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C690 Offset: 0x157AC90 VA: 0x18157C690
	|-Task.WhenAll<object>
	*/

	// RVA: -1 Offset: -1
	private static Task<TResult[]> InternalWhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B990 Offset: 0x1579F90 VA: 0x18157B990
	|-Task.InternalWhenAll<object>
	*/

	// RVA: 0x14A2050 Offset: 0x14A0650 VA: 0x1814A2050
	public static Task<Task> WhenAny(Task[] tasks) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9F80 Offset: 0xED8580 VA: 0x180ED9F80
	|-Task.CreateUnwrapPromise<object>
	*/

	// RVA: 0x14A2300 Offset: 0x14A0900 VA: 0x1814A2300
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

	// RVA: 0x15F3430 Offset: 0x15F1A30 VA: 0x1815F3430
	internal void SetCompleted() { }

	// RVA: 0x15F33B0 Offset: 0x15F19B0 VA: 0x1815F33B0
	internal void DeregisterCancellationCallback() { }

	// RVA: 0x15F3460 Offset: 0x15F1A60 VA: 0x1815F3460
	public void .ctor() { }

}

private sealed class Task.SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction // TypeDefIndex: 855
{	// Methods

	// RVA: 0x15F49E0 Offset: 0x15F2FE0 VA: 0x1815F49E0
	internal void .ctor() { }

	// RVA: 0x15F49D0 Offset: 0x15F2FD0 VA: 0x1815F49D0 Slot: 6
	public void Invoke(Task completingTask) { }

}

private sealed class Task.DelayPromise : Task<VoidTaskResult> // TypeDefIndex: 856
{	// Fields
	internal readonly CancellationToken Token; // 0x58
	internal CancellationTokenRegistration Registration; // 0x60
	internal Timer Timer; // 0x78

	// Methods

	// RVA: 0x15F3620 Offset: 0x15F1C20 VA: 0x1815F3620
	internal void .ctor(CancellationToken token) { }

	// RVA: 0x15F3490 Offset: 0x15F1A90 VA: 0x1815F3490
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
	|-RVA: 0x1369B90 Offset: 0x1368190 VA: 0x181369B90
	|-Task.WhenAllPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void Invoke(Task ignored) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369820 Offset: 0x1367E20 VA: 0x181369820
	|-Task.WhenAllPromise<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override bool get_ShouldNotifyDebuggerOfWaitCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369D90 Offset: 0x1368390 VA: 0x181369D90
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

	// RVA: 0x1608F60 Offset: 0x1607560 VA: 0x181608F60
	internal void <ExecuteSelfReplicating>b__0(object <p0>) { }

}

private sealed class Task.<>c // TypeDefIndex: 859
{	// Fields
	public static readonly Task.<>c <>9; // 0x0
	public static Action<object> <>9__276_0; // 0x8
	public static TimerCallback <>9__276_1; // 0x10

	// Methods

	// RVA: 0x1609400 Offset: 0x1607A00 VA: 0x181609400
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1608DB0 Offset: 0x16073B0 VA: 0x181608DB0
	internal void <Delay>b__276_0(object state) { }

	// RVA: 0x1608E10 Offset: 0x1607410 VA: 0x181608E10
	internal void <Delay>b__276_1(object state) { }

	// RVA: 0x1608EF0 Offset: 0x16074F0 VA: 0x181608EF0
	internal Task.ContingentProperties <.cctor>b__295_0() { }

	// RVA: 0x1608F40 Offset: 0x1607540 VA: 0x181608F40
	internal bool <.cctor>b__295_1(Task t) { }

	// RVA: 0xDF0D80 Offset: 0xDEF380 VA: 0x180DF0D80
	internal bool <.cctor>b__295_2(object tc) { }

}

