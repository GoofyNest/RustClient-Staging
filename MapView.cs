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
	// RVA: 0x56EAF0 Offset: 0x56D0F0 VA: 0x18056EAF0
	public bool get_followingPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EB00 Offset: 0x56D100 VA: 0x18056EB00
	public void set_followingPlayer(bool value) { }

	// RVA: 0x56E970 Offset: 0x56CF70 VA: 0x18056E970
	private bool get_IsOpen() { }

	// RVA: 0x56EAA0 Offset: 0x56D0A0 VA: 0x18056EAA0
	public static float get_MarkerScale() { }

	// RVA: 0x56EA00 Offset: 0x56D000 VA: 0x18056EA00
	private static BasePlayer get_LocalPlayerEntity() { }

	// RVA: 0x5688F0 Offset: 0x566EF0 VA: 0x1805688F0
	private void Awake() { }

	// RVA: 0x56BC00 Offset: 0x56A200 VA: 0x18056BC00
	public void SetActiveView() { }

	// RVA: 0x569CF0 Offset: 0x5682F0 VA: 0x180569CF0
	public void ClearActiveView() { }

	// RVA: 0x56ADE0 Offset: 0x5693E0 VA: 0x18056ADE0
	public void MarkersDirty() { }

	// RVA: 0x56C910 Offset: 0x56AF10 VA: 0x18056C910
	private void SetupMonuments() { }

	// RVA: 0x56BD00 Offset: 0x56A300 VA: 0x18056BD00
	private void SetupMarkers() { }

	// RVA: 0x56AE90 Offset: 0x569490 VA: 0x18056AE90
	public void PopulateMarker(MapMarker marker) { }

	// RVA: 0x56AF20 Offset: 0x569520 VA: 0x18056AF20
	private void PopulateMarker(GameObject uiMarker, MapMarker marker) { }

	// RVA: 0x56DCC0 Offset: 0x56C2C0 VA: 0x18056DCC0
	public void UpdatePointsOfInterest() { }

	// RVA: 0x56B150 Offset: 0x569750 VA: 0x18056B150
	public void PopulateSleepingBags() { }

	// RVA: 0x56AA30 Offset: 0x569030 VA: 0x18056AA30
	private SleepingBagMapMarker GetSleepingBagMarker() { }

	// RVA: 0x56A950 Offset: 0x568F50 VA: 0x18056A950
	private SleepingBagClusterMapMarker GetSleepingBagClusterMarker() { }

	// RVA: 0x568920 Offset: 0x566F20 VA: 0x180568920
	private void BuildMapMarkerClusters(List<MapMarker> markers, List<MapView.MapMarkerCluster> resultClusters, List<MapMarker> resultMarkers) { }

	// RVA: 0x569350 Offset: 0x567950 VA: 0x180569350
	private void BuildSpawnOptionClusters(List<RespawnInformation.SpawnOptions> spawnOptions, ref List<MapView.SleepingBagCluster> resultClusters, ref List<RespawnInformation.SpawnOptions> resultSleepingBags) { }

	// RVA: 0x56CE50 Offset: 0x56B450 VA: 0x18056CE50
	private bool ShouldShowSleepingBags() { }

	// RVA: 0x56D470 Offset: 0x56BA70 VA: 0x18056D470
	private void UpdateMissionMarkers() { }

	// RVA: 0x56D290 Offset: 0x56B890 VA: 0x18056D290
	public void UpdateMarkers() { }

	// RVA: 0x56E2C0 Offset: 0x56C8C0 VA: 0x18056E2C0
	private void Update() { }

	// RVA: 0x56A8D0 Offset: 0x568ED0 VA: 0x18056A8D0
	private MapLayer GetSelectedMapLayer() { }

	// RVA: 0x56A5F0 Offset: 0x568BF0 VA: 0x18056A5F0
	private static Nullable<MapLayer> GetCurrentUndergroundLayer() { }

	// RVA: 0x56E690 Offset: 0x56CC90 VA: 0x18056E690
	public Vector2 WorldPosToImagePos(Vector3 worldPos) { }

	// RVA: 0x56AB10 Offset: 0x569110 VA: 0x18056AB10
	public Vector3 ImagePosToWorldPos(Vector2 imagePos) { }

	// RVA: 0x569CA0 Offset: 0x5682A0 VA: 0x180569CA0
	public void CenterOn(Vector3 worldPos) { }

	// RVA: 0x56D900 Offset: 0x56BF00 VA: 0x18056D900
	public void UpdatePlayerPosition(BasePlayer player) { }

	// RVA: 0x56A420 Offset: 0x568A20 VA: 0x18056A420
	public void DoPlayerUpdate() { }

	// RVA: 0x569D70 Offset: 0x568370 VA: 0x180569D70
	public void ClientTeamUpdated(bool positionsOnly = False) { }

	// RVA: 0x56AD40 Offset: 0x569340 VA: 0x18056AD40
	public void LockCurrentLayer() { }

	// RVA: 0x56CF80 Offset: 0x56B580 VA: 0x18056CF80
	public void UnlockCurrentLayer() { }

	// RVA: 0x56BCA0 Offset: 0x56A2A0 VA: 0x18056BCA0
	public void SetCurrentLayer(int layer) { }

	// RVA: 0x56CF90 Offset: 0x56B590 VA: 0x18056CF90
	public void UpdateLayerButtons(Nullable<MapLayer> currentLayer) { }

	// RVA: 0x56E7D0 Offset: 0x56CDD0 VA: 0x18056E7D0
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

