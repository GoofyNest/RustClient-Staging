internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 893
{	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x13C90

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x15F8290 Offset: 0x15F6890 VA: 0x1815F8290
	internal void .ctor() { }

	// RVA: 0x15F7E70 Offset: 0x15F6470 VA: 0x1815F7E70
	private static void LongRunningThreadWork(object obj) { }

	// RVA: 0x15F7FC0 Offset: 0x15F65C0 VA: 0x1815F7FC0 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x15F8120 Offset: 0x15F6720 VA: 0x1815F8120 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x15F8110 Offset: 0x15F6710 VA: 0x1815F8110 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x15F7F20 Offset: 0x15F6520 VA: 0x1815F7F20 Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x15F8220 Offset: 0x15F6820 VA: 0x1815F8220
	private static void .cctor() { }

}

