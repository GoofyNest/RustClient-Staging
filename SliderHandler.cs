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

	// RVA: 0x22B160 Offset: 0x22A560 VA: 0x18022B160
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x22AF40 Offset: 0x22A340 VA: 0x18022AF40
	public float Handle() { }

	// RVA: 0x22AFC0 Offset: 0x22A3C0 VA: 0x18022AFC0
	private float OnMouseDown() { }

	// RVA: 0x22AFD0 Offset: 0x22A3D0 VA: 0x18022AFD0
	private float OnMouseDrag() { }

	// RVA: 0x22AFE0 Offset: 0x22A3E0 VA: 0x18022AFE0
	private float OnMouseUp() { }

	// RVA: 0x22AFF0 Offset: 0x22A3F0 VA: 0x18022AFF0
	private float OnRepaint() { }

	// RVA: 0x22AEE0 Offset: 0x22A2E0 VA: 0x18022AEE0
	private EventType CurrentEventType() { }

	// RVA: 0x22AF30 Offset: 0x22A330 VA: 0x18022AF30
	private int CurrentScrollTroughSide() { }

	// RVA: 0x22AF70 Offset: 0x22A370 VA: 0x18022AF70
	private bool IsEmptySlider() { }

	// RVA: 0x22B090 Offset: 0x22A490 VA: 0x18022B090
	private bool SupportsPageMovements() { }

	// RVA: 0x22B000 Offset: 0x22A400 VA: 0x18022B000
	private float PageMovementValue() { }

	// RVA: 0x22B010 Offset: 0x22A410 VA: 0x18022B010
	private float PageUpMovementBound() { }

	// RVA: 0x22AEF0 Offset: 0x22A2F0 VA: 0x18022AEF0
	private Event CurrentEvent() { }

	// RVA: 0x22B120 Offset: 0x22A520 VA: 0x18022B120
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x22AEB0 Offset: 0x22A2B0 VA: 0x18022AEB0
	private float Clamp(float value) { }

	// RVA: 0x22B0C0 Offset: 0x22A4C0 VA: 0x18022B0C0
	private Rect ThumbSelectionRect() { }

	// RVA: 0x22B030 Offset: 0x22A430 VA: 0x18022B030
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x22B020 Offset: 0x22A420 VA: 0x18022B020
	private SliderState SliderState() { }

	// RVA: 0x22B0A0 Offset: 0x22A4A0 VA: 0x18022B0A0
	private Rect ThumbExtRect() { }

	// RVA: 0x22B0C0 Offset: 0x22A4C0 VA: 0x18022B0C0
	private Rect ThumbRect() { }

	// RVA: 0x22B140 Offset: 0x22A540 VA: 0x18022B140
	private Rect VerticalThumbRect() { }

	// RVA: 0x22AF50 Offset: 0x22A350 VA: 0x18022AF50
	private Rect HorizontalThumbRect() { }

	// RVA: 0x22AEC0 Offset: 0x22A2C0 VA: 0x18022AEC0
	private float ClampedCurrentValue() { }

	// RVA: 0x22AFB0 Offset: 0x22A3B0 VA: 0x18022AFB0
	private float MousePosition() { }

	// RVA: 0x22B130 Offset: 0x22A530 VA: 0x18022B130
	private float ValuesPerPixel() { }

	// RVA: 0x22B110 Offset: 0x22A510 VA: 0x18022B110
	private float ThumbSize() { }

	// RVA: 0x22AF90 Offset: 0x22A390 VA: 0x18022AF90
	private float MaxValue() { }

	// RVA: 0x22AFA0 Offset: 0x22A3A0 VA: 0x18022AFA0
	private float MinValue() { }

}

