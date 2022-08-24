internal struct ExecutionContextSwitcher // TypeDefIndex: 781
{	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18


	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB45B0 Offset: 0xB39B0 VA: 0x1800B45B0
	[ReliabilityContractAttribute] // RVA: 0xB45B0 Offset: 0xB39B0 VA: 0x1800B45B0
	internal bool UndoNoThrow() { }

	[ReliabilityContractAttribute] // RVA: 0x83D60 Offset: 0x83160 VA: 0x180083D60
	internal void Undo() { }

}

