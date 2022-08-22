public class DeferredAction // TypeDefIndex: 11313
{	// Fields
	private Object sender; // 0x10
	private Action action; // 0x18
	private ActionPriority priority; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Idle>k__BackingField; // 0x24

	// Properties
	public bool Idle { get; set; }
	public int Index { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747A0 Offset: 0x772DA0 VA: 0x1807747A0
	public bool get_Idle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747E0 Offset: 0x772DE0 VA: 0x1807747E0
	private void set_Idle(bool value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_Index() { }

	// RVA: 0x844460 Offset: 0x842A60 VA: 0x180844460
	public void .ctor(Object sender, Action action, ActionPriority priority = 2) { }

	// RVA: 0x844200 Offset: 0x842800 VA: 0x180844200
	public void Action() { }

	// RVA: 0x8443D0 Offset: 0x8429D0 VA: 0x1808443D0
	public void Invoke() { }

	// RVA: 0x682A00 Offset: 0x681000 VA: 0x180682A00
	public static bool op_Implicit(DeferredAction obj) { }

	// RVA: 0x8442C0 Offset: 0x8428C0 VA: 0x1808442C0
	public static void Invoke(Object sender, Action action, ActionPriority priority = 2) { }

}

