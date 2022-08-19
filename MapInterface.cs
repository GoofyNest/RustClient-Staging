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

	// RVA: 0x565490 Offset: 0x563A90 VA: 0x180565490
	private static BasePlayer get_LocalPlayerEntity() { }

	// RVA: 0x564F50 Offset: 0x563550 VA: 0x180564F50
	public static void SetOpen(bool open) { }

	// RVA: 0x564020 Offset: 0x562620 VA: 0x180564020 Slot: 6
	protected override void Awake() { }

	// RVA: 0x564DE0 Offset: 0x5633E0 VA: 0x180564DE0
	private void OnEnable() { }

	// RVA: 0x5640C0 Offset: 0x5626C0 VA: 0x1805640C0
	public void FollowPlayer() { }

	// RVA: 0x564D00 Offset: 0x563300 VA: 0x180564D00
	private void OnDisable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetMap() { }

	// RVA: 0x565030 Offset: 0x563630 VA: 0x180565030
	private void Update() { }

	// RVA: 0x564710 Offset: 0x562D10 VA: 0x180564710
	private void MarkerInput() { }

	// RVA: 0x565580 Offset: 0x563B80 VA: 0x180565580
	public static MapEntity get_localPlayerMap() { }

	// RVA: 0x564100 Offset: 0x562700 VA: 0x180564100
	private void ForceOpen(bool open) { }

	// RVA: 0x564670 Offset: 0x562C70 VA: 0x180564670
	public void GetPointOfInterestSettings(int index, out Sprite resultSprite, out Color resultColour) { }

	// RVA: 0x565400 Offset: 0x563A00 VA: 0x180565400
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

