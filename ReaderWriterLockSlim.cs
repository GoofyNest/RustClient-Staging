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

	// RVA: 0x222B580 Offset: 0x2229B80 VA: 0x18222B580
	private void InitializeThreadCounts() { }

	// RVA: 0x222C6A0 Offset: 0x222ACA0 VA: 0x18222C6A0
	public void .ctor() { }

	// RVA: 0x222C700 Offset: 0x222AD00 VA: 0x18222C700
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x222B590 Offset: 0x2229B90 VA: 0x18222B590
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x222B5D0 Offset: 0x2229BD0 VA: 0x18222B5D0
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x222B340 Offset: 0x2229940 VA: 0x18222B340
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x222AD70 Offset: 0x2229370 VA: 0x18222AD70
	public void EnterWriteLock() { }

	// RVA: 0x222C440 Offset: 0x222AA40 VA: 0x18222C440
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x222C4E0 Offset: 0x222AAE0 VA: 0x18222C4E0
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222BD50 Offset: 0x222A350 VA: 0x18222BD50
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222AD20 Offset: 0x2229320 VA: 0x18222AD20
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x222BCA0 Offset: 0x222A2A0 VA: 0x18222BCA0
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x222BD40 Offset: 0x222A340 VA: 0x18222BD40
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222B760 Offset: 0x2229D60 VA: 0x18222B760
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222B190 Offset: 0x2229790 VA: 0x18222B190
	public void ExitWriteLock() { }

	// RVA: 0x222AFB0 Offset: 0x22295B0 VA: 0x18222AFB0
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x222B600 Offset: 0x2229C00 VA: 0x18222B600
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x222C4F0 Offset: 0x222AAF0 VA: 0x18222C4F0
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	// RVA: 0x222AEF0 Offset: 0x22294F0 VA: 0x18222AEF0
	private void ExitAndWakeUpAppropriateWaiters() { }

	// RVA: 0x222AE60 Offset: 0x2229460 VA: 0x18222AE60
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	// RVA: 0x222ADC0 Offset: 0x22293C0 VA: 0x18222ADC0
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	// RVA: 0x222B5F0 Offset: 0x2229BF0 VA: 0x18222B5F0
	private bool IsWriterAcquired() { }

	// RVA: 0x222B6F0 Offset: 0x2229CF0 VA: 0x18222B6F0
	private void SetWriterAcquired() { }

	// RVA: 0x222A8C0 Offset: 0x2228EC0 VA: 0x18222A8C0
	private void ClearWriterAcquired() { }

	// RVA: 0x222B700 Offset: 0x2229D00 VA: 0x18222B700
	private void SetWritersWaiting() { }

	// RVA: 0x222A8D0 Offset: 0x2228ED0 VA: 0x18222A8D0
	private void ClearWritersWaiting() { }

	// RVA: 0x222B6E0 Offset: 0x2229CE0 VA: 0x18222B6E0
	private void SetUpgraderWaiting() { }

	// RVA: 0x222A8B0 Offset: 0x2228EB0 VA: 0x18222A8B0
	private void ClearUpgraderWaiting() { }

	// RVA: 0x222B330 Offset: 0x2229930 VA: 0x18222B330
	private uint GetNumReaders() { }

	// RVA: 0x222AC80 Offset: 0x2229280 VA: 0x18222AC80
	private void EnterMyLock() { }

	// RVA: 0x222ABF0 Offset: 0x22291F0 VA: 0x18222ABF0
	private void EnterMyLockSpin() { }

	// RVA: 0x222AF90 Offset: 0x2229590 VA: 0x18222AF90
	private void ExitMyLock() { }

	// RVA: 0x222B710 Offset: 0x2229D10 VA: 0x18222B710
	private static void SpinWait(int SpinCount) { }

	// RVA: 0x222A8E0 Offset: 0x2228EE0 VA: 0x18222A8E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x222A8F0 Offset: 0x2228EF0 VA: 0x18222A8F0
	private void Dispose(bool disposing) { }

	// RVA: 0x222C770 Offset: 0x222AD70 VA: 0x18222C770
	public bool get_IsReadLockHeld() { }

	// RVA: 0x222C7E0 Offset: 0x222ADE0 VA: 0x18222C7E0
	public bool get_IsUpgradeableReadLockHeld() { }

	// RVA: 0x222C870 Offset: 0x222AE70 VA: 0x18222C870
	public bool get_IsWriteLockHeld() { }

	// RVA: 0x222C900 Offset: 0x222AF00 VA: 0x18222C900
	public int get_RecursiveReadCount() { }

	// RVA: 0x222C970 Offset: 0x222AF70 VA: 0x18222C970
	public int get_RecursiveUpgradeCount() { }

	// RVA: 0x222CA20 Offset: 0x222B020 VA: 0x18222CA20
	public int get_RecursiveWriteCount() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_WaitingReadCount() { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
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

