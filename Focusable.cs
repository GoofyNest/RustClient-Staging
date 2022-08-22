public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 4586
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private bool <focusable>k__BackingField; // 0x18
	internal bool isIMGUIContainer; // 0x19

	// Properties
	public abstract FocusController focusController { get; }
	public bool focusable { get; }
	public virtual bool canGrabFocus { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public abstract FocusController get_focusController();

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_focusable() { }

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0 Slot: 13
	public virtual bool get_canGrabFocus() { }

}

