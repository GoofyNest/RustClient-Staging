public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 5085
{	// Fields
	private float m_PrevActionTime; // 0x58
	private Vector2 m_LastMoveVector; // 0x5C
	private int m_ConsecutiveMoveCount; // 0x64
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private GameObject m_CurrentFocusedGameObject; // 0x78
	private PointerEventData m_InputPointerEvent; // 0x80
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string m_HorizontalAxis; // 0x88
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string m_VerticalAxis; // 0x90
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string m_SubmitButton; // 0x98
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string m_CancelButton; // 0xA0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_InputActionsPerSecond; // 0xA8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_RepeatDelay; // 0xAC
	[SerializeField] // RVA: 0x88530 Offset: 0x87930 VA: 0x180088530
	[FormerlySerializedAsAttribute] // RVA: 0x88530 Offset: 0x87930 VA: 0x180088530
	private bool m_ForceModuleActive; // 0xB0

	// Properties
	[ObsoleteAttribute] // RVA: 0x88890 Offset: 0x87C90 VA: 0x180088890
	public StandaloneInputModule.InputMode inputMode { get; }
	[ObsoleteAttribute] // RVA: 0x889E0 Offset: 0x87DE0 VA: 0x1800889E0
	public bool allowActivationOnMobileDevice { get; set; }
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x10CD3A0 Offset: 0x10CB9A0 VA: 0x1810CD3A0
	protected void .ctor() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x10CD440 Offset: 0x10CBA40 VA: 0x1810CD440
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x10CD470 Offset: 0x10CBA70 VA: 0x1810CD470
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x10CD440 Offset: 0x10CBA40 VA: 0x1810CD440
	public bool get_forceModuleActive() { }

	// RVA: 0x10CD470 Offset: 0x10CBA70 VA: 0x1810CD470
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x10CD450 Offset: 0x10CBA50 VA: 0x1810CD450
	public float get_inputActionsPerSecond() { }

	// RVA: 0xC1FB10 Offset: 0xC1E110 VA: 0x180C1FB10
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x10CD460 Offset: 0x10CBA60 VA: 0x1810CD460
	public float get_repeatDelay() { }

	// RVA: 0x10CD480 Offset: 0x10CBA80 VA: 0x1810CD480
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

	// RVA: 0x10CD210 Offset: 0x10CB810 VA: 0x1810CD210
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x10CD230 Offset: 0x10CB830 VA: 0x1810CD230 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x10CC440 Offset: 0x10CAA40 VA: 0x1810CC440
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x10CAB30 Offset: 0x10C9130 VA: 0x1810CAB30 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x10CCF60 Offset: 0x10CB560 VA: 0x1810CCF60 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x10CA820 Offset: 0x10C8E20 VA: 0x1810CA820 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x10CA990 Offset: 0x10C8F90 VA: 0x1810CA990 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x10CC240 Offset: 0x10CA840 VA: 0x1810CC240 Slot: 17
	public override void Process() { }

	// RVA: 0x10CB270 Offset: 0x10C9870 VA: 0x1810CB270
	private bool ProcessTouchEvents() { }

	// RVA: 0x10CBB30 Offset: 0x10CA130 VA: 0x1810CBB30
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x10CCB90 Offset: 0x10CB190 VA: 0x1810CCB90
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x10CA9A0 Offset: 0x10C8FA0 VA: 0x1810CA9A0
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x10CC760 Offset: 0x10CAD60 VA: 0x1810CC760
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x10CABA0 Offset: 0x10C91A0 VA: 0x1810CABA0
	protected void ProcessMouseEvent() { }

	[ObsoleteAttribute] // RVA: 0x88810 Offset: 0x87C10 VA: 0x180088810
	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 30
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x10CABB0 Offset: 0x10C91B0 VA: 0x1810CABB0
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x10CCE00 Offset: 0x10CB400 VA: 0x1810CCE00
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x10CAE80 Offset: 0x10C9480 VA: 0x1810CAE80
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

