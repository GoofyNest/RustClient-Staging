public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 4586
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private bool <focusable>k__BackingField; // 0x18
	internal bool isIMGUIContainer; // 0x19

	// Properties
	public abstract FocusController focusController { get; }
	public bool focusable { get; }
	public virtual bool canGrabFocus { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public abstract FocusController get_focusController();

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_focusable() { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0 Slot: 13
	public virtual bool get_canGrabFocus() { }

}

