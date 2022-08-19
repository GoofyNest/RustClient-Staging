public struct CancellationToken // TypeDefIndex: 749
{	// Fields
	private CancellationTokenSource m_source; // 0x0
	private static readonly Action<object> s_ActionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public static CancellationToken get_None() { }

	// RVA: 0x1F0710 Offset: 0x1EFB10 VA: 0x1801F0710
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1F06E0 Offset: 0x1EFAE0 VA: 0x1801F06E0
	public bool get_CanBeCanceled() { }

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x1F0660 Offset: 0x1EFA60 VA: 0x1801F0660
	public void .ctor(bool canceled) { }

	// RVA: 0x1491DA0 Offset: 0x14903A0 VA: 0x181491DA0
	private static void ActionToActionObjShunt(object obj) { }

	// RVA: 0x1F04A0 Offset: 0x1EF8A0 VA: 0x1801F04A0
	public CancellationTokenRegistration Register(Action<object> callback, object state) { }

	// RVA: 0x1F0450 Offset: 0x1EF850 VA: 0x1801F0450
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x1F0570 Offset: 0x1EF970 VA: 0x1801F0570
	private CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0x1F0370 Offset: 0x1EF770 VA: 0x1801F0370
	public bool Equals(CancellationToken other) { }

	// RVA: 0x1F02E0 Offset: 0x1EF6E0 VA: 0x1801F02E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1F0380 Offset: 0x1EF780 VA: 0x1801F0380 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14924D0 Offset: 0x1490AD0 VA: 0x1814924D0
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x14924F0 Offset: 0x1490AF0 VA: 0x1814924F0
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x1F05B0 Offset: 0x1EF9B0 VA: 0x1801F05B0
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x1F05F0 Offset: 0x1EF9F0 VA: 0x1801F05F0
	internal void ThrowIfSourceDisposed() { }

	// RVA: 0x1F0650 Offset: 0x1EFA50 VA: 0x1801F0650
	private void ThrowOperationCanceledException() { }

	// RVA: 0x1492290 Offset: 0x1490890 VA: 0x181492290
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x1492380 Offset: 0x1490980 VA: 0x181492380
	private static void .cctor() { }

}

