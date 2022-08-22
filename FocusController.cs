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

	// RVA: 0xEAF520 Offset: 0xEADB20 VA: 0x180EAF520
	internal Focusable GetLeafFocusedElement() { }

	// RVA: 0xEAF3B0 Offset: 0xEAD9B0 VA: 0x180EAF3B0
	internal void DoFocusChange(Focusable f) { }

	// RVA: 0xEAF2B0 Offset: 0xEAD8B0 VA: 0x180EAF2B0
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xEAF680 Offset: 0xEADC80 VA: 0x180EAF680
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0xEAF1B0 Offset: 0xEAD7B0 VA: 0x180EAF1B0
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xEAF580 Offset: 0xEADB80 VA: 0x180EAF580
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0xEAFA50 Offset: 0xEAE050 VA: 0x180EAFA50
	private void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction) { }

	// RVA: 0xEAF780 Offset: 0xEADD80 VA: 0x180EAF780
	internal Focusable SwitchFocusOnEvent(EventBase e) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_imguiKeyboardControl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	internal void set_imguiKeyboardControl(int value) { }

	// RVA: 0xEAFD20 Offset: 0xEAE320 VA: 0x180EAFD20
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

private struct FocusController.FocusedElement // TypeDefIndex: 4590
{	// Fields
	public VisualElement m_SubTreeRoot; // 0x0
	public Focusable m_FocusedElement; // 0x8

}

