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

	// RVA: 0x1608800 Offset: 0x1606E00 VA: 0x181608800
	internal void .ctor(Task task) { }

	// RVA: 0x16087B0 Offset: 0x1606DB0 VA: 0x1816087B0
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x1607E60 Offset: 0x1606460 VA: 0x181607E60
	private static void EnsureADUnloadCallbackRegistered() { }

	// RVA: 0x1607C10 Offset: 0x1606210 VA: 0x181607C10
	private static void AppDomainUnloadCallback(object sender, EventArgs e) { }

	// RVA: 0x1607F90 Offset: 0x1606590 VA: 0x181607F90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1608990 Offset: 0x1606F90 VA: 0x181608990
	internal bool get_ContainsFaultList() { }

	// RVA: 0x1607AF0 Offset: 0x16060F0 VA: 0x181607AF0
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x16086B0 Offset: 0x1606CB0 VA: 0x1816086B0
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x16076A0 Offset: 0x1605CA0 VA: 0x1816076A0
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x1608630 Offset: 0x1606C30 VA: 0x181608630
	private void MarkAsUnhandled() { }

	// RVA: 0x16085A0 Offset: 0x1606BA0 VA: 0x1816085A0
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x1607C70 Offset: 0x1606270 VA: 0x181607C70
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x16084D0 Offset: 0x1606AD0 VA: 0x1816084D0
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x16087C0 Offset: 0x1606DC0 VA: 0x1816087C0
	private static void .cctor() { }

}

