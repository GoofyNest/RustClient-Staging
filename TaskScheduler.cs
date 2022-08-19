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

	// RVA: 0x1609840 Offset: 0x1607E40 VA: 0x181609840
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x16096C0 Offset: 0x1607CC0 VA: 0x1816096C0
	internal void InternalQueueTask(Task task) { }

	// RVA: 0x1609AF0 Offset: 0x16080F0 VA: 0x181609AF0
	protected void .ctor() { }

	// RVA: 0x16095D0 Offset: 0x1607BD0 VA: 0x1816095D0
	private void AddToActiveTaskSchedulers() { }

	// RVA: 0x1609D00 Offset: 0x1608300 VA: 0x181609D00
	public static TaskScheduler get_Default() { }

	// RVA: 0x1609C30 Offset: 0x1608230 VA: 0x181609C30
	public static TaskScheduler get_Current() { }

	// RVA: 0x1609E10 Offset: 0x1608410 VA: 0x181609E10
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x1609D60 Offset: 0x1608360 VA: 0x181609D60
	public int get_Id() { }

	// RVA: 0x16096F0 Offset: 0x1607CF0 VA: 0x1816096F0
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x1609A50 Offset: 0x1608050 VA: 0x181609A50
	private static void .cctor() { }

}

