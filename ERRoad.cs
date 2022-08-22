public class ERRoad // TypeDefIndex: 7183
{	// Fields
	public ERModularRoad roadScript; // 0x10
	public GameObject gameObject; // 0x18
	public string str; // 0x20

	// Methods

	// RVA: 0xB4BD90 Offset: 0xB4A390 VA: 0x180B4BD90
	public void .ctor() { }

	// RVA: 0xB4BDE0 Offset: 0xB4A3E0 VA: 0x180B4BDE0
	public void .ctor(ERModularRoad scr) { }

	// RVA: 0xB42EB0 Offset: 0xB414B0 VA: 0x180B42EB0
	public void AddInititialMarkers(Vector3 pos) { }

	// RVA: 0xB42F30 Offset: 0xB41530 VA: 0x180B42F30
	public void AddMarker(Vector3 pos) { }

	// RVA: 0xB43880 Offset: 0xB41E80 VA: 0x180B43880
	public void ClampUVs(bool value) { }

	// RVA: 0xB44D90 Offset: 0xB43390 VA: 0x180B44D90
	public void FlipTexture() { }

	// RVA: 0xB43030 Offset: 0xB41630 VA: 0x180B43030
	public void AddMarkers(Vector3[] pos) { }

	// RVA: 0xB48A90 Offset: 0xB47090 VA: 0x180B48A90
	public void InsertMarker(Vector3 pos) { }

	// RVA: 0xB489D0 Offset: 0xB46FD0 VA: 0x180B489D0
	public void InsertMarkerAt(Vector3 pos, int index) { }

	// RVA: 0xB44A90 Offset: 0xB43090 VA: 0x180B44A90
	public void DeleteMarker(int i) { }

	// RVA: 0xB493A0 Offset: 0xB479A0 VA: 0x180B493A0
	public void SetLayer(int layer) { }

	// RVA: 0xB4B3C0 Offset: 0xB499C0 VA: 0x180B4B3C0
	public void SetTag(string tag) { }

	// RVA: 0xB4B5C0 Offset: 0xB49BC0 VA: 0x180B4B5C0
	public void SetWidth(float width) { }

	// RVA: 0xB47E20 Offset: 0xB46420 VA: 0x180B47E20
	public float GetWidth() { }

	// RVA: 0xB47AB0 Offset: 0xB460B0 VA: 0x180B47AB0
	public ERRoadType GetRoadType(ERRoadType[] roadTypes) { }

	// RVA: 0xB47A60 Offset: 0xB46060 VA: 0x180B47A60
	public ERRoadType GetRoadType() { }

	// RVA: 0xB4A360 Offset: 0xB48960 VA: 0x180B4A360
	public bool SetRoadType(ERRoadType roadType) { }

	// RVA: 0xB49560 Offset: 0xB47B60 VA: 0x180B49560
	public bool SetMarkerControlType(int marker, ERMarkerControlType type) { }

	// RVA: 0xB4B0E0 Offset: 0xB496E0 VA: 0x180B4B0E0
	public bool SetSplineStrength(int marker, float strength) { }

	// RVA: 0xB47CE0 Offset: 0xB462E0 VA: 0x180B47CE0
	public float GetSplineStrength(int marker) { }

	// RVA: 0xB48B00 Offset: 0xB47100 VA: 0x180B48B00
	public void IsSideObject(bool isSideObject) { }

	// RVA: 0xB48830 Offset: 0xB46E30 VA: 0x180B48830
	public ERRoad InsertIConnector(int index) { }

	// RVA: 0xB48970 Offset: 0xB46F70 VA: 0x180B48970
	public ERRoad InsertIConnector(int index, string connectionName) { }

	// RVA: 0xB48850 Offset: 0xB46E50 VA: 0x180B48850
	public ERRoad InsertIConnector(int index, string connectionName, out ERConnection connection) { }

	// RVA: 0xB48420 Offset: 0xB46A20 VA: 0x180B48420
	private ERRoad InsertIConnectorCore(int index, ref ERCrossingPrefabs pScript) { }

	// RVA: 0xB4BA50 Offset: 0xB4A050 VA: 0x180B4BA50
	public ERRoad SplitRoad(int markerIndex) { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0xB4B980 Offset: 0xB49F80 VA: 0x180B4B980
	private ERModularRoad SplitRoadExt(int markerIndex) { }

	// RVA: 0xB4A560 Offset: 0xB48B60 VA: 0x180B4A560
	public void SetSideObjects(List<ERSORoadExt> soDataExt) { }

	// RVA: 0xB4B050 Offset: 0xB49650 VA: 0x180B4B050
	public void SetSplatmap(bool active) { }

	// RVA: 0xB4B070 Offset: 0xB49670 VA: 0x180B4B070
	public void SetSplatmap(bool active, int splatIndex, int expand, int smoothLevel, float opacity) { }

	// RVA: 0xB49B10 Offset: 0xB48110 VA: 0x180B49B10
	public void SetMaterial(Material mat) { }

	// RVA: 0xB49660 Offset: 0xB47C60 VA: 0x180B49660
	public void SetMarkerPosition(int marker, Vector3 vec) { }

	// RVA: 0xB49ED0 Offset: 0xB484D0 VA: 0x180B49ED0
	public void SetResolution(float res) { }

	// RVA: 0xB48B20 Offset: 0xB47120 VA: 0x180B48B20
	public void IsStatic(bool value) { }

	// RVA: 0xB48B60 Offset: 0xB47160 VA: 0x180B48B60
	public bool IsStatic() { }

	// RVA: 0xB478D0 Offset: 0xB45ED0 VA: 0x180B478D0
	public float GetResolution() { }

	// RVA: 0xB48E30 Offset: 0xB47430 VA: 0x180B48E30
	public void SetAngleThreshold(float res) { }

	// RVA: 0xB452C0 Offset: 0xB438C0 VA: 0x180B452C0
	public float GetAngleTreshold(float res) { }

	// RVA: 0xB43D30 Offset: 0xB42330 VA: 0x180B43D30
	public bool ClosedTrack(bool value) { }

	// RVA: 0xB45030 Offset: 0xB43630 VA: 0x180B45030
	public void FollowTerrainContours(bool value) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB45000 Offset: 0xB43600 VA: 0x180B45000
	public void SetFollowTerrainContoursOffset(float value) { }

	// RVA: 0xB45000 Offset: 0xB43600 VA: 0x180B45000
	public void FollowTerrainContourThreshold(float value) { }

	// RVA: 0xB45230 Offset: 0xB43830 VA: 0x180B45230
	public void FollowTerrainContours(int markerIndex, bool value) { }

	// RVA: 0xB48AE0 Offset: 0xB470E0 VA: 0x180B48AE0
	public bool IsClosedTrack() { }

	// RVA: 0xB49710 Offset: 0xB47D10 VA: 0x180B49710
	public void SetMarkerPositions(Vector3[] vecs) { }

	// RVA: 0xB49890 Offset: 0xB47E90 VA: 0x180B49890
	public void SetMarkerPositions(Vector3[] vecs, int index) { }

	// RVA: 0xB46F10 Offset: 0xB45510 VA: 0x180B46F10
	public Vector3 GetMarkerPosition(int marker) { }

	// RVA: 0xB46FE0 Offset: 0xB455E0 VA: 0x180B46FE0
	public Vector3[] GetMarkerPositions() { }

	// RVA: 0xB46EC0 Offset: 0xB454C0 VA: 0x180B46EC0
	public int GetMarkerCount() { }

	// RVA: 0xB49A70 Offset: 0xB48070 VA: 0x180B49A70
	public void SetMarkerTilting(float value, int index) { }

	// RVA: 0xB47200 Offset: 0xB45800 VA: 0x180B47200
	public float GetMarkerTilting(int index) { }

	// RVA: 0xB499B0 Offset: 0xB47FB0 VA: 0x180B499B0
	public void SetMarkerTiltingCenter(float value, int index) { }

	// RVA: 0xB47800 Offset: 0xB45E00 VA: 0x180B47800
	public float GetRadius(int markerIndex) { }

	// RVA: 0xB47170 Offset: 0xB45770 VA: 0x180B47170
	public float GetMarkerTiltingCenter(int index) { }

	// RVA: 0xB47D70 Offset: 0xB46370 VA: 0x180B47D70
	public Color GetVertexColor(int index) { }

	// RVA: 0xB4B520 Offset: 0xB49B20 VA: 0x180B4B520
	public void SetVertexColor(int index, Color color) { }

	// RVA: 0xB48F70 Offset: 0xB47570 VA: 0x180B48F70
	public void SetDistances() { }

	// RVA: 0xB47320 Offset: 0xB45920 VA: 0x180B47320
	public Vector3 GetPosition(float distance, ref int currentElement) { }

	// RVA: 0xB463D0 Offset: 0xB449D0 VA: 0x180B463D0
	public Vector3 GetLookatSmooth(float distance, int currentElement) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB45BA0 Offset: 0xB441A0 VA: 0x180B45BA0
	public Vector3 GetLookatAtDistanceSmooth(float distance, ref int currentElement) { }

	// RVA: 0xB46CD0 Offset: 0xB452D0 VA: 0x180B46CD0
	public int GetMarkerByPoint(int el) { }

	// RVA: 0xB47BA0 Offset: 0xB461A0 VA: 0x180B47BA0
	public Vector3[] GetSplinePointsCenter() { }

	// RVA: 0xB47C90 Offset: 0xB46290 VA: 0x180B47C90
	public Vector3[] GetSplinePointsRightSide() { }

	// RVA: 0xB47C40 Offset: 0xB46240 VA: 0x180B47C40
	public Vector3[] GetSplinePointsRightSideExt() { }

	// RVA: 0xB47BF0 Offset: 0xB461F0 VA: 0x180B47BF0
	public Vector3[] GetSplinePointsLeftSide() { }

	// RVA: 0xB492A0 Offset: 0xB478A0 VA: 0x180B492A0
	public float SetIndent(float value, int marker) { }

	// RVA: 0xB49190 Offset: 0xB47790 VA: 0x180B49190
	public float SetIndent(float value, int marker, ERRoadSide type) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB49F00 Offset: 0xB48500 VA: 0x180B49F00
	public float SetRightIndent(float value, int marker) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB493F0 Offset: 0xB479F0 VA: 0x180B493F0
	public float SetLeftIndent(float value, int marker) { }

	// RVA: 0xB4B1B0 Offset: 0xB497B0 VA: 0x180B4B1B0
	public float SetSurrounding(float value, int marker) { }

	// RVA: 0xB4B2B0 Offset: 0xB498B0 VA: 0x180B4B2B0
	public float SetSurrounding(float value, int marker, ERRoadSide type) { }

	// RVA: 0xB49160 Offset: 0xB47760 VA: 0x180B49160
	public void SetIndentAlignment(ERIndentAlignment value, int marker, ERRoadSide type) { }

	// RVA: 0xB45AE0 Offset: 0xB440E0 VA: 0x180B45AE0
	public ERIndentAlignment GetIndentAlignment(int marker, ERRoadSide type) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB49FC0 Offset: 0xB485C0 VA: 0x180B49FC0
	public float SetRightSurrouding(float value, int marker) { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB494B0 Offset: 0xB47AB0 VA: 0x180B494B0
	public float SetLeftSurrouding(float value, int marker) { }

	// RVA: 0xB478F0 Offset: 0xB45EF0 VA: 0x180B478F0
	public Vector3[] GetRightIndentPoints() { }

	// RVA: 0xB45B00 Offset: 0xB44100 VA: 0x180B45B00
	public Vector3[] GetLeftIndentPoints() { }

	// RVA: 0xB47940 Offset: 0xB45F40 VA: 0x180B47940
	public Vector3[] GetRightSurroundingPoints() { }

	// RVA: 0xB45B50 Offset: 0xB44150 VA: 0x180B45B50
	public Vector3[] GetLeftSurroudingPoints() { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB45AC0 Offset: 0xB440C0 VA: 0x180B45AC0
	public float GetLength() { }

	// RVA: 0xB45AC0 Offset: 0xB440C0 VA: 0x180B45AC0
	public float GetDistance() { }

	// RVA: 0xB45A30 Offset: 0xB44030 VA: 0x180B45A30
	public float GetDistance(int markerIndex) { }

	// RVA: 0xB4B820 Offset: 0xB49E20 VA: 0x180B4B820
	public void SideObjectSetActive(SideObject obj, bool value) { }

	// RVA: 0xB4B730 Offset: 0xB49D30 VA: 0x180B4B730
	public void SideObjectMarkerSetActive(SideObject obj, int marker, bool value) { }

	// RVA: 0xB4B640 Offset: 0xB49C40 VA: 0x180B4B640
	public void SideObjectMarkerSetActive(SideObject obj, int[] markers, bool value) { }

	// RVA: 0xB4A480 Offset: 0xB48A80 VA: 0x180B4A480
	public void SetSideObjectOffset(SideObject obj, int marker, OffsetPosition position, float value) { }

	// RVA: 0xB4B440 Offset: 0xB49A40 VA: 0x180B4B440
	public void SetTerrainDeformation(bool value) { }

	// RVA: 0xB4B470 Offset: 0xB49A70 VA: 0x180B4B470
	public void SetTerrainDeformation(int markerIndex, bool value) { }

	// RVA: 0xB49C90 Offset: 0xB48290 VA: 0x180B49C90
	public void SetMeshCollider(bool flag) { }

	// RVA: 0xB48B90 Offset: 0xB47190 VA: 0x180B48B90
	public void Refresh() { }

	// RVA: 0xB45540 Offset: 0xB43B40 VA: 0x180B45540
	public ERConnection GetConnectionAtStart() { }

	// RVA: 0xB45990 Offset: 0xB43F90 VA: 0x180B45990
	public GameObject GetConnectionObjectAtStart() { }

	// RVA: 0xB45660 Offset: 0xB43C60 VA: 0x180B45660
	public ERConnection GetConnectionAtStart(out int connectionIndex) { }

	// RVA: 0xB457A0 Offset: 0xB43DA0 VA: 0x180B457A0
	public ERConnection GetConnectionObjectAtEnd() { }

	// RVA: 0xB452E0 Offset: 0xB438E0 VA: 0x180B452E0
	public ERConnection GetConnectionAtEnd() { }

	// RVA: 0xB45400 Offset: 0xB43A00 VA: 0x180B45400
	public ERConnection GetConnectionAtEnd(out int connectionIndex) { }

	// RVA: 0xB458C0 Offset: 0xB43EC0 VA: 0x180B458C0
	public GameObject GetConnectionObjectAtEnd(out int connection) { }

	// RVA: 0xB44470 Offset: 0xB42A70 VA: 0x180B44470
	public bool ConnectionCheck(ERCrossingPrefabs prefab, int index, int startEnd) { }

	// RVA: 0xB443F0 Offset: 0xB429F0 VA: 0x180B443F0
	public bool ConnectToStart(ERConnection connectionObject, int connectionIndex) { }

	// RVA: 0xB44360 Offset: 0xB42960 VA: 0x180B44360
	public bool ConnectToStart(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB44160 Offset: 0xB42760 VA: 0x180B44160
	public bool ConnectToStartExt(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB44040 Offset: 0xB42640 VA: 0x180B44040
	public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex) { }

	// RVA: 0xB440C0 Offset: 0xB426C0 VA: 0x180B440C0
	public bool ConnectToEnd(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB43E30 Offset: 0xB42430 VA: 0x180B43E30
	public bool ConnectToEndEx(ERConnection connectionObject, int connectionIndex, bool autoAlign) { }

	// RVA: 0xB436D0 Offset: 0xB41CD0 VA: 0x180B436D0
	public ERConnection AttachToStart(ERConnection connectionObject) { }

	// RVA: 0xB43150 Offset: 0xB41750 VA: 0x180B43150
	public ERConnection AttachToEnd(ERConnection connectionObject) { }

	// RVA: 0xB43520 Offset: 0xB41B20 VA: 0x180B43520
	public ERConnection AttachToStart(ERConnection OQQCOQOCDO, int connectionIndex) { }

	// RVA: 0xB43320 Offset: 0xB41920 VA: 0x180B43320
	public ERConnection AttachToEnd(ERConnection connectionInstance, int connectionIndex) { }

	// RVA: 0xB44970 Offset: 0xB42F70 VA: 0x180B44970
	public bool ConnectionMatch(ERConnection connection) { }

	// RVA: 0xB48E60 Offset: 0xB47460 VA: 0x180B48E60
	public void SetCustomMarkerPoints(int markerIndex, List<Vector3> points) { }

	// RVA: 0xB47EB0 Offset: 0xB464B0 VA: 0x180B47EB0
	public ERConnection InsertConnector(ERConnection connectionObject, int markerIndex, int connectionIndex1, int connectionIndex2, out ERRoad road) { }

	// RVA: 0xB4BCE0 Offset: 0xB4A2E0 VA: 0x180B4BCE0
	public void UnConnectStart() { }

	// RVA: 0xB4BC10 Offset: 0xB4A210 VA: 0x180B4BC10
	public void UnConnectEnd() { }

	// RVA: 0xB44860 Offset: 0xB42E60 VA: 0x180B44860
	public bool ConnectionMatch(ERConnection connection, int connectionIndex) { }

	// RVA: 0xB4B8F0 Offset: 0xB49EF0 VA: 0x180B4B8F0
	public void SnapToTerrain(bool flag) { }

	// RVA: 0xB4B930 Offset: 0xB49F30 VA: 0x180B4B930
	public void SnapToTerrain(bool flag, float offset) { }

	// RVA: 0xB47290 Offset: 0xB45890 VA: 0x180B47290
	public string GetName() { }

	// RVA: 0xB49E20 Offset: 0xB48420 VA: 0x180B49E20
	public void SetName(string name) { }

	// RVA: 0xB47B00 Offset: 0xB46100 VA: 0x180B47B00
	public Vector2[] GetShapeNodes() { }

	// RVA: 0xB47990 Offset: 0xB45F90 VA: 0x180B47990
	public Vector2[] GetRoadShapeNodes(int markerIndex) { }

	// RVA: 0xB4A1F0 Offset: 0xB487F0 VA: 0x180B4A1F0
	public void SetRoadShapeNodes(int markerIndex, Vector2[] nodes) { }

	// RVA: 0xB4A070 Offset: 0xB48670 VA: 0x180B4A070
	public void SetRoadShapeNodes(int[] markerIndexes, Vector2[] nodes) { }

	// RVA: 0xB438B0 Offset: 0xB41EB0 VA: 0x180B438B0
	public void Clear() { }

	// RVA: 0xB44B00 Offset: 0xB43100 VA: 0x180B44B00
	public void Destroy() { }

}

