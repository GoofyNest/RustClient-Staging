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

	// RVA: 0x22B0E0 Offset: 0x22A4E0 VA: 0x18022B0E0
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x22AEC0 Offset: 0x22A2C0 VA: 0x18022AEC0
	public float Handle() { }

	// RVA: 0x22AF40 Offset: 0x22A340 VA: 0x18022AF40
	private float OnMouseDown() { }

	// RVA: 0x22AF50 Offset: 0x22A350 VA: 0x18022AF50
	private float OnMouseDrag() { }

	// RVA: 0x22AF60 Offset: 0x22A360 VA: 0x18022AF60
	private float OnMouseUp() { }

	// RVA: 0x22AF70 Offset: 0x22A370 VA: 0x18022AF70
	private float OnRepaint() { }

	// RVA: 0x22AE60 Offset: 0x22A260 VA: 0x18022AE60
	private EventType CurrentEventType() { }

	// RVA: 0x22AEB0 Offset: 0x22A2B0 VA: 0x18022AEB0
	private int CurrentScrollTroughSide() { }

	// RVA: 0x22AEF0 Offset: 0x22A2F0 VA: 0x18022AEF0
	private bool IsEmptySlider() { }

	// RVA: 0x22B010 Offset: 0x22A410 VA: 0x18022B010
	private bool SupportsPageMovements() { }

	// RVA: 0x22AF80 Offset: 0x22A380 VA: 0x18022AF80
	private float PageMovementValue() { }

	// RVA: 0x22AF90 Offset: 0x22A390 VA: 0x18022AF90
	private float PageUpMovementBound() { }

	// RVA: 0x22AE70 Offset: 0x22A270 VA: 0x18022AE70
	private Event CurrentEvent() { }

	// RVA: 0x22B0A0 Offset: 0x22A4A0 VA: 0x18022B0A0
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x22AE30 Offset: 0x22A230 VA: 0x18022AE30
	private float Clamp(float value) { }

	// RVA: 0x22B040 Offset: 0x22A440 VA: 0x18022B040
	private Rect ThumbSelectionRect() { }

	// RVA: 0x22AFB0 Offset: 0x22A3B0 VA: 0x18022AFB0
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x22AFA0 Offset: 0x22A3A0 VA: 0x18022AFA0
	private SliderState SliderState() { }

	// RVA: 0x22B020 Offset: 0x22A420 VA: 0x18022B020
	private Rect ThumbExtRect() { }

	// RVA: 0x22B040 Offset: 0x22A440 VA: 0x18022B040
	private Rect ThumbRect() { }

	// RVA: 0x22B0C0 Offset: 0x22A4C0 VA: 0x18022B0C0
	private Rect VerticalThumbRect() { }

	// RVA: 0x22AED0 Offset: 0x22A2D0 VA: 0x18022AED0
	private Rect HorizontalThumbRect() { }

	// RVA: 0x22AE40 Offset: 0x22A240 VA: 0x18022AE40
	private float ClampedCurrentValue() { }

	// RVA: 0x22AF30 Offset: 0x22A330 VA: 0x18022AF30
	private float MousePosition() { }

	// RVA: 0x22B0B0 Offset: 0x22A4B0 VA: 0x18022B0B0
	private float ValuesPerPixel() { }

	// RVA: 0x22B090 Offset: 0x22A490 VA: 0x18022B090
	private float ThumbSize() { }

	// RVA: 0x22AF10 Offset: 0x22A310 VA: 0x18022AF10
	private float MaxValue() { }

	// RVA: 0x22AF20 Offset: 0x22A320 VA: 0x18022AF20
	private float MinValue() { }

}

