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
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x222B740 Offset: 0x2229D40 VA: 0x18222B740
	private void InitializeThreadCounts() { }

	// RVA: 0x222C860 Offset: 0x222AE60 VA: 0x18222C860
	public void .ctor() { }

	// RVA: 0x222C8C0 Offset: 0x222AEC0 VA: 0x18222C8C0
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x222B750 Offset: 0x2229D50 VA: 0x18222B750
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x222B790 Offset: 0x2229D90 VA: 0x18222B790
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x222B500 Offset: 0x2229B00 VA: 0x18222B500
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x222AF30 Offset: 0x2229530 VA: 0x18222AF30
	public void EnterWriteLock() { }

	// RVA: 0x222C600 Offset: 0x222AC00 VA: 0x18222C600
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x222C6A0 Offset: 0x222ACA0 VA: 0x18222C6A0
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222BF10 Offset: 0x222A510 VA: 0x18222BF10
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222AEE0 Offset: 0x22294E0 VA: 0x18222AEE0
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x222BE60 Offset: 0x222A460 VA: 0x18222BE60
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x222BF00 Offset: 0x222A500 VA: 0x18222BF00
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222B920 Offset: 0x2229F20 VA: 0x18222B920
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x222B350 Offset: 0x2229950 VA: 0x18222B350
	public void ExitWriteLock() { }

	// RVA: 0x222B170 Offset: 0x2229770 VA: 0x18222B170
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x222B7C0 Offset: 0x2229DC0 VA: 0x18222B7C0
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x222C6B0 Offset: 0x222ACB0 VA: 0x18222C6B0
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	// RVA: 0x222B0B0 Offset: 0x22296B0 VA: 0x18222B0B0
	private void ExitAndWakeUpAppropriateWaiters() { }

	// RVA: 0x222B020 Offset: 0x2229620 VA: 0x18222B020
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	// RVA: 0x222AF80 Offset: 0x2229580 VA: 0x18222AF80
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	// RVA: 0x222B7B0 Offset: 0x2229DB0 VA: 0x18222B7B0
	private bool IsWriterAcquired() { }

	// RVA: 0x222B8B0 Offset: 0x2229EB0 VA: 0x18222B8B0
	private void SetWriterAcquired() { }

	// RVA: 0x222AA80 Offset: 0x2229080 VA: 0x18222AA80
	private void ClearWriterAcquired() { }

	// RVA: 0x222B8C0 Offset: 0x2229EC0 VA: 0x18222B8C0
	private void SetWritersWaiting() { }

	// RVA: 0x222AA90 Offset: 0x2229090 VA: 0x18222AA90
	private void ClearWritersWaiting() { }

	// RVA: 0x222B8A0 Offset: 0x2229EA0 VA: 0x18222B8A0
	private void SetUpgraderWaiting() { }

	// RVA: 0x222AA70 Offset: 0x2229070 VA: 0x18222AA70
	private void ClearUpgraderWaiting() { }

	// RVA: 0x222B4F0 Offset: 0x2229AF0 VA: 0x18222B4F0
	private uint GetNumReaders() { }

	// RVA: 0x222AE40 Offset: 0x2229440 VA: 0x18222AE40
	private void EnterMyLock() { }

	// RVA: 0x222ADB0 Offset: 0x22293B0 VA: 0x18222ADB0
	private void EnterMyLockSpin() { }

	// RVA: 0x222B150 Offset: 0x2229750 VA: 0x18222B150
	private void ExitMyLock() { }

	// RVA: 0x222B8D0 Offset: 0x2229ED0 VA: 0x18222B8D0
	private static void SpinWait(int SpinCount) { }

	// RVA: 0x222AAA0 Offset: 0x22290A0 VA: 0x18222AAA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x222AAB0 Offset: 0x22290B0 VA: 0x18222AAB0
	private void Dispose(bool disposing) { }

	// RVA: 0x222C930 Offset: 0x222AF30 VA: 0x18222C930
	public bool get_IsReadLockHeld() { }

	// RVA: 0x222C9A0 Offset: 0x222AFA0 VA: 0x18222C9A0
	public bool get_IsUpgradeableReadLockHeld() { }

	// RVA: 0x222CA30 Offset: 0x222B030 VA: 0x18222CA30
	public bool get_IsWriteLockHeld() { }

	// RVA: 0x222CAC0 Offset: 0x222B0C0 VA: 0x18222CAC0
	public int get_RecursiveReadCount() { }

	// RVA: 0x222CB30 Offset: 0x222B130 VA: 0x18222CB30
	public int get_RecursiveUpgradeCount() { }

	// RVA: 0x222CBE0 Offset: 0x222B1E0 VA: 0x18222CBE0
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

	// RVA: 0x237790 Offset: 0x236B90 VA: 0x180237790
	public void .ctor(int millisecondsTimeout) { }

	// RVA: 0x2377F0 Offset: 0x236BF0 VA: 0x1802377F0
	public int get_RemainingMilliseconds() { }

	// RVA: 0x2377A0 Offset: 0x236BA0 VA: 0x1802377A0
	public bool get_IsExpired() { }

}

