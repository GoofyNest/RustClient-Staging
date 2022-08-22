public class FocusController // TypeDefIndex: 4589
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly IFocusRing <focusRing>k__BackingField; // 0x10
	private List<FocusController.FocusedElement> m_FocusedElements; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private int <imguiKeyboardControl>k__BackingField; // 0x20

	private IFocusRing focusRing { get; }
	internal int imguiKeyboardControl { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IFocusRing get_focusRing() { }

	internal Focusable GetLeafFocusedElement() { }

	internal void DoFocusChange(Focusable f) { }

	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	private void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction) { }

	internal Focusable SwitchFocusOnEvent(EventBase e) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal int get_imguiKeyboardControl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void set_imguiKeyboardControl(int value) { }

	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

private struct FocusController.FocusedElement // TypeDefIndex: 4590
{	public VisualElement m_SubTreeRoot; // 0x0
	public Focusable m_FocusedElement; // 0x8

}

