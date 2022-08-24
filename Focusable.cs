public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 4586
{	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private bool <focusable>k__BackingField; // 0x18
	internal bool isIMGUIContainer; // 0x19

	public abstract FocusController focusController { get; }
	public bool focusable { get; }
	public virtual bool canGrabFocus { get; }


	public abstract FocusController get_focusController();

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_focusable() { }

	public virtual bool get_canGrabFocus() { }

}

