public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1357
{	private bool inited; // 0x20


	[ReliabilityContractAttribute] // RVA: 0xE10F0 Offset: 0xE04F0 VA: 0x1800E10F0
	[CLSCompliantAttribute] // RVA: 0xE10F0 Offset: 0xE04F0 VA: 0x1800E10F0
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public void ReleasePointer() { }

}

