public struct SpinLock // TypeDefIndex: 762
{	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x1F0AC0 Offset: 0x1EFEC0 VA: 0x1801F0AC0
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x1F0940 Offset: 0x1EFD40 VA: 0x1801F0940
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x1F0A30 Offset: 0x1EFE30 VA: 0x1801F0A30
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1F0920 Offset: 0x1EFD20 VA: 0x1801F0920
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1F0930 Offset: 0x1EFD30 VA: 0x1801F0930
	private void DecrementWaiters() { }

	// RVA: 0x1F0910 Offset: 0x1EFD10 VA: 0x1801F0910
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1F09D0 Offset: 0x1EFDD0 VA: 0x1801F09D0
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x1F09C0 Offset: 0x1EFDC0 VA: 0x1801F09C0
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1F0B00 Offset: 0x1EFF00 VA: 0x1801F0B00
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1F0B10 Offset: 0x1EFF10 VA: 0x1801F0B10
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x149B2B0 Offset: 0x14998B0 VA: 0x18149B2B0
	private static void .cctor() { }

}

