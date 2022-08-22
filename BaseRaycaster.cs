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

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x10B7570 Offset: 0x10B5B70 VA: 0x1810B7570 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x10B7570 Offset: 0x10B5B70 VA: 0x1810B7570 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x10B7580 Offset: 0x10B5B80 VA: 0x1810B7580
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x10B71A0 Offset: 0x10B57A0 VA: 0x1810B71A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10B7090 Offset: 0x10B5690 VA: 0x1810B7090 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B6F80 Offset: 0x10B5580 VA: 0x1810B6F80 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xA7DF40 Offset: 0xA7C540 VA: 0x180A7DF40 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0xA7DF40 Offset: 0xA7C540 VA: 0x180A7DF40 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

