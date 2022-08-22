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

	// RVA: 0x15F6E20 Offset: 0x15F5420 VA: 0x1815F6E20
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x15F6CA0 Offset: 0x15F52A0 VA: 0x1815F6CA0
	internal void InternalQueueTask(Task task) { }

	// RVA: 0x15F70D0 Offset: 0x15F56D0 VA: 0x1815F70D0
	protected void .ctor() { }

	// RVA: 0x15F6BB0 Offset: 0x15F51B0 VA: 0x1815F6BB0
	private void AddToActiveTaskSchedulers() { }

	// RVA: 0x15F72E0 Offset: 0x15F58E0 VA: 0x1815F72E0
	public static TaskScheduler get_Default() { }

	// RVA: 0x15F7210 Offset: 0x15F5810 VA: 0x1815F7210
	public static TaskScheduler get_Current() { }

	// RVA: 0x15F73F0 Offset: 0x15F59F0 VA: 0x1815F73F0
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x15F7340 Offset: 0x15F5940 VA: 0x1815F7340
	public int get_Id() { }

	// RVA: 0x15F6CD0 Offset: 0x15F52D0 VA: 0x1815F6CD0
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x15F7030 Offset: 0x15F5630 VA: 0x1815F7030
	private static void .cctor() { }

}

