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
	[ObsoleteAttribute] // RVA: 0xB9C20 Offset: 0xB9020 VA: 0x1800B9C20
	public virtual IntPtr Handle { set; }
	public SafeWaitHandle SafeWaitHandle { get; set; }

	// Methods

	// RVA: 0x161D2F0 Offset: 0x161B8F0 VA: 0x18161D2F0
	protected void .ctor() { }

	// RVA: 0x161C430 Offset: 0x161AA30 VA: 0x18161C430
	private void Init() { }

	// RVA: 0x161D440 Offset: 0x161BA40 VA: 0x18161D440 Slot: 7
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x161D380 Offset: 0x161B980 VA: 0x18161D380
	public SafeWaitHandle get_SafeWaitHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x161D550 Offset: 0x161BB50 VA: 0x18161D550
	public void set_SafeWaitHandle(SafeWaitHandle value) { }

	// RVA: 0x161C5C0 Offset: 0x161ABC0 VA: 0x18161C5C0
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x161CF30 Offset: 0x161B530 VA: 0x18161CF30 Slot: 8
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x161D280 Offset: 0x161B880 VA: 0x18161D280 Slot: 9
	public virtual bool WaitOne() { }

	// RVA: 0x161D260 Offset: 0x161B860 VA: 0x18161D260 Slot: 10
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x161D100 Offset: 0x161B700 VA: 0x18161D100
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x161C4B0 Offset: 0x161AAB0 VA: 0x18161C4B0
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x161C6C0 Offset: 0x161ACC0 VA: 0x18161C6C0
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x161CA20 Offset: 0x161B020 VA: 0x18161CA20
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	// RVA: 0x161C610 Offset: 0x161AC10 VA: 0x18161C610
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x161C660 Offset: 0x161AC60 VA: 0x18161C660
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x161C300 Offset: 0x161A900 VA: 0x18161C300 Slot: 11
	public virtual void Close() { }

	// RVA: 0x161C370 Offset: 0x161A970 VA: 0x18161C370 Slot: 12
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x161C3C0 Offset: 0x161A9C0 VA: 0x18161C3C0 Slot: 6
	public void Dispose() { }

	// RVA: 0x161CB20 Offset: 0x161B120 VA: 0x18161CB20
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x161CDF0 Offset: 0x161B3F0 VA: 0x18161CDF0
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x161D2A0 Offset: 0x161B8A0 VA: 0x18161D2A0
	private static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x161D2B0 Offset: 0x161B8B0 VA: 0x18161D2B0
	private static void .cctor() { }

}

