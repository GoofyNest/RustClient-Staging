public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1351
{	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }


	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public IntPtr DangerousGetHandle() { }

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

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public void SetHandleAsInvalid() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public void DangerousRelease() { }

	private void InternalDispose() { }

	private void InternalFinalize() { }

	private void DangerousReleaseInternal(bool dispose) { }

}

