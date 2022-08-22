public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 782
{	// Fields
	private SynchronizationContext _syncContext; // 0x10
	private SynchronizationContext _syncContextNoFlow; // 0x18
	private LogicalCallContext _logicalCallContext; // 0x20
	private IllogicalCallContext _illogicalCallContext; // 0x28
	private ExecutionContext.Flags _flags; // 0x30
	private Dictionary<IAsyncLocal, object> _localValues; // 0x38
	private List<IAsyncLocal> _localChangeNotifications; // 0x40
	private static readonly ExecutionContext s_dummyDefaultEC; // 0x0

	// Properties
	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal static ExecutionContext PreAllocatedDefault { get; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }

	// Methods

	// RVA: 0x1493DB0 Offset: 0x14923B0 VA: 0x181493DB0
	internal bool get_isNewCapture() { }

	// RVA: 0x1493DE0 Offset: 0x14923E0 VA: 0x181493DE0
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x1493DA0 Offset: 0x14923A0 VA: 0x181493DA0
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x1493DC0 Offset: 0x14923C0 VA: 0x181493DC0
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x1493CE0 Offset: 0x14922E0 VA: 0x181493CE0
	internal static ExecutionContext get_PreAllocatedDefault() { }

	// RVA: 0x1493C60 Offset: 0x1492260 VA: 0x181493C60
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493BC0 Offset: 0x14921C0 VA: 0x181493BC0
	internal void .ctor(bool isPreAllocatedDefault) { }

	// RVA: 0x1492D80 Offset: 0x1491380 VA: 0x181492D80
	internal static object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x14938A0 Offset: 0x1491EA0 VA: 0x1814938A0
	internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1492F70 Offset: 0x1491570 VA: 0x181492F70
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x1493C70 Offset: 0x1492270 VA: 0x181493C70
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x1493BF0 Offset: 0x14921F0 VA: 0x181493BF0
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30 Slot: 4
	public void Dispose() { }

	// RVA: 0x1493590 Offset: 0x1491B90 VA: 0x181493590
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14936A0 Offset: 0x1491CA0 VA: 0x1814936A0
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14932F0 Offset: 0x14918F0 VA: 0x1814932F0
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x1492C70 Offset: 0x1491270 VA: 0x181492C70
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x1492C00 Offset: 0x1491200 VA: 0x181492C00
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1493730 Offset: 0x1491D30 VA: 0x181493730
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x1492860 Offset: 0x1490E60 VA: 0x181492860
	public ExecutionContext CreateCopy() { }

	// RVA: 0x1492A10 Offset: 0x1491010 VA: 0x181492A10
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x1492F30 Offset: 0x1491530 VA: 0x181492F30
	public static bool IsFlowSuppressed() { }

	// RVA: 0x1492810 Offset: 0x1490E10 VA: 0x181492810
	public static ExecutionContext Capture() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1492D20 Offset: 0x1491320 VA: 0x181492D20
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x1492610 Offset: 0x1490C10 VA: 0x181492610
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x1492E10 Offset: 0x1491410 VA: 0x181492E10 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1493AE0 Offset: 0x14920E0 VA: 0x181493AE0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1492EE0 Offset: 0x14914E0 VA: 0x181492EE0
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x1493A80 Offset: 0x1492080 VA: 0x181493A80
	private static void .cctor() { }

}

private enum ExecutionContext.Flags // TypeDefIndex: 783
{	// Fields
	public int value__; // 0x0
	public const ExecutionContext.Flags None = 0;
	public const ExecutionContext.Flags IsNewCapture = 1;
	public const ExecutionContext.Flags IsFlowSuppressed = 2;
	public const ExecutionContext.Flags IsPreAllocatedDefault = 4;

}

internal struct ExecutionContext.Reader // TypeDefIndex: 784
{	// Fields
	private ExecutionContext m_ec; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool IsFlowSuppressed { get; }
	public SynchronizationContext SynchronizationContext { get; }
	public SynchronizationContext SynchronizationContextNoFlow { get; }
	public LogicalCallContext.Reader LogicalCallContext { get; }

	// Methods

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	public void .ctor(ExecutionContext ec) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public ExecutionContext DangerousGetRawExecutionContext() { }

	// RVA: 0x118820 Offset: 0x117C20 VA: 0x180118820
	public bool get_IsNull() { }

	// RVA: 0x1F0B80 Offset: 0x1EFF80 VA: 0x1801F0B80
	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x1F0BE0 Offset: 0x1EFFE0 VA: 0x1801F0BE0
	public bool get_IsFlowSuppressed() { }

	// RVA: 0x1F0C50 Offset: 0x1F0050 VA: 0x1801F0C50
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x1F0C40 Offset: 0x1F0040 VA: 0x1801F0C40
	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	// RVA: 0x1F0C00 Offset: 0x1F0000 VA: 0x1801F0C00
	public LogicalCallContext.Reader get_LogicalCallContext() { }

	// RVA: 0x1F0B40 Offset: 0x1EFF40 VA: 0x1801F0B40
	public object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x1F0B50 Offset: 0x1EFF50 VA: 0x1801F0B50
	public bool HasSameLocalValues(ExecutionContext other) { }

}

internal enum ExecutionContext.CaptureOptions // TypeDefIndex: 785
{	// Fields
	public int value__; // 0x0
	public const ExecutionContext.CaptureOptions None = 0;
	public const ExecutionContext.CaptureOptions IgnoreSyncCtx = 1;
	public const ExecutionContext.CaptureOptions OptimizeDefaultCase = 2;

}

