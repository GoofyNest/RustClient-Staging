public class ERModularBase : MonoBehaviour // TypeDefIndex: 7199
{	public int updateInt; // 0x18
	public bool newSplatMapRestoreCode; // 0x1C
	public int toolbarInt; // 0x20
	public int oldToolbarInt; // 0x24
	public int roadToolbarInt; // 0x28
	public int markerToolbarInt; // 0x2C
	public Texture[] menuTexs; // 0x30
	public Texture[] subMenuTexs; // 0x38
	public GameObject cprefab; // 0x40
	public Texture nodeHandleTexture; // 0x48
	public Texture lockedTexture; // 0x50
	public Texture unLockedTexture; // 0x58
	public Texture favOffTexture; // 0x60
	public Texture favOffFreeTexture; // 0x68
	public Texture favOnTexture; // 0x70
	public Texture selRoadTexture; // 0x78
	public Texture headerTexture; // 0x80
	public Texture sceneGUITex; // 0x88
	public Texture soIcon; // 0x90
	public Transform roadObjectsParent; // 0x98
	public Transform connectionObjectsParent; // 0xA0
	public GameObject OCOQDODDQQ; // 0xA8
	public List<QDQDOOQQDQODD> roadTypes; // 0xB0
	public int selectedRoadType; // 0xB8
	public int selectedNewRoadType; // 0xBC
	public List<QDQDOOQQDQODD> inspRoadTypes; // 0xC0
	public List<int> inspRoadTypeInts; // 0xC8
	public List<ERDecal> decalPresets; // 0xD0
	public float roadWidth; // 0xD8
	public Material roadMaterial; // 0xE0
	public Material crossingMaterial; // 0xE8
	public Material roundAboutMaterial; // 0xF0
	public Material roundAboutConnectionMaterial; // 0xF8
	public Material roundAboutRoadMaterial; // 0x100
	public Material sidewalkMaterial; // 0x108
	public Material targetMaterial; // 0x110
	public Terrain sourceTerrain; // 0x118
	public string[] roadMaterials; // 0x120
	public string[] connectionMaterials; // 0x128
	public int selectedMaterial; // 0x130
	public int selectedConnectionMaterial; // 0x134
	public List<ERMaterial> materials; // 0x138
	public int selectedRoadRoadType; // 0x140
	public bool roadOptions; // 0x144
	public bool sidewalkOptions; // 0x145
	public bool markerOptions; // 0x146
	public bool showRoadSideObjects; // 0x147
	public bool markerSOOptions; // 0x148
	public bool roadTerrainOptions; // 0x149
	public bool camFlyOver; // 0x14A
	public int selectedRoadMaterial; // 0x14C
	public int roadTextureInfoIndex; // 0x150
	public Texture2D selectedRoadTexture; // 0x158
	public float selectedRoadWidth; // 0x160
	public float selectedRoadLeftOffset; // 0x164
	public float selectedRoadRightOffset; // 0x168
	public float selectedRoadLeftInnerOffset; // 0x16C
	public float selectedRoadRightInnerOffset; // 0x170
	public int selectedCrossingMaterial; // 0x174
	public int crossingTextureInfoIndex; // 0x178
	public int handleSelection; // 0x17C
	public int positionHandleSelection; // 0x180
	public bool markerDirXZ; // 0x184
	public GameObject defaultCrossing; // 0x188
	public GameObject defaultTCrossing; // 0x190
	public GameObject defaultCulDeSac; // 0x198
	public GameObject defaultRoundabout; // 0x1A0
	public Texture2D tex; // 0x1A8
	public Texture2D infoTexture; // 0x1B0
	public bool showAllPrefabs; // 0x1B8
	public bool standardPrefabsFlag; // 0x1B9
	public bool sceneSettingsFoldOut; // 0x1BA
	public bool sceneRoadsFoldOut; // 0x1BB
	public bool scenePrefabsFoldOut; // 0x1BC
	public bool sidewalksFoldOut; // 0x1BD
	public bool terrainManagementFoldOut; // 0x1BE
	public bool importRoadDataFoldOut; // 0x1BF
	public bool lodGroupsFoldOut; // 0x1C0
	public bool defaultMaterialsFoldOut; // 0x1C1
	public bool aiTrafficFoldout; // 0x1C2
	public bool kmlFlag; // 0x1C3
	public bool osmFlag; // 0x1C4
	public bool useOSMHeights; // 0x1C5
	public float heightRatio; // 0x1C8
	public bool dynamicPrefabsFoldOut; // 0x1CC
	public bool customPrefabsFoldOut; // 0x1CD
	public List<ERConnectionGUIStatus> dynamicFavList; // 0x1D0
	public List<ERConnectionGUIStatus> customFavList; // 0x1D8
	public float prefabsDisplayType; // 0x1E0
	public bool ignoreTerrainAlerts; // 0x1E4
	public double osmTerrainTopLon; // 0x1E8
	public double osmTerrainBottomLon; // 0x1F0
	public double osmTerrainLeftLat; // 0x1F8
	public double osmTerrainRightLat; // 0x200
	public float terrainMinIndent; // 0x208
	public float minIndent; // 0x20C
	public float minSurrounding; // 0x210
	public float maxIndentSurrounding; // 0x214
	public float terrainY; // 0x218
	public float terrainDetailSplatX; // 0x21C
	public float terrainDetailSplatY; // 0x220
	public Vector3 detailOffsetVec; // 0x224
	public float raise; // 0x230
	public Vector3 baseVector; // 0x234
	public bool mirrorCrossings; // 0x240
	public string[] terrainNames; // 0x248
	public Terrain[] terrainObjects; // 0x250
	public string[] terrainSplatTextures; // 0x258
	public Terrain activeTerrain; // 0x260
	public float activeTerrainY; // 0x268
	public int selectedTerrain; // 0x26C
	public bool selectedRoadsOnly; // 0x270
	public bool terrainDone; // 0x271
	public bool enableBackWithoutRestore; // 0x272
	public float detailDistance; // 0x274
	public float treeDistance; // 0x278
	public bool doHeightmap; // 0x27C
	public bool doTrees; // 0x27D
	public bool soTrees; // 0x27E
	public bool doDetail; // 0x27F
	public Rect terrainRect; // 0x280
	public List<GameObject> tunnelObjects; // 0x290
	public List<GameObject> surfaceObjects; // 0x298
	public float preserveTerrainFloat; // 0x2A0
	public float terrainSmoothIndentDistance; // 0x2A4
	public float terrainSmoothSurroundingDistance; // 0x2A8
	public int indentSmoothStep; // 0x2AC
	public int surroundingSmoothStep; // 0x2B0
	public bool doTangents; // 0x2B4
	public bool doLightmapUVs; // 0x2B5
	public bool doLODGroups; // 0x2B6
	public bool doSplatmaps; // 0x2B7
	public int sLayer; // 0x2B8
	public List<Vector3> terrainHits; // 0x2C0
	public List<Vector3> osmCrossingPoints; // 0x2C8
	public List<CrossingCornerClass> cornerPresets; // 0x2D0
	public List<SidewalkPresetClass> sidewalkPresets; // 0x2D8
	public List<ERSideWalk> sidewalks; // 0x2E0
	public int selectedSidewalk; // 0x2E8
	public int selectedRoadTypeSidewalk; // 0x2EC
	public int osmMotorway; // 0x2F0
	public int osmMotorwayLink; // 0x2F4
	public int osmTrunk; // 0x2F8
	public int osmPrimary; // 0x2FC
	public int osmSecondary; // 0x300
	public int osmTertiary; // 0x304
	public int osmUnclassified; // 0x308
	public int osmResidential; // 0x30C
	public int osmService; // 0x310
	public int osmTrack; // 0x314
	public int osmPath; // 0x318
	public int osmWalkway; // 0x31C
	public int osmRaceway; // 0x320
	public int osmHighwayStringInt; // 0x324
	public bool osmMotorwayFlag; // 0x328
	public bool osmMotorwayLinkFlag; // 0x329
	public bool osmTrunkFlag; // 0x32A
	public bool osmPrimaryFlag; // 0x32B
	public bool osmSecondaryFlag; // 0x32C
	public bool osmTertiaryFlag; // 0x32D
	public bool osmUnclassifiedFlag; // 0x32E
	public bool osmResidentialFlag; // 0x32F
	public bool osmServiceFlag; // 0x330
	public bool osmTrackFlag; // 0x331
	public bool osmPathFlag; // 0x332
	public bool osmWalkwayFlag; // 0x333
	public bool osmRacewayFlag; // 0x334
	public string osmHighwayString; // 0x338
	public int kmlRoadType; // 0x340
	public bool lodGroups; // 0x344
	public int LODLevels; // 0x348
	public List<float> LODLevelValues; // 0x350
	public List<float> LODLevelResolution; // 0x358
	public bool embedRoadShape; // 0x360
	public bool hideSurfaces; // 0x361
	public bool showSurfaces; // 0x362
	public bool useLightProbes; // 0x363
	public bool hideLockedObjects; // 0x364
	public bool ODQCODODDD; // 0x365
	public bool isInBuildMode; // 0x366
	public bool progressFlag; // 0x367
	public int progressTerrain; // 0x368
	public float progressStatus; // 0x36C
	public float progressMax; // 0x370
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public List<SideObject> QOQDQOOQDDQOOQ; // 0x378
	public string[] sideObjectNames; // 0x380
	public int selSideObject; // 0x388
	public int selSubSideObject; // 0x38C
	public string soID; // 0x390
	public string sideObjectName; // 0x398
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int sideObjectType; // 0x3A0
	public GameObject sideObjectSource; // 0x3A8
	public GameObject soEndObject; // 0x3B0
	public int sideObjectTerrainVegetationInt; // 0x3B8
	public int prefabChildHandling; // 0x3BC
	public float sideObjectDistance; // 0x3C0
	public int soYAxisRotation; // 0x3C4
	public float soSidewaysDistance; // 0x3C8
	public int soSidewaysDistanceHandling; // 0x3CC
	public float soDensity; // 0x3D0
	public float soOffset; // 0x3D4
	public int soTerrainAligment; // 0x3D8
	public bool soCombine; // 0x3DC
	public bool soWeld; // 0x3DD
	public int soControllerType; // 0x3E0
	public Material soMaterial; // 0x3E8
	public float soXPosition; // 0x3F0
	public float soYPosition; // 0x3F4
	public bool soMarkerActive; // 0x3F8
	public bool enableSOHandles; // 0x3F9
	public bool enableShapeNodeHandles; // 0x3FA
	public bool enableSOShapeNodeHandles; // 0x3FB
	public bool displayCriticalPoints; // 0x3FC
	public bool highlightRoad; // 0x3FD
	public bool highlightIndents; // 0x3FE
	public bool highlightSurroundings; // 0x3FF
	public bool highlightSideObject; // 0x400
	public Color highlightRoadColor; // 0x404
	public Color highlightIndentColor; // 0x414
	public Color highlightSurroundingColor; // 0x424
	public bool onlyShowSelectedRoad; // 0x434
	public List<GameObject> soDeformationObjects; // 0x438
	public List<GameObject> soSplatmapObjects; // 0x440
	public bool buildSOinEditMode; // 0x448
	public bool tangentsInEditMode; // 0x449
	public bool calculateSmoothNormals; // 0x44A
	public bool importSideObjectsAlert; // 0x44B
	public bool importRoadPresetsAlert; // 0x44C
	public bool importCrossingPresetsAlert; // 0x44D
	public bool importSidewalkPresetsAlert; // 0x44E
	public bool updateSideObjectsAlert; // 0x44F
	public bool updateRoadPresetsAlert; // 0x450
	public bool updateCrossingPresetsAlert; // 0x451
	public bool updateSidewalkPresetsAlert; // 0x452
	public float waypointDistance; // 0x454
	public List<ERModularRoad> RoadObjectsSoUpdates; // 0x458
	public string assetsFolderID; // 0x460
	public GameObject meshSurface; // 0x468
	public Collider meshTerrainCollider; // 0x470
	public float markerScale; // 0x478
	public float markerDistance; // 0x47C
	public float minMarkerDistance; // 0x480
	public float maxMarkerDistance; // 0x484
	public bool debugFlag; // 0x488
	public List<Vector3> leftTHandles; // 0x490
	public List<Vector3> rightTHandles; // 0x498
	public float roadNetworkY; // 0x4A0
	public bool ignoreMinIndents; // 0x4A4
	public Vector3 zoomStart; // 0x4A8
	public Vector3 zoomEnd; // 0x4B4
	public Vector3 lookAtStart; // 0x4C0
	public Vector3 lookAtEnd; // 0x4CC
	public Quaternion zoomRot; // 0x4D8
	public float zoomStartTime; // 0x4E8
	public bool hideSurfaceHandles; // 0x4EC
	public bool dirtyBool; // 0x4ED
	public bool dirtyOnSceneBool; // 0x4EE
	public bool forceRoadNetworkSelect; // 0x4EF
	public bool ODQDQDQDCO; // 0x4F0
	public ERCrossingPrefabs OCOQDODDQQScript; // 0x4F8
	public ERCrossings OOOQDOQCCOCrossingsScript; // 0x500
	public ERCrossingPrefabs OOOQDOQCCOScript; // 0x508
	public int OCOQDODDQQElement; // 0x510
	public int OQCOQCOQQQ; // 0x514
	public ERModularRoad OCCQOOOQQO; // 0x518
	public ERModularRoad OODDQOOCOD; // 0x520
	public int OCODDDQOQC; // 0x528
	public int selectedRoadSOMarker; // 0x52C
	public int selectedMarkerNode; // 0x530
	public List<int> selectedMarkerNodes; // 0x538
	public int selectedMarkerSONode; // 0x540
	public List<int> selectedMarkerSONodes; // 0x548
	public List<SelectedObject> selectedObjects; // 0x550
	public int selectedExitRoad; // 0x558
	public bool newRoadFlag; // 0x55C
	public bool roadTypeUpdateFlag; // 0x55D
	public List<ERModularRoad> roadScripts; // 0x560
	public List<ERCrossingPrefabs> prefabScripts; // 0x568
	public bool globalGridActive; // 0x570
	public bool gridGUIActive; // 0x571
	public Color globalGridColor; // 0x574
	public float globalGridSize; // 0x584
	public float globalGridRadius; // 0x588
	public float globalGridRotation; // 0x58C
	public Vector2 gridOffset; // 0x590
	public Vector3 ggTL; // 0x598
	public Vector3 ggBL; // 0x5A4
	public Vector3 ggBR; // 0x5B0
	public bool localGridActive; // 0x5BC
	public List<ERLocalGrid> localGrids; // 0x5C0
	public int selectedLocalGrid; // 0x5C8
	public MethodInfo crMethod; // 0x5D0
	public MethodInfo upMethod; // 0x5D8
	public MethodInfo hmMethod; // 0x5E0
	public MethodInfo rmMethod; // 0x5E8
	public MethodInfo crBiomeMethod; // 0x5F0
	public MethodInfo upBiomeMethod; // 0x5F8
	public MethodInfo rmBiomeMethod; // 0x600
	public MethodInfo thMethodGet; // 0x608
	public MethodInfo thMethodSet; // 0x610
	public ERSideWalk sw; // 0x618
	public bool roadUpdated; // 0x620
	public bool clampUVs; // 0x621
	public int soCategoryInt; // 0x624
	public int soRoadCategoryInt; // 0x628
	public float minRoadWidth; // 0x62C
	public float maxRoadWidth; // 0x630
	public float maxCurbHeight; // 0x634
	public float minCornerRadius; // 0x638
	public float maxCornerRadius; // 0x63C
	public GameObject SoTestObject; // 0x640
	public bool lockRoadNetwork; // 0x648
	public bool showNotifications; // 0x649
	public bool multipleTerrainsWarning; // 0x64A
	public Texture2D[] OCDCDDQDQC; // 0x650
	public Texture2D[] OCDCOCCCCC; // 0x658
	public int textureCounter; // 0x660
	public static bool AssembliesSet; // 0x0
	public bool vegetationStudio; // 0x664
	public bool vegetationStudioPro; // 0x665
	public bool vegetationStudioActive; // 0x666
	public bool vegetationStudioMaskLineActive; // 0x667
	public float vegetationStudioGrassPerimeter; // 0x668
	public float vegetationStudioPlantPerimeter; // 0x66C
	public float vegetationStudioTreePerimeter; // 0x670
	public float vegetationStudioObjectPerimeter; // 0x674
	public float vegetationStudioLargeObjectPerimeter; // 0x678
	public bool vegetationStudioBiomeMaskActive; // 0x67C
	public float vegetationStudioBiomeMaskDistance; // 0x680
	public float vegetationStudioBiomeMaskBlendDistance; // 0x684
	public float vegetationStudioBiomeMaskNoiseScale; // 0x688
	public bool aiTraffic; // 0x68C
	public bool aiMatchingLanesOnly; // 0x68D
	public bool aiconnectNonMatchinglaneCounts; // 0x68E
	public bool aiIgnoreConnections; // 0x68F
	public bool displayLaneData; // 0x690
	public int rightHandDriving; // 0x694
	public Color leftLaneHandleColour; // 0x698
	public Color rightLaneHandleColour; // 0x6A8
	public Color laneHandleSelectedColour; // 0x6B8
	public float roadUvThreshold; // 0x6C8
	public int updateQueue; // 0x6CC
	public static bool checkPresets; // 0x1
	public bool logChange; // 0x6D0
	public bool debugMode; // 0x6D1
	public bool RoadNetworkInitFlag; // 0x6D2
	public static ERModularBase.RoadUpdate onRoadUpdate; // 0x8
	public static ERModularBase.OnBuildMode onBuildModeEnter; // 0x10
	public List<GameObject> excludeFromSelection; // 0x6D8
	public GameObject addExcludeFromSelection; // 0x6E0
	public Color shapeUVColor; // 0x6E8
	public Color startCapColor; // 0x6F8
	public Color endCapColor; // 0x708
	public Material soSectionMaterial; // 0x718
	public bool v32b4Flag; // 0x720


	public void OnBuildModeEnter() { }

	public void OnRoadUpdate(ERRoad road) { }

	public void RoadNetworkInit() { }

	public void UpdateQueue() { }

	public void SetRoadTypeList() { }

	public void UpdateRoadTypeStatus() { }

	public void OCOCQOODCO() { }

	public void OCQODDDCQQ() { }

	public void ODODOQOODO() { }

	public void OOCQCCCQCD() { }

	public void OQDQQODDCD(GameObject go, Vector3 pos) { }

	public void ODCDQQCQOC() { }

	public ERCrossingPrefabs OCDQQCQCQQ(GameObject prefab, ERModularRoad OCCQOOOQQO, int OCODDDQOQC, int connectionSegment) { }

	public ERCrossingPrefabs AttachConnector(ERModularRoad OCCQOOOQQO, int OCODDDQOQC) { }

	public void OCCDCDQOOD(ERModularRoad OCCQOOOQQO, int selectedMarker) { }

	public int OOOCOQQDQO(ERModularRoad OCCQOOOQQO, ERCrossingPrefabs prefabScript, int OCODDDQOQC, int startConnection, bool swapFlag) { }

	public int OOQQQQCCOC(string roadShapeString, List<string> strings, List<QDOODOQQDQODD> crossingElements) { }

	public GameObject OOQDQOOQQQ(GameObject prefab, Vector3 hitPos, ref GameObject newPrefab, ref ERCrossingPrefabs prefabScript, ref ERCrossings crossingsScript) { }

	public void OQOCDOOQCQ(ERCrossingPrefabs prefabScript) { }

	public void OQCDDCDDQC(GameObject newPrefab, GameObject prefab) { }

	public void ODDQCOQCQC() { }

	public List<ERTerrain> OODQQODOOC(ref bool multTerrainResFlag) { }

	public void ODDCCODOOC() { }

	public void OQQQDCQOOC(bool restoreTerrain) { }

	public void OQQOOCQQCD(Vector3 pos) { }

	public void OCDDQOCDCO(ref Vector3 pos) { }

	public Vector3 OQOODODDQO(Vector3 pos) { }

	public Vector2 GetTerrainUV(Vector3 pos) { }

	public Terrain OQOQDDOQOD(ref Vector3 pos, bool setSelected) { }

	public void OQCQQQDQQD() { }

	public void UpdateLODLevels(int levels) { }

	public void UpdateSideObjectsInScene() { }

	public void OOCDOOCQQC() { }

	public void OQQDDOQQOO() { }

	public ERRoadType[] GetRoadTypes() { }

	public ERRoadType GetRoadTypeByName(string name) { }

	public string GetNewRoadName(double id) { }

	public string GetRoadNameByID(double id) { }

	public SideObject OQCDCQCDCQ(string name) { }

	public void InitLoadImage(string url) { }

	private IEnumerator LoadImage(string url) { }

	public IEnumerator BuildTerrainRoutine(ERRoadNetwork roadNetwork) { }

	public float OCCQDCCCOD(Vector3 fwd, Vector3 targetDir, Vector3 up) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public sealed class ERModularBase.RoadUpdate : MulticastDelegate // TypeDefIndex: 7200
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ERRoad road) { }

	public virtual IAsyncResult BeginInvoke(ERRoad road, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ERModularBase.OnBuildMode : MulticastDelegate // TypeDefIndex: 7201
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class ERModularBase.ᙃ : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 7202
{	private int ᙅ; // 0x10
	private object 4AAAA; // 0x18
	public string url; // 0x20
	public ERModularBase <>4__this; // 0x28
	private WWW 5AAA1; // 0x30

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ERModularBase.ᙄ : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 7203
{	private int ᙅ; // 0x10
	private object 4AAAA; // 0x18
	public ERRoadNetwork roadNetwork; // 0x20
	public ERModularBase <>4__this; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

