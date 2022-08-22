public static class Monitor // TypeDefIndex: 788
{	// Methods

	// RVA: 0x1496F10 Offset: 0x1495510 VA: 0x181496F10
	public static void Enter(object obj) { }

	// RVA: 0x1496F20 Offset: 0x1495520 VA: 0x181496F20
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x1497460 Offset: 0x1495A60 VA: 0x181497460
	private static void ThrowLockTakenException() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1496FB0 Offset: 0x14955B0 VA: 0x181496FB0
	public static void Exit(object obj) { }

	// RVA: 0x14974D0 Offset: 0x1495AD0 VA: 0x1814974D0
	public static void TryEnter(object obj, ref bool lockTaken) { }

	// RVA: 0x1497560 Offset: 0x1495B60 VA: 0x181497560
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x1497560 Offset: 0x1495B60 VA: 0x181497560
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x1497260 Offset: 0x1495860 VA: 0x181497260
	public static void Pulse(object obj) { }

	// RVA: 0x14971A0 Offset: 0x14957A0 VA: 0x1814971A0
	public static void PulseAll(object obj) { }

	// RVA: 0x1496FE0 Offset: 0x14955E0 VA: 0x181496FE0
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x1496FD0 Offset: 0x14955D0 VA: 0x181496FD0
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x1497070 Offset: 0x1495670 VA: 0x181497070
	private static void ObjPulse(object obj) { }

	// RVA: 0x1496FC0 Offset: 0x14955C0 VA: 0x181496FC0
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x1497000 Offset: 0x1495600 VA: 0x181497000
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x1496FF0 Offset: 0x14955F0 VA: 0x181496FF0
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x14970E0 Offset: 0x14956E0 VA: 0x1814970E0
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x1497670 Offset: 0x1495C70 VA: 0x181497670
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1497320 Offset: 0x1495920 VA: 0x181497320
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x14973E0 Offset: 0x14959E0 VA: 0x1814973E0
	private static void ReliableEnter(object obj, ref bool lockTaken) { }

}

public abstract class Monitor // TypeDefIndex: 11821
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RenderTexture <output>k__BackingField; // 0x10
	internal bool requested; // 0x18

	// Properties
	public RenderTexture output { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public RenderTexture get_output() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	protected void set_output(RenderTexture value) { }

	// RVA: 0x1019660 Offset: 0x1017C60 VA: 0x181019660
	public bool IsRequestedAndSupported(PostProcessRenderContext context) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 5
	internal virtual bool NeedsHalfRes() { }

	// RVA: 0x10194D0 Offset: 0x1017AD0 VA: 0x1810194D0
	protected void CheckOutput(int width, int height) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal virtual void OnEnable() { }

	// RVA: 0x1019700 Offset: 0x1017D00 VA: 0x181019700 Slot: 7
	internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void Render(PostProcessRenderContext context);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

