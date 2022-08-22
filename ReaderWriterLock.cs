public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 829
{	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Methods

	// RVA: 0x1498660 Offset: 0x1496C60 VA: 0x181498660
	public void .ctor() { }

	// RVA: 0x14983C0 Offset: 0x14969C0 VA: 0x1814983C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x14983B0 Offset: 0x14969B0 VA: 0x1814983B0
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x14981A0 Offset: 0x14967A0 VA: 0x1814981A0
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1498450 Offset: 0x1496A50 VA: 0x181498450
	public void ReleaseWriterLock() { }

	// RVA: 0x1498600 Offset: 0x1496C00 VA: 0x181498600
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x1498420 Offset: 0x1496A20 VA: 0x181498420
	private bool HasWriterLock() { }

}

