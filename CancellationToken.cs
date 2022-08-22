public struct CancellationToken // TypeDefIndex: 749
{	// Fields
	private CancellationTokenSource m_source; // 0x0
	private static readonly Action<object> s_ActionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }

	// Methods

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	public static CancellationToken get_None() { }

	// RVA: 0x1F0AB0 Offset: 0x1EFEB0 VA: 0x1801F0AB0
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1F0A80 Offset: 0x1EFE80 VA: 0x1801F0A80
	public bool get_CanBeCanceled() { }

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x1F0A00 Offset: 0x1EFE00 VA: 0x1801F0A00
	public void .ctor(bool canceled) { }

	// RVA: 0x1491130 Offset: 0x148F730 VA: 0x181491130
	private static void ActionToActionObjShunt(object obj) { }

	// RVA: 0x1F0840 Offset: 0x1EFC40 VA: 0x1801F0840
	public CancellationTokenRegistration Register(Action<object> callback, object state) { }

	// RVA: 0x1F07F0 Offset: 0x1EFBF0 VA: 0x1801F07F0
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x1F0910 Offset: 0x1EFD10 VA: 0x1801F0910
	private CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0x1F0710 Offset: 0x1EFB10 VA: 0x1801F0710
	public bool Equals(CancellationToken other) { }

	// RVA: 0x1F0680 Offset: 0x1EFA80 VA: 0x1801F0680 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1F0720 Offset: 0x1EFB20 VA: 0x1801F0720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1491860 Offset: 0x148FE60 VA: 0x181491860
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x1491880 Offset: 0x148FE80 VA: 0x181491880
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x1F0950 Offset: 0x1EFD50 VA: 0x1801F0950
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x1F0990 Offset: 0x1EFD90 VA: 0x1801F0990
	internal void ThrowIfSourceDisposed() { }

	// RVA: 0x1F09F0 Offset: 0x1EFDF0 VA: 0x1801F09F0
	private void ThrowOperationCanceledException() { }

	// RVA: 0x1491620 Offset: 0x148FC20 VA: 0x181491620
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x1491710 Offset: 0x148FD10 VA: 0x181491710
	private static void .cctor() { }

}

