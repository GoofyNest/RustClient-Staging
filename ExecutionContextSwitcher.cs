internal struct ExecutionContextSwitcher // TypeDefIndex: 781
{	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18


	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB4380 Offset: 0xB3780 VA: 0x1800B4380
	[ReliabilityContractAttribute] // RVA: 0xB4380 Offset: 0xB3780 VA: 0x1800B4380
	internal bool UndoNoThrow() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	internal void Undo() { }

}

