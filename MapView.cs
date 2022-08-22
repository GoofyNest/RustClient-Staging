public class MapView : FacepunchBehaviour // TypeDefIndex: 10954
{	// Fields
	public RawImage mapImage; // 0x18
	public Image cameraPositon; // 0x20
	public ScrollRectEx scrollRect; // 0x28
	public GameObject monumentMarkerContainer; // 0x30
	public Transform clusterMarkerContainer; // 0x38
	public GameObjectRef monumentMarkerPrefab; // 0x40
	public GameObject missionMarkerContainer; // 0x48
	public GameObjectRef missionMarkerPrefab; // 0x50
	public TeamMemberMapMarker[] teamPositions; // 0x58
	public PointOfInterestMapMarker PointOfInterestMarker; // 0x60
	public PointOfInterestMapMarker LeaderPointOfInterestMarker; // 0x68
	public GameObject PlayerDeathMarker; // 0x70
	public List<SleepingBagMapMarker> SleepingBagMarkers; // 0x78
	public List<SleepingBagClusterMapMarker> SleepingBagClusters; // 0x80
	[FormerlySerializedAsAttribute] // RVA: 0x8D150 Offset: 0x8C550 VA: 0x18008D150
	public RawImage UndergroundLayer; // 0x88
	public bool ShowGrid; // 0x90
	public bool ShowPointOfInterestMarkers; // 0x91
	public bool ShowDeathMarker; // 0x92
	public bool ShowSleepingBags; // 0x93
	public bool ShowLocalPlayer; // 0x94
	public bool ShowTeamMembers; // 0x95
	public bool ShowTrainLayer; // 0x96
	public bool ShowMissions; // 0x97
	[FormerlySerializedAsAttribute] // RVA: 0x8D2E0 Offset: 0x8C6E0 VA: 0x18008D2E0
	public bool ShowUndergroundLayers; // 0x98
	public bool MLRSMarkerMode; // 0x99
	public RustImageButton LockButton; // 0xA0
	public RustImageButton OverworldButton; // 0xA8
	public RustImageButton TrainButton; // 0xB0
	public RustImageButton[] UnderwaterButtons; // 0xB8
	public static MapView ActiveView; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <followingPlayer>k__BackingField; // 0xC0
	private Dictionary<MapMarker.ClusterType, List<MapMarker>> clusterDict; // 0xC8
	private List<GameObject> markersToRetire; // 0xD0
	private Dictionary<MapMarker, GameObject> markerLookup; // 0xD8
	private List<MonumentMarker> monumentMarkers; // 0xE0
	private List<MissionMapMarker> missionMarkers; // 0xE8
	private bool isShowingUndergroundLayers; // 0xF0
	private Nullable<MapLayer> undergroundLayerOverride; // 0xF4
	private MapLayer visibleLayer; // 0xFC
	internal static MapEntity lastActiveMap; // 0x8

	// Properties
	public bool followingPlayer { get; set; }
	private bool IsOpen { get; }
	public static float MarkerScale { get; }
	private static BasePlayer LocalPlayerEntity { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EA80 Offset: 0x56D080 VA: 0x18056EA80
	public bool get_followingPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EA90 Offset: 0x56D090 VA: 0x18056EA90
	public void set_followingPlayer(bool value) { }

	// RVA: 0x56E900 Offset: 0x56CF00 VA: 0x18056E900
	private bool get_IsOpen() { }

	// RVA: 0x56EA30 Offset: 0x56D030 VA: 0x18056EA30
	public static float get_MarkerScale() { }

	// RVA: 0x56E990 Offset: 0x56CF90 VA: 0x18056E990
	private static BasePlayer get_LocalPlayerEntity() { }

	// RVA: 0x568880 Offset: 0x566E80 VA: 0x180568880
	private void Awake() { }

	// RVA: 0x56BB90 Offset: 0x56A190 VA: 0x18056BB90
	public void SetActiveView() { }

	// RVA: 0x569C80 Offset: 0x568280 VA: 0x180569C80
	public void ClearActiveView() { }

	// RVA: 0x56AD70 Offset: 0x569370 VA: 0x18056AD70
	public void MarkersDirty() { }

	// RVA: 0x56C8A0 Offset: 0x56AEA0 VA: 0x18056C8A0
	private void SetupMonuments() { }

	// RVA: 0x56BC90 Offset: 0x56A290 VA: 0x18056BC90
	private void SetupMarkers() { }

	// RVA: 0x56AE20 Offset: 0x569420 VA: 0x18056AE20
	public void PopulateMarker(MapMarker marker) { }

	// RVA: 0x56AEB0 Offset: 0x5694B0 VA: 0x18056AEB0
	private void PopulateMarker(GameObject uiMarker, MapMarker marker) { }

	// RVA: 0x56DC50 Offset: 0x56C250 VA: 0x18056DC50
	public void UpdatePointsOfInterest() { }

	// RVA: 0x56B0E0 Offset: 0x5696E0 VA: 0x18056B0E0
	public void PopulateSleepingBags() { }

	// RVA: 0x56A9C0 Offset: 0x568FC0 VA: 0x18056A9C0
	private SleepingBagMapMarker GetSleepingBagMarker() { }

	// RVA: 0x56A8E0 Offset: 0x568EE0 VA: 0x18056A8E0
	private SleepingBagClusterMapMarker GetSleepingBagClusterMarker() { }

	// RVA: 0x5688B0 Offset: 0x566EB0 VA: 0x1805688B0
	private void BuildMapMarkerClusters(List<MapMarker> markers, List<MapView.MapMarkerCluster> resultClusters, List<MapMarker> resultMarkers) { }

	// RVA: 0x5692E0 Offset: 0x5678E0 VA: 0x1805692E0
	private void BuildSpawnOptionClusters(List<RespawnInformation.SpawnOptions> spawnOptions, ref List<MapView.SleepingBagCluster> resultClusters, ref List<RespawnInformation.SpawnOptions> resultSleepingBags) { }

	// RVA: 0x56CDE0 Offset: 0x56B3E0 VA: 0x18056CDE0
	private bool ShouldShowSleepingBags() { }

	// RVA: 0x56D400 Offset: 0x56BA00 VA: 0x18056D400
	private void UpdateMissionMarkers() { }

	// RVA: 0x56D220 Offset: 0x56B820 VA: 0x18056D220
	public void UpdateMarkers() { }

	// RVA: 0x56E250 Offset: 0x56C850 VA: 0x18056E250
	private void Update() { }

	// RVA: 0x56A860 Offset: 0x568E60 VA: 0x18056A860
	private MapLayer GetSelectedMapLayer() { }

	// RVA: 0x56A580 Offset: 0x568B80 VA: 0x18056A580
	private static Nullable<MapLayer> GetCurrentUndergroundLayer() { }

	// RVA: 0x56E620 Offset: 0x56CC20 VA: 0x18056E620
	public Vector2 WorldPosToImagePos(Vector3 worldPos) { }

	// RVA: 0x56AAA0 Offset: 0x5690A0 VA: 0x18056AAA0
	public Vector3 ImagePosToWorldPos(Vector2 imagePos) { }

	// RVA: 0x569C30 Offset: 0x568230 VA: 0x180569C30
	public void CenterOn(Vector3 worldPos) { }

	// RVA: 0x56D890 Offset: 0x56BE90 VA: 0x18056D890
	public void UpdatePlayerPosition(BasePlayer player) { }

	// RVA: 0x56A3B0 Offset: 0x5689B0 VA: 0x18056A3B0
	public void DoPlayerUpdate() { }

	// RVA: 0x569D00 Offset: 0x568300 VA: 0x180569D00
	public void ClientTeamUpdated(bool positionsOnly = False) { }

	// RVA: 0x56ACD0 Offset: 0x5692D0 VA: 0x18056ACD0
	public void LockCurrentLayer() { }

	// RVA: 0x56CF10 Offset: 0x56B510 VA: 0x18056CF10
	public void UnlockCurrentLayer() { }

	// RVA: 0x56BC30 Offset: 0x56A230 VA: 0x18056BC30
	public void SetCurrentLayer(int layer) { }

	// RVA: 0x56CF20 Offset: 0x56B520 VA: 0x18056CF20
	public void UpdateLayerButtons(Nullable<MapLayer> currentLayer) { }

	// RVA: 0x56E760 Offset: 0x56CD60 VA: 0x18056E760
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private struct MapView.SleepingBagCluster // TypeDefIndex: 10955
{	// Fields
	public List<RespawnInformation.SpawnOptions> clusterMarkers; // 0x0
	public Vector3 centre; // 0x8

}

private struct MapView.MapMarkerCluster // TypeDefIndex: 10956
{	// Fields
	public List<MapMarker> markers; // 0x0
	public Vector3 centre; // 0x8

}

