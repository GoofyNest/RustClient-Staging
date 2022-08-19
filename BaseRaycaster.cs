public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 5091
{	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x18

	// Properties
	public abstract Camera eventCamera { get; }
	[ObsoleteAttribute] // RVA: 0x89190 Offset: 0x88590 VA: 0x180089190
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera();

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x10B72B0 Offset: 0x10B58B0 VA: 0x1810B72B0 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x10B72B0 Offset: 0x10B58B0 VA: 0x1810B72B0 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x10B72C0 Offset: 0x10B58C0 VA: 0x1810B72C0
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x10B6EE0 Offset: 0x10B54E0 VA: 0x1810B6EE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10B6DD0 Offset: 0x10B53D0 VA: 0x1810B6DD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B6CC0 Offset: 0x10B52C0 VA: 0x1810B6CC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xA7DC80 Offset: 0xA7C280 VA: 0x180A7DC80 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0xA7DC80 Offset: 0xA7C280 VA: 0x180A7DC80 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

