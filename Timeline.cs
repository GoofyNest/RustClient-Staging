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

	// RVA: 0xFD6200 Offset: 0xFD4800 VA: 0x180FD6200
	internal void SelectMarker(TimelineMarker marker) { }

	// RVA: 0xFD5860 Offset: 0xFD3E60 VA: 0x180FD5860
	internal void DragMarker(TimelineMarker marker, PointerEventData eventData) { }

	// RVA: 0xFD57D0 Offset: 0xFD3DD0 VA: 0x180FD57D0
	internal void DeleteMarker(TimelineMarker timelineMarker) { }

	// RVA: 0xFD5740 Offset: 0xFD3D40 VA: 0x180FD5740 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFD6010 Offset: 0xFD4610 VA: 0x180FD6010
	public void Rebuild() { }

	// RVA: 0xFD5630 Offset: 0xFD3C30 VA: 0x180FD5630
	public void AddMarker(TimelineMarker marker) { }

	// RVA: 0xFD63B0 Offset: 0xFD49B0 VA: 0x180FD63B0
	public void SetCurrentPosition(int pos) { }

	// RVA: 0xFD5C60 Offset: 0xFD4260 VA: 0x180FD5C60
	public float GetX(int time) { }

	// RVA: 0xFD5B50 Offset: 0xFD4150 VA: 0x180FD5B50
	public int GetTime(float x) { }

	// RVA: 0xFD5FB0 Offset: 0xFD45B0 VA: 0x180FD5FB0 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFD5FE0 Offset: 0xFD45E0 VA: 0x180FD5FE0 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFD6160 Offset: 0xFD4760 VA: 0x180FD6160
	public void Scrubbed(int time) { }

	// RVA: 0xFD5D10 Offset: 0xFD4310 VA: 0x180FD5D10 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFD6450 Offset: 0xFD4A50 VA: 0x180FD6450
	public void .ctor() { }

}

public class Timeline.ScrubEvent : UnityEvent<float> // TypeDefIndex: 7041
{	// Methods

	// RVA: 0xFD3C20 Offset: 0xFD2220 VA: 0x180FD3C20
	public void .ctor() { }

}

