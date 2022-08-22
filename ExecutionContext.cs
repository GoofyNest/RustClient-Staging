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

	// RVA: 0x1494CE0 Offset: 0x14932E0 VA: 0x181494CE0
	internal bool get_isNewCapture() { }

	// RVA: 0x1494D10 Offset: 0x1493310 VA: 0x181494D10
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x1494CD0 Offset: 0x14932D0 VA: 0x181494CD0
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x1494CF0 Offset: 0x14932F0 VA: 0x181494CF0
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x1494C10 Offset: 0x1493210 VA: 0x181494C10
	internal static ExecutionContext get_PreAllocatedDefault() { }

	// RVA: 0x1494B90 Offset: 0x1493190 VA: 0x181494B90
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494AF0 Offset: 0x14930F0 VA: 0x181494AF0
	internal void .ctor(bool isPreAllocatedDefault) { }

	// RVA: 0x1493CB0 Offset: 0x14922B0 VA: 0x181493CB0
	internal static object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x14947D0 Offset: 0x1492DD0 VA: 0x1814947D0
	internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1493EA0 Offset: 0x14924A0 VA: 0x181493EA0
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x1494BA0 Offset: 0x14931A0 VA: 0x181494BA0
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x1494B20 Offset: 0x1493120 VA: 0x181494B20
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30 Slot: 4
	public void Dispose() { }

	// RVA: 0x14944C0 Offset: 0x1492AC0 VA: 0x1814944C0
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14945D0 Offset: 0x1492BD0 VA: 0x1814945D0
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1494220 Offset: 0x1492820 VA: 0x181494220
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x1493BA0 Offset: 0x14921A0 VA: 0x181493BA0
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x1493B30 Offset: 0x1492130 VA: 0x181493B30
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1494660 Offset: 0x1492C60 VA: 0x181494660
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x1493790 Offset: 0x1491D90 VA: 0x181493790
	public ExecutionContext CreateCopy() { }

	// RVA: 0x1493940 Offset: 0x1491F40 VA: 0x181493940
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x1493E60 Offset: 0x1492460 VA: 0x181493E60
	public static bool IsFlowSuppressed() { }

	// RVA: 0x1493740 Offset: 0x1491D40 VA: 0x181493740
	public static ExecutionContext Capture() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1493C50 Offset: 0x1492250 VA: 0x181493C50
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x1493540 Offset: 0x1491B40 VA: 0x181493540
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x1493D40 Offset: 0x1492340 VA: 0x181493D40 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1494A10 Offset: 0x1493010 VA: 0x181494A10
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1493E10 Offset: 0x1492410 VA: 0x181493E10
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x14949B0 Offset: 0x1492FB0 VA: 0x1814949B0
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

	// RVA: 0x1F0760 Offset: 0x1EFB60 VA: 0x1801F0760
	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x1F07C0 Offset: 0x1EFBC0 VA: 0x1801F07C0
	public bool get_IsFlowSuppressed() { }

	// RVA: 0x1F0830 Offset: 0x1EFC30 VA: 0x1801F0830
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x1F0820 Offset: 0x1EFC20 VA: 0x1801F0820
	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	// RVA: 0x1F07E0 Offset: 0x1EFBE0 VA: 0x1801F07E0
	public LogicalCallContext.Reader get_LogicalCallContext() { }

	// RVA: 0x1F0720 Offset: 0x1EFB20 VA: 0x1801F0720
	public object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x1F0730 Offset: 0x1EFB30 VA: 0x1801F0730
	public bool HasSameLocalValues(ExecutionContext other) { }

}

internal enum ExecutionContext.CaptureOptions // TypeDefIndex: 785
{	// Fields
	public int value__; // 0x0
	public const ExecutionContext.CaptureOptions None = 0;
	public const ExecutionContext.CaptureOptions IgnoreSyncCtx = 1;
	public const ExecutionContext.CaptureOptions OptimizeDefaultCase = 2;

}

