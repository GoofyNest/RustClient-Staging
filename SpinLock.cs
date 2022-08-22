public struct SpinLock // TypeDefIndex: 762
{	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x1F0A40 Offset: 0x1EFE40 VA: 0x1801F0A40
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x1F08C0 Offset: 0x1EFCC0 VA: 0x1801F08C0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x1F09B0 Offset: 0x1EFDB0 VA: 0x1801F09B0
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1F08A0 Offset: 0x1EFCA0 VA: 0x1801F08A0
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1F08B0 Offset: 0x1EFCB0 VA: 0x1801F08B0
	private void DecrementWaiters() { }

	// RVA: 0x1F0890 Offset: 0x1EFC90 VA: 0x1801F0890
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1F0950 Offset: 0x1EFD50 VA: 0x1801F0950
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x1F0940 Offset: 0x1EFD40 VA: 0x1801F0940
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1F0A80 Offset: 0x1EFE80 VA: 0x1801F0A80
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1F0A90 Offset: 0x1EFE90 VA: 0x1801F0A90
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x149B570 Offset: 0x1499B70 VA: 0x18149B570
	private static void .cctor() { }

}

