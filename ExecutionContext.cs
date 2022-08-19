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

	// RVA: 0x1494A20 Offset: 0x1493020 VA: 0x181494A20
	internal bool get_isNewCapture() { }

	// RVA: 0x1494A50 Offset: 0x1493050 VA: 0x181494A50
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x1494A10 Offset: 0x1493010 VA: 0x181494A10
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x1494A30 Offset: 0x1493030 VA: 0x181494A30
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x1494950 Offset: 0x1492F50 VA: 0x181494950
	internal static ExecutionContext get_PreAllocatedDefault() { }

	// RVA: 0x14948D0 Offset: 0x1492ED0 VA: 0x1814948D0
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494830 Offset: 0x1492E30 VA: 0x181494830
	internal void .ctor(bool isPreAllocatedDefault) { }

	// RVA: 0x14939F0 Offset: 0x1491FF0 VA: 0x1814939F0
	internal static object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x1494510 Offset: 0x1492B10 VA: 0x181494510
	internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1493BE0 Offset: 0x14921E0 VA: 0x181493BE0
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x14948E0 Offset: 0x1492EE0 VA: 0x1814948E0
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x1494860 Offset: 0x1492E60 VA: 0x181494860
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30 Slot: 4
	public void Dispose() { }

	// RVA: 0x1494200 Offset: 0x1492800 VA: 0x181494200
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1494310 Offset: 0x1492910 VA: 0x181494310
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1493F60 Offset: 0x1492560 VA: 0x181493F60
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x14938E0 Offset: 0x1491EE0 VA: 0x1814938E0
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x1493870 Offset: 0x1491E70 VA: 0x181493870
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14943A0 Offset: 0x14929A0 VA: 0x1814943A0
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x14934D0 Offset: 0x1491AD0 VA: 0x1814934D0
	public ExecutionContext CreateCopy() { }

	// RVA: 0x1493680 Offset: 0x1491C80 VA: 0x181493680
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x1493BA0 Offset: 0x14921A0 VA: 0x181493BA0
	public static bool IsFlowSuppressed() { }

	// RVA: 0x1493480 Offset: 0x1491A80 VA: 0x181493480
	public static ExecutionContext Capture() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1493990 Offset: 0x1491F90 VA: 0x181493990
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x1493280 Offset: 0x1491880 VA: 0x181493280
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x1493A80 Offset: 0x1492080 VA: 0x181493A80 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1494750 Offset: 0x1492D50 VA: 0x181494750
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1493B50 Offset: 0x1492150 VA: 0x181493B50
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x14946F0 Offset: 0x1492CF0 VA: 0x1814946F0
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

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	public void .ctor(ExecutionContext ec) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public ExecutionContext DangerousGetRawExecutionContext() { }

	// RVA: 0x1188A0 Offset: 0x117CA0 VA: 0x1801188A0
	public bool get_IsNull() { }

	// RVA: 0x1F07E0 Offset: 0x1EFBE0 VA: 0x1801F07E0
	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x1F0840 Offset: 0x1EFC40 VA: 0x1801F0840
	public bool get_IsFlowSuppressed() { }

	// RVA: 0x1F08B0 Offset: 0x1EFCB0 VA: 0x1801F08B0
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x1F08A0 Offset: 0x1EFCA0 VA: 0x1801F08A0
	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	// RVA: 0x1F0860 Offset: 0x1EFC60 VA: 0x1801F0860
	public LogicalCallContext.Reader get_LogicalCallContext() { }

	// RVA: 0x1F07A0 Offset: 0x1EFBA0 VA: 0x1801F07A0
	public object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x1F07B0 Offset: 0x1EFBB0 VA: 0x1801F07B0
	public bool HasSameLocalValues(ExecutionContext other) { }

}

internal enum ExecutionContext.CaptureOptions // TypeDefIndex: 785
{	// Fields
	public int value__; // 0x0
	public const ExecutionContext.CaptureOptions None = 0;
	public const ExecutionContext.CaptureOptions IgnoreSyncCtx = 1;
	public const ExecutionContext.CaptureOptions OptimizeDefaultCase = 2;

}

