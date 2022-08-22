public sealed class AsyncCallback : MulticastDelegate // TypeDefIndex: 173
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A3B0 Offset: 0x4989B0 VA: 0x18049A3B0 Slot: 12
	public virtual void Invoke(IAsyncResult ar) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AsyncLocal<T> : IAsyncLocal // TypeDefIndex: 774
{	// Fields
	private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1359F10 Offset: 0x1358510 VA: 0x181359F10
	|-AsyncLocal<ActivityTracker.ActivityInfo>..ctor
	|-AsyncLocal<CultureInfo>..ctor
	|-AsyncLocal<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1359F50 Offset: 0x1358550 VA: 0x181359F50
	|-AsyncLocal<ActivityTracker.ActivityInfo>.get_Value
	|-AsyncLocal<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x135A000 Offset: 0x1358600 VA: 0x18135A000
	|-AsyncLocal<ActivityTracker.ActivityInfo>.set_Value
	|-AsyncLocal<CultureInfo>.set_Value
	|-AsyncLocal<object>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1359D70 Offset: 0x1358370 VA: 0x181359D70
	|-AsyncLocal<object>.System.Threading.IAsyncLocal.OnValueChanged
	*/

}

public struct AsyncLocalValueChangedArgs<T> // TypeDefIndex: 776
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T <PreviousValue>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T <CurrentValue>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <ThreadContextChanged>k__BackingField; // 0x0

	// Properties
	public T PreviousValue { get; set; }
	public T CurrentValue { get; set; }
	private bool ThreadContextChanged { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public T get_PreviousValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	|-AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo>.get_PreviousValue
	|-AsyncLocalValueChangedArgs<object>.get_PreviousValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private void set_PreviousValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	|-AsyncLocalValueChangedArgs<object>.set_PreviousValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public T get_CurrentValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	|-AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo>.get_CurrentValue
	|-AsyncLocalValueChangedArgs<CultureInfo>.get_CurrentValue
	|-AsyncLocalValueChangedArgs<object>.get_CurrentValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private void set_CurrentValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF14A0 Offset: 0xF08A0 VA: 0x1800F14A0
	|-AsyncLocalValueChangedArgs<object>.set_CurrentValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private void set_ThreadContextChanged(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2360 Offset: 0x1E1760 VA: 0x1801E2360
	|-AsyncLocalValueChangedArgs<object>.set_ThreadContextChanged
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T previousValue, T currentValue, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2350 Offset: 0x1E1750 VA: 0x1801E2350
	|-AsyncLocalValueChangedArgs<object>..ctor
	*/

}

internal enum AsyncCausalityStatus // TypeDefIndex: 838
{	// Fields
	public int value__; // 0x0
	public const AsyncCausalityStatus Started = 0;
	public const AsyncCausalityStatus Completed = 1;
	public const AsyncCausalityStatus Canceled = 2;
	public const AsyncCausalityStatus Error = 3;

}

internal static class AsyncCausalityTracer // TypeDefIndex: 841
{	// Properties
	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static bool LoggingOn { get; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void TraceOperationRelation(CausalityTraceLevel traceLevel, int taskId, CausalityRelation relation) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

}

internal class AsyncRequest // TypeDefIndex: 1193
{	// Fields
	internal IMessageSink ReplySink; // 0x10
	internal IMessage MsgRequest; // 0x18

	// Methods

	// RVA: 0xFDC360 Offset: 0xFDA960 VA: 0x180FDC360
	public void .ctor(IMessage msgRequest, IMessageSink replySink) { }

}

public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1223
{	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x146EC20 Offset: 0x146D220 VA: 0x18146EC20
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x146EB20 Offset: 0x146D120 VA: 0x18146EB20
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x146ED20 Offset: 0x146D320 VA: 0x18146ED20 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x8C1050 Offset: 0x8BF650 VA: 0x1808C1050 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x1160330 Offset: 0x115E930 VA: 0x181160330
	public bool get_EndInvokeCalled() { }

	// RVA: 0x1160740 Offset: 0x115ED40 VA: 0x181160740
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x146E790 Offset: 0x146CD90 VA: 0x18146E790 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x78E170 Offset: 0x78C770 VA: 0x18078E170
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x146E7E0 Offset: 0x146CDE0 VA: 0x18146E7E0
	internal IMessage EndInvoke() { }

	// RVA: 0x146E910 Offset: 0x146CF10 VA: 0x18146E910 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x146E900 Offset: 0x146CF00 VA: 0x18146E900 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x146E900 Offset: 0x146CF00 VA: 0x18146E900
	internal object Invoke() { }

	// RVA: 0x146EBB0 Offset: 0x146D1B0 VA: 0x18146EBB0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x146EA70 Offset: 0x146D070 VA: 0x18146EA70
	private void <.ctor>b__17_0(object <p0>) { }

}

public struct AsyncVoidMethodBuilder // TypeDefIndex: 1273
{	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x8
	private Task m_task; // 0x18

	// Properties
	private Task Task { get; }

	// Methods

	// RVA: 0xFDC7B0 Offset: 0xFDADB0 VA: 0x180FDC7B0
	public static AsyncVoidMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B880 Offset: 0x13AC80 VA: 0x18013B880
	|-AsyncVoidMethodBuilder.Start<CompanionSetupScreen.<Disable>d__26>
	|
	|-RVA: 0x13B890 Offset: 0x13AC90 VA: 0x18013B890
	|-AsyncVoidMethodBuilder.Start<CompanionSetupScreen.<Enable>d__25>
	|
	|-RVA: 0x13B920 Offset: 0x13AD20 VA: 0x18013B920
	|-AsyncVoidMethodBuilder.Start<CompanionSetupScreen.<RefreshImpl>d__24>
	|
	|-RVA: 0x13B8C0 Offset: 0x13ACC0 VA: 0x18013B8C0
	|-AsyncVoidMethodBuilder.Start<ConnectionScreen.<LoadServerInfo>d__13>
	|
	|-RVA: 0x13B8D0 Offset: 0x13ACD0 VA: 0x18013B8D0
	|-AsyncVoidMethodBuilder.Start<ConnectionScreen.<LoadServerRules>d__14>
	|
	|-RVA: 0x13B870 Offset: 0x13AC70 VA: 0x18013B870
	|-AsyncVoidMethodBuilder.Start<ItemStore.<Checkout>d__24>
	|
	|-RVA: 0x13B930 Offset: 0x13AD30 VA: 0x18013B930
	|-AsyncVoidMethodBuilder.Start<ItemStore.<RefreshList>d__17>
	|
	|-RVA: 0x13B980 Offset: 0x13AD80 VA: 0x18013B980
	|-AsyncVoidMethodBuilder.Start<LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|56_0>d>
	|
	|-RVA: 0x13B8B0 Offset: 0x13ACB0 VA: 0x18013B8B0
	|-AsyncVoidMethodBuilder.Start<SteamPlatform.<LoadAvatarFromSteamAsync>d__1>
	|
	|-RVA: 0x13B8A0 Offset: 0x13ACA0 VA: 0x18013B8A0
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<EventImpl>d__40>
	|
	|-RVA: 0x13B8F0 Offset: 0x13ACF0 VA: 0x18013B8F0
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<PulseColorImpl>d__38>
	|
	|-RVA: 0x13B940 Offset: 0x13AD40 VA: 0x18013B940
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<SendHeartbeatAndWait>d__34>
	|
	|-RVA: 0x13B970 Offset: 0x13AD70 VA: 0x18013B970
	|-AsyncVoidMethodBuilder.Start<RestRgbService.<StaticColorImpl>d__36>
	|
	|-RVA: 0x13B9A0 Offset: 0x13ADA0 VA: 0x18013B9A0
	|-AsyncVoidMethodBuilder.Start<RgbController.<Worker>d__14>
	|
	|-RVA: 0x13B960 Offset: 0x13AD60 VA: 0x18013B960
	|-AsyncVoidMethodBuilder.Start<ReportBug.<SendReport>d__29>
	|
	|-RVA: 0x13B950 Offset: 0x13AD50 VA: 0x18013B950
	|-AsyncVoidMethodBuilder.Start<ReportPlayer.<SendReport>d__21>
	|
	|-RVA: 0x13B900 Offset: 0x13AD00 VA: 0x18013B900
	|-AsyncVoidMethodBuilder.Start<ServerBrowserInfo.<QueryRules>d__19>
	|
	|-RVA: 0x13B910 Offset: 0x13AD10 VA: 0x18013B910
	|-AsyncVoidMethodBuilder.Start<ShoutcastStreamer.<ReadData>d__46>
	|
	|-RVA: 0x13B990 Offset: 0x13AD90 VA: 0x18013B990
	|-AsyncVoidMethodBuilder.Start<SteamUserButton.<UpdateFromUser>d__14>
	|
	|-RVA: 0x13B8E0 Offset: 0x13ACE0 VA: 0x18013B8E0
	|-AsyncVoidMethodBuilder.Start<Dispatch.<LoopClientAsync>d__22>
	|
	|-RVA: 0x13B860 Offset: 0x13AC60 VA: 0x18013B860
	|-AsyncVoidMethodBuilder.Start<object>
	*/

	// RVA: 0x14BEF0 Offset: 0x14B2F0 VA: 0x18014BEF0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B700 Offset: 0x13AB00 VA: 0x18013B700
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x13B7E0 Offset: 0x13ABE0 VA: 0x18013B7E0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CompanionSetupScreen.<Disable>d__26>
	|
	|-RVA: 0x13B7F0 Offset: 0x13ABF0 VA: 0x18013B7F0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CompanionSetupScreen.<Enable>d__25>
	|
	|-RVA: 0x13B800 Offset: 0x13AC00 VA: 0x18013B800
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<EventImpl>d__40>
	|
	|-RVA: 0x13B820 Offset: 0x13AC20 VA: 0x18013B820
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<PulseColorImpl>d__38>
	|
	|-RVA: 0x13B830 Offset: 0x13AC30 VA: 0x18013B830
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<SendHeartbeatAndWait>d__34>
	|
	|-RVA: 0x13B840 Offset: 0x13AC40 VA: 0x18013B840
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<StaticColorImpl>d__36>
	|
	|-RVA: 0x13B810 Offset: 0x13AC10 VA: 0x18013B810
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Dispatch.<LoopClientAsync>d__22>
	|
	|-RVA: 0x13B760 Offset: 0x13AB60 VA: 0x18013B760
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<CompanionSubscription.Status>, CompanionSetupScreen.<RefreshImpl>d__24>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSetupScreen.<RefreshImpl>d__24>
	|
	|-RVA: 0x13B7B0 Offset: 0x13ABB0 VA: 0x18013B7B0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInfo>, SteamUserButton.<UpdateFromUser>d__14>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamUserButton.<UpdateFromUser>d__14>
	|
	|-RVA: 0x13B7D0 Offset: 0x13ABD0 VA: 0x18013B7D0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, RestRgbService.<SendHeartbeatAndWait>d__34>
	|
	|-RVA: 0x13B7C0 Offset: 0x13ABC0 VA: 0x18013B7C0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ShoutcastStreamer.<ReadData>d__46>
	|
	|-RVA: 0x13B740 Offset: 0x13AB40 VA: 0x18013B740
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ConnectionScreen.<LoadServerRules>d__14>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ConnectionScreen.<LoadServerRules>d__14>
	|
	|-RVA: 0x13B750 Offset: 0x13AB50 VA: 0x18013B750
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerBrowserInfo.<QueryRules>d__19>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerBrowserInfo.<QueryRules>d__19>
	|
	|-RVA: 0x13B770 Offset: 0x13AB70 VA: 0x18013B770
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IPlayerItemDefinition>>, ItemStore.<RefreshList>d__17>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ItemStore.<RefreshList>d__17>
	|
	|-RVA: 0x13B730 Offset: 0x13AB30 VA: 0x18013B730
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ServerInfo>>, ConnectionScreen.<LoadServerInfo>d__13>
	|
	|-RVA: 0x13B720 Offset: 0x13AB20 VA: 0x18013B720
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<Image>>, SteamPlatform.<LoadAvatarFromSteamAsync>d__1>
	|
	|-RVA: 0x13B710 Offset: 0x13AB10 VA: 0x18013B710
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryPurchaseResult>>, ItemStore.<Checkout>d__24>
	|
	|-RVA: 0x13B7A0 Offset: 0x13ABA0 VA: 0x18013B7A0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|56_0>d>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|56_0>d>
	|
	|-RVA: 0x13B790 Offset: 0x13AB90 VA: 0x18013B790
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ReportBug.<SendReport>d__29>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, ReportBug.<SendReport>d__29>
	|
	|-RVA: 0x13B780 Offset: 0x13AB80 VA: 0x18013B780
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ReportPlayer.<SendReport>d__21>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, ReportPlayer.<SendReport>d__21>
	|
	|-RVA: 0x13B850 Offset: 0x13AC50 VA: 0x18013B850
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<Worker>d__14>
	*/

	// RVA: 0x14BE90 Offset: 0x14B290 VA: 0x18014BE90
	public void SetResult() { }

	// RVA: 0x14BE80 Offset: 0x14B280 VA: 0x18014BE80
	public void SetException(Exception exception) { }

	// RVA: 0x14BE70 Offset: 0x14B270 VA: 0x18014BE70
	private void NotifySynchronizationContextOfCompletion() { }

	// RVA: 0x14BFB0 Offset: 0x14B3B0 VA: 0x18014BFB0
	private Task get_Task() { }

}

public struct AsyncTaskMethodBuilder // TypeDefIndex: 1274
{	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0xDA8390 Offset: 0xDA6990 VA: 0x180DA8390
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121C40 Offset: 0x121040 VA: 0x180121C40
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<Report>d__11>
	|
	|-RVA: 0x121C60 Offset: 0x121060 VA: 0x180121C60
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunAsync>d__7>
	|
	|-RVA: 0x121C70 Offset: 0x121070 VA: 0x180121C70
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunBenchmarkScene>d__9>
	|
	|-RVA: 0x121C80 Offset: 0x121080 VA: 0x180121C80
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunBenchmarksInScene>d__10>
	|
	|-RVA: 0x121C90 Offset: 0x121090 VA: 0x180121C90
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunDemoBasedBenchmark>d__12>
	|
	|-RVA: 0x121CA0 Offset: 0x1210A0 VA: 0x180121CA0
	|-AsyncTaskMethodBuilder.Start<Benchmarking.<RunSingleSceneAsync>d__8>
	|
	|-RVA: 0x121AD0 Offset: 0x120ED0 VA: 0x180121AD0
	|-AsyncTaskMethodBuilder.Start<Client.<Connect>d__37>
	|
	|-RVA: 0x121AA0 Offset: 0x120EA0 VA: 0x180121AA0
	|-AsyncTaskMethodBuilder.Start<CompanionSubscription.<Add>d__6>
	|
	|-RVA: 0x121C30 Offset: 0x121030 VA: 0x180121C30
	|-AsyncTaskMethodBuilder.Start<CompanionSubscription.<Remove>d__7>
	|
	|-RVA: 0x121B90 Offset: 0x120F90 VA: 0x180121B90
	|-AsyncTaskMethodBuilder.Start<EAC.<OnJoinServer>d__16>
	|
	|-RVA: 0x121BE0 Offset: 0x120FE0 VA: 0x180121BE0
	|-AsyncTaskMethodBuilder.Start<Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x121C10 Offset: 0x121010 VA: 0x180121C10
	|-AsyncTaskMethodBuilder.Start<Account.<Refresh>d__6>
	|
	|-RVA: 0x121BC0 Offset: 0x120FC0 VA: 0x180121BC0
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x121B60 Offset: 0x120F60 VA: 0x180121B60
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x121BB0 Offset: 0x120FB0 VA: 0x180121BB0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x121B70 Offset: 0x120F70 VA: 0x180121B70
	|-AsyncTaskMethodBuilder.Start<SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x121D40 Offset: 0x121140 VA: 0x180121D40
	|-AsyncTaskMethodBuilder.Start<RestRgbService.<Start>d__31>
	|
	|-RVA: 0x121D60 Offset: 0x121160 VA: 0x180121D60
	|-AsyncTaskMethodBuilder.Start<RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x121D80 Offset: 0x121180 VA: 0x180121D80
	|-AsyncTaskMethodBuilder.Start<RestRgbService.<Update>d__33>
	|
	|-RVA: 0x121D30 Offset: 0x121130 VA: 0x180121D30
	|-AsyncTaskMethodBuilder.Start<RgbController.<StartServices>d__15>
	|
	|-RVA: 0x121D50 Offset: 0x121150 VA: 0x180121D50
	|-AsyncTaskMethodBuilder.Start<RgbController.<StopServices>d__16>
	|
	|-RVA: 0x121D70 Offset: 0x121170 VA: 0x180121D70
	|-AsyncTaskMethodBuilder.Start<RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x121CB0 Offset: 0x1210B0 VA: 0x180121CB0
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendEvent>d__15>
	|
	|-RVA: 0x121CC0 Offset: 0x1210C0 VA: 0x180121CC0
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|
	|-RVA: 0x121CD0 Offset: 0x1210D0 VA: 0x180121CD0
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|
	|-RVA: 0x121CE0 Offset: 0x1210E0 VA: 0x180121CE0
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|
	|-RVA: 0x121D20 Offset: 0x121120 VA: 0x180121D20
	|-AsyncTaskMethodBuilder.Start<SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x121D00 Offset: 0x121100 VA: 0x180121D00
	|-AsyncTaskMethodBuilder.Start<Hero.<ShowAsync>d__10>
	|
	|-RVA: 0x121B20 Offset: 0x120F20 VA: 0x180121B20
	|-AsyncTaskMethodBuilder.Start<SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x121AF0 Offset: 0x120EF0 VA: 0x180121AF0
	|-AsyncTaskMethodBuilder.Start<SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x121B50 Offset: 0x120F50 VA: 0x180121B50
	|-AsyncTaskMethodBuilder.Start<SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x121C20 Offset: 0x121020 VA: 0x180121C20
	|-AsyncTaskMethodBuilder.Start<SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x121BA0 Offset: 0x120FA0 VA: 0x180121BA0
	|-AsyncTaskMethodBuilder.Start<SteamInventoryNewItem.<Open>d__0>
	|
	|-RVA: 0x121B00 Offset: 0x120F00 VA: 0x180121B00
	|-AsyncTaskMethodBuilder.Start<Publisher.<DoExport>d__15>
	|
	|-RVA: 0x121B10 Offset: 0x120F10 VA: 0x180121B10
	|-AsyncTaskMethodBuilder.Start<Publisher.<DoExport>d__21>
	|
	|-RVA: 0x121B30 Offset: 0x120F30 VA: 0x180121B30
	|-AsyncTaskMethodBuilder.Start<Publisher.<ExportTexture>d__19>
	|
	|-RVA: 0x121B40 Offset: 0x120F40 VA: 0x180121B40
	|-AsyncTaskMethodBuilder.Start<Publisher.<ExportToFolder>d__16>
	|
	|-RVA: 0x121BD0 Offset: 0x120FD0 VA: 0x180121BD0
	|-AsyncTaskMethodBuilder.Start<Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x121BF0 Offset: 0x120FF0 VA: 0x180121BF0
	|-AsyncTaskMethodBuilder.Start<WorkshopItemList.<Refresh>d__26>
	|
	|-RVA: 0x121C00 Offset: 0x121000 VA: 0x180121C00
	|-AsyncTaskMethodBuilder.Start<ServerHistory.<Refresh>d__4>
	|
	|-RVA: 0x121AC0 Offset: 0x120EC0 VA: 0x180121AC0
	|-AsyncTaskMethodBuilder.Start<ShoutcastStream.<ConnectAsync>d__42>
	|
	|-RVA: 0x121D10 Offset: 0x121110 VA: 0x180121D10
	|-AsyncTaskMethodBuilder.Start<ShoutcastStream.<ShutdownSafely>d__54>
	|
	|-RVA: 0x121C50 Offset: 0x121050 VA: 0x180121C50
	|-AsyncTaskMethodBuilder.Start<Friend.<RequestInfoAsync>d__13>
	|
	|-RVA: 0x121CF0 Offset: 0x1210F0 VA: 0x180121CF0
	|-AsyncTaskMethodBuilder.Start<SourceServerQuery.<Send>d__8>
	|
	|-RVA: 0x121AB0 Offset: 0x120EB0 VA: 0x180121AB0
	|-AsyncTaskMethodBuilder.Start<SteamFriends.<CacheUserInformationAsync>d__51>
	|
	|-RVA: 0x121AE0 Offset: 0x120EE0 VA: 0x180121AE0
	|-AsyncTaskMethodBuilder.Start<Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x121B80 Offset: 0x120F80 VA: 0x180121B80
	|-AsyncTaskMethodBuilder.Start<HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-RVA: 0x121A90 Offset: 0x120E90 VA: 0x180121A90
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x121D90 Offset: 0x121190 VA: 0x180121D90
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: 0x14BDC0 Offset: 0x14B1C0 VA: 0x18014BDC0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1238C0 Offset: 0x122CC0 VA: 0x1801238C0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x1238B0 Offset: 0x122CB0 VA: 0x1801238B0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123950 Offset: 0x122D50 VA: 0x180123950
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x123920 Offset: 0x122D20 VA: 0x180123920
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x123900 Offset: 0x122D00 VA: 0x180123900
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x1238F0 Offset: 0x122CF0 VA: 0x1801238F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x123910 Offset: 0x122D10 VA: 0x180123910
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-RVA: 0x123930 Offset: 0x122D30 VA: 0x180123930
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x123940 Offset: 0x122D40 VA: 0x180123940
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x1238D0 Offset: 0x122CD0 VA: 0x1801238D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x1238E0 Offset: 0x122CE0 VA: 0x1801238E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x123B50 Offset: 0x122F50 VA: 0x180123B50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunAsync>d__7>
	|
	|-RVA: 0x123B60 Offset: 0x122F60 VA: 0x180123B60
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarkScene>d__9>
	|
	|-RVA: 0x123B70 Offset: 0x122F70 VA: 0x180123B70
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarksInScene>d__10>
	|
	|-RVA: 0x123B80 Offset: 0x122F80 VA: 0x180123B80
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunDemoBasedBenchmark>d__12>
	|
	|-RVA: 0x123B90 Offset: 0x122F90 VA: 0x180123B90
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunSingleSceneAsync>d__8>
	|
	|-RVA: 0x123A70 Offset: 0x122E70 VA: 0x180123A70
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Client.<Connect>d__37>
	|
	|-RVA: 0x123B10 Offset: 0x122F10 VA: 0x180123B10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x123AF0 Offset: 0x122EF0 VA: 0x180123AF0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x123BB0 Offset: 0x122FB0 VA: 0x180123BB0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Start>d__31>
	|
	|-RVA: 0x123BC0 Offset: 0x122FC0 VA: 0x180123BC0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x123AB0 Offset: 0x122EB0 VA: 0x180123AB0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x123A80 Offset: 0x122E80 VA: 0x180123A80
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x123AE0 Offset: 0x122EE0 VA: 0x180123AE0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x123B30 Offset: 0x122F30 VA: 0x180123B30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x123B00 Offset: 0x122F00 VA: 0x180123B00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryNewItem.<Open>d__0>
	|
	|-RVA: 0x123A90 Offset: 0x122E90 VA: 0x180123A90
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__15>
	|
	|-RVA: 0x123AA0 Offset: 0x122EA0 VA: 0x180123AA0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__21>
	|
	|-RVA: 0x123AC0 Offset: 0x122EC0 VA: 0x180123AC0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportTexture>d__19>
	|
	|-RVA: 0x123AD0 Offset: 0x122ED0 VA: 0x180123AD0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportToFolder>d__16>
	|
	|-RVA: 0x123B20 Offset: 0x122F20 VA: 0x180123B20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, ServerHistory.<Refresh>d__4>
	|
	|-RVA: 0x123BA0 Offset: 0x122FA0 VA: 0x180123BA0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, ShoutcastStream.<ShutdownSafely>d__54>
	|
	|-RVA: 0x123B40 Offset: 0x122F40 VA: 0x180123B40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Friend.<RequestInfoAsync>d__13>
	|
	|-RVA: 0x123A60 Offset: 0x122E60 VA: 0x180123A60
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, SteamFriends.<CacheUserInformationAsync>d__51>
	|
	|-RVA: 0x123990 Offset: 0x122D90 VA: 0x180123990
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, CompanionSubscription.<Add>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, CompanionSubscription.<Add>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Add>d__6>
	|
	|-RVA: 0x1239D0 Offset: 0x122DD0 VA: 0x1801239D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, CompanionSubscription.<Remove>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, CompanionSubscription.<Remove>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Remove>d__7>
	|
	|-RVA: 0x1239B0 Offset: 0x122DB0 VA: 0x1801239B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, Account.<ReadAllNotices>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<ReadAllNotices>d__7>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x1239C0 Offset: 0x122DC0 VA: 0x1801239C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, Account.<Refresh>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<Refresh>d__6>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Account.<Refresh>d__6>
	|
	|-RVA: 0x1219E0 Offset: 0x120DE0 VA: 0x1801219E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInventory>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInventory[]>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x1219F0 Offset: 0x120DF0 VA: 0x1801219F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<IPlayerInventory>, SteamInventoryManager.<Refresh>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x1219C0 Offset: 0x120DC0 VA: 0x1801219C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<MP3Stream>, ShoutcastStream.<ConnectAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, ShoutcastStream.<ConnectAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, ShoutcastStream.<ConnectAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ShoutcastStream.<ConnectAsync>d__42>
	|
	|-RVA: 0x123960 Offset: 0x122D60 VA: 0x180123960
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<PublishResult>, Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x1239A0 Offset: 0x122DA0 VA: 0x1801239A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, EAC.<OnJoinServer>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EAC.<OnJoinServer>d__16>
	|
	|-RVA: 0x123980 Offset: 0x122D80 VA: 0x180123980
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SourceServerQuery.<Send>d__8>
	|
	|-RVA: 0x1239F0 Offset: 0x122DF0 VA: 0x1801239F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendEvent>d__15>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendEvent>d__15>
	|
	|-RVA: 0x123A00 Offset: 0x122E00 VA: 0x180123A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|
	|-RVA: 0x123A10 Offset: 0x122E10 VA: 0x180123A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|
	|-RVA: 0x121A00 Offset: 0x120E00 VA: 0x180121A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|
	|-RVA: 0x123A50 Offset: 0x122E50 VA: 0x180123A50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x123A30 Offset: 0x122E30 VA: 0x180123A30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x123A40 Offset: 0x122E40 VA: 0x180123A40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x123970 Offset: 0x122D70 VA: 0x180123970
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<Item>>, Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x123A20 Offset: 0x122E20 VA: 0x180123A20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ResultPage>>, WorkshopItemList.<Refresh>d__26>
	|
	|-RVA: 0x1239E0 Offset: 0x122DE0 VA: 0x1801239E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Benchmarking.<Report>d__11>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Benchmarking.<Report>d__11>
	|
	|-RVA: 0x121A20 Offset: 0x120E20 VA: 0x180121A20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x121A10 Offset: 0x120E10 VA: 0x180121A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Hero.<ShowAsync>d__10>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Hero.<ShowAsync>d__10>
	|
	|-RVA: 0x1219D0 Offset: 0x120DD0 VA: 0x1801219D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Publisher.<DoExport>d__21>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Publisher.<DoExport>d__21>
	|
	|-RVA: 0x121A60 Offset: 0x120E60 VA: 0x180121A60
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x121A80 Offset: 0x120E80 VA: 0x180121A80
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Update>d__33>
	|
	|-RVA: 0x121A40 Offset: 0x120E40 VA: 0x180121A40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StartServices>d__15>
	|
	|-RVA: 0x121A50 Offset: 0x120E50 VA: 0x180121A50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StopServices>d__16>
	|
	|-RVA: 0x121A70 Offset: 0x120E70 VA: 0x180121A70
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x121A30 Offset: 0x120E30 VA: 0x180121A30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, RestRgbService.<Start>d__31>
	*/

	// RVA: 0x14BE10 Offset: 0x14B210 VA: 0x18014BE10
	public Task get_Task() { }

	// RVA: 0x14BD50 Offset: 0x14B150 VA: 0x18014BD50
	public void SetResult() { }

	// RVA: 0x14BD00 Offset: 0x14B100 VA: 0x18014BD00
	public void SetException(Exception exception) { }

	// RVA: 0xFDC700 Offset: 0xFDAD00 VA: 0x180FDC700
	private static void .cctor() { }

}

public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 1275
{	// Fields
	internal static readonly Task<TResult> s_defaultResultTask; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x0
	private Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDA8390 Offset: 0xDA6990 VA: 0x180DA8390
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.Create
	|-AsyncTaskMethodBuilder<IAuthTicket>.Create
	|-AsyncTaskMethodBuilder<IPlayerInfo>.Create
	|-AsyncTaskMethodBuilder<IPlayerInventory>.Create
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.Create
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.Create
	|-AsyncTaskMethodBuilder<AuthTicket>.Create
	|-AsyncTaskMethodBuilder<InventoryDef[]>.Create
	|-AsyncTaskMethodBuilder<PublishResult>.Create
	|-AsyncTaskMethodBuilder<byte[]>.Create
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Create
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.Create
	|-AsyncTaskMethodBuilder<Stream>.Create
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.Create
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.Create
	|-AsyncTaskMethodBuilder<Nullable<Image>>.Create
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.Create
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Create
	|-AsyncTaskMethodBuilder<Nullable<Result>>.Create
	|-AsyncTaskMethodBuilder<Nullable<Item>>.Create
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.Create
	|-AsyncTaskMethodBuilder<Nullable<int>>.Create
	|-AsyncTaskMethodBuilder<string>.Create
	|-AsyncTaskMethodBuilder<bool>.Create
	|-AsyncTaskMethodBuilder<int>.Create
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.Create
	|-AsyncTaskMethodBuilder<object>.Create
	|-AsyncTaskMethodBuilder<VoidTaskResult>.Create
	*/

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121720 Offset: 0x120B20 VA: 0x180121720
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.Start<CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<object>.Start<CompanionSubscription.<CheckStatus>d__5>
	|
	|-RVA: 0x1217A0 Offset: 0x120BA0 VA: 0x1801217A0
	|-AsyncTaskMethodBuilder<IAuthTicket>.Start<SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|
	|-RVA: 0x1217E0 Offset: 0x120BE0 VA: 0x1801217E0
	|-AsyncTaskMethodBuilder<IPlayerInfo>.Start<SteamPlatform.<GetPlayerInformationAsync>d__57>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<GetPlayerInformationAsync>d__57>
	|
	|-RVA: 0x121760 Offset: 0x120B60 VA: 0x180121760
	|-AsyncTaskMethodBuilder<IPlayerInventory>.Start<SteamPlatform.<CraftItem>d__20>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<CraftItem>d__20>
	|
	|-RVA: 0x1218A0 Offset: 0x120CA0 VA: 0x1801218A0
	|-AsyncTaskMethodBuilder<IPlayerInventory>.Start<SteamPlatform.<RefreshAndGetItems>d__19>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<RefreshAndGetItems>d__19>
	|
	|-RVA: 0x121940 Offset: 0x120D40 VA: 0x180121940
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x13B3D0 Offset: 0x13A7D0 VA: 0x18013B3D0
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.Start<SteamInventoryCrafting.<GetMarketPrice>d__29>
	|-AsyncTaskMethodBuilder<object>.Start<SteamInventoryCrafting.<GetMarketPrice>d__29>
	|
	|-RVA: 0x13B3C0 Offset: 0x13A7C0 VA: 0x18013B3C0
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.Start<SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|-AsyncTaskMethodBuilder<object>.Start<SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|
	|-RVA: 0x13B380 Offset: 0x13A780 VA: 0x18013B380
	|-AsyncTaskMethodBuilder<AuthTicket>.Start<SteamUser.<GetAuthSessionTicketAsync>d__54>
	|-AsyncTaskMethodBuilder<object>.Start<SteamUser.<GetAuthSessionTicketAsync>d__54>
	|
	|-RVA: 0x13B3A0 Offset: 0x13A7A0 VA: 0x18013B3A0
	|-AsyncTaskMethodBuilder<InventoryDef[]>.Start<SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|-AsyncTaskMethodBuilder<object>.Start<SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|
	|-RVA: 0x121970 Offset: 0x120D70 VA: 0x180121970
	|-AsyncTaskMethodBuilder<PublishResult>.Start<Editor.<SubmitAsync>d__40>
	|
	|-RVA: 0x121800 Offset: 0x120C00 VA: 0x180121800
	|-AsyncTaskMethodBuilder<bool>.Start<SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-RVA: 0x121880 Offset: 0x120C80 VA: 0x180121880
	|-AsyncTaskMethodBuilder<bool>.Start<ShoutcastStream.<ReadDataAsync>d__43>
	|
	|-RVA: 0x121890 Offset: 0x120C90 VA: 0x180121890
	|-AsyncTaskMethodBuilder<bool>.Start<ShoutcastStream.<ReadDataAsync>d__44>
	|
	|-RVA: 0x1218C0 Offset: 0x120CC0 VA: 0x1801218C0
	|-AsyncTaskMethodBuilder<bool>.Start<Base.<RunQueryAsync>d__15>
	|
	|-RVA: 0x1218D0 Offset: 0x120CD0 VA: 0x1801218D0
	|-AsyncTaskMethodBuilder<bool>.Start<IpList.<RunQueryAsync>d__4>
	|
	|-RVA: 0x1219B0 Offset: 0x120DB0 VA: 0x1801219B0
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x13B390 Offset: 0x13A790 VA: 0x18013B390
	|-AsyncTaskMethodBuilder<byte[]>.Start<SourceServerQuery.<GetChallengeData>d__7>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<GetChallengeData>d__7>
	|
	|-RVA: 0x13B470 Offset: 0x13A870 VA: 0x18013B470
	|-AsyncTaskMethodBuilder<byte[]>.Start<SourceServerQuery.<Receive>d__6>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<Receive>d__6>
	|
	|-RVA: 0x13B480 Offset: 0x13A880 VA: 0x18013B480
	|-AsyncTaskMethodBuilder<byte[]>.Start<SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|-AsyncTaskMethodBuilder<object>.Start<SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|
	|-RVA: 0x13B430 Offset: 0x13A830 VA: 0x18013B430
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<ServerInfoExtensions.<QueryRulesAsync>d__0>
	|-AsyncTaskMethodBuilder<object>.Start<ServerInfoExtensions.<QueryRulesAsync>d__0>
	|
	|-RVA: 0x13B420 Offset: 0x13A820 VA: 0x18013B420
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<ServerInfoHelpers.<LoadRules>d__1>
	|-AsyncTaskMethodBuilder<object>.Start<ServerInfoHelpers.<LoadRules>d__1>
	|
	|-RVA: 0x13B440 Offset: 0x13A840 VA: 0x18013B440
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<ServerInfo.<QueryRulesAsync>d__85>
	|-AsyncTaskMethodBuilder<object>.Start<ServerInfo.<QueryRulesAsync>d__85>
	|
	|-RVA: 0x13B400 Offset: 0x13A800 VA: 0x18013B400
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<SourceServerQuery.<GetRules>d__5>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<GetRules>d__5>
	|
	|-RVA: 0x13B3F0 Offset: 0x13A7F0 VA: 0x18013B3F0
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.Start<SourceServerQuery.<GetRulesImpl>d__4>
	|-AsyncTaskMethodBuilder<object>.Start<SourceServerQuery.<GetRulesImpl>d__4>
	|
	|-RVA: 0x1217B0 Offset: 0x120BB0 VA: 0x1801217B0
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.Start<SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|-AsyncTaskMethodBuilder<object>.Start<SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|
	|-RVA: 0x13B370 Offset: 0x13A770 VA: 0x18013B370
	|-AsyncTaskMethodBuilder<Stream>.Start<HttpContent.<CreateContentReadStreamAsync>d__12>
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<CreateContentReadStreamAsync>d__12>
	|
	|-RVA: 0x13B450 Offset: 0x13A850 VA: 0x18013B450
	|-AsyncTaskMethodBuilder<Stream>.Start<HttpContent.<ReadAsStreamAsync>d__18>
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsStreamAsync>d__18>
	|
	|-RVA: 0x13B3E0 Offset: 0x13A7E0 VA: 0x18013B3E0
	|-AsyncTaskMethodBuilder<Stream>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x121820 Offset: 0x120C20 VA: 0x180121820
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x121950 Offset: 0x120D50 VA: 0x180121950
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-RVA: 0x121870 Offset: 0x120C70 VA: 0x180121870
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x13B4B0 Offset: 0x13A8B0 VA: 0x18013B4B0
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.Start<HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.Start<HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0x13B4A0 Offset: 0x13A8A0 VA: 0x18013B4A0
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.Start<HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.Start<HttpClientHandler.<SendAsync>d__64>
	|
	|-RVA: 0x121830 Offset: 0x120C30 VA: 0x180121830
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.Start<ServerInfoHelpers.<Load>d__0>
	|
	|-RVA: 0x1217C0 Offset: 0x120BC0 VA: 0x1801217C0
	|-AsyncTaskMethodBuilder<Nullable<Image>>.Start<SteamFriends.<GetMediumAvatarAsync>d__53>
	|
	|-RVA: 0x121960 Offset: 0x120D60 VA: 0x180121960
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.Start<SteamInventory.<StartPurchaseAsync>d__39>
	|
	|-RVA: 0x121710 Offset: 0x120B10 VA: 0x180121710
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryItem.<AddAsync>d__23>
	|
	|-RVA: 0x121730 Offset: 0x120B30 VA: 0x180121730
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryItem.<ConsumeAsync>d__21>
	|
	|-RVA: 0x121930 Offset: 0x120D30 VA: 0x180121930
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryItem.<SplitStackAsync>d__22>
	|
	|-RVA: 0x121790 Offset: 0x120B90 VA: 0x180121790
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<InventoryResult.<GetAsync>d__11>
	|
	|-RVA: 0x121740 Offset: 0x120B40 VA: 0x180121740
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<CraftItemAsync>d__33>
	|
	|-RVA: 0x121750 Offset: 0x120B50 VA: 0x180121750
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<CraftItemAsync>d__34>
	|
	|-RVA: 0x121780 Offset: 0x120B80 VA: 0x180121780
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<GetAllItemsAsync>d__31>
	|
	|-RVA: 0x1217F0 Offset: 0x120BF0 VA: 0x1801217F0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<GrantPromoItemsAsync>d__36>
	|
	|-RVA: 0x121980 Offset: 0x120D80 VA: 0x180121980
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.Start<SteamInventory.<TriggerItemDropAsync>d__37>
	|
	|-RVA: 0x1219A0 Offset: 0x120DA0 VA: 0x1801219A0
	|-AsyncTaskMethodBuilder<Nullable<Result>>.Start<Item.<Vote>d__83>
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.Start<Item.<Vote>d__83>
	|
	|-RVA: 0x121860 Offset: 0x120C60 VA: 0x180121860
	|-AsyncTaskMethodBuilder<Nullable<Item>>.Start<SteamUGC.<QueryFileAsync>d__19>
	|
	|-RVA: 0x1217D0 Offset: 0x120BD0 VA: 0x1801217D0
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.Start<Query.<GetPageAsync>d__76>
	|
	|-RVA: 0x121810 Offset: 0x120C10 VA: 0x180121810
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x121990 Offset: 0x120D90 VA: 0x180121990
	|-AsyncTaskMethodBuilder<object>.Start<BenchmarkData.<Upload>d__13>
	|-AsyncTaskMethodBuilder<string>.Start<BenchmarkData.<Upload>d__13>
	|
	|-RVA: 0x1218B0 Offset: 0x120CB0 VA: 0x1801218B0
	|-AsyncTaskMethodBuilder<object>.Start<Feedback.<Report>d__0>
	|-AsyncTaskMethodBuilder<string>.Start<Feedback.<Report>d__0>
	|
	|-RVA: 0x121770 Offset: 0x120B70 VA: 0x180121770
	|-AsyncTaskMethodBuilder<object>.Start<WebUtil.<DownloadFileTemp>d__3>
	|-AsyncTaskMethodBuilder<string>.Start<WebUtil.<DownloadFileTemp>d__3>
	|
	|-RVA: 0x121840 Offset: 0x120C40 VA: 0x180121840
	|-AsyncTaskMethodBuilder<object>.Start<WebUtil.<PostAsync>d__6>
	|-AsyncTaskMethodBuilder<string>.Start<WebUtil.<PostAsync>d__6>
	|
	|-RVA: 0x121850 Offset: 0x120C50 VA: 0x180121850
	|-AsyncTaskMethodBuilder<object>.Start<WebUtil.<PostDataAsync>d__8>
	|-AsyncTaskMethodBuilder<string>.Start<WebUtil.<PostDataAsync>d__8>
	|
	|-RVA: 0x1218F0 Offset: 0x120CF0 VA: 0x1801218F0
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>>
	|
	|-RVA: 0x121900 Offset: 0x120D00 VA: 0x180121900
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>>
	|
	|-RVA: 0x121920 Offset: 0x120D20 VA: 0x180121920
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<GameMetadata>>
	|
	|-RVA: 0x121910 Offset: 0x120D10 VA: 0x180121910
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<LoadGoLispHandlers>>
	|
	|-RVA: 0x1218E0 Offset: 0x120CE0 VA: 0x1801218E0
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<RegisterGameEvent>>
	|
	|-RVA: 0x13B4C0 Offset: 0x13A8C0 VA: 0x18013B4C0
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<RegisterTimelineEvents>>
	|
	|-RVA: 0x13B4D0 Offset: 0x13A8D0 VA: 0x18013B4D0
	|-AsyncTaskMethodBuilder<object>.Start<RestRgbService.<SendPost>d__42<RemoveGame>>
	|
	|-RVA: 0x13B490 Offset: 0x13A890 VA: 0x18013B490
	|-AsyncTaskMethodBuilder<object>.Start<FileDialog.<SaveAsync>d__24>
	|-AsyncTaskMethodBuilder<string>.Start<FileDialog.<SaveAsync>d__24>
	|
	|-RVA: 0x13B410 Offset: 0x13A810 VA: 0x18013B410
	|-AsyncTaskMethodBuilder<object>.Start<HttpClient.<GetStringAsync>d__52>
	|-AsyncTaskMethodBuilder<string>.Start<HttpClient.<GetStringAsync>d__52>
	|
	|-RVA: 0x13B460 Offset: 0x13A860 VA: 0x18013B460
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsStringAsync>d__20>
	|-AsyncTaskMethodBuilder<string>.Start<HttpContent.<ReadAsStringAsync>d__20>
	|
	|-RVA: 0x13B360 Offset: 0x13A760 VA: 0x18013B360
	|-AsyncTaskMethodBuilder<object>.Start<object>
	|
	|-RVA: 0x13B3B0 Offset: 0x13A7B0 VA: 0x18013B3B0
	|-AsyncTaskMethodBuilder<object>.Start<XmlUrlResolver.<GetEntityAsync>d__15>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E29F0 Offset: 0x1E1DF0 VA: 0x1801E29F0
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.SetStateMachine
	|-AsyncTaskMethodBuilder<IAuthTicket>.SetStateMachine
	|-AsyncTaskMethodBuilder<IPlayerInfo>.SetStateMachine
	|-AsyncTaskMethodBuilder<IPlayerInventory>.SetStateMachine
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.SetStateMachine
	|-AsyncTaskMethodBuilder<AuthTicket>.SetStateMachine
	|-AsyncTaskMethodBuilder<InventoryDef[]>.SetStateMachine
	|-AsyncTaskMethodBuilder<PublishResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<bool>.SetStateMachine
	|-AsyncTaskMethodBuilder<byte[]>.SetStateMachine
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.SetStateMachine
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Stream>.SetStateMachine
	|-AsyncTaskMethodBuilder<int>.SetStateMachine
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Result>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetStateMachine
	|-AsyncTaskMethodBuilder<object>.SetStateMachine
	|-AsyncTaskMethodBuilder<string>.SetStateMachine
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121260 Offset: 0x120660 VA: 0x180121260
	|-AsyncTaskMethodBuilder<InventoryDef[]>.AwaitOnCompleted<CallResult<SteamInventoryRequestPricesResult_t>, SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<CallResult<SteamInventoryRequestPricesResult_t>, SteamInventory.<GetDefinitionsWithPricesAsync>d__19>
	|
	|-RVA: 0x121280 Offset: 0x120680 VA: 0x180121280
	|-AsyncTaskMethodBuilder<PublishResult>.AwaitOnCompleted<CallResult<CreateItemResult_t>, Editor.<SubmitAsync>d__40>
	|
	|-RVA: 0x121240 Offset: 0x120640 VA: 0x180121240
	|-AsyncTaskMethodBuilder<byte[]>.AwaitOnCompleted<CallResult<EncryptedAppTicketResponse_t>, SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<CallResult<EncryptedAppTicketResponse_t>, SteamUser.<RequestEncryptedAppTicketAsync>d__71>
	|
	|-RVA: 0x121290 Offset: 0x120690 VA: 0x180121290
	|-AsyncTaskMethodBuilder<int>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x121250 Offset: 0x120650 VA: 0x180121250
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.AwaitOnCompleted<CallResult<SteamInventoryStartPurchaseResult_t>, SteamInventory.<StartPurchaseAsync>d__39>
	|
	|-RVA: 0x121230 Offset: 0x120630 VA: 0x180121230
	|-AsyncTaskMethodBuilder<Nullable<Result>>.AwaitOnCompleted<CallResult<SetUserItemVoteResult_t>, Item.<Vote>d__83>
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.AwaitOnCompleted<CallResult<SetUserItemVoteResult_t>, Item.<Vote>d__83>
	|
	|-RVA: 0x121270 Offset: 0x120670 VA: 0x180121270
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.AwaitOnCompleted<CallResult<SteamUGCQueryCompleted_t>, Query.<GetPageAsync>d__76>
	|
	|-RVA: 0x1212A0 Offset: 0x1206A0 VA: 0x1801212A0
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x13AF80 Offset: 0x13A380 VA: 0x18013AF80
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x13AF70 Offset: 0x13A370 VA: 0x18013AF70
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121400 Offset: 0x120800 VA: 0x180121400
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, CompanionSubscription.<CheckStatus>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<CheckStatus>d__5>
	|
	|-RVA: 0x121410 Offset: 0x120810 VA: 0x180121410
	|-AsyncTaskMethodBuilder<IAuthTicket>.AwaitUnsafeOnCompleted<TaskAwaiter<AuthTicket>, SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamPlatform.<GetAuthSessionTicketAsync>d__53>
	|
	|-RVA: 0x121680 Offset: 0x120A80 VA: 0x180121680
	|-AsyncTaskMethodBuilder<IPlayerInfo>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<GetPlayerInformationAsync>d__57>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<GetPlayerInformationAsync>d__57>
	|
	|-RVA: 0x1215B0 Offset: 0x1209B0 VA: 0x1801215B0
	|-AsyncTaskMethodBuilder<IPlayerInventory>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<CraftItem>d__20>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<CraftItem>d__20>
	|
	|-RVA: 0x1215E0 Offset: 0x1209E0 VA: 0x1801215E0
	|-AsyncTaskMethodBuilder<IPlayerInventory>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<RefreshAndGetItems>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<RefreshAndGetItems>d__19>
	|
	|-RVA: 0x121340 Offset: 0x120740 VA: 0x180121340
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x121450 Offset: 0x120850 VA: 0x180121450
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.AwaitUnsafeOnCompleted<TaskAwaiter<SteamInventoryCrafting.MarketPrice>, SteamInventoryCrafting.<GetMarketPrice>d__29>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<GetMarketPrice>d__29>
	|
	|-RVA: 0x121440 Offset: 0x120840 VA: 0x180121440
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<GetMarketPriceImpl>d__30>
	|
	|-RVA: 0x121650 Offset: 0x120A50 VA: 0x180121650
	|-AsyncTaskMethodBuilder<AuthTicket>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamUser.<GetAuthSessionTicketAsync>d__54>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamUser.<GetAuthSessionTicketAsync>d__54>
	|
	|-RVA: 0x121700 Offset: 0x120B00 VA: 0x180121700
	|-AsyncTaskMethodBuilder<PublishResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Editor.<SubmitAsync>d__40>
	|
	|-RVA: 0x1212E0 Offset: 0x1206E0 VA: 0x1801212E0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x1213C0 Offset: 0x1207C0 VA: 0x1801213C0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x1216E0 Offset: 0x120AE0 VA: 0x1801216E0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter, Base.<RunQueryAsync>d__15>
	|
	|-RVA: 0x121610 Offset: 0x120A10 VA: 0x180121610
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ShoutcastStream.<ReadDataAsync>d__43>
	|
	|-RVA: 0x121620 Offset: 0x120A20 VA: 0x180121620
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, IpList.<RunQueryAsync>d__4>
	|
	|-RVA: 0x1213F0 Offset: 0x1207F0 VA: 0x1801213F0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ShoutcastStream.<ReadDataAsync>d__44>
	|
	|-RVA: 0x121480 Offset: 0x120880 VA: 0x180121480
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-RVA: 0x121660 Offset: 0x120A60 VA: 0x180121660
	|-AsyncTaskMethodBuilder<byte[]>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetChallengeData>d__7>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetChallengeData>d__7>
	|
	|-RVA: 0x121420 Offset: 0x120820 VA: 0x180121420
	|-AsyncTaskMethodBuilder<byte[]>.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, SourceServerQuery.<GetChallengeData>d__7>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SourceServerQuery.<GetChallengeData>d__7>
	|
	|-RVA: 0x1213E0 Offset: 0x1207E0 VA: 0x1801213E0
	|-AsyncTaskMethodBuilder<byte[]>.AwaitUnsafeOnCompleted<TaskAwaiter<UdpReceiveResult>, SourceServerQuery.<Receive>d__6>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<UdpReceiveResult>, SourceServerQuery.<Receive>d__6>
	|
	|-RVA: 0x1216A0 Offset: 0x120AA0 VA: 0x1801216A0
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerInfoHelpers.<LoadRules>d__1>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerInfoHelpers.<LoadRules>d__1>
	|
	|-RVA: 0x121690 Offset: 0x120A90 VA: 0x180121690
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetRules>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, SourceServerQuery.<GetRules>d__5>
	|
	|-RVA: 0x121470 Offset: 0x120870 VA: 0x180121470
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, SourceServerQuery.<GetRules>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SourceServerQuery.<GetRules>d__5>
	|
	|-RVA: 0x1214A0 Offset: 0x1208A0 VA: 0x1801214A0
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerInfoExtensions.<QueryRulesAsync>d__0>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerInfoExtensions.<QueryRulesAsync>d__0>
	|
	|-RVA: 0x121490 Offset: 0x120890 VA: 0x180121490
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerInfoHelpers.<LoadRules>d__1>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerInfoHelpers.<LoadRules>d__1>
	|
	|-RVA: 0x1214B0 Offset: 0x1208B0 VA: 0x1801214B0
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, ServerInfo.<QueryRulesAsync>d__85>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ServerInfo.<QueryRulesAsync>d__85>
	|
	|-RVA: 0x121460 Offset: 0x120860 VA: 0x180121460
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, SourceServerQuery.<GetRulesImpl>d__4>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SourceServerQuery.<GetRulesImpl>d__4>
	|
	|-RVA: 0x121430 Offset: 0x120830 VA: 0x180121430
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.AwaitUnsafeOnCompleted<TaskAwaiter<InventoryDef[]>, SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamPlatform.<GetItemDefinitionsWithPrices>d__21>
	|
	|-RVA: 0x1212F0 Offset: 0x1206F0 VA: 0x1801212F0
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<CreateContentReadStreamAsync>d__12>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<CreateContentReadStreamAsync>d__12>
	|
	|-RVA: 0x121380 Offset: 0x120780 VA: 0x180121380
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, HttpContent.<ReadAsStreamAsync>d__18>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpContent.<ReadAsStreamAsync>d__18>
	|
	|-RVA: 0x121360 Offset: 0x120760 VA: 0x180121360
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x121310 Offset: 0x120710 VA: 0x180121310
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x1213B0 Offset: 0x1207B0 VA: 0x1801213B0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<StartOperation>d__58>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-RVA: 0x1212C0 Offset: 0x1206C0 VA: 0x1801212C0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x1212D0 Offset: 0x1206D0 VA: 0x1801212D0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x121330 Offset: 0x120730 VA: 0x180121330
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0x121320 Offset: 0x120720 VA: 0x180121320
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClientHandler.<SendAsync>d__64>
	|
	|-RVA: 0x121390 Offset: 0x120790 VA: 0x180121390
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClientHandler.<SendAsync>d__64>
	|
	|-RVA: 0x1213A0 Offset: 0x1207A0 VA: 0x1801213A0
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>, HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0x1214D0 Offset: 0x1208D0 VA: 0x1801214D0
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, HttpClientHandler.<SendAsync>d__64>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, HttpClientHandler.<SendAsync>d__64>
	|
	|-RVA: 0x1216B0 Offset: 0x120AB0 VA: 0x1801216B0
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerInfoHelpers.<Load>d__0>
	|
	|-RVA: 0x121670 Offset: 0x120A70 VA: 0x180121670
	|-AsyncTaskMethodBuilder<Nullable<Image>>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamFriends.<GetMediumAvatarAsync>d__53>
	|
	|-RVA: 0x121640 Offset: 0x120A40 VA: 0x180121640
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter, InventoryResult.<GetAsync>d__11>
	|
	|-RVA: 0x121570 Offset: 0x120970 VA: 0x180121570
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, InventoryItem.<AddAsync>d__23>
	|
	|-RVA: 0x121580 Offset: 0x120980 VA: 0x180121580
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, InventoryItem.<ConsumeAsync>d__21>
	|
	|-RVA: 0x1215F0 Offset: 0x1209F0 VA: 0x1801215F0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, InventoryItem.<SplitStackAsync>d__22>
	|
	|-RVA: 0x121590 Offset: 0x120990 VA: 0x180121590
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<CraftItemAsync>d__33>
	|
	|-RVA: 0x1215A0 Offset: 0x1209A0 VA: 0x1801215A0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<CraftItemAsync>d__34>
	|
	|-RVA: 0x1215C0 Offset: 0x1209C0 VA: 0x1801215C0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<GetAllItemsAsync>d__31>
	|
	|-RVA: 0x1215D0 Offset: 0x1209D0 VA: 0x1801215D0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<GrantPromoItemsAsync>d__36>
	|
	|-RVA: 0x121600 Offset: 0x120A00 VA: 0x180121600
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventory.<TriggerItemDropAsync>d__37>
	|
	|-RVA: 0x121560 Offset: 0x120960 VA: 0x180121560
	|-AsyncTaskMethodBuilder<Nullable<Item>>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ResultPage>>, SteamUGC.<QueryFileAsync>d__19>
	|
	|-RVA: 0x1212B0 Offset: 0x1206B0 VA: 0x1801212B0
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x1213D0 Offset: 0x1207D0 VA: 0x1801213D0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x121300 Offset: 0x120700 VA: 0x180121300
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<ReadAsStringAsync>d__20>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<ReadAsStringAsync>d__20>
	|
	|-RVA: 0x121350 Offset: 0x120750 VA: 0x180121350
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, XmlUrlResolver.<GetEntityAsync>d__15>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x121370 Offset: 0x120770 VA: 0x180121370
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClient.<GetStringAsync>d__52>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>, HttpClient.<GetStringAsync>d__52>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string>, HttpClient.<GetStringAsync>d__52>
	|
	|-RVA: 0x121630 Offset: 0x120A30 VA: 0x180121630
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<DownloadFileTemp>d__3>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<DownloadFileTemp>d__3>
	|
	|-RVA: 0x1216C0 Offset: 0x120AC0 VA: 0x1801216C0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostAsync>d__6>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostAsync>d__6>
	|
	|-RVA: 0x1216D0 Offset: 0x120AD0 VA: 0x1801216D0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostDataAsync>d__8>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, WebUtil.<PostDataAsync>d__8>
	|
	|-RVA: 0x1216F0 Offset: 0x120AF0 VA: 0x1801216F0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, FileDialog.<SaveAsync>d__24>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter, FileDialog.<SaveAsync>d__24>
	|
	|-RVA: 0x121550 Offset: 0x120950 VA: 0x180121550
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, BenchmarkData.<Upload>d__13>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, BenchmarkData.<Upload>d__13>
	|
	|-RVA: 0x1214C0 Offset: 0x1208C0 VA: 0x1801214C0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Feedback.<Report>d__0>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter<IAuthTicket>, Feedback.<Report>d__0>
	|-AsyncTaskMethodBuilder<string>.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Feedback.<Report>d__0>
	|
	|-RVA: 0x121500 Offset: 0x120900 VA: 0x180121500
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>>
	|
	|-RVA: 0x121520 Offset: 0x120920 VA: 0x180121520
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>>
	|
	|-RVA: 0x121540 Offset: 0x120940 VA: 0x180121540
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<GameMetadata>>
	|
	|-RVA: 0x121530 Offset: 0x120930 VA: 0x180121530
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<LoadGoLispHandlers>>
	|
	|-RVA: 0x1214E0 Offset: 0x1208E0 VA: 0x1801214E0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<RegisterGameEvent>>
	|
	|-RVA: 0x1214F0 Offset: 0x1208F0 VA: 0x1801214F0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<RegisterTimelineEvents>>
	|
	|-RVA: 0x121510 Offset: 0x120910 VA: 0x180121510
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, RestRgbService.<SendPost>d__42<RemoveGame>>
	|
	|-RVA: 0x13B010 Offset: 0x13A410 VA: 0x18013B010
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x13AFE0 Offset: 0x13A3E0 VA: 0x18013AFE0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x13AFC0 Offset: 0x13A3C0 VA: 0x18013AFC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x13AFB0 Offset: 0x13A3B0 VA: 0x18013AFB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x13AFD0 Offset: 0x13A3D0 VA: 0x18013AFD0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-RVA: 0x13AFF0 Offset: 0x13A3F0 VA: 0x18013AFF0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x13AF90 Offset: 0x13A390 VA: 0x18013AF90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__27>
	|
	|-RVA: 0x13AFA0 Offset: 0x13A3A0 VA: 0x18013AFA0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x13B000 Offset: 0x13A400 VA: 0x18013B000
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x13B280 Offset: 0x13A680 VA: 0x18013B280
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunAsync>d__7>
	|
	|-RVA: 0x13B290 Offset: 0x13A690 VA: 0x18013B290
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarkScene>d__9>
	|
	|-RVA: 0x13B2A0 Offset: 0x13A6A0 VA: 0x18013B2A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunBenchmarksInScene>d__10>
	|
	|-RVA: 0x13B2B0 Offset: 0x13A6B0 VA: 0x18013B2B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunDemoBasedBenchmark>d__12>
	|
	|-RVA: 0x13B2C0 Offset: 0x13A6C0 VA: 0x18013B2C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Benchmarking.<RunSingleSceneAsync>d__8>
	|
	|-RVA: 0x13B1A0 Offset: 0x13A5A0 VA: 0x18013B1A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Client.<Connect>d__37>
	|
	|-RVA: 0x13B240 Offset: 0x13A640 VA: 0x18013B240
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x13B220 Offset: 0x13A620 VA: 0x18013B220
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x13B2E0 Offset: 0x13A6E0 VA: 0x18013B2E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Start>d__31>
	|
	|-RVA: 0x13B2F0 Offset: 0x13A6F0 VA: 0x18013B2F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B1E0 Offset: 0x13A5E0 VA: 0x18013B1E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x13B1B0 Offset: 0x13A5B0 VA: 0x18013B1B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x13B210 Offset: 0x13A610 VA: 0x18013B210
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x13B260 Offset: 0x13A660 VA: 0x18013B260
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x13B230 Offset: 0x13A630 VA: 0x18013B230
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamInventoryNewItem.<Open>d__0>
	|
	|-RVA: 0x13B1C0 Offset: 0x13A5C0 VA: 0x18013B1C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__15>
	|
	|-RVA: 0x13B1D0 Offset: 0x13A5D0 VA: 0x18013B1D0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<DoExport>d__21>
	|
	|-RVA: 0x13B1F0 Offset: 0x13A5F0 VA: 0x18013B1F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportTexture>d__19>
	|
	|-RVA: 0x13B200 Offset: 0x13A600 VA: 0x18013B200
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Publisher.<ExportToFolder>d__16>
	|
	|-RVA: 0x13B250 Offset: 0x13A650 VA: 0x18013B250
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, ServerHistory.<Refresh>d__4>
	|
	|-RVA: 0x13B2D0 Offset: 0x13A6D0 VA: 0x18013B2D0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, ShoutcastStream.<ShutdownSafely>d__54>
	|
	|-RVA: 0x13B270 Offset: 0x13A670 VA: 0x18013B270
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Friend.<RequestInfoAsync>d__13>
	|
	|-RVA: 0x13B190 Offset: 0x13A590 VA: 0x18013B190
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, SteamFriends.<CacheUserInformationAsync>d__51>
	|
	|-RVA: 0x13B020 Offset: 0x13A420 VA: 0x18013B020
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<PublishResult>, Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x13B040 Offset: 0x13A440 VA: 0x18013B040
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SourceServerQuery.<Send>d__8>
	|
	|-RVA: 0x13B180 Offset: 0x13A580 VA: 0x18013B180
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamPlatform.<InventoryDropAsync>d__26>
	|
	|-RVA: 0x13B160 Offset: 0x13A560 VA: 0x18013B160
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryCrateOpen.<DoCraftAsync>d__12>
	|
	|-RVA: 0x13B170 Offset: 0x13A570 VA: 0x18013B170
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<InventoryResult>>, SteamInventoryManager.<FixStacks>d__9>
	|
	|-RVA: 0x13B030 Offset: 0x13A430 VA: 0x18013B030
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<Item>>, Publisher.<PublishToSteam>d__18>
	|
	|-RVA: 0x13B150 Offset: 0x13A550 VA: 0x18013B150
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<Nullable<ResultPage>>, WorkshopItemList.<Refresh>d__26>
	|
	|-RVA: 0x13B0E0 Offset: 0x13A4E0 VA: 0x18013B0E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Benchmarking.<Report>d__11>
	|
	|-RVA: 0x13B050 Offset: 0x13A450 VA: 0x18013B050
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Add>d__6>
	|
	|-RVA: 0x13B0D0 Offset: 0x13A4D0 VA: 0x18013B0D0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CompanionSubscription.<Remove>d__7>
	|
	|-RVA: 0x13B090 Offset: 0x13A490 VA: 0x18013B090
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EAC.<OnJoinServer>d__16>
	|
	|-RVA: 0x13B0A0 Offset: 0x13A4A0 VA: 0x18013B0A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<ReadAllNotices>d__7>
	|
	|-RVA: 0x13B0B0 Offset: 0x13A4B0 VA: 0x18013B0B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Account.<Refresh>d__6>
	|
	|-RVA: 0x13B0F0 Offset: 0x13A4F0 VA: 0x18013B0F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendEvent>d__15>
	|
	|-RVA: 0x13B100 Offset: 0x13A500 VA: 0x18013B100
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendHeartbeat>d__12>
	|
	|-RVA: 0x13B110 Offset: 0x13A510 VA: 0x18013B110
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendPulseColor>d__14>
	|
	|-RVA: 0x13B120 Offset: 0x13A520 VA: 0x18013B120
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<SendStaticColor>d__13>
	|
	|-RVA: 0x13B140 Offset: 0x13A540 VA: 0x18013B140
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x13B130 Offset: 0x13A530 VA: 0x18013B130
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Hero.<ShowAsync>d__10>
	|
	|-RVA: 0x13B080 Offset: 0x13A480 VA: 0x18013B080
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryCrafting.<ExchangeItems>d__33>
	|
	|-RVA: 0x13B0C0 Offset: 0x13A4C0 VA: 0x18013B0C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteamInventoryManager.<Refresh>d__8>
	|
	|-RVA: 0x13B070 Offset: 0x13A470 VA: 0x18013B070
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Publisher.<DoExport>d__21>
	|
	|-RVA: 0x13B060 Offset: 0x13A460 VA: 0x18013B060
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, ShoutcastStream.<ConnectAsync>d__42>
	|
	|-RVA: 0x13B330 Offset: 0x13A730 VA: 0x18013B330
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B350 Offset: 0x13A750 VA: 0x18013B350
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Update>d__33>
	|
	|-RVA: 0x13B310 Offset: 0x13A710 VA: 0x18013B310
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StartServices>d__15>
	|
	|-RVA: 0x13B320 Offset: 0x13A720 VA: 0x18013B320
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StopServices>d__16>
	|
	|-RVA: 0x13B340 Offset: 0x13A740 VA: 0x18013B340
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x13B300 Offset: 0x13A700 VA: 0x18013B300
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, RestRgbService.<Start>d__31>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2A00 Offset: 0x1E1E00 VA: 0x1801E2A00
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.get_Task
	|-AsyncTaskMethodBuilder<IAuthTicket>.get_Task
	|-AsyncTaskMethodBuilder<IPlayerInfo>.get_Task
	|-AsyncTaskMethodBuilder<IPlayerInventory>.get_Task
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.get_Task
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.get_Task
	|-AsyncTaskMethodBuilder<AuthTicket>.get_Task
	|-AsyncTaskMethodBuilder<InventoryDef[]>.get_Task
	|-AsyncTaskMethodBuilder<PublishResult>.get_Task
	|-AsyncTaskMethodBuilder<byte[]>.get_Task
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.get_Task
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.get_Task
	|-AsyncTaskMethodBuilder<Stream>.get_Task
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<Image>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<Result>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<Item>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<int>>.get_Task
	|-AsyncTaskMethodBuilder<string>.get_Task
	|-AsyncTaskMethodBuilder<bool>.get_Task
	|-AsyncTaskMethodBuilder<int>.get_Task
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.get_Task
	|-AsyncTaskMethodBuilder<object>.get_Task
	|-AsyncTaskMethodBuilder<VoidTaskResult>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2880 Offset: 0x1E1C80 VA: 0x1801E2880
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.SetResult
	|-AsyncTaskMethodBuilder<IAuthTicket>.SetResult
	|-AsyncTaskMethodBuilder<IPlayerInfo>.SetResult
	|-AsyncTaskMethodBuilder<IPlayerInventory>.SetResult
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetResult
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.SetResult
	|-AsyncTaskMethodBuilder<AuthTicket>.SetResult
	|-AsyncTaskMethodBuilder<InventoryDef[]>.SetResult
	|-AsyncTaskMethodBuilder<byte[]>.SetResult
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.SetResult
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.SetResult
	|-AsyncTaskMethodBuilder<Stream>.SetResult
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.SetResult
	|-AsyncTaskMethodBuilder<object>.SetResult
	|-AsyncTaskMethodBuilder<string>.SetResult
	|
	|-RVA: 0x214090 Offset: 0x213490 VA: 0x180214090
	|-AsyncTaskMethodBuilder<PublishResult>.SetResult
	|
	|-RVA: 0x214140 Offset: 0x213540 VA: 0x180214140
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x2140C0 Offset: 0x2134C0 VA: 0x1802140C0
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x213ED0 Offset: 0x2132D0 VA: 0x180213ED0
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetResult
	|
	|-RVA: 0x213E40 Offset: 0x213240 VA: 0x180213E40
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetResult
	|
	|-RVA: 0x213F30 Offset: 0x213330 VA: 0x180213F30
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetResult
	|
	|-RVA: 0x1E28A0 Offset: 0x1E1CA0 VA: 0x1801E28A0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetResult
	|
	|-RVA: 0x1E2690 Offset: 0x1E1A90 VA: 0x1801E2690
	|-AsyncTaskMethodBuilder<Nullable<Result>>.SetResult
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetResult
	|
	|-RVA: 0x1E2780 Offset: 0x1E1B80 VA: 0x1801E2780
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetResult
	|
	|-RVA: 0x1E2590 Offset: 0x1E1990 VA: 0x1801E2590
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetResult
	|
	|-RVA: 0x1E2890 Offset: 0x1E1C90 VA: 0x1801E2890
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x1E2580 Offset: 0x1E1980 VA: 0x1801E2580
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	// RVA: -1 Offset: -1
	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x214150 Offset: 0x213550 VA: 0x180214150
	|-AsyncTaskMethodBuilder<PublishResult>.SetResult
	|
	|-RVA: 0x213DE0 Offset: 0x2131E0 VA: 0x180213DE0
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x213E70 Offset: 0x213270 VA: 0x180213E70
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x213F60 Offset: 0x213360 VA: 0x180213F60
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetResult
	|
	|-RVA: 0x214010 Offset: 0x213410 VA: 0x180214010
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetResult
	|
	|-RVA: 0x2140D0 Offset: 0x2134D0 VA: 0x1802140D0
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetResult
	|
	|-RVA: 0x1E26A0 Offset: 0x1E1AA0 VA: 0x1801E26A0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetResult
	|
	|-RVA: 0x1E28D0 Offset: 0x1E1CD0 VA: 0x1801E28D0
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetResult
	|
	|-RVA: 0x1E2620 Offset: 0x1E1A20 VA: 0x1801E2620
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetResult
	|
	|-RVA: 0x1E25C0 Offset: 0x1E19C0 VA: 0x1801E25C0
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x1E2520 Offset: 0x1E1920 VA: 0x1801E2520
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetResult
	|
	|-RVA: 0x1E2820 Offset: 0x1E1C20 VA: 0x1801E2820
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x1E2720 Offset: 0x1E1B20 VA: 0x1801E2720
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E24E0 Offset: 0x1E18E0 VA: 0x1801E24E0
	|-AsyncTaskMethodBuilder<CompanionSubscription.Status>.SetException
	|-AsyncTaskMethodBuilder<IAuthTicket>.SetException
	|-AsyncTaskMethodBuilder<IPlayerInfo>.SetException
	|-AsyncTaskMethodBuilder<IPlayerInventory>.SetException
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetException
	|-AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice>.SetException
	|-AsyncTaskMethodBuilder<AuthTicket>.SetException
	|-AsyncTaskMethodBuilder<InventoryDef[]>.SetException
	|-AsyncTaskMethodBuilder<byte[]>.SetException
	|-AsyncTaskMethodBuilder<Dictionary<string, string>>.SetException
	|-AsyncTaskMethodBuilder<List<IPlayerItemDefinition>>.SetException
	|-AsyncTaskMethodBuilder<Stream>.SetException
	|-AsyncTaskMethodBuilder<HttpResponseMessage>.SetException
	|-AsyncTaskMethodBuilder<object>.SetException
	|-AsyncTaskMethodBuilder<string>.SetException
	|
	|-RVA: 0x213DC0 Offset: 0x2131C0 VA: 0x180213DC0
	|-AsyncTaskMethodBuilder<PublishResult>.SetException
	|
	|-RVA: 0x213DB0 Offset: 0x2131B0 VA: 0x180213DB0
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x213DD0 Offset: 0x2131D0 VA: 0x180213DD0
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x213D80 Offset: 0x213180 VA: 0x180213D80
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.SetException
	|
	|-RVA: 0x213DA0 Offset: 0x2131A0 VA: 0x180213DA0
	|-AsyncTaskMethodBuilder<Nullable<Image>>.SetException
	|
	|-RVA: 0x213D90 Offset: 0x213190 VA: 0x180213D90
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.SetException
	|
	|-RVA: 0x1E24B0 Offset: 0x1E18B0 VA: 0x1801E24B0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.SetException
	|
	|-RVA: 0x1E24C0 Offset: 0x1E18C0 VA: 0x1801E24C0
	|-AsyncTaskMethodBuilder<Nullable<Result>>.SetException
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.SetException
	|
	|-RVA: 0x1E2510 Offset: 0x1E1910 VA: 0x1801E2510
	|-AsyncTaskMethodBuilder<Nullable<Item>>.SetException
	|
	|-RVA: 0x1E24F0 Offset: 0x1E18F0 VA: 0x1801E24F0
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.SetException
	|
	|-RVA: 0x1E24D0 Offset: 0x1E18D0 VA: 0x1801E24D0
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-RVA: 0x1E2500 Offset: 0x1E1900 VA: 0x1801E2500
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x213D50 Offset: 0x213150 VA: 0x180213D50
	|-AsyncTaskMethodBuilder<PublishResult>.GetTaskForResult
	|
	|-RVA: 0x213CE0 Offset: 0x2130E0 VA: 0x180213CE0
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-RVA: 0x213CA0 Offset: 0x2130A0 VA: 0x180213CA0
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-RVA: 0x213CF0 Offset: 0x2130F0 VA: 0x180213CF0
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>.GetTaskForResult
	|
	|-RVA: 0x213C70 Offset: 0x213070 VA: 0x180213C70
	|-AsyncTaskMethodBuilder<Nullable<Image>>.GetTaskForResult
	|
	|-RVA: 0x213CB0 Offset: 0x2130B0 VA: 0x180213CB0
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>.GetTaskForResult
	|
	|-RVA: 0x1E2450 Offset: 0x1E1850 VA: 0x1801E2450
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>.GetTaskForResult
	|
	|-RVA: 0x1E23B0 Offset: 0x1E17B0 VA: 0x1801E23B0
	|-AsyncTaskMethodBuilder<Nullable<Item>>.GetTaskForResult
	|
	|-RVA: 0x1E2480 Offset: 0x1E1880 VA: 0x1801E2480
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>.GetTaskForResult
	|
	|-RVA: 0x1E2370 Offset: 0x1E1770 VA: 0x1801E2370
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-RVA: 0x1E2390 Offset: 0x1E1790 VA: 0x1801E2390
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>.GetTaskForResult
	|
	|-RVA: 0x1E2380 Offset: 0x1E1780 VA: 0x1801E2380
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-RVA: 0x1E23A0 Offset: 0x1E17A0 VA: 0x1801E23A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189F230 Offset: 0x189D830 VA: 0x18189F230
	|-AsyncTaskMethodBuilder<PublishResult>..cctor
	|
	|-RVA: 0x189F440 Offset: 0x189DA40 VA: 0x18189F440
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-RVA: 0x189F640 Offset: 0x189DC40 VA: 0x18189F640
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-RVA: 0x189F730 Offset: 0x189DD30 VA: 0x18189F730
	|-AsyncTaskMethodBuilder<Nullable<ServerInfo>>..cctor
	|
	|-RVA: 0x189F530 Offset: 0x189DB30 VA: 0x18189F530
	|-AsyncTaskMethodBuilder<Nullable<Image>>..cctor
	|
	|-RVA: 0x189F340 Offset: 0x189D940 VA: 0x18189F340
	|-AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>>..cctor
	|
	|-RVA: 0x1362DF0 Offset: 0x13613F0 VA: 0x181362DF0
	|-AsyncTaskMethodBuilder<Nullable<InventoryResult>>..cctor
	|
	|-RVA: 0x1362A80 Offset: 0x1361080 VA: 0x181362A80
	|-AsyncTaskMethodBuilder<Nullable<Item>>..cctor
	|
	|-RVA: 0x13627A0 Offset: 0x1360DA0 VA: 0x1813627A0
	|-AsyncTaskMethodBuilder<Nullable<ResultPage>>..cctor
	|
	|-RVA: 0x13628A0 Offset: 0x1360EA0 VA: 0x1813628A0
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-RVA: 0x1362D00 Offset: 0x1361300 VA: 0x181362D00
	|-AsyncTaskMethodBuilder<Nullable<Int32Enum>>..cctor
	|
	|-RVA: 0x1362990 Offset: 0x1360F90 VA: 0x181362990
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-RVA: 0x1362C10 Offset: 0x1361210 VA: 0x181362C10
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	*/

}

internal static class AsyncTaskCache // TypeDefIndex: 1276
{	// Fields
	internal static readonly Task<bool> TrueTask; // 0x0
	internal static readonly Task<bool> FalseTask; // 0x8
	internal static readonly Task<int>[] Int32Tasks; // 0x10

	// Methods

	// RVA: 0xFDC3B0 Offset: 0xFDA9B0 VA: 0x180FDC3B0
	private static Task<int>[] CreateInt32Tasks() { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED1270 Offset: 0xECF870 VA: 0x180ED1270
	|-AsyncTaskCache.CreateCacheableTask<PublishResult>
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Image>>
	|
	|-RVA: 0xED0ED0 Offset: 0xECF4D0 VA: 0x180ED0ED0
	|-AsyncTaskCache.CreateCacheableTask<bool>
	|
	|-RVA: 0xED0F50 Offset: 0xECF550 VA: 0x180ED0F50
	|-AsyncTaskCache.CreateCacheableTask<int>
	|
	|-RVA: 0xED1300 Offset: 0xECF900 VA: 0x180ED1300
	|-AsyncTaskCache.CreateCacheableTask<Nullable<ServerInfo>>
	|
	|-RVA: 0xED10E0 Offset: 0xECF6E0 VA: 0x180ED10E0
	|-AsyncTaskCache.CreateCacheableTask<Nullable<InventoryPurchaseResult>>
	|-AsyncTaskCache.CreateCacheableTask<Nullable<ResultPage>>
	|
	|-RVA: 0xED1050 Offset: 0xECF650 VA: 0x180ED1050
	|-AsyncTaskCache.CreateCacheableTask<Nullable<InventoryResult>>
	|
	|-RVA: 0xED1170 Offset: 0xECF770 VA: 0x180ED1170
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Item>>
	|
	|-RVA: 0xED0FD0 Offset: 0xECF5D0 VA: 0x180ED0FD0
	|-AsyncTaskCache.CreateCacheableTask<Nullable<int>>
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Int32Enum>>
	|
	|-RVA: 0xED13D0 Offset: 0xECF9D0 VA: 0x180ED13D0
	|-AsyncTaskCache.CreateCacheableTask<object>
	|
	|-RVA: 0xED1450 Offset: 0xECFA50 VA: 0x180ED1450
	|-AsyncTaskCache.CreateCacheableTask<VoidTaskResult>
	*/

	// RVA: 0xFDC490 Offset: 0xFDAA90 VA: 0x180FDC490
	private static void .cctor() { }

}

internal struct AsyncMethodBuilderCore // TypeDefIndex: 1277
{	// Fields
	internal IAsyncStateMachine m_stateMachine; // 0x0
	internal Action m_defaultContextAction; // 0x8

	// Methods

	// RVA: 0x14BC20 Offset: 0x14B020 VA: 0x18014BC20
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x14BA90 Offset: 0x14AE90 VA: 0x18014BA90
	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	// RVA: 0x14BAA0 Offset: 0x14AEA0 VA: 0x18014BAA0
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	// RVA: 0x14BAB0 Offset: 0x14AEB0 VA: 0x18014BAB0
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	// RVA: 0xFDC000 Offset: 0xFDA600 VA: 0x180FDC000
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	// RVA: 0xFDB8D0 Offset: 0xFD9ED0 VA: 0x180FDB8D0
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0xFDC2E0 Offset: 0xFDA8E0 VA: 0x180FDC2E0
	internal static Task TryGetContinuationTask(Action action) { }

}

internal sealed class AsyncMethodBuilderCore.MoveNextRunner // TypeDefIndex: 1278
{	// Fields
	private readonly ExecutionContext m_context; // 0x10
	internal IAsyncStateMachine m_stateMachine; // 0x18
	private static ContextCallback s_invokeMoveNext; // 0x0

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(ExecutionContext context, IAsyncStateMachine stateMachine) { }

	// RVA: 0xFEB090 Offset: 0xFE9690 VA: 0x180FEB090
	internal void Run() { }

	// RVA: 0xFEAFF0 Offset: 0xFE95F0 VA: 0x180FEAFF0
	private static void InvokeMoveNext(object stateMachine) { }

}

private class AsyncMethodBuilderCore.ContinuationWrapper // TypeDefIndex: 1279
{	// Fields
	internal readonly Action m_continuation; // 0x10
	private readonly Action m_invokeAction; // 0x18
	internal readonly Task m_innerTask; // 0x20

	// Methods

	// RVA: 0xFE49F0 Offset: 0xFE2FF0 VA: 0x180FE49F0
	internal void .ctor(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0xFE49D0 Offset: 0xFE2FD0 VA: 0x180FE49D0
	internal void Invoke() { }

}

private sealed class AsyncMethodBuilderCore.<>c__DisplayClass4_0 // TypeDefIndex: 1280
{	// Fields
	public Task innerTask; // 0x10
	public Action continuation; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFF6B60 Offset: 0xFF5160 VA: 0x180FF6B60
	internal void <OutputAsyncCausalityEvents>b__0() { }

}

private sealed class AsyncMethodBuilderCore.<>c // TypeDefIndex: 1281
{	// Fields
	public static readonly AsyncMethodBuilderCore.<>c <>9; // 0x0
	public static SendOrPostCallback <>9__6_0; // 0x8
	public static WaitCallback <>9__6_1; // 0x10

	// Methods

	// RVA: 0xFF6BC0 Offset: 0xFF51C0 VA: 0x180FF6BC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFF6AA0 Offset: 0xFF50A0 VA: 0x180FF6AA0
	internal void <ThrowAsync>b__6_0(object state) { }

	// RVA: 0xFF6B00 Offset: 0xFF5100 VA: 0x180FF6B00
	internal void <ThrowAsync>b__6_1(object state) { }

}

public sealed class AsyncStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 1282
{	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(Type stateMachineType) { }

}

internal static class AsyncHelper // TypeDefIndex: 1812
{	// Fields
	public static readonly Task DoneTask; // 0x0
	public static readonly Task<bool> DoneTaskTrue; // 0x8
	public static readonly Task<bool> DoneTaskFalse; // 0x10
	public static readonly Task<int> DoneTaskZero; // 0x18

	// Methods

	// RVA: 0x12DD3E0 Offset: 0x12DB9E0 VA: 0x1812DD3E0
	private static void .cctor() { }

}

internal enum AsyncOperationStatus // TypeDefIndex: 2532
{	// Fields
	public int value__; // 0x0
	public const AsyncOperationStatus Initialize = 0;
	public const AsyncOperationStatus Continue = 1;
	public const AsyncOperationStatus ReadDone = 2;
	public const AsyncOperationStatus Complete = 3;

}

internal class AsyncProtocolResult // TypeDefIndex: 2533
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <UserResult>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x18

	// Properties
	public int UserResult { get; }
	public ExceptionDispatchInfo Error { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int result) { }

	// RVA: 0x10B5840 Offset: 0x10B3E40 VA: 0x1810B5840
	public void .ctor(ExceptionDispatchInfo error) { }

}

internal abstract class AsyncProtocolRequest // TypeDefIndex: 2534
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_RunSynchronously() { }

	// RVA: 0x7493E0 Offset: 0x7479E0 VA: 0x1807493E0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0
	protected void set_UserResult(int value) { }

	// RVA: 0x120FA80 Offset: 0x120E080 VA: 0x18120FA80
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x120F820 Offset: 0x120DE20 VA: 0x18120F820
	internal void RequestRead(int size) { }

	// RVA: 0x120F8E0 Offset: 0x120DEE0 VA: 0x18120F8E0
	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] // RVA: 0xA2AB0 Offset: 0xA1EB0 VA: 0x1800A2AB0
	// RVA: 0x120F8F0 Offset: 0x120DEF0 VA: 0x18120F8F0
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2BE0 Offset: 0xA1FE0 VA: 0x1800A2BE0
	// RVA: 0x120F700 Offset: 0x120DD00 VA: 0x18120F700
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2D70 Offset: 0xA2170 VA: 0x1800A2D70
	// RVA: 0x120F5E0 Offset: 0x120DBE0 VA: 0x18120F5E0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

	// RVA: 0x120FA10 Offset: 0x120E010 VA: 0x18120FA10 Slot: 3
	public override string ToString() { }

}

private struct AsyncProtocolRequest.<StartOperation>d__23 : IAsyncStateMachine // TypeDefIndex: 2535
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AsyncProtocolResult> <>t__builder; // 0x8
	public AsyncProtocolRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1D1EA0 Offset: 0x1D12A0 VA: 0x1801D1EA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D1EB0 Offset: 0x1D12B0 VA: 0x1801D1EB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct AsyncProtocolRequest.<ProcessOperation>d__24 : IAsyncStateMachine // TypeDefIndex: 2536
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public AsyncProtocolRequest <>4__this; // 0x28
	private AsyncOperationStatus <status>5__1; // 0x30
	private AsyncOperationStatus <newStatus>5__2; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x1D1E90 Offset: 0x1D1290 VA: 0x1801D1E90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct AsyncProtocolRequest.<InnerRead>d__25 : IAsyncStateMachine // TypeDefIndex: 2537
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<int>> <>t__builder; // 0x8
	public AsyncProtocolRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private int <requestedSize>5__1; // 0x30
	private Nullable<int> <totalRead>5__2; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40

	// Methods

	// RVA: 0x1D1DB0 Offset: 0x1D11B0 VA: 0x1801D1DB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D1DC0 Offset: 0x1D11C0 VA: 0x1801D1DC0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal class AsyncHandshakeRequest : AsyncProtocolRequest // TypeDefIndex: 2538
{	// Methods

	// RVA: 0x120F5D0 Offset: 0x120DBD0 VA: 0x18120F5D0
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x120F5B0 Offset: 0x120DBB0 VA: 0x18120F5B0 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 2539
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <CurrentSize>k__BackingField; // 0x40

	// Properties
	protected BufferOffsetSize UserBuffer { get; }
	protected int CurrentSize { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	protected int get_CurrentSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	protected void set_CurrentSize(int value) { }

	// RVA: 0x120FB90 Offset: 0x120E190 VA: 0x18120FB90
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x120FB20 Offset: 0x120E120 VA: 0x18120FB20 Slot: 3
	public override string ToString() { }

}

internal class AsyncReadRequest : AsyncReadOrWriteRequest // TypeDefIndex: 2540
{	// Methods

	// RVA: 0x120FCB0 Offset: 0x120E2B0 VA: 0x18120FCB0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x120FC30 Offset: 0x120E230 VA: 0x18120FC30 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

internal class AsyncWriteRequest : AsyncReadOrWriteRequest // TypeDefIndex: 2541
{	// Methods

	// RVA: 0x120FCB0 Offset: 0x120E2B0 VA: 0x18120FCB0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x120FCC0 Offset: 0x120E2C0 VA: 0x18120FCC0 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

internal class AsyncStreamReader // TypeDefIndex: 2647
{	// Fields
	private Stream stream; // 0x10
	private Encoding encoding; // 0x18
	private Decoder decoder; // 0x20
	private byte[] byteBuffer; // 0x28
	private char[] charBuffer; // 0x30
	private bool cancelOperation; // 0x38
	private ManualResetEvent eofEvent; // 0x40
	private object syncObject; // 0x48

	// Methods

	// RVA: 0x100F0B0 Offset: 0x100D6B0 VA: 0x18100F0B0 Slot: 4
	public virtual void Close() { }

	// RVA: 0x1727A20 Offset: 0x1726020 VA: 0x181727A20 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1727A10 Offset: 0x1726010 VA: 0x181727A10
	internal void CancelOperation() { }

}

public class AsyncCompletedEventArgs : EventArgs // TypeDefIndex: 2662
{	// Fields
	private readonly Exception error; // 0x10
	private readonly bool cancelled; // 0x18
	private readonly object userState; // 0x20

	// Properties
	[SRDescriptionAttribute] // RVA: 0xA9520 Offset: 0xA8920 VA: 0x1800A9520
	public bool Cancelled { get; }
	[SRDescriptionAttribute] // RVA: 0xA9610 Offset: 0xA8A10 VA: 0x1800A9610
	public Exception Error { get; }

	// Methods

	// RVA: 0x15BC7A0 Offset: 0x15BADA0 VA: 0x1815BC7A0
	public void .ctor(Exception error, bool cancelled, object userState) { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_Cancelled() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Exception get_Error() { }

	// RVA: 0x15BC6C0 Offset: 0x15BACC0 VA: 0x1815BC6C0
	protected void RaiseExceptionIfNecessary() { }

}

public sealed class AsyncCompletedEventHandler : MulticastDelegate // TypeDefIndex: 2663
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AsyncOperation // TypeDefIndex: 2664
{	// Fields
	private SynchronizationContext syncContext; // 0x10
	private object userSuppliedState; // 0x18
	private bool alreadyCompleted; // 0x20

	// Properties
	public object UserSuppliedState { get; }

	// Methods

	// RVA: 0x15BCF20 Offset: 0x15BB520 VA: 0x1815BCF20
	private void .ctor(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x15BCA50 Offset: 0x15BB050 VA: 0x1815BCA50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public object get_UserSuppliedState() { }

	// RVA: 0x15BCD00 Offset: 0x15BB300 VA: 0x1815BCD00
	public void Post(SendOrPostCallback d, object arg) { }

	// RVA: 0x15BCBE0 Offset: 0x15BB1E0 VA: 0x1815BCBE0
	public void PostOperationCompleted(SendOrPostCallback d, object arg) { }

	// RVA: 0x15BCB00 Offset: 0x15BB100 VA: 0x1815BCB00
	private void OperationCompletedCore() { }

	// RVA: 0x15BCEA0 Offset: 0x15BB4A0 VA: 0x1815BCEA0
	private void VerifyNotCompleted() { }

	// RVA: 0x15BCE20 Offset: 0x15BB420 VA: 0x1815BCE20
	private void VerifyDelegateNotNull(SendOrPostCallback d) { }

	// RVA: 0x15BC9B0 Offset: 0x15BAFB0 VA: 0x1815BC9B0
	internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext) { }

}

public static class AsyncOperationManager // TypeDefIndex: 2665
{	// Properties
	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public static SynchronizationContext SynchronizationContext { get; }

	// Methods

	// RVA: 0x15BC840 Offset: 0x15BAE40 VA: 0x1815BC840
	public static AsyncOperation CreateOperation(object userSuppliedState) { }

	// RVA: 0x15BC940 Offset: 0x15BAF40 VA: 0x1815BC940
	public static SynchronizationContext get_SynchronizationContext() { }

}

public class AsyncOperation : YieldInstruction // TypeDefIndex: 3491
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public int priority { set; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xB69C0 Offset: 0xB5DC0 VA: 0x1800B69C0
	[NativeMethodAttribute] // RVA: 0xB69C0 Offset: 0xB5DC0 VA: 0x1800B69C0
	// RVA: 0x181ED80 Offset: 0x181D380 VA: 0x18181ED80
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0x90BC0 Offset: 0x8FFC0 VA: 0x180090BC0
	// RVA: 0x181EE20 Offset: 0x181D420 VA: 0x18181EE20
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0xB6C90 Offset: 0xB6090 VA: 0x1800B6C90
	// RVA: 0x181EE60 Offset: 0x181D460 VA: 0x18181EE60
	public void set_priority(int value) { }

	// RVA: 0x181ECD0 Offset: 0x181D2D0 VA: 0x18181ECD0 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181EDC0 Offset: 0x181D3C0 VA: 0x18181EDC0
	internal void InvokeCompletionEvent() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public struct AsyncGPUReadbackRequest // TypeDefIndex: 3802
{	// Fields
	internal IntPtr m_Ptr; // 0x0
	internal int m_Version; // 0x8

	// Properties
	public bool done { get; }
	public bool hasError { get; }
	public int layerCount { get; }
	public int layerDataSize { get; }

	// Methods

	// RVA: -1 Offset: -1
	public NativeArray<T> GetData<T>(int layer = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2254A0 Offset: 0x2248A0 VA: 0x1802254A0
	|-AsyncGPUReadbackRequest.GetData<Color32>
	*/

	// RVA: 0x2217D0 Offset: 0x220BD0 VA: 0x1802217D0
	public bool get_done() { }

	// RVA: 0x221790 Offset: 0x220B90 VA: 0x180221790
	public bool get_hasError() { }

	// RVA: 0x221710 Offset: 0x220B10 VA: 0x180221710
	public int get_layerCount() { }

	// RVA: 0x221750 Offset: 0x220B50 VA: 0x180221750
	public int get_layerDataSize() { }

	// RVA: 0x2217D0 Offset: 0x220BD0 VA: 0x1802217D0
	private bool IsDone() { }

	// RVA: 0x221790 Offset: 0x220B90 VA: 0x180221790
	private bool HasError() { }

	// RVA: 0x221710 Offset: 0x220B10 VA: 0x180221710
	private int GetLayerCount() { }

	// RVA: 0x221750 Offset: 0x220B50 VA: 0x180221750
	private int GetLayerDataSize() { }

	// RVA: 0x221810 Offset: 0x220C10 VA: 0x180221810
	internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x2216C0 Offset: 0x220AC0 VA: 0x1802216C0
	private IntPtr GetDataRaw(int layer) { }

	// RVA: 0x19A4CA0 Offset: 0x19A32A0 VA: 0x1819A4CA0
	private static bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x19A4C60 Offset: 0x19A3260 VA: 0x1819A4C60
	private static bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x19A4BE0 Offset: 0x19A31E0 VA: 0x1819A4BE0
	private static int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x19A4C20 Offset: 0x19A3220 VA: 0x1819A4C20
	private static int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x19A4CE0 Offset: 0x19A32E0 VA: 0x1819A4CE0
	private static void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x19A4BA0 Offset: 0x19A31A0 VA: 0x1819A4BA0
	private static IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer) { }

}

public static class AsyncGPUReadback // TypeDefIndex: 3803
{	// Methods

	// RVA: 0x19A4FD0 Offset: 0x19A35D0 VA: 0x1819A4FD0
	private static void SetUpScriptingRequest(AsyncGPUReadbackRequest request, Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x19A4F30 Offset: 0x19A3530 VA: 0x1819A4F30
	public static AsyncGPUReadbackRequest Request(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x19A4E80 Offset: 0x19A3480 VA: 0x1819A4E80
	public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex = 0, Action<AsyncGPUReadbackRequest> callback) { }

	[NativeMethodAttribute] // RVA: 0x6FF20 Offset: 0x6F320 VA: 0x18006FF20
	// RVA: 0x19A4D80 Offset: 0x19A3380 VA: 0x1819A4D80
	private static AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0x6FF20 Offset: 0x6F320 VA: 0x18006FF20
	// RVA: 0x19A4E20 Offset: 0x19A3420 VA: 0x1819A4E20
	private static AsyncGPUReadbackRequest Request_Internal_Texture_1(Texture src, int mipIndex) { }

	// RVA: 0x19A4D30 Offset: 0x19A3330 VA: 0x1819A4D30
	private static void Request_Internal_ComputeBuffer_1_Injected(ComputeBuffer buffer, out AsyncGPUReadbackRequest ret) { }

	// RVA: 0x19A4DD0 Offset: 0x19A33D0 VA: 0x1819A4DD0
	private static void Request_Internal_Texture_1_Injected(Texture src, int mipIndex, out AsyncGPUReadbackRequest ret) { }

}

public class AsyncTextureLoad : CustomYieldInstruction // TypeDefIndex: 6627
{	// Fields
	private IntPtr buffer; // 0x10
	private int size; // 0x18
	private int width; // 0x1C
	private int height; // 0x20
	private int format; // 0x24
	public string filename; // 0x28
	public bool normal; // 0x30
	public bool dither; // 0x31
	public bool hqmode; // 0x32
	public bool cache; // 0x33
	private Action worker; // 0x38

	// Properties
	public override bool keepWaiting { get; }
	public bool isDone { get; }
	public bool isValid { get; }
	public Texture2D texture { get; }

	// Methods

	// RVA: 0x74DC50 Offset: 0x74C250 VA: 0x18074DC50 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x13192C0 Offset: 0x13178C0 VA: 0x1813192C0
	public bool get_isDone() { }

	// RVA: 0x1B9E1C0 Offset: 0x1B9C7C0 VA: 0x181B9E1C0
	public bool get_isValid() { }

	// RVA: 0x1B9E2B0 Offset: 0x1B9C8B0 VA: 0x181B9E2B0
	public Texture2D get_texture() { }

	// RVA: 0x1B9DC60 Offset: 0x1B9C260 VA: 0x181B9DC60
	public void LoadIntoTexture(Texture2D tex) { }

	// RVA: 0x1B9DFC0 Offset: 0x1B9C5C0 VA: 0x181B9DFC0
	public void WriteToCache(string cachename) { }

	// RVA: 0x1B9DB20 Offset: 0x1B9C120 VA: 0x181B9DB20
	private static extern void FreeTexture(ref IntPtr buffer) { }

	// RVA: 0x1B9DDF0 Offset: 0x1B9C3F0 VA: 0x181B9DDF0
	private static extern void LoadTextureFromFile(string filename, ref IntPtr buffer, ref int size, ref int width, ref int height, ref int channels, bool normal, bool dither, bool hqmode) { }

	// RVA: 0x1B9DD10 Offset: 0x1B9C310 VA: 0x181B9DD10
	private static extern void LoadTextureFromCache(string filename, ref IntPtr buffer, ref int size, ref int width, ref int height, ref int format) { }

	// RVA: 0x1B9DEF0 Offset: 0x1B9C4F0 VA: 0x181B9DEF0
	private static extern void SaveTextureToCache(string filename, IntPtr buffer, int size, int width, int height, int format) { }

	// RVA: 0x1B9E0A0 Offset: 0x1B9C6A0 VA: 0x181B9E0A0
	public void .ctor(string filename, bool normal, bool dither, bool hqmode, bool cache) { }

	// RVA: 0x1B9D950 Offset: 0x1B9BF50 VA: 0x181B9D950
	private void DoWork() { }

	// RVA: 0x1B9DBA0 Offset: 0x1B9C1A0 VA: 0x181B9DBA0
	private void Invoke() { }

	// RVA: 0x1B9D910 Offset: 0x1B9BF10 VA: 0x181B9D910
	private void Callback(IAsyncResult result) { }

}

public sealed class AsyncMethodBuilderAttribute : Attribute // TypeDefIndex: 7091
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly Type <BuilderType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(Type builderType) { }

}

public struct AsyncValueTaskMethodBuilder // TypeDefIndex: 7092
{	// Fields
	private AsyncTaskMethodBuilder _methodBuilder; // 0x0
	private bool _haveResult; // 0x18
	private bool _useBuilder; // 0x19

	// Properties
	public ValueTask Task { get; }

	// Methods

	// RVA: 0x4CF8A0 Offset: 0x4CDEA0 VA: 0x1804CF8A0
	public static AsyncValueTaskMethodBuilder Create() { }

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B6B0 Offset: 0x13AAB0 VA: 0x18013B6B0
	|-AsyncValueTaskMethodBuilder.Start<RestRgbService.<Start>d__31>
	|
	|-RVA: 0x13B6D0 Offset: 0x13AAD0 VA: 0x18013B6D0
	|-AsyncValueTaskMethodBuilder.Start<RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B6F0 Offset: 0x13AAF0 VA: 0x18013B6F0
	|-AsyncValueTaskMethodBuilder.Start<RestRgbService.<Update>d__33>
	|
	|-RVA: 0x13B6A0 Offset: 0x13AAA0 VA: 0x18013B6A0
	|-AsyncValueTaskMethodBuilder.Start<RgbController.<StartServices>d__15>
	|
	|-RVA: 0x13B6C0 Offset: 0x13AAC0 VA: 0x18013B6C0
	|-AsyncValueTaskMethodBuilder.Start<RgbController.<StopServices>d__16>
	|
	|-RVA: 0x13B6E0 Offset: 0x13AAE0 VA: 0x18013B6E0
	|-AsyncValueTaskMethodBuilder.Start<RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x13B690 Offset: 0x13AA90 VA: 0x18013B690
	|-AsyncValueTaskMethodBuilder.Start<SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x13B680 Offset: 0x13AA80 VA: 0x18013B680
	|-AsyncValueTaskMethodBuilder.Start<object>
	*/

	// RVA: 0x2405D0 Offset: 0x23F9D0 VA: 0x1802405D0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x2405B0 Offset: 0x23F9B0 VA: 0x1802405B0
	public void SetResult() { }

	// RVA: 0x2405A0 Offset: 0x23F9A0 VA: 0x1802405A0
	public void SetException(Exception exception) { }

	// RVA: 0x2405E0 Offset: 0x23F9E0 VA: 0x1802405E0
	public ValueTask get_Task() { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B540 Offset: 0x13A940 VA: 0x18013B540
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x13B580 Offset: 0x13A980 VA: 0x18013B580
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Start>d__31>
	|
	|-RVA: 0x13B5A0 Offset: 0x13A9A0 VA: 0x18013B5A0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B560 Offset: 0x13A960 VA: 0x18013B560
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Shutdown>d__11>
	|
	|-RVA: 0x13B620 Offset: 0x13AA20 VA: 0x18013B620
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Stop>d__32>
	|
	|-RVA: 0x13B660 Offset: 0x13AA60 VA: 0x18013B660
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RestRgbService.<Update>d__33>
	|
	|-RVA: 0x13B5E0 Offset: 0x13A9E0 VA: 0x18013B5E0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StartServices>d__15>
	|
	|-RVA: 0x13B600 Offset: 0x13AA00 VA: 0x18013B600
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<StopServices>d__16>
	|
	|-RVA: 0x13B640 Offset: 0x13AA40 VA: 0x18013B640
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, RgbController.<UpdateServices>d__17>
	|
	|-RVA: 0x13B5C0 Offset: 0x13A9C0 VA: 0x18013B5C0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, RestRgbService.<Start>d__31>
	*/

}

public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 7093
{	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4CF8A0 Offset: 0x4CDEA0 VA: 0x1804CF8A0
	|-AsyncValueTaskMethodBuilder<bool>.Create
	|
	|-RVA: 0x1362FE0 Offset: 0x13615E0 VA: 0x181362FE0
	|-AsyncValueTaskMethodBuilder<object>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B530 Offset: 0x13A930 VA: 0x18013B530
	|-AsyncValueTaskMethodBuilder<bool>.Start<SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-RVA: 0x13B520 Offset: 0x13A920 VA: 0x18013B520
	|-AsyncValueTaskMethodBuilder<object>.Start<object>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BE0 Offset: 0x1E1FE0 VA: 0x1801E2BE0
	|-AsyncValueTaskMethodBuilder<bool>.SetStateMachine
	|
	|-RVA: 0x1E2BA0 Offset: 0x1E1FA0 VA: 0x1801E2BA0
	|-AsyncValueTaskMethodBuilder<object>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2AB0 Offset: 0x1E1EB0 VA: 0x1801E2AB0
	|-AsyncValueTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x1E2B20 Offset: 0x1E1F20 VA: 0x1801E2B20
	|-AsyncValueTaskMethodBuilder<object>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2A60 Offset: 0x1E1E60 VA: 0x1801E2A60
	|-AsyncValueTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x1E2A10 Offset: 0x1E1E10 VA: 0x1801E2A10
	|-AsyncValueTaskMethodBuilder<object>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2D30 Offset: 0x1E2130 VA: 0x1801E2D30
	|-AsyncValueTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0x1E2C30 Offset: 0x1E2030 VA: 0x1801E2C30
	|-AsyncValueTaskMethodBuilder<object>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13B500 Offset: 0x13A900 VA: 0x18013B500
	|-AsyncValueTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, SteelSeriesGameSenseService.<Initialize>d__10>
	|-AsyncValueTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, SteelSeriesGameSenseService.<Initialize>d__10>
	|
	|-RVA: 0x13B4E0 Offset: 0x13A8E0 VA: 0x18013B4E0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	*/

}

public class AsyncTerrainNavMeshBake : CustomYieldInstruction // TypeDefIndex: 10314
{	// Fields
	private List<int> indices; // 0x10
	private List<Vector3> vertices; // 0x18
	private List<Vector3> normals; // 0x20
	private List<int> triangles; // 0x28
	private Vector3 pivot; // 0x30
	private int width; // 0x3C
	private int height; // 0x40
	private bool normal; // 0x44
	private bool alpha; // 0x45
	private Action worker; // 0x48

	// Properties
	public override bool keepWaiting { get; }
	public bool isDone { get; }
	public Mesh mesh { get; }

	// Methods

	// RVA: 0x831930 Offset: 0x82FF30 VA: 0x180831930 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x831920 Offset: 0x82FF20 VA: 0x180831920
	public bool get_isDone() { }

	// RVA: 0x830CA0 Offset: 0x82F2A0 VA: 0x180830CA0
	public NavMeshBuildSource CreateNavMeshBuildSource() { }

	// RVA: 0x830FB0 Offset: 0x82F5B0 VA: 0x180830FB0
	public NavMeshBuildSource CreateNavMeshBuildSource(int area) { }

	// RVA: 0x831940 Offset: 0x82FF40 VA: 0x180831940
	public Mesh get_mesh() { }

	// RVA: 0x831740 Offset: 0x82FD40 VA: 0x180831740
	public void .ctor(Vector3 pivot, int width, int height, bool normal, bool alpha) { }

	// RVA: 0x831050 Offset: 0x82F650 VA: 0x180831050
	private void DoWork() { }

	// RVA: 0x831680 Offset: 0x82FC80 VA: 0x180831680
	private void Invoke() { }

	// RVA: 0x830C60 Offset: 0x82F260 VA: 0x180830C60
	private void Callback(IAsyncResult result) { }

}

