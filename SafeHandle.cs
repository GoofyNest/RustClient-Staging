public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1351
{	// Fields
	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFF67A0 Offset: 0xFF4DA0 VA: 0x180FF67A0
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0xFE5990 Offset: 0xFE3F90 VA: 0x180FE5990 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x8C16A0 Offset: 0x8BFCA0 VA: 0x1808C16A0
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x85D9D0 Offset: 0x85BFD0 VA: 0x18085D9D0
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
	// RVA: 0xFF6570 Offset: 0xFF4B70 VA: 0x180FF6570 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFF66D0 Offset: 0xFF4CD0 VA: 0x180FF66D0
	public void SetHandleAsInvalid() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFF6290 Offset: 0xFF4890 VA: 0x180FF6290
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFF6560 Offset: 0xFF4B60 VA: 0x180FF6560
	public void DangerousRelease() { }

	// RVA: 0xFF6620 Offset: 0xFF4C20 VA: 0x180FF6620
	private void InternalDispose() { }

	// RVA: 0xFF66B0 Offset: 0xFF4CB0 VA: 0x180FF66B0
	private void InternalFinalize() { }

	// RVA: 0xFF63B0 Offset: 0xFF49B0 VA: 0x180FF63B0
	private void DangerousReleaseInternal(bool dispose) { }

}

