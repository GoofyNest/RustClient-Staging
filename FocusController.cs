public class FocusController // TypeDefIndex: 4589
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly IFocusRing <focusRing>k__BackingField; // 0x10
	private List<FocusController.FocusedElement> m_FocusedElements; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private int <imguiKeyboardControl>k__BackingField; // 0x20

	// Properties
	private IFocusRing focusRing { get; }
	internal int imguiKeyboardControl { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	private IFocusRing get_focusRing() { }

	// RVA: 0xEAFFD0 Offset: 0xEAE5D0 VA: 0x180EAFFD0
	internal Focusable GetLeafFocusedElement() { }

	// RVA: 0xEAFE60 Offset: 0xEAE460 VA: 0x180EAFE60
	internal void DoFocusChange(Focusable f) { }

	// RVA: 0xEAFD60 Offset: 0xEAE360 VA: 0x180EAFD60
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xEB0130 Offset: 0xEAE730 VA: 0x180EB0130
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xEAFC60 Offset: 0xEAE260 VA: 0x180EAFC60
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xEB0030 Offset: 0xEAE630 VA: 0x180EB0030
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xEB0500 Offset: 0xEAEB00 VA: 0x180EB0500
	private void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction) { }

	// RVA: 0xEB0230 Offset: 0xEAE830 VA: 0x180EB0230
	internal Focusable SwitchFocusOnEvent(EventBase e) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal int get_imguiKeyboardControl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	internal void set_imguiKeyboardControl(int value) { }

	// RVA: 0xEB07D0 Offset: 0xEAEDD0 VA: 0x180EB07D0
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

private struct FocusController.FocusedElement // TypeDefIndex: 4590
{	// Fields
	public VisualElement m_SubTreeRoot; // 0x0
	public Focusable m_FocusedElement; // 0x8

}

