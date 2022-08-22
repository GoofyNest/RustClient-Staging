public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 5085
{	// Fields
	private float m_PrevActionTime; // 0x58
	private Vector2 m_LastMoveVector; // 0x5C
	private int m_ConsecutiveMoveCount; // 0x64
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private GameObject m_CurrentFocusedGameObject; // 0x78
	private PointerEventData m_InputPointerEvent; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_HorizontalAxis; // 0x88
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_VerticalAxis; // 0x90
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_SubmitButton; // 0x98
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_CancelButton; // 0xA0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_InputActionsPerSecond; // 0xA8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_RepeatDelay; // 0xAC
	[SerializeField] // RVA: 0x885A0 Offset: 0x879A0 VA: 0x1800885A0
	[FormerlySerializedAsAttribute] // RVA: 0x885A0 Offset: 0x879A0 VA: 0x1800885A0
	private bool m_ForceModuleActive; // 0xB0

	// Properties
	[ObsoleteAttribute] // RVA: 0x88900 Offset: 0x87D00 VA: 0x180088900
	public StandaloneInputModule.InputMode inputMode { get; }
	[ObsoleteAttribute] // RVA: 0x88B30 Offset: 0x87F30 VA: 0x180088B30
	public bool allowActivationOnMobileDevice { get; set; }
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x10CD660 Offset: 0x10CBC60 VA: 0x1810CD660
	protected void .ctor() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x10CD700 Offset: 0x10CBD00 VA: 0x1810CD700
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x10CD730 Offset: 0x10CBD30 VA: 0x1810CD730
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x10CD700 Offset: 0x10CBD00 VA: 0x1810CD700
	public bool get_forceModuleActive() { }

	// RVA: 0x10CD730 Offset: 0x10CBD30 VA: 0x1810CD730
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x10CD710 Offset: 0x10CBD10 VA: 0x1810CD710
	public float get_inputActionsPerSecond() { }

	// RVA: 0xC1FDD0 Offset: 0xC1E3D0 VA: 0x180C1FDD0
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x10CD720 Offset: 0x10CBD20 VA: 0x1810CD720
	public float get_repeatDelay() { }

	// RVA: 0x10CD740 Offset: 0x10CBD40 VA: 0x1810CD740
	public void set_repeatDelay(float value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public string get_horizontalAxis() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void set_horizontalAxis(string value) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public string get_verticalAxis() { }

	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	public void set_verticalAxis(string value) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_submitButton() { }

	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	public void set_submitButton(string value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public string get_cancelButton() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_cancelButton(string value) { }

	// RVA: 0x10CD4D0 Offset: 0x10CBAD0 VA: 0x1810CD4D0
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x10CD4F0 Offset: 0x10CBAF0 VA: 0x1810CD4F0 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x10CC700 Offset: 0x10CAD00 VA: 0x1810CC700
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x10CADF0 Offset: 0x10C93F0 VA: 0x1810CADF0 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x10CD220 Offset: 0x10CB820 VA: 0x1810CD220 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x10CAAE0 Offset: 0x10C90E0 VA: 0x1810CAAE0 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x10CAC50 Offset: 0x10C9250 VA: 0x1810CAC50 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x10CC500 Offset: 0x10CAB00 VA: 0x1810CC500 Slot: 17
	public override void Process() { }

	// RVA: 0x10CB530 Offset: 0x10C9B30 VA: 0x1810CB530
	private bool ProcessTouchEvents() { }

	// RVA: 0x10CBDF0 Offset: 0x10CA3F0 VA: 0x1810CBDF0
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x10CCE50 Offset: 0x10CB450 VA: 0x1810CCE50
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x10CAC60 Offset: 0x10C9260 VA: 0x1810CAC60
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x10CCA20 Offset: 0x10CB020 VA: 0x1810CCA20
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x10CAE60 Offset: 0x10C9460 VA: 0x1810CAE60
	protected void ProcessMouseEvent() { }

	[ObsoleteAttribute] // RVA: 0x88880 Offset: 0x87C80 VA: 0x180088880
	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 30
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x10CAE70 Offset: 0x10C9470 VA: 0x1810CAE70
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x10CD0C0 Offset: 0x10CB6C0 VA: 0x1810CD0C0
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x10CB140 Offset: 0x10C9740 VA: 0x1810CB140
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	protected GameObject GetCurrentFocusedGameObject() { }

}

public enum StandaloneInputModule.InputMode // TypeDefIndex: 5086
{	// Fields
	public int value__; // 0x0
	public const StandaloneInputModule.InputMode Mouse = 0;
	public const StandaloneInputModule.InputMode Buttons = 1;

}

