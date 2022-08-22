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

	// RVA: 0x1608AC0 Offset: 0x16070C0 VA: 0x181608AC0
	internal void .ctor(Task task) { }

	// RVA: 0x1608A70 Offset: 0x1607070 VA: 0x181608A70
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x1608120 Offset: 0x1606720 VA: 0x181608120
	private static void EnsureADUnloadCallbackRegistered() { }

	// RVA: 0x1607ED0 Offset: 0x16064D0 VA: 0x181607ED0
	private static void AppDomainUnloadCallback(object sender, EventArgs e) { }

	// RVA: 0x1608250 Offset: 0x1606850 VA: 0x181608250 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1608C50 Offset: 0x1607250 VA: 0x181608C50
	internal bool get_ContainsFaultList() { }

	// RVA: 0x1607DB0 Offset: 0x16063B0 VA: 0x181607DB0
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x1608970 Offset: 0x1606F70 VA: 0x181608970
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x1607960 Offset: 0x1605F60 VA: 0x181607960
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x16088F0 Offset: 0x1606EF0 VA: 0x1816088F0
	private void MarkAsUnhandled() { }

	// RVA: 0x1608860 Offset: 0x1606E60 VA: 0x181608860
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x1607F30 Offset: 0x1606530 VA: 0x181607F30
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x1608790 Offset: 0x1606D90 VA: 0x181608790
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x1608A80 Offset: 0x1607080 VA: 0x181608A80
	private static void .cctor() { }

}

