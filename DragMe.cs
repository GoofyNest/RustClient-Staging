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

	// RVA: 0xAB07B0 Offset: 0xAAEDB0 VA: 0x180AB07B0 Slot: 7
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0xAB0290 Offset: 0xAAE890 VA: 0x180AB0290 Slot: 8
	protected virtual GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	// RVA: 0xAB0EF0 Offset: 0xAAF4F0 VA: 0x180AB0EF0 Slot: 9
	protected virtual Canvas get_TopCanvas() { }

	// RVA: 0xAB0C20 Offset: 0xAAF220 VA: 0x180AB0C20 Slot: 10
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0xAB0D90 Offset: 0xAAF390 VA: 0x180AB0D90 Slot: 11
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0xAB01F0 Offset: 0xAAE7F0 VA: 0x180AB01F0
	public void CancelDrag() { }

	// RVA: 0xAB04A0 Offset: 0xAAEAA0 VA: 0x180AB04A0
	internal DropMe FindTarget(GameObject obj) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	public virtual bool get_CancelOnDrop() { }

	// RVA: 0xAB00E0 Offset: 0xAAE6E0 VA: 0x180AB00E0
	public void .ctor() { }

}

