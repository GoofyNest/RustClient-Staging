public sealed class Thread : CriticalFinalizerObject, _Thread // TypeDefIndex: 801
{	// Fields
	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static LocalDataStoreHolder s_LocalDataStore; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static CultureInfo m_CurrentCulture; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static CultureInfo m_CurrentUICulture; // 0x80000010
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; // 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
	private InternalThread internal_thread; // 0x10
	private object m_ThreadStartArg; // 0x18
	private object pending_exception; // 0x20
	private IPrincipal principal; // 0x28
	private int principal_version; // 0x30
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Thread current_thread; // 0x80000018
	private MulticastDelegate m_Delegate; // 0x38
	private ExecutionContext m_ExecutionContext; // 0x40
	private bool m_ExecutionContextBelongsToOuterScope; // 0x48

	// Properties
	internal bool ExecutionContextBelongsToCurrentScope { get; set; }
	public ThreadPriority Priority { set; }
	public CultureInfo CurrentUICulture { get; set; }
	public CultureInfo CurrentCulture { get; set; }
	private InternalThread Internal { get; }
	public static Context CurrentContext { get; }
	public static Thread CurrentThread { get; }
	internal static int CurrentThreadId { get; }
	public bool IsThreadPoolThread { get; }
	internal bool IsThreadPoolThreadInternal { get; }
	public bool IsAlive { get; }
	public bool IsBackground { set; }
	public string Name { set; }
	public ThreadState ThreadState { get; }
	public int ManagedThreadId { get; }

	// Methods

	// RVA: 0x160CD30 Offset: 0x160B330 VA: 0x18160CD30
	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x160CD80 Offset: 0x160B380 VA: 0x18160CD80
	private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x160DAB0 Offset: 0x160C0B0 VA: 0x18160DAB0
	public void .ctor(ThreadStart start) { }

	// RVA: 0x160DA20 Offset: 0x160C020 VA: 0x18160DA20
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x160D7B0 Offset: 0x160BDB0 VA: 0x18160D7B0
	public void Start() { }

	// RVA: 0x160D6F0 Offset: 0x160BCF0 VA: 0x18160D6F0
	public void Start(object parameter) { }

	// RVA: 0x160D7D0 Offset: 0x160BDD0 VA: 0x18160D7D0
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D070 Offset: 0x160B670 VA: 0x18160D070
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x160DBF0 Offset: 0x160C1F0 VA: 0x18160DBF0
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x160E0A0 Offset: 0x160C6A0 VA: 0x18160E0A0
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x160D0E0 Offset: 0x160B6E0 VA: 0x18160D0E0
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D320 Offset: 0x160B920 VA: 0x18160D320
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D320 Offset: 0x160B920 VA: 0x18160D320
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x160D370 Offset: 0x160B970 VA: 0x18160D370
	public void set_Priority(ThreadPriority value) { }

	// RVA: 0x160D370 Offset: 0x160B970 VA: 0x18160D370
	private void SetPriorityNative(int priority) { }

	// RVA: 0x160D260 Offset: 0x160B860 VA: 0x18160D260
	private bool JoinInternal(int millisecondsTimeout) { }

	// RVA: 0x160D270 Offset: 0x160B870 VA: 0x18160D270
	public void Join() { }

	// RVA: 0x160D280 Offset: 0x160B880 VA: 0x18160D280
	public bool Join(int millisecondsTimeout) { }

	// RVA: 0x160D590 Offset: 0x160BB90 VA: 0x18160D590
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x160D5A0 Offset: 0x160BBA0 VA: 0x18160D5A0
	public static void Sleep(int millisecondsTimeout) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160DA10 Offset: 0x160C010 VA: 0x18160DA10
	private static bool YieldInternal() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160DA10 Offset: 0x160C010 VA: 0x18160DA10
	public static bool Yield() { }

	// RVA: 0x160D380 Offset: 0x160B980 VA: 0x18160D380
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x160CFC0 Offset: 0x160B5C0 VA: 0x18160CFC0
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x160DEF0 Offset: 0x160C4F0 VA: 0x18160DEF0
	public void set_CurrentUICulture(CultureInfo value) { }

	// RVA: 0x160CFC0 Offset: 0x160B5C0 VA: 0x18160CFC0
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x160CF10 Offset: 0x160B510 VA: 0x18160CF10
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x160DD70 Offset: 0x160C370 VA: 0x18160DD70
	public void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x160CF10 Offset: 0x160B510 VA: 0x18160CF10
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x160DCE0 Offset: 0x160C2E0 VA: 0x18160DCE0
	private static void nativeInitCultureAccessors() { }

	// RVA: 0x160D310 Offset: 0x160B910 VA: 0x18160D310
	public static void MemoryBarrier() { }

	// RVA: 0x160CE70 Offset: 0x160B470 VA: 0x18160CE70
	private void ConstructInternalThread() { }

	// RVA: 0x160DC00 Offset: 0x160C200 VA: 0x18160DC00
	private InternalThread get_Internal() { }

	// RVA: 0x1475F30 Offset: 0x1474530 VA: 0x181475F30
	public static Context get_CurrentContext() { }

	// RVA: 0x160CFB0 Offset: 0x160B5B0 VA: 0x18160CFB0
	private static Thread GetCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x160DBA0 Offset: 0x160C1A0 VA: 0x18160DBA0
	public static Thread get_CurrentThread() { }

	// RVA: 0x160DB40 Offset: 0x160C140 VA: 0x18160DB40
	internal static int get_CurrentThreadId() { }

	// RVA: 0x160D060 Offset: 0x160B660 VA: 0x18160D060
	public static int GetDomainID() { }

	// RVA: 0x160D980 Offset: 0x160BF80 VA: 0x18160D980
	private IntPtr Thread_internal(MulticastDelegate start) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1498680 Offset: 0x1496C80 VA: 0x181498680 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x160DC70 Offset: 0x160C270 VA: 0x18160DC70
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x160DC70 Offset: 0x160C270 VA: 0x18160DC70
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x160DC30 Offset: 0x160C230 VA: 0x18160DC30
	public bool get_IsAlive() { }

	// RVA: 0x160E0B0 Offset: 0x160C6B0 VA: 0x18160E0B0
	public void set_IsBackground(bool value) { }

	// RVA: 0x160D360 Offset: 0x160B960 VA: 0x18160D360
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x160E180 Offset: 0x160C780 VA: 0x18160E180
	public void set_Name(string value) { }

	// RVA: 0x160DCB0 Offset: 0x160C2B0 VA: 0x18160DCB0
	public ThreadState get_ThreadState() { }

	// RVA: 0x160CCF0 Offset: 0x160B2F0 VA: 0x18160CCF0
	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	// RVA: 0x160CD00 Offset: 0x160B300 VA: 0x18160CD00
	public void Abort() { }

	// RVA: 0xD699D0 Offset: 0xD67FD0 VA: 0x180D699D0
	private static void SpinWait_nop() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D630 Offset: 0x160BC30 VA: 0x18160D630
	public static void SpinWait(int iterations) { }

	// RVA: 0x160D660 Offset: 0x160BC60 VA: 0x18160D660
	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x160D580 Offset: 0x160BB80 VA: 0x18160D580
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x160CE60 Offset: 0x160B460 VA: 0x18160CE60
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x160D250 Offset: 0x160B850 VA: 0x18160D250
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x160D970 Offset: 0x160BF70 VA: 0x18160D970
	private static int SystemMaxStackStize() { }

	// RVA: 0x160D1A0 Offset: 0x160B7A0 VA: 0x18160D1A0
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x160D530 Offset: 0x160BB30 VA: 0x18160D530
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D0A0 Offset: 0x160B6A0 VA: 0x18160D0A0
	public int get_ManagedThreadId() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x160CDD0 Offset: 0x160B3D0 VA: 0x18160CDD0
	public static void BeginCriticalRegion() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160CE80 Offset: 0x160B480 VA: 0x18160CE80
	public static void EndCriticalRegion() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x160D0A0 Offset: 0x160B6A0 VA: 0x18160D0A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x160D990 Offset: 0x160BF90 VA: 0x18160D990
	private ThreadState ValidateThreadState() { }

}

