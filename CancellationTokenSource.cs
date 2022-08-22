public class CancellationTokenSource : IDisposable // TypeDefIndex: 751
{	// Fields
	private static readonly CancellationTokenSource _staticSource_Set; // 0x0
	private static readonly CancellationTokenSource _staticSource_NotCancelable; // 0x8
	private static readonly int s_nLists; // 0x10
	private ManualResetEvent m_kernelEvent; // 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] m_registeredCallbacksLists; // 0x18
	private const int CANNOT_BE_CANCELED = 0;
	private const int NOT_CANCELED = 1;
	private const int NOTIFYING = 2;
	private const int NOTIFYINGCOMPLETE = 3;
	private int m_state; // 0x20
	private int m_threadIDExecutingCallbacks; // 0x24
	private bool m_disposed; // 0x28
	private CancellationTokenRegistration[] m_linkingRegistrations; // 0x30
	private static readonly Action<object> s_LinkedTokenCancelDelegate; // 0x18
	private CancellationCallbackInfo m_executingCallback; // 0x38
	private Timer m_timer; // 0x40
	private static readonly TimerCallback s_timerCallback; // 0x20

	// Properties
	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal bool CanBeCanceled { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }

	// Methods

	// RVA: 0x1490900 Offset: 0x148EF00 VA: 0x181490900
	private static void LinkedTokenCancelDelegate(object source) { }

	// RVA: 0x1491050 Offset: 0x148F650 VA: 0x181491050
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1491030 Offset: 0x148F630 VA: 0x181491030
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	internal bool get_IsDisposed() { }

	// RVA: 0x1491100 Offset: 0x148F700 VA: 0x181491100
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x1491070 Offset: 0x148F670 VA: 0x181491070
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x1491090 Offset: 0x148F690 VA: 0x181491090
	public CancellationToken get_Token() { }

	// RVA: 0x1490FF0 Offset: 0x148F5F0 VA: 0x181490FF0
	internal bool get_CanBeCanceled() { }

	// RVA: 0x1491010 Offset: 0x148F610 VA: 0x181491010
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x1490F70 Offset: 0x148F570 VA: 0x181490F70
	public void .ctor() { }

	// RVA: 0x1490FB0 Offset: 0x148F5B0 VA: 0x181490FB0
	private void .ctor(bool set) { }

	// RVA: 0x148FAB0 Offset: 0x148E0B0 VA: 0x18148FAB0
	public void Cancel() { }

	// RVA: 0x148FB20 Offset: 0x148E120 VA: 0x18148FB20
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x148FA20 Offset: 0x148E020 VA: 0x18148FA20
	public void CancelAfter(TimeSpan delay) { }

	// RVA: 0x148F850 Offset: 0x148DE50 VA: 0x18148F850
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x1490BE0 Offset: 0x148F1E0 VA: 0x181490BE0
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x148FF30 Offset: 0x148E530 VA: 0x18148FF30 Slot: 4
	public void Dispose() { }

	// RVA: 0x148FFA0 Offset: 0x148E5A0 VA: 0x18148FFA0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1490B10 Offset: 0x148F110 VA: 0x181490B10
	internal void ThrowIfDisposed() { }

	// RVA: 0x1490B70 Offset: 0x148F170 VA: 0x181490B70
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x1490490 Offset: 0x148EA90 VA: 0x181490490
	internal static CancellationTokenSource InternalGetStaticSource(bool set) { }

	// RVA: 0x1490530 Offset: 0x148EB30 VA: 0x181490530
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x1490A00 Offset: 0x148F000 VA: 0x181490A00
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x14900C0 Offset: 0x148E6C0 VA: 0x1814900C0
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x148FB90 Offset: 0x148E190 VA: 0x18148FB90
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x148FC10 Offset: 0x148E210 VA: 0x18148FC10
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x148FCE0 Offset: 0x148E2E0 VA: 0x18148FCE0
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x1490D00 Offset: 0x148F300 VA: 0x181490D00
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x1490E00 Offset: 0x148F400 VA: 0x181490E00
	private static void .cctor() { }

}

