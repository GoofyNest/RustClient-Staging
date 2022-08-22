public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1345
{	// Fields
	protected IntPtr handle; // 0x10
	private bool _isClosed; // 0x18

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFE5A30 Offset: 0xFE4030 VA: 0x180FE5A30
	protected void .ctor(IntPtr invalidHandleValue) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE5990 Offset: 0xFE3F90 VA: 0x180FE5990 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE5890 Offset: 0xFE3E90 VA: 0x180FE5890
	private void Cleanup() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void FireCustomerDebugProbe() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x8C16A0 Offset: 0x8BFCA0 VA: 0x1808C16A0
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE5970 Offset: 0xFE3F70 VA: 0x180FE5970
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE5970 Offset: 0xFE3F70 VA: 0x180FE5970 Slot: 4
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE5890 Offset: 0xFE3E90 VA: 0x180FE5890 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

}

