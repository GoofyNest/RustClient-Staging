internal struct ExecutionContextSwitcher // TypeDefIndex: 781
{	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB4380 Offset: 0xB3780 VA: 0x1800B4380
	[ReliabilityContractAttribute] // RVA: 0xB4380 Offset: 0xB3780 VA: 0x1800B4380
	// RVA: 0x1F0B00 Offset: 0x1EFF00 VA: 0x1801F0B00
	internal bool UndoNoThrow() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x1F0B10 Offset: 0x1EFF10 VA: 0x1801F0B10
	internal void Undo() { }

}

