internal class TaskExceptionHolder // TypeDefIndex: 883
{	// Fields
	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private static bool s_domainUnloadStarted; // 0x1
	private static EventHandler s_adUnloadEventHandler; // 0x8
	private readonly Task m_task; // 0x10
	private List<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	// Properties
	internal bool ContainsFaultList { get; }

	// Methods

	// RVA: 0x15F5DE0 Offset: 0x15F43E0 VA: 0x1815F5DE0
	internal void .ctor(Task task) { }

	// RVA: 0x15F5D90 Offset: 0x15F4390 VA: 0x1815F5D90
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x15F5440 Offset: 0x15F3A40 VA: 0x1815F5440
	private static void EnsureADUnloadCallbackRegistered() { }

	// RVA: 0x15F51F0 Offset: 0x15F37F0 VA: 0x1815F51F0
	private static void AppDomainUnloadCallback(object sender, EventArgs e) { }

	// RVA: 0x15F5570 Offset: 0x15F3B70 VA: 0x1815F5570 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15F5F70 Offset: 0x15F4570 VA: 0x1815F5F70
	internal bool get_ContainsFaultList() { }

	// RVA: 0x15F50D0 Offset: 0x15F36D0 VA: 0x1815F50D0
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x15F5C90 Offset: 0x15F4290 VA: 0x1815F5C90
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x15F4C80 Offset: 0x15F3280 VA: 0x1815F4C80
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x15F5C10 Offset: 0x15F4210 VA: 0x1815F5C10
	private void MarkAsUnhandled() { }

	// RVA: 0x15F5B80 Offset: 0x15F4180 VA: 0x1815F5B80
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x15F5250 Offset: 0x15F3850 VA: 0x1815F5250
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x15F5AB0 Offset: 0x15F40B0 VA: 0x1815F5AB0
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15F5DA0 Offset: 0x15F43A0 VA: 0x1815F5DA0
	private static void .cctor() { }

}

