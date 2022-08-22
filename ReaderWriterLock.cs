public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 829
{	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Methods

	// RVA: 0x1498920 Offset: 0x1496F20 VA: 0x181498920
	public void .ctor() { }

	// RVA: 0x1498680 Offset: 0x1496C80 VA: 0x181498680 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1498670 Offset: 0x1496C70 VA: 0x181498670
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x1498460 Offset: 0x1496A60 VA: 0x181498460
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1498710 Offset: 0x1496D10 VA: 0x181498710
	public void ReleaseWriterLock() { }

	// RVA: 0x14988C0 Offset: 0x1496EC0 VA: 0x1814988C0
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x14986E0 Offset: 0x1496CE0 VA: 0x1814986E0
	private bool HasWriterLock() { }

}

