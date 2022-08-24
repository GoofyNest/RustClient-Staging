public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1345
{	protected IntPtr handle; // 0x10
	private bool _isClosed; // 0x18

	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }


	[ReliabilityContractAttribute] // RVA: 0x83D60 Offset: 0x83160 VA: 0x180083D60
	protected void .ctor(IntPtr invalidHandleValue) { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	private void Cleanup() { }

	private static void FireCustomerDebugProbe() { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	protected abstract bool ReleaseHandle();

}

