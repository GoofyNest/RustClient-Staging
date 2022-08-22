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

	// RVA: 0x160A610 Offset: 0x1608C10 VA: 0x18160A610
	protected void .ctor() { }

	// RVA: 0x1609750 Offset: 0x1607D50 VA: 0x181609750
	private void Init() { }

	// RVA: 0x160A760 Offset: 0x1608D60 VA: 0x18160A760 Slot: 7
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x160A6A0 Offset: 0x1608CA0 VA: 0x18160A6A0
	public SafeWaitHandle get_SafeWaitHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x160A870 Offset: 0x1608E70 VA: 0x18160A870
	public void set_SafeWaitHandle(SafeWaitHandle value) { }

	// RVA: 0x16098E0 Offset: 0x1607EE0 VA: 0x1816098E0
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x160A250 Offset: 0x1608850 VA: 0x18160A250 Slot: 8
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x160A5A0 Offset: 0x1608BA0 VA: 0x18160A5A0 Slot: 9
	public virtual bool WaitOne() { }

	// RVA: 0x160A580 Offset: 0x1608B80 VA: 0x18160A580 Slot: 10
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x160A420 Offset: 0x1608A20 VA: 0x18160A420
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x16097D0 Offset: 0x1607DD0 VA: 0x1816097D0
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x16099E0 Offset: 0x1607FE0 VA: 0x1816099E0
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x1609D40 Offset: 0x1608340 VA: 0x181609D40
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	// RVA: 0x1609930 Offset: 0x1607F30 VA: 0x181609930
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x1609980 Offset: 0x1607F80 VA: 0x181609980
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x1609620 Offset: 0x1607C20 VA: 0x181609620 Slot: 11
	public virtual void Close() { }

	// RVA: 0x1609690 Offset: 0x1607C90 VA: 0x181609690 Slot: 12
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x16096E0 Offset: 0x1607CE0 VA: 0x1816096E0 Slot: 6
	public void Dispose() { }

	// RVA: 0x1609E40 Offset: 0x1608440 VA: 0x181609E40
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x160A110 Offset: 0x1608710 VA: 0x18160A110
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x160A5C0 Offset: 0x1608BC0 VA: 0x18160A5C0
	private static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x160A5D0 Offset: 0x1608BD0 VA: 0x18160A5D0
	private static void .cctor() { }

}

