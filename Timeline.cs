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
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public TimelineMarker get_SelectedMarker() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_SelectedMarker(TimelineMarker value) { }

	// RVA: 0xFD6F60 Offset: 0xFD5560 VA: 0x180FD6F60
	internal void SelectMarker(TimelineMarker marker) { }

	// RVA: 0xFD65C0 Offset: 0xFD4BC0 VA: 0x180FD65C0
	internal void DragMarker(TimelineMarker marker, PointerEventData eventData) { }

	// RVA: 0xFD6530 Offset: 0xFD4B30 VA: 0x180FD6530
	internal void DeleteMarker(TimelineMarker timelineMarker) { }

	// RVA: 0xFD64A0 Offset: 0xFD4AA0 VA: 0x180FD64A0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFD6D70 Offset: 0xFD5370 VA: 0x180FD6D70
	public void Rebuild() { }

	// RVA: 0xFD6390 Offset: 0xFD4990 VA: 0x180FD6390
	public void AddMarker(TimelineMarker marker) { }

	// RVA: 0xFD7110 Offset: 0xFD5710 VA: 0x180FD7110
	public void SetCurrentPosition(int pos) { }

	// RVA: 0xFD69C0 Offset: 0xFD4FC0 VA: 0x180FD69C0
	public float GetX(int time) { }

	// RVA: 0xFD68B0 Offset: 0xFD4EB0 VA: 0x180FD68B0
	public int GetTime(float x) { }

	// RVA: 0xFD6D10 Offset: 0xFD5310 VA: 0x180FD6D10 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFD6D40 Offset: 0xFD5340 VA: 0x180FD6D40 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFD6EC0 Offset: 0xFD54C0 VA: 0x180FD6EC0
	public void Scrubbed(int time) { }

	// RVA: 0xFD6A70 Offset: 0xFD5070 VA: 0x180FD6A70 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFD71B0 Offset: 0xFD57B0 VA: 0x180FD71B0
	public void .ctor() { }

}

public class Timeline.ScrubEvent : UnityEvent<float> // TypeDefIndex: 7041
{	// Methods

	// RVA: 0xFD4980 Offset: 0xFD2F80 VA: 0x180FD4980
	public void .ctor() { }

}

