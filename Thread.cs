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

	// RVA: 0x160CA70 Offset: 0x160B070 VA: 0x18160CA70
	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x160CAC0 Offset: 0x160B0C0 VA: 0x18160CAC0
	private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x160D7F0 Offset: 0x160BDF0 VA: 0x18160D7F0
	public void .ctor(ThreadStart start) { }

	// RVA: 0x160D760 Offset: 0x160BD60 VA: 0x18160D760
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x160D4F0 Offset: 0x160BAF0 VA: 0x18160D4F0
	public void Start() { }

	// RVA: 0x160D430 Offset: 0x160BA30 VA: 0x18160D430
	public void Start(object parameter) { }

	// RVA: 0x160D510 Offset: 0x160BB10 VA: 0x18160D510
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160CDB0 Offset: 0x160B3B0 VA: 0x18160CDB0
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x160D930 Offset: 0x160BF30 VA: 0x18160D930
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x160DDE0 Offset: 0x160C3E0 VA: 0x18160DDE0
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x160CE20 Offset: 0x160B420 VA: 0x18160CE20
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D060 Offset: 0x160B660 VA: 0x18160D060
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D060 Offset: 0x160B660 VA: 0x18160D060
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x160D0B0 Offset: 0x160B6B0 VA: 0x18160D0B0
	public void set_Priority(ThreadPriority value) { }

	// RVA: 0x160D0B0 Offset: 0x160B6B0 VA: 0x18160D0B0
	private void SetPriorityNative(int priority) { }

	// RVA: 0x160CFA0 Offset: 0x160B5A0 VA: 0x18160CFA0
	private bool JoinInternal(int millisecondsTimeout) { }

	// RVA: 0x160CFB0 Offset: 0x160B5B0 VA: 0x18160CFB0
	public void Join() { }

	// RVA: 0x160CFC0 Offset: 0x160B5C0 VA: 0x18160CFC0
	public bool Join(int millisecondsTimeout) { }

	// RVA: 0x160D2D0 Offset: 0x160B8D0 VA: 0x18160D2D0
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x160D2E0 Offset: 0x160B8E0 VA: 0x18160D2E0
	public static void Sleep(int millisecondsTimeout) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D750 Offset: 0x160BD50 VA: 0x18160D750
	private static bool YieldInternal() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D750 Offset: 0x160BD50 VA: 0x18160D750
	public static bool Yield() { }

	// RVA: 0x160D0C0 Offset: 0x160B6C0 VA: 0x18160D0C0
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x160CD00 Offset: 0x160B300 VA: 0x18160CD00
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x160DC30 Offset: 0x160C230 VA: 0x18160DC30
	public void set_CurrentUICulture(CultureInfo value) { }

	// RVA: 0x160CD00 Offset: 0x160B300 VA: 0x18160CD00
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x160CC50 Offset: 0x160B250 VA: 0x18160CC50
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x160DAB0 Offset: 0x160C0B0 VA: 0x18160DAB0
	public void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x160CC50 Offset: 0x160B250 VA: 0x18160CC50
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x160DA20 Offset: 0x160C020 VA: 0x18160DA20
	private static void nativeInitCultureAccessors() { }

	// RVA: 0x160D050 Offset: 0x160B650 VA: 0x18160D050
	public static void MemoryBarrier() { }

	// RVA: 0x160CBB0 Offset: 0x160B1B0 VA: 0x18160CBB0
	private void ConstructInternalThread() { }

	// RVA: 0x160D940 Offset: 0x160BF40 VA: 0x18160D940
	private InternalThread get_Internal() { }

	// RVA: 0x1475C70 Offset: 0x1474270 VA: 0x181475C70
	public static Context get_CurrentContext() { }

	// RVA: 0x160CCF0 Offset: 0x160B2F0 VA: 0x18160CCF0
	private static Thread GetCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x160D8E0 Offset: 0x160BEE0 VA: 0x18160D8E0
	public static Thread get_CurrentThread() { }

	// RVA: 0x160D880 Offset: 0x160BE80 VA: 0x18160D880
	internal static int get_CurrentThreadId() { }

	// RVA: 0x160CDA0 Offset: 0x160B3A0 VA: 0x18160CDA0
	public static int GetDomainID() { }

	// RVA: 0x160D6C0 Offset: 0x160BCC0 VA: 0x18160D6C0
	private IntPtr Thread_internal(MulticastDelegate start) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x14983C0 Offset: 0x14969C0 VA: 0x1814983C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x160D9B0 Offset: 0x160BFB0 VA: 0x18160D9B0
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x160D9B0 Offset: 0x160BFB0 VA: 0x18160D9B0
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x160D970 Offset: 0x160BF70 VA: 0x18160D970
	public bool get_IsAlive() { }

	// RVA: 0x160DDF0 Offset: 0x160C3F0 VA: 0x18160DDF0
	public void set_IsBackground(bool value) { }

	// RVA: 0x160D0A0 Offset: 0x160B6A0 VA: 0x18160D0A0
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x160DEC0 Offset: 0x160C4C0 VA: 0x18160DEC0
	public void set_Name(string value) { }

	// RVA: 0x160D9F0 Offset: 0x160BFF0 VA: 0x18160D9F0
	public ThreadState get_ThreadState() { }

	// RVA: 0x160CA30 Offset: 0x160B030 VA: 0x18160CA30
	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	// RVA: 0x160CA40 Offset: 0x160B040 VA: 0x18160CA40
	public void Abort() { }

	// RVA: 0xD69710 Offset: 0xD67D10 VA: 0x180D69710
	private static void SpinWait_nop() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160D370 Offset: 0x160B970 VA: 0x18160D370
	public static void SpinWait(int iterations) { }

	// RVA: 0x160D3A0 Offset: 0x160B9A0 VA: 0x18160D3A0
	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x160D2C0 Offset: 0x160B8C0 VA: 0x18160D2C0
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x160CBA0 Offset: 0x160B1A0 VA: 0x18160CBA0
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x160CF90 Offset: 0x160B590 VA: 0x18160CF90
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x160D6B0 Offset: 0x160BCB0 VA: 0x18160D6B0
	private static int SystemMaxStackStize() { }

	// RVA: 0x160CEE0 Offset: 0x160B4E0 VA: 0x18160CEE0
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x160D270 Offset: 0x160B870 VA: 0x18160D270
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160CDE0 Offset: 0x160B3E0 VA: 0x18160CDE0
	public int get_ManagedThreadId() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x160CB10 Offset: 0x160B110 VA: 0x18160CB10
	public static void BeginCriticalRegion() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160CBC0 Offset: 0x160B1C0 VA: 0x18160CBC0
	public static void EndCriticalRegion() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x160CDE0 Offset: 0x160B3E0 VA: 0x18160CDE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x160D6D0 Offset: 0x160BCD0 VA: 0x18160D6D0
	private ThreadState ValidateThreadState() { }

}

