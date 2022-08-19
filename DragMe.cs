public class DragMe : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 11271
{	// Fields
	public static DragMe dragging; // 0x0
	public static GameObject dragIcon; // 0x8
	public static object data; // 0x10
	public string dragType; // 0x18

	// Properties
	protected virtual Canvas TopCanvas { get; }
	public virtual bool CancelOnDrop { get; }

	// Methods

	// RVA: 0xAB0020 Offset: 0xAAE620 VA: 0x180AB0020 Slot: 7
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0xAAFB00 Offset: 0xAAE100 VA: 0x180AAFB00 Slot: 8
	protected virtual GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	// RVA: 0xAB0760 Offset: 0xAAED60 VA: 0x180AB0760 Slot: 9
	protected virtual Canvas get_TopCanvas() { }

	// RVA: 0xAB0490 Offset: 0xAAEA90 VA: 0x180AB0490 Slot: 10
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0xAB0600 Offset: 0xAAEC00 VA: 0x180AB0600 Slot: 11
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0xAAFA60 Offset: 0xAAE060 VA: 0x180AAFA60
	public void CancelDrag() { }

	// RVA: 0xAAFD10 Offset: 0xAAE310 VA: 0x180AAFD10
	internal DropMe FindTarget(GameObject obj) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	public virtual bool get_CancelOnDrop() { }

	// RVA: 0xAAF950 Offset: 0xAADF50 VA: 0x180AAF950
	public void .ctor() { }

}

