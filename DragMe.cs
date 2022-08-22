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

	// RVA: 0xAB02E0 Offset: 0xAAE8E0 VA: 0x180AB02E0 Slot: 7
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0xAAFDC0 Offset: 0xAAE3C0 VA: 0x180AAFDC0 Slot: 8
	protected virtual GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	// RVA: 0xAB0A20 Offset: 0xAAF020 VA: 0x180AB0A20 Slot: 9
	protected virtual Canvas get_TopCanvas() { }

	// RVA: 0xAB0750 Offset: 0xAAED50 VA: 0x180AB0750 Slot: 10
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0xAB08C0 Offset: 0xAAEEC0 VA: 0x180AB08C0 Slot: 11
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0xAAFD20 Offset: 0xAAE320 VA: 0x180AAFD20
	public void CancelDrag() { }

	// RVA: 0xAAFFD0 Offset: 0xAAE5D0 VA: 0x180AAFFD0
	internal DropMe FindTarget(GameObject obj) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	public virtual bool get_CancelOnDrop() { }

	// RVA: 0xAAFC10 Offset: 0xAAE210 VA: 0x180AAFC10
	public void .ctor() { }

}

