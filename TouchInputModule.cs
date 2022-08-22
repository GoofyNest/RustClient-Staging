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

	// RVA: 0x10CEBE0 Offset: 0x10CD1E0 VA: 0x1810CEBE0
	protected void .ctor() { }

	// RVA: 0xC312F0 Offset: 0xC2F8F0 VA: 0x180C312F0
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0xC32410 Offset: 0xC30A10 VA: 0x180C32410
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0xC312F0 Offset: 0xC2F8F0 VA: 0x180C312F0
	public bool get_forceModuleActive() { }

	// RVA: 0xC32410 Offset: 0xC30A10 VA: 0x180C32410
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x10CEA40 Offset: 0x10CD040 VA: 0x1810CEA40 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x10CD610 Offset: 0x10CBC10 VA: 0x1810CD610 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x10CE640 Offset: 0x10CCC40 VA: 0x1810CE640 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x10CEBA0 Offset: 0x10CD1A0 VA: 0x1810CEBA0
	private bool UseFakeInput() { }

	// RVA: 0x10CE5F0 Offset: 0x10CCBF0 VA: 0x1810CE5F0 Slot: 17
	public override void Process() { }

	// RVA: 0x10CD490 Offset: 0x10CBA90 VA: 0x1810CD490
	private void FakeTouches() { }

	// RVA: 0x10CD650 Offset: 0x10CBC50 VA: 0x1810CD650
	private void ProcessTouchEvents() { }

	// RVA: 0x10CDEE0 Offset: 0x10CC4E0 VA: 0x1810CDEE0
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x10CA990 Offset: 0x10C8F90 VA: 0x1810CA990 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x10CE7D0 Offset: 0x10CCDD0 VA: 0x1810CE7D0 Slot: 3
	public override string ToString() { }

}

