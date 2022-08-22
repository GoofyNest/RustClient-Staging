public abstract class TaskScheduler // TypeDefIndex: 886
{	// Fields
	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers; // 0x0
	private static readonly TaskScheduler s_defaultTaskScheduler; // 0x8
	internal static int s_taskSchedulerIdCounter; // 0x10
	private int m_taskSchedulerId; // 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x18
	private static readonly object _unobservedTaskExceptionLockObject; // 0x20

	// Properties
	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract void QueueTask(Task task);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	// RVA: 0x1609B00 Offset: 0x1608100 VA: 0x181609B00
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x1609980 Offset: 0x1607F80 VA: 0x181609980
	internal void InternalQueueTask(Task task) { }

	// RVA: 0x1609DB0 Offset: 0x16083B0 VA: 0x181609DB0
	protected void .ctor() { }

	// RVA: 0x1609890 Offset: 0x1607E90 VA: 0x181609890
	private void AddToActiveTaskSchedulers() { }

	// RVA: 0x1609FC0 Offset: 0x16085C0 VA: 0x181609FC0
	public static TaskScheduler get_Default() { }

	// RVA: 0x1609EF0 Offset: 0x16084F0 VA: 0x181609EF0
	public static TaskScheduler get_Current() { }

	// RVA: 0x160A0D0 Offset: 0x16086D0 VA: 0x18160A0D0
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x160A020 Offset: 0x1608620 VA: 0x18160A020
	public int get_Id() { }

	// RVA: 0x16099B0 Offset: 0x1607FB0 VA: 0x1816099B0
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x1609D10 Offset: 0x1608310 VA: 0x181609D10
	private static void .cctor() { }

}

