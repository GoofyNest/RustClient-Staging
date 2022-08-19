public class ERRoad // TypeDefIndex: 7183
{	// Fields
	public ERModularRoad roadScript; // 0x10
	public GameObject gameObject; // 0x18
	public string str; // 0x20

	// Methods

	// RVA: 0xB4BAD0 Offset: 0xB4A0D0 VA: 0x180B4BAD0
	public void .ctor() { }

	// RVA: 0xB4BB20 Offset: 0xB4A120 VA: 0x180B4BB20
	public void .ctor(ERModularRoad scr) { }

	// RVA: 0xB42BF0 Offset: 0xB411F0 VA: 0x180B42BF0
	public void AddInititialMarkers(Vector3 pos) { }

	// RVA: 0xB42C70 Offset: 0xB41270 VA: 0x180B42C70
	public void AddMarker(Vector3 pos) { }

	// RVA: 0xB435C0 Offset: 0xB41BC0 VA: 0x180B435C0
	public void ClampUVs(bool value) { }

	// RVA: 0xB44AD0 Offset: 0xB430D0 VA: 0x180B44AD0
	public void FlipTexture() { }

	// RVA: 0xB42D70 Offset: 0xB41370 VA: 0x180B42D70
	public void AddMarkers(Vector3[] pos) { }

	// RVA: 0xB487D0 Offset: 0xB46DD0 VA: 0x180B487D0
	public void InsertMarker(Vector3 pos) { }

	// RVA: 0xB48710 Offset: 0xB46D10 VA: 0x180B48710
	public void InsertMarkerAt(Vector3 pos, int index) { }

	// RVA: 0xB447D0 Offset: 0xB42DD0 VA: 0x180B447D0
	public void DeleteMarker(int i) { }

	// RVA: 0xB490E0 Offset: 0xB476E0 VA: 0x180B490E0
	public void SetLayer(int layer) { }

	// RVA: 0xB4B100 Offset: 0xB49700 VA: 0x180B4B100
	public void SetTag(string tag) { }

	// RVA: 0xB4B300 Offset: 0xB49900 VA: 0x180B4B300
	public void SetWidth(float width) { }

	// RVA: 0xB47B60 Offset: 0xB46160 VA: 0x180B47B60
	public float GetWidth() { }

	// RVA: 0xB477F0 Offset: 0xB45DF0 VA: 0x180B477F0
	public ERRoadType GetRoadType(ERRoadType[] roadTypes) { }

	// RVA: 0xB477A0 Offset: 0xB45DA0 VA: 0x180B477A0
	public ERRoadType GetRoadType() { }

	// RVA: 0xB4A0A0 Offset: 0xB486A0 VA: 0x180B4A0A0
	public bool SetRoadType(ERRoadType roadType) { }

	// RVA: 0xB492A0 Offset: 0xB478A0 VA: 0x180B492A0
	public bool SetMarkerControlType(int marker, ERMarkerControlType type) { }

	// RVA: 0xB4AE20 Offset: 0xB49420 VA: 0x180B4AE20
	public bool SetSplineStrength(int marker, float strength) { }

	// RVA: 0xB47A20 Offset: 0xB46020 VA: 0x180B47A20
	public float GetSplineStrength(int marker) { }

	// RVA: 0xB48840 Offset: 0xB46E40 VA: 0x180B48840
	public void IsSideObject(bool isSideObject) { }

	// RVA: 0xB48570 Offset: 0xB46B70 VA: 0x180B48570
	public ERRoad InsertIConnector(int index) { }

	// RVA: 0xB486B0 Offset: 0xB46CB0 VA: 0x180B486B0
	public ERRoad InsertIConnector(int index, string connectionName) { }

	// RVA: 0xB48590 Offset: 0xB46B90 VA: 0x180B48590
	public ERRoad InsertIConnector(int index, string connectionName, out ERConnection connection) { }

	// RVA: 0xB48160 Offset: 0xB46760 VA: 0x180B48160
	private ERRoad InsertIConnectorCore(int index, ref ERCrossingPrefabs pScript) { }

	// RVA: 0xB4B790 Offset: 0xB49D90 VA: 0x180B4B790
	public ERRoad SplitRoad(int markerIndex) { }

	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	// RVA: 0xB4B6C0 Offset: 0xB49CC0 VA: 0x180B4B6C0
	private ERModularRoad SplitRoadExt(int markerIndex) { }

	// RVA: 0xB4A2A0 Offset: 0xB488A0 VA: 0x180B4A2A0
	public void SetSideObjects(List<ERSORoadExt> soDataExt) { }

	// RVA: 0xB4AD90 Offset: 0xB49390 VA: 0x180B4AD90
	public void SetSplatmap(bool active) { }

	// RVA: 0xB4ADB0 Offset: 0xB493B0 VA: 0x180B4ADB0
	public void SetSplatmap(bool active, int splatIndex, int expand, int smoothLevel, float opacity) { }

	// RVA: 0xB49850 Offset: 0xB47E50 VA: 0x180B49850
	public void SetMaterial(Material mat) { }

	// RVA: 0xB493A0 Offset: 0xB479A0 VA: 0x180B493A0
	public void SetMarkerPosition(int marker, Vector3 vec) { }

	// RVA: 0xB49C10 Offset: 0xB48210 VA: 0x180B49C10
	public void SetResolution(float res) { }

	// RVA: 0xB48860 Offset: 0xB46E60 VA: 0x180B48860
	public void IsStatic(bool value) { }

	// RVA: 0xB488A0 Offset: 0xB46EA0 VA: 0x180B488A0
	public bool IsStatic() { }

	// RVA: 0xB47610 Offset: 0xB45C10 VA: 0x180B47610
	public float GetResolution() { }

	// RVA: 0xB48B70 Offset: 0xB47170 VA: 0x180B48B70
	public void SetAngleThreshold(float res) { }

	// RVA: 0xB45000 Offset: 0xB43600 VA: 0x180B45000
	public float GetAngleTreshold(float res) { }

	// RVA: 0xB43A70 Offset: 0xB42070 VA: 0x180B43A70
	public bool ClosedTrack(bool value) { }

	// RVA: 0xB44D70 Offset: 0xB43370 VA: 0x180B44D70
	public void FollowTerrainContours(bool value) { }

	[ObsoleteAttribute] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	// RVA: 0xB44D40 Offset: 0xB43340 VA: 0x180B44D40
	public void SetFollowTerrainContoursOffset(float value) { }

	// RVA: 0xB44D40 Offset: 0xB43340 VA: 0x180B44D40
	public void FollowTerrainContourThreshold(float value) { }

	// RVA: 0xB44F70 Offset: 0xB43570 VA: 0x180B44F70
	public void FollowTerrainContours(int markerIndex, bool value) { }

	// RVA: 0xB48820 Offset: 0xB46E20 VA: 0x180B48820
	public bool IsClosedTrack() { }

	// RVA: 0xB49450 Offset: 0xB47A50 VA: 0x180B49450
	public void SetMarkerPositions(Vector3[] vecs) { }

	// RVA: 0xB495D0 Offset: 0xB47BD0 VA: 0x180B495D0
	public void SetMarkerPositions(Vector3[] vecs, int index) { }

	// RVA: 0xB46C50 Offset: 0xB45250 VA: 0x180B46C50
	public Vector3 GetMarkerPosition(int marker) { }

	// RVA: 0xB46D20 Offset: 0xB45320 VA: 0x180B46D20
	public Vector3[] GetMarkerPositions() { }

	// RVA: 0xB46C00 Offset: 0xB45200 VA: 0x180B46C00
	public int GetMarkerCount() { }

	// RVA: 0xB497B0 Offset: 0xB47DB0 VA: 0x180B497B0
	public void SetMarkerTilting(float value, int index) { }

	// RVA: 0xB46F40 Offset: 0xB45540 VA: 0x180B46F40
	public float GetMarkerTilting(int index) { }

	// RVA: 0xB496F0 Offset: 0xB47CF0 VA: 0x180B496F0
	public void SetMarkerTiltingCenter(float value, int index) { }

	// RVA: 0xB47540 Offset: 0xB45B40 VA: 0x180B47540
	public float GetRadius(int markerIndex) { }

	// RVA: 0xB46EB0 Offset: 0xB454B0 VA: 0x180B46EB0
	public float GetMarkerTiltingCenter(int index) { }

	// RVA: 0xB47AB0 Offset: 0xB460B0 VA: 0x180B47AB0
	public Color GetVertexColor(int index) { }

	// RVA: 0xB4B260 Offset: 0xB49860 VA: 0x180B4B260
	public void SetVertexColor(int index, Color color) { }

	// RVA: 0xB48CB0 Offset: 0xB472B0 VA: 0x180B48CB0
	public void SetDistances() { }

	// RVA: 0xB47060 Offset: 0xB45660 VA: 0x180B47060
	public Vector3 GetPosition(float distance, ref int currentElement) { }

	// RVA: 0xB46110 Offset: 0xB44710 VA: 0x180B46110
	public Vector3 GetLookatSmooth(float distance, int currentElement) { }

	[ObsoleteAttribute] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	// RVA: 0xB458E0 Offset: 0xB43EE0 VA: 0x180B458E0
	public Vector3 GetLookatAtDistanceSmooth(float distance, ref int currentElement) { }

	// RVA: 0xB46A10 Offset: 0xB45010 VA: 0x180B46A10
	public int GetMarkerByPoint(int el) { }

	// RVA: 0xB478E0 Offset: 0xB45EE0 VA: 0x180B478E0
	public Vector3[] GetSplinePointsCenter() { }

	// RVA: 0xB479D0 Offset: 0xB45FD0 VA: 0x180B479D0
	public Vector3[] GetSplinePointsRightSide() { }

	// RVA: 0xB47980 Offset: 0xB45F80 VA: 0x180B47980
	public Vector3[] GetSplinePointsRightSideExt() { }

	// RVA: 0xB47930 Offset: 0xB45F30 VA: 0x180B47930
	public Vector3[] GetSplinePointsLeftSide() { }

	// RVA: 0xB48FE0 Offset: 0xB475E0 VA: 0x180B48FE0
	public float SetIndent(float value, int marker) { }

	// RVA: 0xB48ED0 Offset: 0xB474D0 VA: 0x180B48ED0
	public float SetIndent(float value, int marker, ERRoadSide type) { }

	[ObsoleteAttribute] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	// RVA: 0xB49C40 Offset: 0xB48240 VA: 0x180B49C40
	public float SetRightIndent(float value, int marker) { }

	[ObsoleteAttribute] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	// RVA: 0xB49130 Offset: 0xB47730 VA: 0x180B49130
	public float SetLeftIndent(float value, int marker) { }

	// RVA: 0xB4AEF0 Offset: 0xB494F0 VA: 0x180B4AEF0
	public float SetSurrounding(float value, int marker) { }

	// RVA: 0xB4AFF0 Offset: 0xB495F0 VA: 0x180B4AFF0
	public float SetSurrounding(float value, int marker, ERRoadSide type) { }

	// RVA: 0xB48EA0 Offset: 0xB474A0 VA: 0x180B48EA0
	public void SetIndentAlignment(ERIndentAlignment value, int marker, ERRoadSide type) { }

	// RVA: 0xB45820 Offset: 0xB43E20 VA: 0x180B45820
	public ERIndentAlignment GetIndentAlignment(int marker, ERRoadSide type) { }

	[ObsoleteAttribute] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	// RVA: 0xB49D00 Offset: 0xB48300 VA: 0x180B49D00
	public float SetRightSurrouding(float value, int marker) { }

	[ObsoleteAttribute] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	// RVA: 0xB491F0 Offset: 0xB477F0 VA: 0x180B491F0
	public float SetLeftSurrouding(float value, int marker) { }

	// RVA: 0xB47630 Offset: 0xB45C30 VA: 0x180B47630
	public Vector3[] GetRightIndentPoints() { }

	// RVA: 0xB45840 Offset: 0xB43E40 VA: 0x180B45840
	public Vector3[] GetLeftIndentPoints() { }

	// RVA: 0xB47680 Offset: 0xB45C80 VA: 0x180B47680
	public Vector3[] GetRightSurroundingPoints() { }

	// RVA: 0xB45890 Offset: 0xB43E90 VA: 0x180B45890
	public Vector3[] GetLeftSurroudingPoints() { }

	[ObsoleteAttribute] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	// RVA: 0xB45800 Offset: 0xB43E00 VA: 0x180B45800
	public float GetLength() { }

	// RVA: 0xB45800 Offset: 0xB43E00 VA: 0x180B45800
	public float GetDistance() { }

	// RVA: 0xB45770 Offset: 0xB43D70 VA: 0x180B45770
	public float GetDistance(int markerIndex) { }

	// RVA: 0xB4B560 Offset: 0xB49B60 VA: 0x180B4B560
	public void SideObjectSetActive(SideObject obj, bool value) { }

	// RVA: 0xB4B470 Offset: 0xB49A70 VA: 0x180B4B470
	public void SideObjectMarkerSetActive(SideObject obj, int marker, bool value) { }

	// RVA: 0xB4B380 Offset: 0xB49980 VA: 0x180B4B380
	public void SideObjectMarkerSetActive(SideObject obj, int[] markers, bool value) { }

	// RVA: 0xB4A1C0 Offset: 0xB487C0 VA: 0x180B4A1C0
	public void SetSideObjectOffset(SideObject obj, int marker, OffsetPosition position, float value) { }

	// RVA: 0xB4B180 Offset: 0xB49780 VA: 0x180B4B180
	public void SetTerrainDeformation(bool value) { }

	// RVA: 0xB4B1B0 Offset: 0xB497B0 VA: 0x180B4B1B0
	public void SetTerrainDeformation(int markerIndex, bool value) { }

	// RVA: 0xB499D0 Offset: 0xB47FD0 VA: 0x180B499D0
	public void SetMeshCollider(bool flag) { }

	// RVA: 0xB488D0 Offset: 0xB46ED0 VA: 0x180B488D0
	public void Refresh() { }

	// RVA: 0xB45280 Offset: 0xB43880 VA: 0x180B45280
	public ERConnection GetConnectionAtStart() { }

	// RVA: 0xB456D0 Offset: 0xB43CD0 VA: 0x180B456D0
	public GameObject GetConnectionObjectAtStart() { }

	// RVA: 0xB453A0 Offset: 0xB439A0 VA: 0x180B453A0
	public ERConnection GetConnectionAtStart(out int connectionIndex) { }

	// RVA: 0xB454E0 Offset: 0xB43AE0 VA: 0x180B454E0
	public ERConnection GetConnectionObjectAtEnd() { }

	// RVA: 0xB45020 Offset: 0xB43620 VA: 0x180B45020
	public ERConnection GetConnectionAtEnd() { }

	// RVA: 0xB45140 Offset: 0xB43740 VA: 0x180B45140
	public ERConnection GetConnectionAtEnd(out int connectionIndex) { }

	// RVA: 0xB45600 Offset: 0xB43C00 VA: 0x180B45600
	public GameObject GetConnectionObjectAtEnd(out int connection) { }

	// RVA: 0xB441B0 Offset: 0xB427B0 VA: 0x180B441B0
	public bool ConnectionCheck(ERCrossingPrefabs prefab, int index, int startEnd) { }

	// RVA: 0xB44130 Offset: 0xB42730 VA: 0x180B44130
	public bool ConnectToStart(ERConnection connectionObject, int connectionIndex) { }

	// RVA: 0xB440A0 Offset: 0xB426A0 VA: 0x180B440A0
	public bool ConnectToStart(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB43EA0 Offset: 0xB424A0 VA: 0x180B43EA0
	public bool ConnectToStartExt(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB43D80 Offset: 0xB42380 VA: 0x180B43D80
	public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex) { }

	// RVA: 0xB43E00 Offset: 0xB42400 VA: 0x180B43E00
	public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB43B70 Offset: 0xB42170 VA: 0x180B43B70
	public bool ConnectToEndEx(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB43410 Offset: 0xB41A10 VA: 0x180B43410
	public ERConnection AttachToStart(ERConnection connectionObject) { }

	// RVA: 0xB42E90 Offset: 0xB41490 VA: 0x180B42E90
	public ERConnection AttachToEnd(ERConnection connectionObject) { }

	// RVA: 0xB43260 Offset: 0xB41860 VA: 0x180B43260
	public ERConnection AttachToStart(ERConnection OQQCOQOCDO, int connectionIndex) { }

	// RVA: 0xB43060 Offset: 0xB41660 VA: 0x180B43060
	public ERConnection AttachToEnd(ERConnection connectionInstance, int connectionIndex) { }

	// RVA: 0xB446B0 Offset: 0xB42CB0 VA: 0x180B446B0
	public bool ConnectionMatch(ERConnection connection) { }

	// RVA: 0xB48BA0 Offset: 0xB471A0 VA: 0x180B48BA0
	public void SetCustomMarkerPoints(int markerIndex, List<Vector3> points) { }

	// RVA: 0xB47BF0 Offset: 0xB461F0 VA: 0x180B47BF0
	public ERConnection InsertConnector(ERConnection connectionObject, int markerIndex, int connectionIndex1, int connectionIndex2, out ERRoad road) { }

	// RVA: 0xB4BA20 Offset: 0xB4A020 VA: 0x180B4BA20
	public void UnConnectStart() { }

	// RVA: 0xB4B950 Offset: 0xB49F50 VA: 0x180B4B950
	public void UnConnectEnd() { }

	// RVA: 0xB445A0 Offset: 0xB42BA0 VA: 0x180B445A0
	public bool ConnectionMatch(ERConnection connection, int connectionIndex) { }

	// RVA: 0xB4B630 Offset: 0xB49C30 VA: 0x180B4B630
	public void SnapToTerrain(bool flag) { }

	// RVA: 0xB4B670 Offset: 0xB49C70 VA: 0x180B4B670
	public void SnapToTerrain(bool flag, float offset) { }

	// RVA: 0xB46FD0 Offset: 0xB455D0 VA: 0x180B46FD0
	public string GetName() { }

	// RVA: 0xB49B60 Offset: 0xB48160 VA: 0x180B49B60
	public void SetName(string name) { }

	// RVA: 0xB47840 Offset: 0xB45E40 VA: 0x180B47840
	public Vector2[] GetShapeNodes() { }

	// RVA: 0xB476D0 Offset: 0xB45CD0 VA: 0x180B476D0
	public Vector2[] GetRoadShapeNodes(int markerIndex) { }

	// RVA: 0xB49F30 Offset: 0xB48530 VA: 0x180B49F30
	public void SetRoadShapeNodes(int markerIndex, Vector2[] nodes) { }

	// RVA: 0xB49DB0 Offset: 0xB483B0 VA: 0x180B49DB0
	public void SetRoadShapeNodes(int[] markerIndexes, Vector2[] nodes) { }

	// RVA: 0xB435F0 Offset: 0xB41BF0 VA: 0x180B435F0
	public void Clear() { }

	// RVA: 0xB44840 Offset: 0xB42E40 VA: 0x180B44840
	public void Destroy() { }

}

