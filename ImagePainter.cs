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

	// RVA: 0x80C5F0 Offset: 0x80ABF0 VA: 0x18080C5F0
	public RectTransform get_rectTransform() { }

	// RVA: 0x80C220 Offset: 0x80A820 VA: 0x18080C220 Slot: 10
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x80C380 Offset: 0x80A980 VA: 0x18080C380 Slot: 11
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x80BF60 Offset: 0x80A560 VA: 0x18080BF60 Slot: 12
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x80BEC0 Offset: 0x80A4C0 VA: 0x18080BEC0 Slot: 13
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x80C0E0 Offset: 0x80A6E0 VA: 0x18080C0E0 Slot: 14
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x80C180 Offset: 0x80A780 VA: 0x18080C180 Slot: 15
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x80BBD0 Offset: 0x80A1D0 VA: 0x18080BBD0
	private void DrawAt(Vector2 position, PointerEventData.InputButton button) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void UpdateBrush(Brush brush) { }

	// RVA: 0x80C3D0 Offset: 0x80A9D0 VA: 0x18080C3D0
	public void .ctor() { }

}

public class ImagePainter.OnDrawingEvent : UnityEvent<Vector2, Brush> // TypeDefIndex: 10945
{	// Methods

	// RVA: 0x8203C0 Offset: 0x81E9C0 VA: 0x1808203C0
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

