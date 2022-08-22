public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 3191
{	// Fields
	private bool fIsReentrant; // 0x10
	private int myLock; // 0x14
	private uint numWriteWaiters; // 0x18
	private uint numReadWaiters; // 0x1C
	private uint numWriteUpgradeWaiters; // 0x20
	private uint numUpgradeWaiters; // 0x24
	private bool fNoWaiters; // 0x28
	private int upgradeLockOwnerId; // 0x2C
	private int writeLockOwnerId; // 0x30
	private EventWaitHandle writeEvent; // 0x38
	private EventWaitHandle readEvent; // 0x40
	private EventWaitHandle upgradeEvent; // 0x48
	private EventWaitHandle waitUpgradeEvent; // 0x50
	private static long s_nextLockID; // 0x0
	private long lockID; // 0x58
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static ReaderWriterCount t_rwc; // 0x80000000
	private bool fUpgradeThreadHoldingRead; // 0x60
	private uint owners; // 0x64
	private bool fDisposed; // 0x68

	// Properties
	public bool IsReadLockHeld { get; }
	public bool IsUpgradeableReadLockHeld { get; }
	public bool IsWriteLockHeld { get; }
	public int RecursiveReadCount { get; }
	public int RecursiveUpgradeCount { get; }
	public int RecursiveWriteCount { get; }
	public int WaitingReadCount { get; }
	public int WaitingUpgradeCount { get; }
	public int WaitingWriteCount { get; }

	// Methods

	// RVA: 0x222B840 Offset: 0x2229E40 VA: 0x18222B840
	private void InitializeThreadCounts() { }

	// RVA: 0x222C960 Offset: 0x222AF60 VA: 0x18222C960
	public void .ctor() { }

	// RVA: 0x222C9C0 Offset: 0x222AFC0 VA: 0x18222C9C0
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x222B850 Offset: 0x2229E50 VA: 0x18222B850
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x222B890 Offset: 0x2229E90 VA: 0x18222B890
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x222B600 Offset: 0x2229C00 VA: 0x18222B600
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x222B030 Offset: 0x2229630 VA: 0x18222B030
	public void EnterWriteLock() { }

	// RVA: 0x222C700 Offset: 0x222AD00 VA: 0x18222C700
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x222C7A0 Offset: 0x222ADA0 VA: 0x18222C7A0
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222C010 Offset: 0x222A610 VA: 0x18222C010
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222AFE0 Offset: 0x22295E0 VA: 0x18222AFE0
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x222BF60 Offset: 0x222A560 VA: 0x18222BF60
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x222C000 Offset: 0x222A600 VA: 0x18222C000
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222BA20 Offset: 0x222A020 VA: 0x18222BA20
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222B450 Offset: 0x2229A50 VA: 0x18222B450
	public void ExitWriteLock() { }

	// RVA: 0x222B270 Offset: 0x2229870 VA: 0x18222B270
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x222B8C0 Offset: 0x2229EC0 VA: 0x18222B8C0
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x222C7B0 Offset: 0x222ADB0 VA: 0x18222C7B0
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	// RVA: 0x222B1B0 Offset: 0x22297B0 VA: 0x18222B1B0
	private void ExitAndWakeUpAppropriateWaiters() { }

	// RVA: 0x222B120 Offset: 0x2229720 VA: 0x18222B120
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	// RVA: 0x222B080 Offset: 0x2229680 VA: 0x18222B080
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	// RVA: 0x222B8B0 Offset: 0x2229EB0 VA: 0x18222B8B0
	private bool IsWriterAcquired() { }

	// RVA: 0x222B9B0 Offset: 0x2229FB0 VA: 0x18222B9B0
	private void SetWriterAcquired() { }

	// RVA: 0x222AB80 Offset: 0x2229180 VA: 0x18222AB80
	private void ClearWriterAcquired() { }

	// RVA: 0x222B9C0 Offset: 0x2229FC0 VA: 0x18222B9C0
	private void SetWritersWaiting() { }

	// RVA: 0x222AB90 Offset: 0x2229190 VA: 0x18222AB90
	private void ClearWritersWaiting() { }

	// RVA: 0x222B9A0 Offset: 0x2229FA0 VA: 0x18222B9A0
	private void SetUpgraderWaiting() { }

	// RVA: 0x222AB70 Offset: 0x2229170 VA: 0x18222AB70
	private void ClearUpgraderWaiting() { }

	// RVA: 0x222B5F0 Offset: 0x2229BF0 VA: 0x18222B5F0
	private uint GetNumReaders() { }

	// RVA: 0x222AF40 Offset: 0x2229540 VA: 0x18222AF40
	private void EnterMyLock() { }

	// RVA: 0x222AEB0 Offset: 0x22294B0 VA: 0x18222AEB0
	private void EnterMyLockSpin() { }

	// RVA: 0x222B250 Offset: 0x2229850 VA: 0x18222B250
	private void ExitMyLock() { }

	// RVA: 0x222B9D0 Offset: 0x2229FD0 VA: 0x18222B9D0
	private static void SpinWait(int SpinCount) { }

	// RVA: 0x222ABA0 Offset: 0x22291A0 VA: 0x18222ABA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x222ABB0 Offset: 0x22291B0 VA: 0x18222ABB0
	private void Dispose(bool disposing) { }

	// RVA: 0x222CA30 Offset: 0x222B030 VA: 0x18222CA30
	public bool get_IsReadLockHeld() { }

	// RVA: 0x222CAA0 Offset: 0x222B0A0 VA: 0x18222CAA0
	public bool get_IsUpgradeableReadLockHeld() { }

	// RVA: 0x222CB30 Offset: 0x222B130 VA: 0x18222CB30
	public bool get_IsWriteLockHeld() { }

	// RVA: 0x222CBC0 Offset: 0x222B1C0 VA: 0x18222CBC0
	public int get_RecursiveReadCount() { }

	// RVA: 0x222CC30 Offset: 0x222B230 VA: 0x18222CC30
	public int get_RecursiveUpgradeCount() { }

	// RVA: 0x222CCE0 Offset: 0x222B2E0 VA: 0x18222CCE0
	public int get_RecursiveWriteCount() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_WaitingReadCount() { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public int get_WaitingUpgradeCount() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_WaitingWriteCount() { }

}

private struct ReaderWriterLockSlim.TimeoutTracker // TypeDefIndex: 3192
{	// Fields
	private int m_total; // 0x0
	private int m_start; // 0x4

	// Properties
	public int RemainingMilliseconds { get; }
	public bool IsExpired { get; }

	// Methods

	// RVA: 0x237710 Offset: 0x236B10 VA: 0x180237710
	public void .ctor(int millisecondsTimeout) { }

	// RVA: 0x237770 Offset: 0x236B70 VA: 0x180237770
	public int get_RemainingMilliseconds() { }

	// RVA: 0x237720 Offset: 0x236B20 VA: 0x180237720
	public bool get_IsExpired() { }

}

