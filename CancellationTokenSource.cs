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

	// RVA: 0x1491830 Offset: 0x148FE30 VA: 0x181491830
	private static void LinkedTokenCancelDelegate(object source) { }

	// RVA: 0x1491F80 Offset: 0x1490580 VA: 0x181491F80
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1491F60 Offset: 0x1490560 VA: 0x181491F60
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	internal bool get_IsDisposed() { }

	// RVA: 0x1492030 Offset: 0x1490630 VA: 0x181492030
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x1491FA0 Offset: 0x14905A0 VA: 0x181491FA0
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x1491FC0 Offset: 0x14905C0 VA: 0x181491FC0
	public CancellationToken get_Token() { }

	// RVA: 0x1491F20 Offset: 0x1490520 VA: 0x181491F20
	internal bool get_CanBeCanceled() { }

	// RVA: 0x1491F40 Offset: 0x1490540 VA: 0x181491F40
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x1491EA0 Offset: 0x14904A0 VA: 0x181491EA0
	public void .ctor() { }

	// RVA: 0x1491EE0 Offset: 0x14904E0 VA: 0x181491EE0
	private void .ctor(bool set) { }

	// RVA: 0x14909E0 Offset: 0x148EFE0 VA: 0x1814909E0
	public void Cancel() { }

	// RVA: 0x1490A50 Offset: 0x148F050 VA: 0x181490A50
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x1490950 Offset: 0x148EF50 VA: 0x181490950
	public void CancelAfter(TimeSpan delay) { }

	// RVA: 0x1490780 Offset: 0x148ED80 VA: 0x181490780
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x1491B10 Offset: 0x1490110 VA: 0x181491B10
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x1490E60 Offset: 0x148F460 VA: 0x181490E60 Slot: 4
	public void Dispose() { }

	// RVA: 0x1490ED0 Offset: 0x148F4D0 VA: 0x181490ED0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1491A40 Offset: 0x1490040 VA: 0x181491A40
	internal void ThrowIfDisposed() { }

	// RVA: 0x1491AA0 Offset: 0x14900A0 VA: 0x181491AA0
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x14913C0 Offset: 0x148F9C0 VA: 0x1814913C0
	internal static CancellationTokenSource InternalGetStaticSource(bool set) { }

	// RVA: 0x1491460 Offset: 0x148FA60 VA: 0x181491460
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x1491930 Offset: 0x148FF30 VA: 0x181491930
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x1490FF0 Offset: 0x148F5F0 VA: 0x181490FF0
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x1490AC0 Offset: 0x148F0C0 VA: 0x181490AC0
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x1490B40 Offset: 0x148F140 VA: 0x181490B40
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x1490C10 Offset: 0x148F210 VA: 0x181490C10
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x1491C30 Offset: 0x1490230 VA: 0x181491C30
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x1491D30 Offset: 0x1490330 VA: 0x181491D30
	private static void .cctor() { }

}

