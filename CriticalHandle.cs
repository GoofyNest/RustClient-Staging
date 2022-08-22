public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1345
{	protected IntPtr handle; // 0x10
	private bool _isClosed; // 0x18

	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }


	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	protected void .ctor(IntPtr invalidHandleValue) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	private void Cleanup() { }

	private static void FireCustomerDebugProbe() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	protected abstract bool ReleaseHandle();

}

