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

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0xFF5A40 Offset: 0xFF4040 VA: 0x180FF5A40
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0xFE4C30 Offset: 0xFE3230 VA: 0x180FE4C30 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x8C1080 Offset: 0x8BF680 VA: 0x1808C1080
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x87A580 Offset: 0x878B80 VA: 0x18087A580
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0xFE4C10 Offset: 0xFE3210 VA: 0x180FE4C10
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0xFE4C10 Offset: 0xFE3210 VA: 0x180FE4C10 Slot: 4
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0xFF5810 Offset: 0xFF3E10 VA: 0x180FF5810 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0xFF5970 Offset: 0xFF3F70 VA: 0x180FF5970
	public void SetHandleAsInvalid() { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0xFF5530 Offset: 0xFF3B30 VA: 0x180FF5530
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0xFF5800 Offset: 0xFF3E00 VA: 0x180FF5800
	public void DangerousRelease() { }

	// RVA: 0xFF58C0 Offset: 0xFF3EC0 VA: 0x180FF58C0
	private void InternalDispose() { }

	// RVA: 0xFF5950 Offset: 0xFF3F50 VA: 0x180FF5950
	private void InternalFinalize() { }

	// RVA: 0xFF5650 Offset: 0xFF3C50 VA: 0x180FF5650
	private void DangerousReleaseInternal(bool dispose) { }

}

