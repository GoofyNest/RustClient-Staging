public static class Monitor // TypeDefIndex: 788
{	// Methods

	// RVA: 0x14971D0 Offset: 0x14957D0 VA: 0x1814971D0
	public static void Enter(object obj) { }

	// RVA: 0x14971E0 Offset: 0x14957E0 VA: 0x1814971E0
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x1497720 Offset: 0x1495D20 VA: 0x181497720
	private static void ThrowLockTakenException() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1497270 Offset: 0x1495870 VA: 0x181497270
	public static void Exit(object obj) { }

	// RVA: 0x1497790 Offset: 0x1495D90 VA: 0x181497790
	public static void TryEnter(object obj, ref bool lockTaken) { }

	// RVA: 0x1497820 Offset: 0x1495E20 VA: 0x181497820
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x1497820 Offset: 0x1495E20 VA: 0x181497820
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x1497520 Offset: 0x1495B20 VA: 0x181497520
	public static void Pulse(object obj) { }

	// RVA: 0x1497460 Offset: 0x1495A60 VA: 0x181497460
	public static void PulseAll(object obj) { }

	// RVA: 0x14972A0 Offset: 0x14958A0 VA: 0x1814972A0
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x1497290 Offset: 0x1495890 VA: 0x181497290
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x1497330 Offset: 0x1495930 VA: 0x181497330
	private static void ObjPulse(object obj) { }

	// RVA: 0x1497280 Offset: 0x1495880 VA: 0x181497280
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x14972C0 Offset: 0x14958C0 VA: 0x1814972C0
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x14972B0 Offset: 0x14958B0 VA: 0x1814972B0
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x14973A0 Offset: 0x14959A0 VA: 0x1814973A0
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x1497930 Offset: 0x1495F30 VA: 0x181497930
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x14975E0 Offset: 0x1495BE0 VA: 0x1814975E0
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x14976A0 Offset: 0x1495CA0 VA: 0x1814976A0
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

	// RVA: 0x1019920 Offset: 0x1017F20 VA: 0x181019920
	public bool IsRequestedAndSupported(PostProcessRenderContext context) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 5
	internal virtual bool NeedsHalfRes() { }

	// RVA: 0x1019790 Offset: 0x1017D90 VA: 0x181019790
	protected void CheckOutput(int width, int height) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal virtual void OnEnable() { }

	// RVA: 0x10199C0 Offset: 0x1017FC0 VA: 0x1810199C0 Slot: 7
	internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void Render(PostProcessRenderContext context);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

