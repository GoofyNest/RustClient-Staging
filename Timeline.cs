public class Timeline : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7040
{	// Fields
	public int StartTime; // 0x30
	public int EndTime; // 0x34
	public int CurrentPosition; // 0x38
	public TimeRuler TimeRuler; // 0x40
	public RectTransform IndicatorCurrent; // 0x48
	public UnityEvent OnStartScrub; // 0x50
	public UnityEvent OnEndScrub; // 0x58
	public Timeline.ScrubEvent OnScrubToTime; // 0x60
	public List<TimelineMarker> Markers; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TimelineMarker <SelectedMarker>k__BackingField; // 0x70

	// Properties
	public TimelineMarker SelectedMarker { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public TimelineMarker get_SelectedMarker() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_SelectedMarker(TimelineMarker value) { }

	// RVA: 0xFD64C0 Offset: 0xFD4AC0 VA: 0x180FD64C0
	internal void SelectMarker(TimelineMarker marker) { }

	// RVA: 0xFD5B20 Offset: 0xFD4120 VA: 0x180FD5B20
	internal void DragMarker(TimelineMarker marker, PointerEventData eventData) { }

	// RVA: 0xFD5A90 Offset: 0xFD4090 VA: 0x180FD5A90
	internal void DeleteMarker(TimelineMarker timelineMarker) { }

	// RVA: 0xFD5A00 Offset: 0xFD4000 VA: 0x180FD5A00 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFD62D0 Offset: 0xFD48D0 VA: 0x180FD62D0
	public void Rebuild() { }

	// RVA: 0xFD58F0 Offset: 0xFD3EF0 VA: 0x180FD58F0
	public void AddMarker(TimelineMarker marker) { }

	// RVA: 0xFD6670 Offset: 0xFD4C70 VA: 0x180FD6670
	public void SetCurrentPosition(int pos) { }

	// RVA: 0xFD5F20 Offset: 0xFD4520 VA: 0x180FD5F20
	public float GetX(int time) { }

	// RVA: 0xFD5E10 Offset: 0xFD4410 VA: 0x180FD5E10
	public int GetTime(float x) { }

	// RVA: 0xFD6270 Offset: 0xFD4870 VA: 0x180FD6270 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFD62A0 Offset: 0xFD48A0 VA: 0x180FD62A0 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFD6420 Offset: 0xFD4A20 VA: 0x180FD6420
	public void Scrubbed(int time) { }

	// RVA: 0xFD5FD0 Offset: 0xFD45D0 VA: 0x180FD5FD0 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFD6710 Offset: 0xFD4D10 VA: 0x180FD6710
	public void .ctor() { }

}

public class Timeline.ScrubEvent : UnityEvent<float> // TypeDefIndex: 7041
{	// Methods

	// RVA: 0xFD3EE0 Offset: 0xFD24E0 VA: 0x180FD3EE0
	public void .ctor() { }

}

