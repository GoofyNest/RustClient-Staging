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

	// RVA: 0x15FA050 Offset: 0x15F8650 VA: 0x1815FA050
	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x15FA0A0 Offset: 0x15F86A0 VA: 0x1815FA0A0
	private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x15FADD0 Offset: 0x15F93D0 VA: 0x1815FADD0
	public void .ctor(ThreadStart start) { }

	// RVA: 0x15FAD40 Offset: 0x15F9340 VA: 0x1815FAD40
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x15FAAD0 Offset: 0x15F90D0 VA: 0x1815FAAD0
	public void Start() { }

	// RVA: 0x15FAA10 Offset: 0x15F9010 VA: 0x1815FAA10
	public void Start(object parameter) { }

	// RVA: 0x15FAAF0 Offset: 0x15F90F0 VA: 0x1815FAAF0
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x15FA390 Offset: 0x15F8990 VA: 0x1815FA390
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x15FAF10 Offset: 0x15F9510 VA: 0x1815FAF10
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x15FB3C0 Offset: 0x15F99C0 VA: 0x1815FB3C0
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x15FA400 Offset: 0x15F8A00 VA: 0x1815FA400
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x15FA640 Offset: 0x15F8C40 VA: 0x1815FA640
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x15FA640 Offset: 0x15F8C40 VA: 0x1815FA640
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x15FA690 Offset: 0x15F8C90 VA: 0x1815FA690
	public void set_Priority(ThreadPriority value) { }

	// RVA: 0x15FA690 Offset: 0x15F8C90 VA: 0x1815FA690
	private void SetPriorityNative(int priority) { }

	// RVA: 0x15FA580 Offset: 0x15F8B80 VA: 0x1815FA580
	private bool JoinInternal(int millisecondsTimeout) { }

	// RVA: 0x15FA590 Offset: 0x15F8B90 VA: 0x1815FA590
	public void Join() { }

	// RVA: 0x15FA5A0 Offset: 0x15F8BA0 VA: 0x1815FA5A0
	public bool Join(int millisecondsTimeout) { }

	// RVA: 0x15FA8B0 Offset: 0x15F8EB0 VA: 0x1815FA8B0
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x15FA8C0 Offset: 0x15F8EC0 VA: 0x1815FA8C0
	public static void Sleep(int millisecondsTimeout) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x15FAD30 Offset: 0x15F9330 VA: 0x1815FAD30
	private static bool YieldInternal() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x15FAD30 Offset: 0x15F9330 VA: 0x1815FAD30
	public static bool Yield() { }

	// RVA: 0x15FA6A0 Offset: 0x15F8CA0 VA: 0x1815FA6A0
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x15FA2E0 Offset: 0x15F88E0 VA: 0x1815FA2E0
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x15FB210 Offset: 0x15F9810 VA: 0x1815FB210
	public void set_CurrentUICulture(CultureInfo value) { }

	// RVA: 0x15FA2E0 Offset: 0x15F88E0 VA: 0x1815FA2E0
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x15FA230 Offset: 0x15F8830 VA: 0x1815FA230
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x15FB090 Offset: 0x15F9690 VA: 0x1815FB090
	public void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x15FA230 Offset: 0x15F8830 VA: 0x1815FA230
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x15FB000 Offset: 0x15F9600 VA: 0x1815FB000
	private static void nativeInitCultureAccessors() { }

	// RVA: 0x15FA630 Offset: 0x15F8C30 VA: 0x1815FA630
	public static void MemoryBarrier() { }

	// RVA: 0x15FA190 Offset: 0x15F8790 VA: 0x1815FA190
	private void ConstructInternalThread() { }

	// RVA: 0x15FAF20 Offset: 0x15F9520 VA: 0x1815FAF20
	private InternalThread get_Internal() { }

	// RVA: 0x1475000 Offset: 0x1473600 VA: 0x181475000
	public static Context get_CurrentContext() { }

	// RVA: 0x15FA2D0 Offset: 0x15F88D0 VA: 0x1815FA2D0
	private static Thread GetCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x15FAEC0 Offset: 0x15F94C0 VA: 0x1815FAEC0
	public static Thread get_CurrentThread() { }

	// RVA: 0x15FAE60 Offset: 0x15F9460 VA: 0x1815FAE60
	internal static int get_CurrentThreadId() { }

	// RVA: 0x15FA380 Offset: 0x15F8980 VA: 0x1815FA380
	public static int GetDomainID() { }

	// RVA: 0x15FACA0 Offset: 0x15F92A0 VA: 0x1815FACA0
	private IntPtr Thread_internal(MulticastDelegate start) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1497750 Offset: 0x1495D50 VA: 0x181497750 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15FAF90 Offset: 0x15F9590 VA: 0x1815FAF90
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x15FAF90 Offset: 0x15F9590 VA: 0x1815FAF90
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x15FAF50 Offset: 0x15F9550 VA: 0x1815FAF50
	public bool get_IsAlive() { }

	// RVA: 0x15FB3D0 Offset: 0x15F99D0 VA: 0x1815FB3D0
	public void set_IsBackground(bool value) { }

	// RVA: 0x15FA680 Offset: 0x15F8C80 VA: 0x1815FA680
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x15FB4A0 Offset: 0x15F9AA0 VA: 0x1815FB4A0
	public void set_Name(string value) { }

	// RVA: 0x15FAFD0 Offset: 0x15F95D0 VA: 0x1815FAFD0
	public ThreadState get_ThreadState() { }

	// RVA: 0x15FA010 Offset: 0x15F8610 VA: 0x1815FA010
	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	// RVA: 0x15FA020 Offset: 0x15F8620 VA: 0x1815FA020
	public void Abort() { }

	// RVA: 0xD6A480 Offset: 0xD68A80 VA: 0x180D6A480
	private static void SpinWait_nop() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x15FA950 Offset: 0x15F8F50 VA: 0x1815FA950
	public static void SpinWait(int iterations) { }

	// RVA: 0x15FA980 Offset: 0x15F8F80 VA: 0x1815FA980
	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x15FA8A0 Offset: 0x15F8EA0 VA: 0x1815FA8A0
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x15FA180 Offset: 0x15F8780 VA: 0x1815FA180
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x15FA570 Offset: 0x15F8B70 VA: 0x1815FA570
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x15FAC90 Offset: 0x15F9290 VA: 0x1815FAC90
	private static int SystemMaxStackStize() { }

	// RVA: 0x15FA4C0 Offset: 0x15F8AC0 VA: 0x1815FA4C0
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x15FA850 Offset: 0x15F8E50 VA: 0x1815FA850
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x15FA3C0 Offset: 0x15F89C0 VA: 0x1815FA3C0
	public int get_ManagedThreadId() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x15FA0F0 Offset: 0x15F86F0 VA: 0x1815FA0F0
	public static void BeginCriticalRegion() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x15FA1A0 Offset: 0x15F87A0 VA: 0x1815FA1A0
	public static void EndCriticalRegion() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x15FA3C0 Offset: 0x15F89C0 VA: 0x1815FA3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15FACB0 Offset: 0x15F92B0 VA: 0x1815FACB0
	private ThreadState ValidateThreadState() { }

}

