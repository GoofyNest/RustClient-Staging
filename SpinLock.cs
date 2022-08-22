public struct SpinLock // TypeDefIndex: 762
{	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x1F0E60 Offset: 0x1F0260 VA: 0x1801F0E60
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x1F0CE0 Offset: 0x1F00E0 VA: 0x1801F0CE0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x1F0DD0 Offset: 0x1F01D0 VA: 0x1801F0DD0
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1F0CC0 Offset: 0x1F00C0 VA: 0x1801F0CC0
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1F0CD0 Offset: 0x1F00D0 VA: 0x1801F0CD0
	private void DecrementWaiters() { }

	// RVA: 0x1F0CB0 Offset: 0x1F00B0 VA: 0x1801F0CB0
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1F0D70 Offset: 0x1F0170 VA: 0x1801F0D70
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x1F0D60 Offset: 0x1F0160 VA: 0x1801F0D60
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1F0EA0 Offset: 0x1F02A0 VA: 0x1801F0EA0
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1F0EB0 Offset: 0x1F02B0 VA: 0x1801F0EB0
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x149A640 Offset: 0x1498C40 VA: 0x18149A640
	private static void .cctor() { }

}

