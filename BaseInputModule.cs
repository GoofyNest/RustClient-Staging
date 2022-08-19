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

	// RVA: 0x10B6530 Offset: 0x10B4B30 VA: 0x1810B6530
	public BaseInput get_input() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public BaseInput get_inputOverride() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	protected EventSystem get_eventSystem() { }

	// RVA: 0x10B6420 Offset: 0x10B4A20 VA: 0x1810B6420 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B6400 Offset: 0x10B4A00 VA: 0x1810B6400 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process();

	// RVA: 0x10B5B60 Offset: 0x10B4160 VA: 0x1810B5B60
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x10B5990 Offset: 0x10B3F90 VA: 0x1810B5990
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x10B58A0 Offset: 0x10B3EA0 VA: 0x1810B58A0
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x10B59A0 Offset: 0x10B3FA0 VA: 0x1810B59A0
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x10B5F00 Offset: 0x10B4500 VA: 0x1810B5F00
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x10B5CB0 Offset: 0x10B42B0 VA: 0x1810B5CB0 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x10B5E50 Offset: 0x10B4450 VA: 0x1810B5E50 Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10B6480 Offset: 0x10B4A80 VA: 0x1810B6480 Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x10B64C0 Offset: 0x10B4AC0 VA: 0x1810B64C0
	protected void .ctor() { }

}

