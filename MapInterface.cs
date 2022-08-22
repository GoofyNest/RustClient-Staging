public class MapInterface : SingletonComponent<MapInterface> // TypeDefIndex: 10952
{	// Fields
	public static bool IsOpen; // 0x0
	public Image cameraPositon; // 0x18
	public ScrollRectEx scrollRect; // 0x20
	public Toggle showGridToggle; // 0x28
	public Button FocusButton; // 0x30
	public CanvasGroup CanvasGroup; // 0x38
	public SoundDefinition PlaceMarkerSound; // 0x40
	public SoundDefinition ClearMarkerSound; // 0x48
	public MapView View; // 0x50
	public Color[] PointOfInterestColours; // 0x58
	public Sprite[] PointOfInterestSprites; // 0x60
	public bool DebugStayOpen; // 0x68
	private PointerEventData pointerData; // 0x70
	private List<RaycastResult> rayResults; // 0x78
	public static float LastOpened; // 0x4
	private NeedsCursor NeedsCursor; // 0x80
	private NeedsMouseButtons NeedsMouseButtons; // 0x88
	private NeedsMouseWheel NeedsMouseWheel; // 0x90
	private Vector3 rmbStartPos; // 0x98
	private float rmbStartTime; // 0xA4
	internal static MapEntity lastActiveMap; // 0x8

	// Properties
	private static BasePlayer LocalPlayerEntity { get; }
	public static MapEntity localPlayerMap { get; }

	// Methods

	// RVA: 0x565420 Offset: 0x563A20 VA: 0x180565420
	private static BasePlayer get_LocalPlayerEntity() { }

	// RVA: 0x564EE0 Offset: 0x5634E0 VA: 0x180564EE0
	public static void SetOpen(bool open) { }

	// RVA: 0x563FB0 Offset: 0x5625B0 VA: 0x180563FB0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x564D70 Offset: 0x563370 VA: 0x180564D70
	private void OnEnable() { }

	// RVA: 0x564050 Offset: 0x562650 VA: 0x180564050
	public void FollowPlayer() { }

	// RVA: 0x564C90 Offset: 0x563290 VA: 0x180564C90
	private void OnDisable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetMap() { }

	// RVA: 0x564FC0 Offset: 0x5635C0 VA: 0x180564FC0
	private void Update() { }

	// RVA: 0x5646A0 Offset: 0x562CA0 VA: 0x1805646A0
	private void MarkerInput() { }

	// RVA: 0x565510 Offset: 0x563B10 VA: 0x180565510
	public static MapEntity get_localPlayerMap() { }

	// RVA: 0x564090 Offset: 0x562690 VA: 0x180564090
	private void ForceOpen(bool open) { }

	// RVA: 0x564600 Offset: 0x562C00 VA: 0x180564600
	public void GetPointOfInterestSettings(int index, out Sprite resultSprite, out Color resultColour) { }

	// RVA: 0x565390 Offset: 0x563990 VA: 0x180565390
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

