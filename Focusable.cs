public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 4586
{	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private bool <focusable>k__BackingField; // 0x18
	internal bool isIMGUIContainer; // 0x19

	public abstract FocusController focusController { get; }
	public bool focusable { get; }
	public virtual bool canGrabFocus { get; }


	public abstract FocusController get_focusController();

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_focusable() { }

	public virtual bool get_canGrabFocus() { }

}

