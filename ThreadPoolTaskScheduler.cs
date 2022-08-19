internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 893
{	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x13EF3

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x160ACB0 Offset: 0x16092B0 VA: 0x18160ACB0
	internal void .ctor() { }

	// RVA: 0x160A890 Offset: 0x1608E90 VA: 0x18160A890
	private static void LongRunningThreadWork(object obj) { }

	// RVA: 0x160A9E0 Offset: 0x1608FE0 VA: 0x18160A9E0 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x160AB40 Offset: 0x1609140 VA: 0x18160AB40 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x160AB30 Offset: 0x1609130 VA: 0x18160AB30 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x160A940 Offset: 0x1608F40 VA: 0x18160A940 Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x160AC40 Offset: 0x1609240 VA: 0x18160AC40
	private static void .cctor() { }

}

