public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1357
{	private bool inited; // 0x20


	[ReliabilityContractAttribute] // RVA: 0xE0FD0 Offset: 0xE03D0 VA: 0x1800E0FD0
	[CLSCompliantAttribute] // RVA: 0xE0FD0 Offset: 0xE03D0 VA: 0x1800E0FD0
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public void ReleasePointer() { }

}

