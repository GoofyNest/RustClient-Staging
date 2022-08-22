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

	// RVA: 0x10CE0D0 Offset: 0x10CC6D0 VA: 0x1810CE0D0
	protected void .ctor() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x10CE170 Offset: 0x10CC770 VA: 0x1810CE170
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x10CE1A0 Offset: 0x10CC7A0 VA: 0x1810CE1A0
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x10CE170 Offset: 0x10CC770 VA: 0x1810CE170
	public bool get_forceModuleActive() { }

	// RVA: 0x10CE1A0 Offset: 0x10CC7A0 VA: 0x1810CE1A0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x10CE180 Offset: 0x10CC780 VA: 0x1810CE180
	public float get_inputActionsPerSecond() { }

	// RVA: 0xC202A0 Offset: 0xC1E8A0 VA: 0x180C202A0
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x10CE190 Offset: 0x10CC790 VA: 0x1810CE190
	public float get_repeatDelay() { }

	// RVA: 0x10CE1B0 Offset: 0x10CC7B0 VA: 0x1810CE1B0
	public void set_repeatDelay(float value) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public string get_horizontalAxis() { }

	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public void set_horizontalAxis(string value) { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public string get_verticalAxis() { }

	// RVA: 0x4E3FF0 Offset: 0x4E25F0 VA: 0x1804E3FF0
	public void set_verticalAxis(string value) { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public string get_submitButton() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public void set_submitButton(string value) { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	public string get_cancelButton() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public void set_cancelButton(string value) { }

	// RVA: 0x10CDF40 Offset: 0x10CC540 VA: 0x1810CDF40
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x10CDF60 Offset: 0x10CC560 VA: 0x1810CDF60 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x10CD170 Offset: 0x10CB770 VA: 0x1810CD170
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x10CB860 Offset: 0x10C9E60 VA: 0x1810CB860 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x10CDC90 Offset: 0x10CC290 VA: 0x1810CDC90 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x10CB550 Offset: 0x10C9B50 VA: 0x1810CB550 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x10CB6C0 Offset: 0x10C9CC0 VA: 0x1810CB6C0 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x10CCF70 Offset: 0x10CB570 VA: 0x1810CCF70 Slot: 17
	public override void Process() { }

	// RVA: 0x10CBFA0 Offset: 0x10CA5A0 VA: 0x1810CBFA0
	private bool ProcessTouchEvents() { }

	// RVA: 0x10CC860 Offset: 0x10CAE60 VA: 0x1810CC860
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x10CD8C0 Offset: 0x10CBEC0 VA: 0x1810CD8C0
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x10CB6D0 Offset: 0x10C9CD0 VA: 0x1810CB6D0
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x10CD490 Offset: 0x10CBA90 VA: 0x1810CD490
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x10CB8D0 Offset: 0x10C9ED0 VA: 0x1810CB8D0
	protected void ProcessMouseEvent() { }

	[ObsoleteAttribute] // RVA: 0x88880 Offset: 0x87C80 VA: 0x180088880
	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 30
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x10CB8E0 Offset: 0x10C9EE0 VA: 0x1810CB8E0
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x10CDB30 Offset: 0x10CC130 VA: 0x1810CDB30
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x10CBBB0 Offset: 0x10CA1B0 VA: 0x1810CBBB0
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	protected GameObject GetCurrentFocusedGameObject() { }

}

public enum StandaloneInputModule.InputMode // TypeDefIndex: 5086
{	// Fields
	public int value__; // 0x0
	public const StandaloneInputModule.InputMode Mouse = 0;
	public const StandaloneInputModule.InputMode Buttons = 1;

}

