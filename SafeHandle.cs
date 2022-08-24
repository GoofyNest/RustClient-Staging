public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1351
{	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }


	[ReliabilityContractAttribute] // RVA: 0x83D60 Offset: 0x83160 VA: 0x180083D60
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	protected abstract bool ReleaseHandle();

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public void SetHandleAsInvalid() { }

	[ReliabilityContractAttribute] // RVA: 0x83D60 Offset: 0x83160 VA: 0x180083D60
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public void DangerousRelease() { }

	private void InternalDispose() { }

	private void InternalFinalize() { }

	private void DangerousReleaseInternal(bool dispose) { }

}

