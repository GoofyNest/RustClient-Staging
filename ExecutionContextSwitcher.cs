internal struct ExecutionContextSwitcher // TypeDefIndex: 781
{	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB4350 Offset: 0xB3750 VA: 0x1800B4350
	[ReliabilityContractAttribute] // RVA: 0xB4350 Offset: 0xB3750 VA: 0x1800B4350
	// RVA: 0x1F0760 Offset: 0x1EFB60 VA: 0x1801F0760
	internal bool UndoNoThrow() { }

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x1F0770 Offset: 0x1EFB70 VA: 0x1801F0770
	internal void Undo() { }

}

