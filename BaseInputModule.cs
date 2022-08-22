public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 5080
{	// Fields
	protected List<RaycastResult> m_RaycastResultCache; // 0x18
	private AxisEventData m_AxisEventData; // 0x20
	private EventSystem m_EventSystem; // 0x28
	private BaseEventData m_BaseEventData; // 0x30
	protected BaseInput m_InputOverride; // 0x38
	private BaseInput m_DefaultInput; // 0x40

	// Properties
	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }

	// Methods

	// RVA: 0x10B7260 Offset: 0x10B5860 VA: 0x1810B7260
	public BaseInput get_input() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public BaseInput get_inputOverride() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	protected EventSystem get_eventSystem() { }

	// RVA: 0x10B7150 Offset: 0x10B5750 VA: 0x1810B7150 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B7130 Offset: 0x10B5730 VA: 0x1810B7130 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process();

	// RVA: 0x10B6890 Offset: 0x10B4E90 VA: 0x1810B6890
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x10B66C0 Offset: 0x10B4CC0 VA: 0x1810B66C0
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x10B65D0 Offset: 0x10B4BD0 VA: 0x1810B65D0
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x10B66D0 Offset: 0x10B4CD0 VA: 0x1810B66D0
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x10B6C30 Offset: 0x10B5230 VA: 0x1810B6C30
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x10B69E0 Offset: 0x10B4FE0 VA: 0x1810B69E0 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x10B6B80 Offset: 0x10B5180 VA: 0x1810B6B80 Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10B71B0 Offset: 0x10B57B0 VA: 0x1810B71B0 Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x10B71F0 Offset: 0x10B57F0 VA: 0x1810B71F0
	protected void .ctor() { }

}

