public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 5091
{	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x18

	// Properties
	public abstract Camera eventCamera { get; }
	[ObsoleteAttribute] // RVA: 0x89200 Offset: 0x88600 VA: 0x180089200
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera();

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x10B7FE0 Offset: 0x10B65E0 VA: 0x1810B7FE0 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x10B7FE0 Offset: 0x10B65E0 VA: 0x1810B7FE0 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x10B7FF0 Offset: 0x10B65F0 VA: 0x1810B7FF0
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x10B7C10 Offset: 0x10B6210 VA: 0x1810B7C10 Slot: 3
	public override string ToString() { }

	// RVA: 0x10B7B00 Offset: 0x10B6100 VA: 0x1810B7B00 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B79F0 Offset: 0x10B5FF0 VA: 0x1810B79F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xA7E410 Offset: 0xA7CA10 VA: 0x180A7E410 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0xA7E410 Offset: 0xA7CA10 VA: 0x180A7E410 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

