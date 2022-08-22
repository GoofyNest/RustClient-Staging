public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1345
{	// Fields
	protected IntPtr handle; // 0x10
	private bool _isClosed; // 0x18

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFE4CD0 Offset: 0xFE32D0 VA: 0x180FE4CD0
	protected void .ctor(IntPtr invalidHandleValue) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE4C30 Offset: 0xFE3230 VA: 0x180FE4C30 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE4B30 Offset: 0xFE3130 VA: 0x180FE4B30
	private void Cleanup() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void FireCustomerDebugProbe() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x8C1080 Offset: 0x8BF680 VA: 0x1808C1080
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE4C10 Offset: 0xFE3210 VA: 0x180FE4C10
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE4C10 Offset: 0xFE3210 VA: 0x180FE4C10 Slot: 4
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE4B30 Offset: 0xFE3130 VA: 0x180FE4B30 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

}

