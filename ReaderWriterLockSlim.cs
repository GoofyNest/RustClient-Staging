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

	// RVA: 0x222C060 Offset: 0x222A660 VA: 0x18222C060
	private void InitializeThreadCounts() { }

	// RVA: 0x222D180 Offset: 0x222B780 VA: 0x18222D180
	public void .ctor() { }

	// RVA: 0x222D1E0 Offset: 0x222B7E0 VA: 0x18222D1E0
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x222C070 Offset: 0x222A670 VA: 0x18222C070
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x222C0B0 Offset: 0x222A6B0 VA: 0x18222C0B0
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x222BE20 Offset: 0x222A420 VA: 0x18222BE20
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x222B850 Offset: 0x2229E50 VA: 0x18222B850
	public void EnterWriteLock() { }

	// RVA: 0x222CF20 Offset: 0x222B520 VA: 0x18222CF20
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x222CFC0 Offset: 0x222B5C0 VA: 0x18222CFC0
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222C830 Offset: 0x222AE30 VA: 0x18222C830
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222B800 Offset: 0x2229E00 VA: 0x18222B800
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x222C780 Offset: 0x222AD80 VA: 0x18222C780
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x222C820 Offset: 0x222AE20 VA: 0x18222C820
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222C240 Offset: 0x222A840 VA: 0x18222C240
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222BC70 Offset: 0x222A270 VA: 0x18222BC70
	public void ExitWriteLock() { }

	// RVA: 0x222BA90 Offset: 0x222A090 VA: 0x18222BA90
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x222C0E0 Offset: 0x222A6E0 VA: 0x18222C0E0
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x222CFD0 Offset: 0x222B5D0 VA: 0x18222CFD0
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	// RVA: 0x222B9D0 Offset: 0x2229FD0 VA: 0x18222B9D0
	private void ExitAndWakeUpAppropriateWaiters() { }

	// RVA: 0x222B940 Offset: 0x2229F40 VA: 0x18222B940
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	// RVA: 0x222B8A0 Offset: 0x2229EA0 VA: 0x18222B8A0
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	// RVA: 0x222C0D0 Offset: 0x222A6D0 VA: 0x18222C0D0
	private bool IsWriterAcquired() { }

	// RVA: 0x222C1D0 Offset: 0x222A7D0 VA: 0x18222C1D0
	private void SetWriterAcquired() { }

	// RVA: 0x222B3A0 Offset: 0x22299A0 VA: 0x18222B3A0
	private void ClearWriterAcquired() { }

	// RVA: 0x222C1E0 Offset: 0x222A7E0 VA: 0x18222C1E0
	private void SetWritersWaiting() { }

	// RVA: 0x222B3B0 Offset: 0x22299B0 VA: 0x18222B3B0
	private void ClearWritersWaiting() { }

	// RVA: 0x222C1C0 Offset: 0x222A7C0 VA: 0x18222C1C0
	private void SetUpgraderWaiting() { }

	// RVA: 0x222B390 Offset: 0x2229990 VA: 0x18222B390
	private void ClearUpgraderWaiting() { }

	// RVA: 0x222BE10 Offset: 0x222A410 VA: 0x18222BE10
	private uint GetNumReaders() { }

	// RVA: 0x222B760 Offset: 0x2229D60 VA: 0x18222B760
	private void EnterMyLock() { }

	// RVA: 0x222B6D0 Offset: 0x2229CD0 VA: 0x18222B6D0
	private void EnterMyLockSpin() { }

	// RVA: 0x222BA70 Offset: 0x222A070 VA: 0x18222BA70
	private void ExitMyLock() { }

	// RVA: 0x222C1F0 Offset: 0x222A7F0 VA: 0x18222C1F0
	private static void SpinWait(int SpinCount) { }

	// RVA: 0x222B3C0 Offset: 0x22299C0 VA: 0x18222B3C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x222B3D0 Offset: 0x22299D0 VA: 0x18222B3D0
	private void Dispose(bool disposing) { }

	// RVA: 0x222D250 Offset: 0x222B850 VA: 0x18222D250
	public bool get_IsReadLockHeld() { }

	// RVA: 0x222D2C0 Offset: 0x222B8C0 VA: 0x18222D2C0
	public bool get_IsUpgradeableReadLockHeld() { }

	// RVA: 0x222D350 Offset: 0x222B950 VA: 0x18222D350
	public bool get_IsWriteLockHeld() { }

	// RVA: 0x222D3E0 Offset: 0x222B9E0 VA: 0x18222D3E0
	public int get_RecursiveReadCount() { }

	// RVA: 0x222D450 Offset: 0x222BA50 VA: 0x18222D450
	public int get_RecursiveUpgradeCount() { }

	// RVA: 0x222D500 Offset: 0x222BB00 VA: 0x18222D500
	public int get_RecursiveWriteCount() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public int get_WaitingReadCount() { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public int get_WaitingUpgradeCount() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
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

