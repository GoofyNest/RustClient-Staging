private sealed class Task.<>c<TResult> // TypeDefIndex: 843
{	// Fields
	public static readonly Task.<>c<TResult> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD65540 Offset: 0xD63B40 VA: 0x180D65540
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
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
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
	|-RVA: 0x1AAC4A0 Offset: 0x1AAAAA0 VA: 0x181AAC4A0
	|-Task.<>c<PublishResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC1E0 Offset: 0x1AAA7E0 VA: 0x181AAC1E0
	|-Task.<>c<bool>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC600 Offset: 0x1AAAC00 VA: 0x181AAC600
	|-Task.<>c<int>.<.cctor>b__64_0
	|
	|-RVA: 0x1AABF20 Offset: 0x1AAA520 VA: 0x181AABF20
	|-Task.<>c<UdpReceiveResult>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC290 Offset: 0x1AAA890 VA: 0x181AAC290
	|-Task.<>c<Nullable<ServerInfo>>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC760 Offset: 0x1AAAD60 VA: 0x181AAC760
	|-Task.<>c<Nullable<Image>>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC130 Offset: 0x1AAA730 VA: 0x181AAC130
	|-Task.<>c<Nullable<InventoryPurchaseResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC810 Offset: 0x1AAAE10 VA: 0x181AAC810
	|-Task.<>c<Nullable<InventoryResult>>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC080 Offset: 0x1AAA680 VA: 0x181AAC080
	|-Task.<>c<Nullable<Item>>.<.cctor>b__64_0
	|
	|-RVA: 0x1AABFD0 Offset: 0x1AAA5D0 VA: 0x181AABFD0
	|-Task.<>c<Nullable<ResultPage>>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC3F0 Offset: 0x1AAA9F0 VA: 0x181AAC3F0
	|-Task.<>c<Nullable<int>>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC6B0 Offset: 0x1AAACB0 VA: 0x181AAC6B0
	|-Task.<>c<Nullable<Int32Enum>>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC340 Offset: 0x1AAA940 VA: 0x181AAC340
	|-Task.<>c<object>.<.cctor>b__64_0
	|
	|-RVA: 0x1AAC550 Offset: 0x1AAAB50 VA: 0x181AAC550
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
	// RVA: 0x149CE00 Offset: 0x149B400 VA: 0x18149CE00
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A1860 Offset: 0x149FE60 VA: 0x1814A1860
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x14A36F0 Offset: 0x14A1CF0 VA: 0x1814A36F0
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x14A37C0 Offset: 0x14A1DC0 VA: 0x1814A37C0
	internal void .ctor() { }

	// RVA: 0x14A35C0 Offset: 0x14A1BC0 VA: 0x1814A35C0
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x14A34B0 Offset: 0x14A1AB0 VA: 0x1814A34B0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x14A2900 Offset: 0x14A0F00 VA: 0x1814A2900
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x149D070 Offset: 0x149B670 VA: 0x18149D070
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x14A2810 Offset: 0x14A0E10 VA: 0x1814A2810
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x14A1110 Offset: 0x149F710 VA: 0x1814A1110
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x14A4270 Offset: 0x14A2870 VA: 0x1814A4270
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x149D400 Offset: 0x149BA00 VA: 0x18149D400
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x149D530 Offset: 0x149BB30 VA: 0x18149D530
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x14A2070 Offset: 0x14A0670 VA: 0x1814A2070
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x14A1080 Offset: 0x149F680 VA: 0x1814A1080
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x149CFD0 Offset: 0x149B5D0 VA: 0x18149CFD0
	internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks) { }

	// RVA: 0x14A4220 Offset: 0x14A2820 VA: 0x1814A4220
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x14A4250 Offset: 0x14A2850 VA: 0x1814A4250 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x14A4250 Offset: 0x14A2850 VA: 0x1814A4250
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x14A10E0 Offset: 0x149F6E0 VA: 0x1814A10E0
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x14A1000 Offset: 0x149F600 VA: 0x1814A1000
	internal bool MarkStarted() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x149C8E0 Offset: 0x149AEE0 VA: 0x18149C8E0
	internal void AddNewChild() { }

	// RVA: 0x149EDA0 Offset: 0x149D3A0 VA: 0x18149EDA0
	internal void DisregardChild() { }

	// RVA: 0x14A0D60 Offset: 0x149F360 VA: 0x1814A0D60
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x14A1020 Offset: 0x149F620 VA: 0x1814A1020
	internal static int NewId() { }

	// RVA: 0x14A3E10 Offset: 0x14A2410 VA: 0x1814A3E10
	public int get_Id() { }

	// RVA: 0x14A3EF0 Offset: 0x14A24F0 VA: 0x1814A3EF0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x14A0CB0 Offset: 0x149F2B0 VA: 0x1814A0CB0
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x14A3C40 Offset: 0x14A2240 VA: 0x1814A3C40
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x14A3D60 Offset: 0x14A2360 VA: 0x1814A3D60
	public AggregateException get_Exception() { }

	// RVA: 0x14A42D0 Offset: 0x14A28D0 VA: 0x1814A42D0
	public TaskStatus get_Status() { }

	// RVA: 0x14A3FB0 Offset: 0x14A25B0 VA: 0x1814A3FB0
	public bool get_IsCanceled() { }

	// RVA: 0x14A4000 Offset: 0x14A2600 VA: 0x1814A4000
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x149EF10 Offset: 0x149D510 VA: 0x18149EF10
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x149EE50 Offset: 0x149D450 VA: 0x18149EE50
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x14A37F0 Offset: 0x14A1DF0 VA: 0x1814A37F0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x14A3FE0 Offset: 0x14A25E0 VA: 0x1814A3FE0
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x14A40D0 Offset: 0x14A26D0 VA: 0x1814A40D0 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x14A0FF0 Offset: 0x149F5F0 VA: 0x1814A0FF0
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x14A4190 Offset: 0x14A2790 VA: 0x1814A4190
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x14A3BE0 Offset: 0x14A21E0 VA: 0x1814A3BE0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x14A2650 Offset: 0x14A0C50 VA: 0x1814A2650 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x14A3DB0 Offset: 0x14A23B0 VA: 0x1814A3DB0
	public static TaskFactory get_Factory() { }

	// RVA: 0x14A3AF0 Offset: 0x14A20F0 VA: 0x1814A3AF0
	public static Task get_CompletedTask() { }

	// RVA: 0x14A3910 Offset: 0x14A1F10 VA: 0x1814A3910
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x14A41C0 Offset: 0x14A27C0 VA: 0x1814A41C0
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x14A4070 Offset: 0x14A2670 VA: 0x1814A4070
	internal bool get_IsChildReplica() { }

	// RVA: 0x14A3D00 Offset: 0x14A2300 VA: 0x1814A3D00
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x14A4170 Offset: 0x14A2770 VA: 0x1814A4170
	public bool get_IsFaulted() { }

	// RVA: 0x14A3820 Offset: 0x14A1E20 VA: 0x1814A3820
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x14A4360 Offset: 0x14A2960 VA: 0x1814A4360
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x149E1D0 Offset: 0x149C7D0 VA: 0x18149E1D0
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x149EBA0 Offset: 0x149D1A0 VA: 0x18149EBA0 Slot: 10
	public void Dispose() { }

	// RVA: 0x149EC10 Offset: 0x149D210 VA: 0x18149EC10 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14A1C10 Offset: 0x14A0210 VA: 0x1814A1C10
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x149C450 Offset: 0x149AA50 VA: 0x18149C450
	internal void AddException(object exceptionObject) { }

	// RVA: 0x149C460 Offset: 0x149AA60 VA: 0x18149C460
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x14A06E0 Offset: 0x149ECE0 VA: 0x1814A06E0
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x14A05E0 Offset: 0x149EBE0 VA: 0x1814A05E0
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x14A05A0 Offset: 0x149EBA0 VA: 0x1814A05A0
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x14A2BB0 Offset: 0x14A11B0 VA: 0x1814A2BB0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x14A2C20 Offset: 0x14A1220 VA: 0x1814A2C20
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x14A4150 Offset: 0x14A2750 VA: 0x1814A4150
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x14A4130 Offset: 0x14A2730 VA: 0x1814A4130
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x14A02A0 Offset: 0x149E8A0 VA: 0x1814A02A0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x14A00A0 Offset: 0x149E6A0 VA: 0x1814A00A0
	internal void FinishStageTwo() { }

	// RVA: 0x149FFF0 Offset: 0x149E5F0 VA: 0x18149FFF0
	internal void FinishStageThree() { }

	// RVA: 0x14A1180 Offset: 0x149F780 VA: 0x1814A1180
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x149C670 Offset: 0x149AC70 VA: 0x18149C670
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x14A0210 Offset: 0x149E810 VA: 0x1814A0210
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x149F770 Offset: 0x149DD70 VA: 0x18149F770
	private void Execute() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x149E240 Offset: 0x149C840 VA: 0x18149E240 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x149F270 Offset: 0x149D870 VA: 0x18149F270
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x14A2720 Offset: 0x14A0D20 VA: 0x1814A2720 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x14A2730 Offset: 0x14A0D30 VA: 0x1814A2730 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x149F000 Offset: 0x149D600 VA: 0x18149F000
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x149F3B0 Offset: 0x149D9B0 VA: 0x18149F3B0
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x149F9C0 Offset: 0x149DFC0 VA: 0x18149F9C0
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x14A09D0 Offset: 0x149EFD0 VA: 0x1814A09D0 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x14A09A0 Offset: 0x149EFA0 VA: 0x1814A09A0
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x14A0870 Offset: 0x149EE70 VA: 0x1814A0870
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x14A0580 Offset: 0x149EB80 VA: 0x1814A0580
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x149D750 Offset: 0x149BD50 VA: 0x18149D750
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x14A1E00 Offset: 0x14A0400 VA: 0x1814A1E00
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x14A2D50 Offset: 0x14A1350 VA: 0x1814A2D50
	public void Wait() { }

	// RVA: 0x14A2E20 Offset: 0x14A1420 VA: 0x1814A2E20
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14A3150 Offset: 0x14A1750 VA: 0x1814A3150
	private bool WrappedTryRunInline() { }

	// RVA: 0x14A0E80 Offset: 0x149F480 VA: 0x1814A0E80
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14A21B0 Offset: 0x14A07B0 VA: 0x1814A21B0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14A2510 Offset: 0x14A0B10 VA: 0x1814A2510
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x14A0A60 Offset: 0x149F060 VA: 0x1814A0A60
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x14A1440 Offset: 0x149FA40 VA: 0x1814A1440
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x14A14F0 Offset: 0x149FAF0 VA: 0x1814A14F0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x14A1370 Offset: 0x149F970 VA: 0x1814A1370
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x149D660 Offset: 0x149BC60 VA: 0x18149D660
	internal void CancellationCleanupLogic() { }

	// RVA: 0x14A1DD0 Offset: 0x14A03D0 VA: 0x1814A1DD0
	private void SetCancellationAcknowledged() { }

	// RVA: 0x149FA70 Offset: 0x149E070 VA: 0x18149FA70
	internal void FinishContinuations() { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	private void LogFinishCompletionNotification() { }

	// RVA: 0x149E030 Offset: 0x149C630 VA: 0x18149E030
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x149DE70 Offset: 0x149C470 VA: 0x18149DE70
	public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x149DB50 Offset: 0x149C150 VA: 0x18149DB50
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x149D9B0 Offset: 0x149BFB0 VA: 0x18149D9B0
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x149DCE0 Offset: 0x149C2E0 VA: 0x18149DCE0
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x149E380 Offset: 0x149C980 VA: 0x18149E380
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x149D770 Offset: 0x149BD70 VA: 0x18149D770
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x149C3E0 Offset: 0x149A9E0 VA: 0x18149C3E0
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x149C360 Offset: 0x149A960 VA: 0x18149C360
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x149CA10 Offset: 0x149B010 VA: 0x18149CA10
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x149CD30 Offset: 0x149B330 VA: 0x18149CD30
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x14A1590 Offset: 0x149FB90 VA: 0x1814A1590
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C7A0 Offset: 0x157ADA0 VA: 0x18157C7A0
	|-Task.FromResult<bool>
	|
	|-RVA: 0x157C860 Offset: 0x157AE60 VA: 0x18157C860
	|-Task.FromResult<Stream>
	|-Task.FromResult<Tuple<int, int, int, bool>>
	|-Task.FromResult<object>
	|
	|-RVA: 0x157C800 Offset: 0x157AE00 VA: 0x18157C800
	|-Task.FromResult<int>
	*/

	// RVA: 0x14A0520 Offset: 0x149EB20 VA: 0x1814A0520
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C530 Offset: 0x157AB30 VA: 0x18157C530
	|-Task.FromException<int>
	|
	|-RVA: 0x157C600 Offset: 0x157AC00 VA: 0x18157C600
	|-Task.FromException<object>
	|
	|-RVA: 0x157C6D0 Offset: 0x157ACD0 VA: 0x18157C6D0
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A0470 Offset: 0x149EA70 VA: 0x1814A0470
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9540 Offset: 0xED7B40 VA: 0x180ED9540
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0xED96F0 Offset: 0xED7CF0 VA: 0x180ED96F0
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x157C380 Offset: 0x157A980 VA: 0x18157C380
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9610 Offset: 0xED7C10 VA: 0x180ED9610
	|-Task.FromCancellation<int>
	|
	|-RVA: 0xED97C0 Offset: 0xED7DC0 VA: 0x180ED97C0
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x157C450 Offset: 0x157AA50 VA: 0x18157C450
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x14A1A10 Offset: 0x14A0010 VA: 0x1814A1A10
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CF20 Offset: 0x157B520 VA: 0x18157CF20
	|-Task.Run<Stream>
	|-Task.Run<object>
	|
	|-RVA: 0x157C9C0 Offset: 0x157AFC0 VA: 0x18157C9C0
	|-Task.Run<int>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CDC0 Offset: 0x157B3C0 VA: 0x18157CDC0
	|-Task.Run<MP3Stream>
	|-Task.Run<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CD50 Offset: 0x157B350 VA: 0x18157CD50
	|-Task.Run<Stream>
	|-Task.Run<WebResponse>
	|-Task.Run<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CB30 Offset: 0x157B130 VA: 0x18157CB30
	|-Task.Run<object>
	*/

	// RVA: 0x149E5F0 Offset: 0x149CBF0 VA: 0x18149E5F0
	public static Task Delay(TimeSpan delay) { }

	// RVA: 0x149E520 Offset: 0x149CB20 VA: 0x18149E520
	public static Task Delay(TimeSpan delay, CancellationToken cancellationToken) { }

	// RVA: 0x149E4C0 Offset: 0x149CAC0 VA: 0x18149E4C0
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x149E6F0 Offset: 0x149CCF0 VA: 0x18149E6F0
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D090 Offset: 0x157B690 VA: 0x18157D090
	|-Task.WhenAll<IPlayerInventory>
	|-Task.WhenAll<object>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult[]> WhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D5C0 Offset: 0x157BBC0 VA: 0x18157D5C0
	|-Task.WhenAll<object>
	*/

	// RVA: -1 Offset: -1
	private static Task<TResult[]> InternalWhenAll<TResult>(Task<TResult>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C8C0 Offset: 0x157AEC0 VA: 0x18157C8C0
	|-Task.InternalWhenAll<object>
	*/

	// RVA: 0x14A2F80 Offset: 0x14A1580 VA: 0x1814A2F80
	public static Task<Task> WhenAny(Task[] tasks) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED94D0 Offset: 0xED7AD0 VA: 0x180ED94D0
	|-Task.CreateUnwrapPromise<object>
	*/

	// RVA: 0x14A3230 Offset: 0x14A1830 VA: 0x1814A3230
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

	// RVA: 0x1606110 Offset: 0x1604710 VA: 0x181606110
	internal void SetCompleted() { }

	// RVA: 0x1606090 Offset: 0x1604690 VA: 0x181606090
	internal void DeregisterCancellationCallback() { }

	// RVA: 0x1606140 Offset: 0x1604740 VA: 0x181606140
	public void .ctor() { }

}

private sealed class Task.SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction // TypeDefIndex: 855
{	// Methods

	// RVA: 0x16076C0 Offset: 0x1605CC0 VA: 0x1816076C0
	internal void .ctor() { }

	// RVA: 0x16076B0 Offset: 0x1605CB0 VA: 0x1816076B0 Slot: 6
	public void Invoke(Task completingTask) { }

}

private sealed class Task.DelayPromise : Task<VoidTaskResult> // TypeDefIndex: 856
{	// Fields
	internal readonly CancellationToken Token; // 0x58
	internal CancellationTokenRegistration Registration; // 0x60
	internal Timer Timer; // 0x78

	// Methods

	// RVA: 0x1606300 Offset: 0x1604900 VA: 0x181606300
	internal void .ctor(CancellationToken token) { }

	// RVA: 0x1606170 Offset: 0x1604770 VA: 0x181606170
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
	|-RVA: 0x136AA90 Offset: 0x1369090 VA: 0x18136AA90
	|-Task.WhenAllPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void Invoke(Task ignored) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x136A720 Offset: 0x1368D20 VA: 0x18136A720
	|-Task.WhenAllPromise<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override bool get_ShouldNotifyDebuggerOfWaitCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x136AC90 Offset: 0x1369290 VA: 0x18136AC90
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

	// RVA: 0x161BC40 Offset: 0x161A240 VA: 0x18161BC40
	internal void <ExecuteSelfReplicating>b__0(object <p0>) { }

}

private sealed class Task.<>c // TypeDefIndex: 859
{	// Fields
	public static readonly Task.<>c <>9; // 0x0
	public static Action<object> <>9__276_0; // 0x8
	public static TimerCallback <>9__276_1; // 0x10

	// Methods

	// RVA: 0x161C0E0 Offset: 0x161A6E0 VA: 0x18161C0E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x161BA90 Offset: 0x161A090 VA: 0x18161BA90
	internal void <Delay>b__276_0(object state) { }

	// RVA: 0x161BAF0 Offset: 0x161A0F0 VA: 0x18161BAF0
	internal void <Delay>b__276_1(object state) { }

	// RVA: 0x161BBD0 Offset: 0x161A1D0 VA: 0x18161BBD0
	internal Task.ContingentProperties <.cctor>b__295_0() { }

	// RVA: 0x161BC20 Offset: 0x161A220 VA: 0x18161BC20
	internal bool <.cctor>b__295_1(Task t) { }

	// RVA: 0xDF02D0 Offset: 0xDEE8D0 VA: 0x180DF02D0
	internal bool <.cctor>b__295_2(object tc) { }

}

