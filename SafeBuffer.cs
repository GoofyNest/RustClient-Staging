public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1357
{	// Fields
	private bool inited; // 0x20

	// Methods

	[ReliabilityContractAttribute] // RVA: 0xE0FD0 Offset: 0xE03D0 VA: 0x1800E0FD0
	[CLSCompliantAttribute] // RVA: 0xE0FD0 Offset: 0xE03D0 VA: 0x1800E0FD0
	// RVA: 0xFF5430 Offset: 0xFF3A30 VA: 0x180FF5430
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFF54C0 Offset: 0xFF3AC0 VA: 0x180FF54C0
	public void ReleasePointer() { }

}

