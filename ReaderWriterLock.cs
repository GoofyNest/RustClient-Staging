public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 829
{	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Methods

	// RVA: 0x14979F0 Offset: 0x1495FF0 VA: 0x1814979F0
	public void .ctor() { }

	// RVA: 0x1497750 Offset: 0x1495D50 VA: 0x181497750 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1497740 Offset: 0x1495D40 VA: 0x181497740
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x1497530 Offset: 0x1495B30 VA: 0x181497530
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x14977E0 Offset: 0x1495DE0 VA: 0x1814977E0
	public void ReleaseWriterLock() { }

	// RVA: 0x1497990 Offset: 0x1495F90 VA: 0x181497990
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x14977B0 Offset: 0x1495DB0 VA: 0x1814977B0
	private bool HasWriterLock() { }

}

