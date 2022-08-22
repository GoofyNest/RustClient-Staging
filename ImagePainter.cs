public class ImagePainter : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 10944
{	// Fields
	public ImagePainter.OnDrawingEvent onDrawing; // 0x18
	public MonoBehaviour redirectRightClick; // 0x20
	[TooltipAttribute] // RVA: 0x8D070 Offset: 0x8C470 VA: 0x18008D070
	public float spacingScale; // 0x28
	internal Brush brush; // 0x30
	internal ImagePainter.PointerState[] pointerState; // 0x38

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x80CB80 Offset: 0x80B180 VA: 0x18080CB80
	public RectTransform get_rectTransform() { }

	// RVA: 0x80C7B0 Offset: 0x80ADB0 VA: 0x18080C7B0 Slot: 10
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x80C910 Offset: 0x80AF10 VA: 0x18080C910 Slot: 11
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x80C4F0 Offset: 0x80AAF0 VA: 0x18080C4F0 Slot: 12
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x80C450 Offset: 0x80AA50 VA: 0x18080C450 Slot: 13
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x80C670 Offset: 0x80AC70 VA: 0x18080C670 Slot: 14
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x80C710 Offset: 0x80AD10 VA: 0x18080C710 Slot: 15
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x80C160 Offset: 0x80A760 VA: 0x18080C160
	private void DrawAt(Vector2 position, PointerEventData.InputButton button) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void UpdateBrush(Brush brush) { }

	// RVA: 0x80C960 Offset: 0x80AF60 VA: 0x18080C960
	public void .ctor() { }

}

public class ImagePainter.OnDrawingEvent : UnityEvent<Vector2, Brush> // TypeDefIndex: 10945
{	// Methods

	// RVA: 0x820950 Offset: 0x81EF50 VA: 0x180820950
	public void .ctor() { }

}

internal class ImagePainter.PointerState // TypeDefIndex: 10946
{	// Fields
	public Vector2 lastPos; // 0x10
	public bool isDown; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

