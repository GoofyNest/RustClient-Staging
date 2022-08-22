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
	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	public bool get_Idle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774730 Offset: 0x772D30 VA: 0x180774730
	private void set_Idle(bool value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_Index() { }

	// RVA: 0x8449B0 Offset: 0x842FB0 VA: 0x1808449B0
	public void .ctor(Object sender, Action action, ActionPriority priority = 2) { }

	// RVA: 0x844750 Offset: 0x842D50 VA: 0x180844750
	public void Action() { }

	// RVA: 0x844920 Offset: 0x842F20 VA: 0x180844920
	public void Invoke() { }

	// RVA: 0x682990 Offset: 0x680F90 VA: 0x180682990
	public static bool op_Implicit(DeferredAction obj) { }

	// RVA: 0x844810 Offset: 0x842E10 VA: 0x180844810
	public static void Invoke(Object sender, Action action, ActionPriority priority = 2) { }

}

