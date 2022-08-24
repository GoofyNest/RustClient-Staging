public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1357
{	private bool inited; // 0x20


	[ReliabilityContractAttribute] // RVA: 0xE0FC0 Offset: 0xE03C0 VA: 0x1800E0FC0
	[CLSCompliantAttribute] // RVA: 0xE0FC0 Offset: 0xE03C0 VA: 0x1800E0FC0
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	public void ReleasePointer() { }

}

