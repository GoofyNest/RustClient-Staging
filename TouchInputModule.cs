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

	// RVA: 0x10CF910 Offset: 0x10CDF10 VA: 0x1810CF910
	protected void .ctor() { }

	// RVA: 0xC31A80 Offset: 0xC30080 VA: 0x180C31A80
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0xC32BA0 Offset: 0xC311A0 VA: 0x180C32BA0
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0xC31A80 Offset: 0xC30080 VA: 0x180C31A80
	public bool get_forceModuleActive() { }

	// RVA: 0xC32BA0 Offset: 0xC311A0 VA: 0x180C32BA0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x10CF770 Offset: 0x10CDD70 VA: 0x1810CF770 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x10CE340 Offset: 0x10CC940 VA: 0x1810CE340 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x10CF370 Offset: 0x10CD970 VA: 0x1810CF370 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x10CF8D0 Offset: 0x10CDED0 VA: 0x1810CF8D0
	private bool UseFakeInput() { }

	// RVA: 0x10CF320 Offset: 0x10CD920 VA: 0x1810CF320 Slot: 17
	public override void Process() { }

	// RVA: 0x10CE1C0 Offset: 0x10CC7C0 VA: 0x1810CE1C0
	private void FakeTouches() { }

	// RVA: 0x10CE380 Offset: 0x10CC980 VA: 0x1810CE380
	private void ProcessTouchEvents() { }

	// RVA: 0x10CEC10 Offset: 0x10CD210 VA: 0x1810CEC10
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x10CB6C0 Offset: 0x10C9CC0 VA: 0x1810CB6C0 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x10CF500 Offset: 0x10CDB00 VA: 0x1810CF500 Slot: 3
	public override string ToString() { }

}

