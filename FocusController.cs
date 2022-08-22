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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	private IFocusRing get_focusRing() { }

	// RVA: 0xEAF260 Offset: 0xEAD860 VA: 0x180EAF260
	internal Focusable GetLeafFocusedElement() { }

	// RVA: 0xEAF0F0 Offset: 0xEAD6F0 VA: 0x180EAF0F0
	internal void DoFocusChange(Focusable f) { }

	// RVA: 0xEAEFF0 Offset: 0xEAD5F0 VA: 0x180EAEFF0
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xEAF3C0 Offset: 0xEAD9C0 VA: 0x180EAF3C0
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xEAEEF0 Offset: 0xEAD4F0 VA: 0x180EAEEF0
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xEAF2C0 Offset: 0xEAD8C0 VA: 0x180EAF2C0
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xEAF790 Offset: 0xEADD90 VA: 0x180EAF790
	private void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction) { }

	// RVA: 0xEAF4C0 Offset: 0xEADAC0 VA: 0x180EAF4C0
	internal Focusable SwitchFocusOnEvent(EventBase e) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_imguiKeyboardControl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	internal void set_imguiKeyboardControl(int value) { }

	// RVA: 0xEAFA60 Offset: 0xEAE060 VA: 0x180EAFA60
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

private struct FocusController.FocusedElement // TypeDefIndex: 4590
{	// Fields
	public VisualElement m_SubTreeRoot; // 0x0
	public Focusable m_FocusedElement; // 0x8

}

