internal struct SliderHandler // TypeDefIndex: 4060
{	// Fields
	private readonly Rect position; // 0x0
	private readonly float currentValue; // 0x10
	private readonly float size; // 0x14
	private readonly float start; // 0x18
	private readonly float end; // 0x1C
	private readonly GUIStyle slider; // 0x20
	private readonly GUIStyle thumb; // 0x28
	private readonly GUIStyle thumbExtent; // 0x30
	private readonly bool horiz; // 0x38
	private readonly int id; // 0x3C

	// Methods

	// RVA: 0x22A0C0 Offset: 0x2294C0 VA: 0x18022A0C0
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x229EA0 Offset: 0x2292A0 VA: 0x180229EA0
	public float Handle() { }

	// RVA: 0x229F20 Offset: 0x229320 VA: 0x180229F20
	private float OnMouseDown() { }

	// RVA: 0x229F30 Offset: 0x229330 VA: 0x180229F30
	private float OnMouseDrag() { }

	// RVA: 0x229F40 Offset: 0x229340 VA: 0x180229F40
	private float OnMouseUp() { }

	// RVA: 0x229F50 Offset: 0x229350 VA: 0x180229F50
	private float OnRepaint() { }

	// RVA: 0x229E40 Offset: 0x229240 VA: 0x180229E40
	private EventType CurrentEventType() { }

	// RVA: 0x229E90 Offset: 0x229290 VA: 0x180229E90
	private int CurrentScrollTroughSide() { }

	// RVA: 0x229ED0 Offset: 0x2292D0 VA: 0x180229ED0
	private bool IsEmptySlider() { }

	// RVA: 0x229FF0 Offset: 0x2293F0 VA: 0x180229FF0
	private bool SupportsPageMovements() { }

	// RVA: 0x229F60 Offset: 0x229360 VA: 0x180229F60
	private float PageMovementValue() { }

	// RVA: 0x229F70 Offset: 0x229370 VA: 0x180229F70
	private float PageUpMovementBound() { }

	// RVA: 0x229E50 Offset: 0x229250 VA: 0x180229E50
	private Event CurrentEvent() { }

	// RVA: 0x22A080 Offset: 0x229480 VA: 0x18022A080
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x229E10 Offset: 0x229210 VA: 0x180229E10
	private float Clamp(float value) { }

	// RVA: 0x22A020 Offset: 0x229420 VA: 0x18022A020
	private Rect ThumbSelectionRect() { }

	// RVA: 0x229F90 Offset: 0x229390 VA: 0x180229F90
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x229F80 Offset: 0x229380 VA: 0x180229F80
	private SliderState SliderState() { }

	// RVA: 0x22A000 Offset: 0x229400 VA: 0x18022A000
	private Rect ThumbExtRect() { }

	// RVA: 0x22A020 Offset: 0x229420 VA: 0x18022A020
	private Rect ThumbRect() { }

	// RVA: 0x22A0A0 Offset: 0x2294A0 VA: 0x18022A0A0
	private Rect VerticalThumbRect() { }

	// RVA: 0x229EB0 Offset: 0x2292B0 VA: 0x180229EB0
	private Rect HorizontalThumbRect() { }

	// RVA: 0x229E20 Offset: 0x229220 VA: 0x180229E20
	private float ClampedCurrentValue() { }

	// RVA: 0x229F10 Offset: 0x229310 VA: 0x180229F10
	private float MousePosition() { }

	// RVA: 0x22A090 Offset: 0x229490 VA: 0x18022A090
	private float ValuesPerPixel() { }

	// RVA: 0x22A070 Offset: 0x229470 VA: 0x18022A070
	private float ThumbSize() { }

	// RVA: 0x229EF0 Offset: 0x2292F0 VA: 0x180229EF0
	private float MaxValue() { }

	// RVA: 0x229F00 Offset: 0x229300 VA: 0x180229F00
	private float MinValue() { }

}

