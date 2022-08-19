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

	// RVA: 0x1491570 Offset: 0x148FB70 VA: 0x181491570
	private static void LinkedTokenCancelDelegate(object source) { }

	// RVA: 0x1491CC0 Offset: 0x14902C0 VA: 0x181491CC0
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1491CA0 Offset: 0x14902A0 VA: 0x181491CA0
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	internal bool get_IsDisposed() { }

	// RVA: 0x1491D70 Offset: 0x1490370 VA: 0x181491D70
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x1491CE0 Offset: 0x14902E0 VA: 0x181491CE0
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x1491D00 Offset: 0x1490300 VA: 0x181491D00
	public CancellationToken get_Token() { }

	// RVA: 0x1491C60 Offset: 0x1490260 VA: 0x181491C60
	internal bool get_CanBeCanceled() { }

	// RVA: 0x1491C80 Offset: 0x1490280 VA: 0x181491C80
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x1491BE0 Offset: 0x14901E0 VA: 0x181491BE0
	public void .ctor() { }

	// RVA: 0x1491C20 Offset: 0x1490220 VA: 0x181491C20
	private void .ctor(bool set) { }

	// RVA: 0x1490720 Offset: 0x148ED20 VA: 0x181490720
	public void Cancel() { }

	// RVA: 0x1490790 Offset: 0x148ED90 VA: 0x181490790
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x1490690 Offset: 0x148EC90 VA: 0x181490690
	public void CancelAfter(TimeSpan delay) { }

	// RVA: 0x14904C0 Offset: 0x148EAC0 VA: 0x1814904C0
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x1491850 Offset: 0x148FE50 VA: 0x181491850
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x1490BA0 Offset: 0x148F1A0 VA: 0x181490BA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1490C10 Offset: 0x148F210 VA: 0x181490C10 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1491780 Offset: 0x148FD80 VA: 0x181491780
	internal void ThrowIfDisposed() { }

	// RVA: 0x14917E0 Offset: 0x148FDE0 VA: 0x1814917E0
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x1491100 Offset: 0x148F700 VA: 0x181491100
	internal static CancellationTokenSource InternalGetStaticSource(bool set) { }

	// RVA: 0x14911A0 Offset: 0x148F7A0 VA: 0x1814911A0
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x1491670 Offset: 0x148FC70 VA: 0x181491670
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x1490D30 Offset: 0x148F330 VA: 0x181490D30
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x1490800 Offset: 0x148EE00 VA: 0x181490800
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x1490880 Offset: 0x148EE80 VA: 0x181490880
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x1490950 Offset: 0x148EF50 VA: 0x181490950
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x1491970 Offset: 0x148FF70 VA: 0x181491970
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x1491A70 Offset: 0x1490070 VA: 0x181491A70
	private static void .cctor() { }

}

