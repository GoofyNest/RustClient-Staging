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

	// RVA: 0x80C4E0 Offset: 0x80AAE0 VA: 0x18080C4E0
	public RectTransform get_rectTransform() { }

	// RVA: 0x80C110 Offset: 0x80A710 VA: 0x18080C110 Slot: 10
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x80C270 Offset: 0x80A870 VA: 0x18080C270 Slot: 11
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x80BE50 Offset: 0x80A450 VA: 0x18080BE50 Slot: 12
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x80BDB0 Offset: 0x80A3B0 VA: 0x18080BDB0 Slot: 13
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x80BFD0 Offset: 0x80A5D0 VA: 0x18080BFD0 Slot: 14
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x80C070 Offset: 0x80A670 VA: 0x18080C070 Slot: 15
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x80BAC0 Offset: 0x80A0C0 VA: 0x18080BAC0
	private void DrawAt(Vector2 position, PointerEventData.InputButton button) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void UpdateBrush(Brush brush) { }

	// RVA: 0x80C2C0 Offset: 0x80A8C0 VA: 0x18080C2C0
	public void .ctor() { }

}

public class ImagePainter.OnDrawingEvent : UnityEvent<Vector2, Brush> // TypeDefIndex: 10945
{	// Methods

	// RVA: 0x8202B0 Offset: 0x81E8B0 VA: 0x1808202B0
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

