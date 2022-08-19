public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 822
{	// Fields
	public const int WaitTimeout = 258;
	private const int MAX_WAITHANDLES = 64;
	private IntPtr waitHandle; // 0x18
	internal SafeWaitHandle safeWaitHandle; // 0x20
	internal bool hasThreadAffinity; // 0x28
	private const int WAIT_OBJECT_0 = 0;
	private const int WAIT_ABANDONED = 128;
	private const int WAIT_FAILED = 2147483647;
	private const int ERROR_TOO_MANY_POSTS = 298;
	protected static readonly IntPtr InvalidHandle; // 0x0
	internal const int MaxWaitHandles = 64;

	// Properties
	[ObsoleteAttribute] // RVA: 0xB9BF0 Offset: 0xB8FF0 VA: 0x1800B9BF0
	public virtual IntPtr Handle { set; }
	public SafeWaitHandle SafeWaitHandle { get; set; }

	// Methods

	// RVA: 0x161D030 Offset: 0x161B630 VA: 0x18161D030
	protected void .ctor() { }

	// RVA: 0x161C170 Offset: 0x161A770 VA: 0x18161C170
	private void Init() { }

	// RVA: 0x161D180 Offset: 0x161B780 VA: 0x18161D180 Slot: 7
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x161D0C0 Offset: 0x161B6C0 VA: 0x18161D0C0
	public SafeWaitHandle get_SafeWaitHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x161D290 Offset: 0x161B890 VA: 0x18161D290
	public void set_SafeWaitHandle(SafeWaitHandle value) { }

	// RVA: 0x161C300 Offset: 0x161A900 VA: 0x18161C300
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x161CC70 Offset: 0x161B270 VA: 0x18161CC70 Slot: 8
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x161CFC0 Offset: 0x161B5C0 VA: 0x18161CFC0 Slot: 9
	public virtual bool WaitOne() { }

	// RVA: 0x161CFA0 Offset: 0x161B5A0 VA: 0x18161CFA0 Slot: 10
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x161CE40 Offset: 0x161B440 VA: 0x18161CE40
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x161C1F0 Offset: 0x161A7F0 VA: 0x18161C1F0
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x161C400 Offset: 0x161AA00 VA: 0x18161C400
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x161C760 Offset: 0x161AD60 VA: 0x18161C760
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	// RVA: 0x161C350 Offset: 0x161A950 VA: 0x18161C350
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x161C3A0 Offset: 0x161A9A0 VA: 0x18161C3A0
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x161C040 Offset: 0x161A640 VA: 0x18161C040 Slot: 11
	public virtual void Close() { }

	// RVA: 0x161C0B0 Offset: 0x161A6B0 VA: 0x18161C0B0 Slot: 12
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x161C100 Offset: 0x161A700 VA: 0x18161C100 Slot: 6
	public void Dispose() { }

	// RVA: 0x161C860 Offset: 0x161AE60 VA: 0x18161C860
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x161CB30 Offset: 0x161B130 VA: 0x18161CB30
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x161CFE0 Offset: 0x161B5E0 VA: 0x18161CFE0
	private static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x161CFF0 Offset: 0x161B5F0 VA: 0x18161CFF0
	private static void .cctor() { }

}

