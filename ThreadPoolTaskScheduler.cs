internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 893
{	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x13EF3

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x160AF70 Offset: 0x1609570 VA: 0x18160AF70
	internal void .ctor() { }

	// RVA: 0x160AB50 Offset: 0x1609150 VA: 0x18160AB50
	private static void LongRunningThreadWork(object obj) { }

	// RVA: 0x160ACA0 Offset: 0x16092A0 VA: 0x18160ACA0 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x160AE00 Offset: 0x1609400 VA: 0x18160AE00 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x160ADF0 Offset: 0x16093F0 VA: 0x18160ADF0 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x160AC00 Offset: 0x1609200 VA: 0x18160AC00 Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x160AF00 Offset: 0x1609500 VA: 0x18160AF00
	private static void .cctor() { }

}

