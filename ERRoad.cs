public class ERRoad // TypeDefIndex: 7183
{	// Fields
	public ERModularRoad roadScript; // 0x10
	public GameObject gameObject; // 0x18
	public string str; // 0x20

	// Methods

	// RVA: 0xB4C260 Offset: 0xB4A860 VA: 0x180B4C260
	public void .ctor() { }

	// RVA: 0xB4C2B0 Offset: 0xB4A8B0 VA: 0x180B4C2B0
	public void .ctor(ERModularRoad scr) { }

	// RVA: 0xB43380 Offset: 0xB41980 VA: 0x180B43380
	public void AddInititialMarkers(Vector3 pos) { }

	// RVA: 0xB43400 Offset: 0xB41A00 VA: 0x180B43400
	public void AddMarker(Vector3 pos) { }

	// RVA: 0xB43D50 Offset: 0xB42350 VA: 0x180B43D50
	public void ClampUVs(bool value) { }

	// RVA: 0xB45260 Offset: 0xB43860 VA: 0x180B45260
	public void FlipTexture() { }

	// RVA: 0xB43500 Offset: 0xB41B00 VA: 0x180B43500
	public void AddMarkers(Vector3[] pos) { }

	// RVA: 0xB48F60 Offset: 0xB47560 VA: 0x180B48F60
	public void InsertMarker(Vector3 pos) { }

	// RVA: 0xB48EA0 Offset: 0xB474A0 VA: 0x180B48EA0
	public void InsertMarkerAt(Vector3 pos, int index) { }

	// RVA: 0xB44F60 Offset: 0xB43560 VA: 0x180B44F60
	public void DeleteMarker(int i) { }

	// RVA: 0xB49870 Offset: 0xB47E70 VA: 0x180B49870
	public void SetLayer(int layer) { }

	// RVA: 0xB4B890 Offset: 0xB49E90 VA: 0x180B4B890
	public void SetTag(string tag) { }

	// RVA: 0xB4BA90 Offset: 0xB4A090 VA: 0x180B4BA90
	public void SetWidth(float width) { }

	// RVA: 0xB482F0 Offset: 0xB468F0 VA: 0x180B482F0
	public float GetWidth() { }

	// RVA: 0xB47F80 Offset: 0xB46580 VA: 0x180B47F80
	public ERRoadType GetRoadType(ERRoadType[] roadTypes) { }

	// RVA: 0xB47F30 Offset: 0xB46530 VA: 0x180B47F30
	public ERRoadType GetRoadType() { }

	// RVA: 0xB4A830 Offset: 0xB48E30 VA: 0x180B4A830
	public bool SetRoadType(ERRoadType roadType) { }

	// RVA: 0xB49A30 Offset: 0xB48030 VA: 0x180B49A30
	public bool SetMarkerControlType(int marker, ERMarkerControlType type) { }

	// RVA: 0xB4B5B0 Offset: 0xB49BB0 VA: 0x180B4B5B0
	public bool SetSplineStrength(int marker, float strength) { }

	// RVA: 0xB481B0 Offset: 0xB467B0 VA: 0x180B481B0
	public float GetSplineStrength(int marker) { }

	// RVA: 0xB48FD0 Offset: 0xB475D0 VA: 0x180B48FD0
	public void IsSideObject(bool isSideObject) { }

	// RVA: 0xB48D00 Offset: 0xB47300 VA: 0x180B48D00
	public ERRoad InsertIConnector(int index) { }

	// RVA: 0xB48E40 Offset: 0xB47440 VA: 0x180B48E40
	public ERRoad InsertIConnector(int index, string connectionName) { }

	// RVA: 0xB48D20 Offset: 0xB47320 VA: 0x180B48D20
	public ERRoad InsertIConnector(int index, string connectionName, out ERConnection connection) { }

	// RVA: 0xB488F0 Offset: 0xB46EF0 VA: 0x180B488F0
	private ERRoad InsertIConnectorCore(int index, ref ERCrossingPrefabs pScript) { }

	// RVA: 0xB4BF20 Offset: 0xB4A520 VA: 0x180B4BF20
	public ERRoad SplitRoad(int markerIndex) { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0xB4BE50 Offset: 0xB4A450 VA: 0x180B4BE50
	private ERModularRoad SplitRoadExt(int markerIndex) { }

	// RVA: 0xB4AA30 Offset: 0xB49030 VA: 0x180B4AA30
	public void SetSideObjects(List<ERSORoadExt> soDataExt) { }

	// RVA: 0xB4B520 Offset: 0xB49B20 VA: 0x180B4B520
	public void SetSplatmap(bool active) { }

	// RVA: 0xB4B540 Offset: 0xB49B40 VA: 0x180B4B540
	public void SetSplatmap(bool active, int splatIndex, int expand, int smoothLevel, float opacity) { }

	// RVA: 0xB49FE0 Offset: 0xB485E0 VA: 0x180B49FE0
	public void SetMaterial(Material mat) { }

	// RVA: 0xB49B30 Offset: 0xB48130 VA: 0x180B49B30
	public void SetMarkerPosition(int marker, Vector3 vec) { }

	// RVA: 0xB4A3A0 Offset: 0xB489A0 VA: 0x180B4A3A0
	public void SetResolution(float res) { }

	// RVA: 0xB48FF0 Offset: 0xB475F0 VA: 0x180B48FF0
	public void IsStatic(bool value) { }

	// RVA: 0xB49030 Offset: 0xB47630 VA: 0x180B49030
	public bool IsStatic() { }

	// RVA: 0xB47DA0 Offset: 0xB463A0 VA: 0x180B47DA0
	public float GetResolution() { }

	// RVA: 0xB49300 Offset: 0xB47900 VA: 0x180B49300
	public void SetAngleThreshold(float res) { }

	// RVA: 0xB45790 Offset: 0xB43D90 VA: 0x180B45790
	public float GetAngleTreshold(float res) { }

	// RVA: 0xB44200 Offset: 0xB42800 VA: 0x180B44200
	public bool ClosedTrack(bool value) { }

	// RVA: 0xB45500 Offset: 0xB43B00 VA: 0x180B45500
	public void FollowTerrainContours(bool value) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB454D0 Offset: 0xB43AD0 VA: 0x180B454D0
	public void SetFollowTerrainContoursOffset(float value) { }

	// RVA: 0xB454D0 Offset: 0xB43AD0 VA: 0x180B454D0
	public void FollowTerrainContourThreshold(float value) { }

	// RVA: 0xB45700 Offset: 0xB43D00 VA: 0x180B45700
	public void FollowTerrainContours(int markerIndex, bool value) { }

	// RVA: 0xB48FB0 Offset: 0xB475B0 VA: 0x180B48FB0
	public bool IsClosedTrack() { }

	// RVA: 0xB49BE0 Offset: 0xB481E0 VA: 0x180B49BE0
	public void SetMarkerPositions(Vector3[] vecs) { }

	// RVA: 0xB49D60 Offset: 0xB48360 VA: 0x180B49D60
	public void SetMarkerPositions(Vector3[] vecs, int index) { }

	// RVA: 0xB473E0 Offset: 0xB459E0 VA: 0x180B473E0
	public Vector3 GetMarkerPosition(int marker) { }

	// RVA: 0xB474B0 Offset: 0xB45AB0 VA: 0x180B474B0
	public Vector3[] GetMarkerPositions() { }

	// RVA: 0xB47390 Offset: 0xB45990 VA: 0x180B47390
	public int GetMarkerCount() { }

	// RVA: 0xB49F40 Offset: 0xB48540 VA: 0x180B49F40
	public void SetMarkerTilting(float value, int index) { }

	// RVA: 0xB476D0 Offset: 0xB45CD0 VA: 0x180B476D0
	public float GetMarkerTilting(int index) { }

	// RVA: 0xB49E80 Offset: 0xB48480 VA: 0x180B49E80
	public void SetMarkerTiltingCenter(float value, int index) { }

	// RVA: 0xB47CD0 Offset: 0xB462D0 VA: 0x180B47CD0
	public float GetRadius(int markerIndex) { }

	// RVA: 0xB47640 Offset: 0xB45C40 VA: 0x180B47640
	public float GetMarkerTiltingCenter(int index) { }

	// RVA: 0xB48240 Offset: 0xB46840 VA: 0x180B48240
	public Color GetVertexColor(int index) { }

	// RVA: 0xB4B9F0 Offset: 0xB49FF0 VA: 0x180B4B9F0
	public void SetVertexColor(int index, Color color) { }

	// RVA: 0xB49440 Offset: 0xB47A40 VA: 0x180B49440
	public void SetDistances() { }

	// RVA: 0xB477F0 Offset: 0xB45DF0 VA: 0x180B477F0
	public Vector3 GetPosition(float distance, ref int currentElement) { }

	// RVA: 0xB468A0 Offset: 0xB44EA0 VA: 0x180B468A0
	public Vector3 GetLookatSmooth(float distance, int currentElement) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB46070 Offset: 0xB44670 VA: 0x180B46070
	public Vector3 GetLookatAtDistanceSmooth(float distance, ref int currentElement) { }

	// RVA: 0xB471A0 Offset: 0xB457A0 VA: 0x180B471A0
	public int GetMarkerByPoint(int el) { }

	// RVA: 0xB48070 Offset: 0xB46670 VA: 0x180B48070
	public Vector3[] GetSplinePointsCenter() { }

	// RVA: 0xB48160 Offset: 0xB46760 VA: 0x180B48160
	public Vector3[] GetSplinePointsRightSide() { }

	// RVA: 0xB48110 Offset: 0xB46710 VA: 0x180B48110
	public Vector3[] GetSplinePointsRightSideExt() { }

	// RVA: 0xB480C0 Offset: 0xB466C0 VA: 0x180B480C0
	public Vector3[] GetSplinePointsLeftSide() { }

	// RVA: 0xB49770 Offset: 0xB47D70 VA: 0x180B49770
	public float SetIndent(float value, int marker) { }

	// RVA: 0xB49660 Offset: 0xB47C60 VA: 0x180B49660
	public float SetIndent(float value, int marker, ERRoadSide type) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB4A3D0 Offset: 0xB489D0 VA: 0x180B4A3D0
	public float SetRightIndent(float value, int marker) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB498C0 Offset: 0xB47EC0 VA: 0x180B498C0
	public float SetLeftIndent(float value, int marker) { }

	// RVA: 0xB4B680 Offset: 0xB49C80 VA: 0x180B4B680
	public float SetSurrounding(float value, int marker) { }

	// RVA: 0xB4B780 Offset: 0xB49D80 VA: 0x180B4B780
	public float SetSurrounding(float value, int marker, ERRoadSide type) { }

	// RVA: 0xB49630 Offset: 0xB47C30 VA: 0x180B49630
	public void SetIndentAlignment(ERIndentAlignment value, int marker, ERRoadSide type) { }

	// RVA: 0xB45FB0 Offset: 0xB445B0 VA: 0x180B45FB0
	public ERIndentAlignment GetIndentAlignment(int marker, ERRoadSide type) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB4A490 Offset: 0xB48A90 VA: 0x180B4A490
	public float SetRightSurrouding(float value, int marker) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB49980 Offset: 0xB47F80 VA: 0x180B49980
	public float SetLeftSurrouding(float value, int marker) { }

	// RVA: 0xB47DC0 Offset: 0xB463C0 VA: 0x180B47DC0
	public Vector3[] GetRightIndentPoints() { }

	// RVA: 0xB45FD0 Offset: 0xB445D0 VA: 0x180B45FD0
	public Vector3[] GetLeftIndentPoints() { }

	// RVA: 0xB47E10 Offset: 0xB46410 VA: 0x180B47E10
	public Vector3[] GetRightSurroundingPoints() { }

	// RVA: 0xB46020 Offset: 0xB44620 VA: 0x180B46020
	public Vector3[] GetLeftSurroudingPoints() { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB45F90 Offset: 0xB44590 VA: 0x180B45F90
	public float GetLength() { }

	// RVA: 0xB45F90 Offset: 0xB44590 VA: 0x180B45F90
	public float GetDistance() { }

	// RVA: 0xB45F00 Offset: 0xB44500 VA: 0x180B45F00
	public float GetDistance(int markerIndex) { }

	// RVA: 0xB4BCF0 Offset: 0xB4A2F0 VA: 0x180B4BCF0
	public void SideObjectSetActive(SideObject obj, bool value) { }

	// RVA: 0xB4BC00 Offset: 0xB4A200 VA: 0x180B4BC00
	public void SideObjectMarkerSetActive(SideObject obj, int marker, bool value) { }

	// RVA: 0xB4BB10 Offset: 0xB4A110 VA: 0x180B4BB10
	public void SideObjectMarkerSetActive(SideObject obj, int[] markers, bool value) { }

	// RVA: 0xB4A950 Offset: 0xB48F50 VA: 0x180B4A950
	public void SetSideObjectOffset(SideObject obj, int marker, OffsetPosition position, float value) { }

	// RVA: 0xB4B910 Offset: 0xB49F10 VA: 0x180B4B910
	public void SetTerrainDeformation(bool value) { }

	// RVA: 0xB4B940 Offset: 0xB49F40 VA: 0x180B4B940
	public void SetTerrainDeformation(int markerIndex, bool value) { }

	// RVA: 0xB4A160 Offset: 0xB48760 VA: 0x180B4A160
	public void SetMeshCollider(bool flag) { }

	// RVA: 0xB49060 Offset: 0xB47660 VA: 0x180B49060
	public void Refresh() { }

	// RVA: 0xB45A10 Offset: 0xB44010 VA: 0x180B45A10
	public ERConnection GetConnectionAtStart() { }

	// RVA: 0xB45E60 Offset: 0xB44460 VA: 0x180B45E60
	public GameObject GetConnectionObjectAtStart() { }

	// RVA: 0xB45B30 Offset: 0xB44130 VA: 0x180B45B30
	public ERConnection GetConnectionAtStart(out int connectionIndex) { }

	// RVA: 0xB45C70 Offset: 0xB44270 VA: 0x180B45C70
	public ERConnection GetConnectionObjectAtEnd() { }

	// RVA: 0xB457B0 Offset: 0xB43DB0 VA: 0x180B457B0
	public ERConnection GetConnectionAtEnd() { }

	// RVA: 0xB458D0 Offset: 0xB43ED0 VA: 0x180B458D0
	public ERConnection GetConnectionAtEnd(out int connectionIndex) { }

	// RVA: 0xB45D90 Offset: 0xB44390 VA: 0x180B45D90
	public GameObject GetConnectionObjectAtEnd(out int connection) { }

	// RVA: 0xB44940 Offset: 0xB42F40 VA: 0x180B44940
	public bool ConnectionCheck(ERCrossingPrefabs prefab, int index, int startEnd) { }

	// RVA: 0xB448C0 Offset: 0xB42EC0 VA: 0x180B448C0
	public bool ConnectToStart(ERConnection connectionObject, int connectionIndex) { }

	// RVA: 0xB44830 Offset: 0xB42E30 VA: 0x180B44830
	public bool ConnectToStart(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB44630 Offset: 0xB42C30 VA: 0x180B44630
	public bool ConnectToStartExt(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB44510 Offset: 0xB42B10 VA: 0x180B44510
	public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex) { }

	// RVA: 0xB44590 Offset: 0xB42B90 VA: 0x180B44590
	public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB44300 Offset: 0xB42900 VA: 0x180B44300
	public bool ConnectToEndEx(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB43BA0 Offset: 0xB421A0 VA: 0x180B43BA0
	public ERConnection AttachToStart(ERConnection connectionObject) { }

	// RVA: 0xB43620 Offset: 0xB41C20 VA: 0x180B43620
	public ERConnection AttachToEnd(ERConnection connectionObject) { }

	// RVA: 0xB439F0 Offset: 0xB41FF0 VA: 0x180B439F0
	public ERConnection AttachToStart(ERConnection OQQCOQOCDO, int connectionIndex) { }

	// RVA: 0xB437F0 Offset: 0xB41DF0 VA: 0x180B437F0
	public ERConnection AttachToEnd(ERConnection connectionInstance, int connectionIndex) { }

	// RVA: 0xB44E40 Offset: 0xB43440 VA: 0x180B44E40
	public bool ConnectionMatch(ERConnection connection) { }

	// RVA: 0xB49330 Offset: 0xB47930 VA: 0x180B49330
	public void SetCustomMarkerPoints(int markerIndex, List<Vector3> points) { }

	// RVA: 0xB48380 Offset: 0xB46980 VA: 0x180B48380
	public ERConnection InsertConnector(ERConnection connectionObject, int markerIndex, int connectionIndex1, int connectionIndex2, out ERRoad road) { }

	// RVA: 0xB4C1B0 Offset: 0xB4A7B0 VA: 0x180B4C1B0
	public void UnConnectStart() { }

	// RVA: 0xB4C0E0 Offset: 0xB4A6E0 VA: 0x180B4C0E0
	public void UnConnectEnd() { }

	// RVA: 0xB44D30 Offset: 0xB43330 VA: 0x180B44D30
	public bool ConnectionMatch(ERConnection connection, int connectionIndex) { }

	// RVA: 0xB4BDC0 Offset: 0xB4A3C0 VA: 0x180B4BDC0
	public void SnapToTerrain(bool flag) { }

	// RVA: 0xB4BE00 Offset: 0xB4A400 VA: 0x180B4BE00
	public void SnapToTerrain(bool flag, float offset) { }

	// RVA: 0xB47760 Offset: 0xB45D60 VA: 0x180B47760
	public string GetName() { }

	// RVA: 0xB4A2F0 Offset: 0xB488F0 VA: 0x180B4A2F0
	public void SetName(string name) { }

	// RVA: 0xB47FD0 Offset: 0xB465D0 VA: 0x180B47FD0
	public Vector2[] GetShapeNodes() { }

	// RVA: 0xB47E60 Offset: 0xB46460 VA: 0x180B47E60
	public Vector2[] GetRoadShapeNodes(int markerIndex) { }

	// RVA: 0xB4A6C0 Offset: 0xB48CC0 VA: 0x180B4A6C0
	public void SetRoadShapeNodes(int markerIndex, Vector2[] nodes) { }

	// RVA: 0xB4A540 Offset: 0xB48B40 VA: 0x180B4A540
	public void SetRoadShapeNodes(int[] markerIndexes, Vector2[] nodes) { }

	// RVA: 0xB43D80 Offset: 0xB42380 VA: 0x180B43D80
	public void Clear() { }

	// RVA: 0xB44FD0 Offset: 0xB435D0 VA: 0x180B44FD0
	public void Destroy() { }

}

