public static class Monitor // TypeDefIndex: 788
{	// Methods

	// RVA: 0x14962A0 Offset: 0x14948A0 VA: 0x1814962A0
	public static void Enter(object obj) { }

	// RVA: 0x14962B0 Offset: 0x14948B0 VA: 0x1814962B0
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x14967F0 Offset: 0x1494DF0 VA: 0x1814967F0
	private static void ThrowLockTakenException() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1496340 Offset: 0x1494940 VA: 0x181496340
	public static void Exit(object obj) { }

	// RVA: 0x1496860 Offset: 0x1494E60 VA: 0x181496860
	public static void TryEnter(object obj, ref bool lockTaken) { }

	// RVA: 0x14968F0 Offset: 0x1494EF0 VA: 0x1814968F0
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x14968F0 Offset: 0x1494EF0 VA: 0x1814968F0
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x14965F0 Offset: 0x1494BF0 VA: 0x1814965F0
	public static void Pulse(object obj) { }

	// RVA: 0x1496530 Offset: 0x1494B30 VA: 0x181496530
	public static void PulseAll(object obj) { }

	// RVA: 0x1496370 Offset: 0x1494970 VA: 0x181496370
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x1496360 Offset: 0x1494960 VA: 0x181496360
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x1496400 Offset: 0x1494A00 VA: 0x181496400
	private static void ObjPulse(object obj) { }

	// RVA: 0x1496350 Offset: 0x1494950 VA: 0x181496350
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x1496390 Offset: 0x1494990 VA: 0x181496390
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x1496380 Offset: 0x1494980 VA: 0x181496380
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x1496470 Offset: 0x1494A70 VA: 0x181496470
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x1496A00 Offset: 0x1495000 VA: 0x181496A00
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x14966B0 Offset: 0x1494CB0 VA: 0x1814966B0
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x1496770 Offset: 0x1494D70 VA: 0x181496770
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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public RenderTexture get_output() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	protected void set_output(RenderTexture value) { }

	// RVA: 0x101A3C0 Offset: 0x10189C0 VA: 0x18101A3C0
	public bool IsRequestedAndSupported(PostProcessRenderContext context) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 5
	internal virtual bool NeedsHalfRes() { }

	// RVA: 0x101A230 Offset: 0x1018830 VA: 0x18101A230
	protected void CheckOutput(int width, int height) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal virtual void OnEnable() { }

	// RVA: 0x101A460 Offset: 0x1018A60 VA: 0x18101A460 Slot: 7
	internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void Render(PostProcessRenderContext context);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

