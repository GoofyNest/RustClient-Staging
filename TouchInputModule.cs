public class TouchInputModule : PointerInputModule // TypeDefIndex: 5087
{	// Fields
	private Vector2 m_LastMousePosition; // 0x58
	private Vector2 m_MousePosition; // 0x60
	private PointerEventData m_InputPointerEvent; // 0x68
	[SerializeField] // RVA: 0x89090 Offset: 0x88490 VA: 0x180089090
	[FormerlySerializedAsAttribute] // RVA: 0x89090 Offset: 0x88490 VA: 0x180089090
	private bool m_ForceModuleActive; // 0x70

	// Properties
	[ObsoleteAttribute] // RVA: 0x89150 Offset: 0x88550 VA: 0x180089150
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }

	// Methods

	// RVA: 0x10CEEA0 Offset: 0x10CD4A0 VA: 0x1810CEEA0
	protected void .ctor() { }

	// RVA: 0xC315B0 Offset: 0xC2FBB0 VA: 0x180C315B0
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0xC326D0 Offset: 0xC30CD0 VA: 0x180C326D0
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0xC315B0 Offset: 0xC2FBB0 VA: 0x180C315B0
	public bool get_forceModuleActive() { }

	// RVA: 0xC326D0 Offset: 0xC30CD0 VA: 0x180C326D0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x10CED00 Offset: 0x10CD300 VA: 0x1810CED00 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x10CD8D0 Offset: 0x10CBED0 VA: 0x1810CD8D0 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x10CE900 Offset: 0x10CCF00 VA: 0x1810CE900 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x10CEE60 Offset: 0x10CD460 VA: 0x1810CEE60
	private bool UseFakeInput() { }

	// RVA: 0x10CE8B0 Offset: 0x10CCEB0 VA: 0x1810CE8B0 Slot: 17
	public override void Process() { }

	// RVA: 0x10CD750 Offset: 0x10CBD50 VA: 0x1810CD750
	private void FakeTouches() { }

	// RVA: 0x10CD910 Offset: 0x10CBF10 VA: 0x1810CD910
	private void ProcessTouchEvents() { }

	// RVA: 0x10CE1A0 Offset: 0x10CC7A0 VA: 0x1810CE1A0
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x10CAC50 Offset: 0x10C9250 VA: 0x1810CAC50 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x10CEA90 Offset: 0x10CD090 VA: 0x1810CEA90 Slot: 3
	public override string ToString() { }

}

