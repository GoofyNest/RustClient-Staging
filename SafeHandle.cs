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
	// RVA: 0xFF5D00 Offset: 0xFF4300 VA: 0x180FF5D00
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0xFE4EF0 Offset: 0xFE34F0 VA: 0x180FE4EF0 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x8C1190 Offset: 0x8BF790 VA: 0x1808C1190
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x87A690 Offset: 0x878C90 VA: 0x18087A690
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE4ED0 Offset: 0xFE34D0 VA: 0x180FE4ED0
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFE4ED0 Offset: 0xFE34D0 VA: 0x180FE4ED0 Slot: 4
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFF5AD0 Offset: 0xFF40D0 VA: 0x180FF5AD0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFF5C30 Offset: 0xFF4230 VA: 0x180FF5C30
	public void SetHandleAsInvalid() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFF57F0 Offset: 0xFF3DF0 VA: 0x180FF57F0
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFF5AC0 Offset: 0xFF40C0 VA: 0x180FF5AC0
	public void DangerousRelease() { }

	// RVA: 0xFF5B80 Offset: 0xFF4180 VA: 0x180FF5B80
	private void InternalDispose() { }

	// RVA: 0xFF5C10 Offset: 0xFF4210 VA: 0x180FF5C10
	private void InternalFinalize() { }

	// RVA: 0xFF5910 Offset: 0xFF3F10 VA: 0x180FF5910
	private void DangerousReleaseInternal(bool dispose) { }

}

