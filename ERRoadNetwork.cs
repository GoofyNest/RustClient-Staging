public class ERRoadNetwork // TypeDefIndex: 7273
{	// Fields
	public ERModularBase roadNetwork; // 0x10
	public bool isInBuildMode; // 0x18
	public string str; // 0x20
	public static ERRoadNetwork.RoadUpdateCallback onRoadUpdate; // 0x0
	public static ERRoadNetwork.BuildModeCallback onBuildModeEnter; // 0x8
	public static ERRoadNetwork.EditModeCallback onEditModeEnter; // 0x10

	// Methods

	// RVA: 0xB40B30 Offset: 0xB3F130 VA: 0x180B40B30
	public static void OnBuildModeEnter() { }

	// RVA: 0xB40D10 Offset: 0xB3F310 VA: 0x180B40D10
	public static void OnEditModeEnter() { }

	// RVA: 0xB40EF0 Offset: 0xB3F4F0 VA: 0x180B40EF0
	public static void OnRoadUpdated(ERRoad road) { }

	// RVA: 0xB41730 Offset: 0xB3FD30 VA: 0x180B41730
	public void .ctor() { }

	// RVA: 0xB3FCF0 Offset: 0xB3E2F0 VA: 0x180B3FCF0
	public void GetTerrainData() { }

	// RVA: 0xB3FD20 Offset: 0xB3E320 VA: 0x180B3FD20
	public ERTrafficDirection GetTrafficDirection() { }

	// RVA: 0xB41350 Offset: 0xB3F950 VA: 0x180B41350
	public void Translate(Vector3 pos) { }

	// RVA: 0xB3BD60 Offset: 0xB3A360 VA: 0x180B3BD60
	public void CenterPivotPoints() { }

	// RVA: 0xB3F8D0 Offset: 0xB3DED0 VA: 0x180B3F8D0
	public ERRoad[] GetRoads() { }

	// RVA: 0xB3F750 Offset: 0xB3DD50 VA: 0x180B3F750
	public ERRoad GetRoadByName(string name) { }

	// RVA: 0xB3F610 Offset: 0xB3DC10 VA: 0x180B3F610
	public ERRoad GetRoadByGameObject(GameObject go) { }

	// RVA: 0xB3DFB0 Offset: 0xB3C5B0 VA: 0x180B3DFB0
	public ERRoad CreateRoad(string roadName) { }

	// RVA: 0xB3D510 Offset: 0xB3BB10 VA: 0x180B3D510
	public ERRoad CreateRoad(string roadName, Vector3[] markers) { }

	// RVA: 0xB3D650 Offset: 0xB3BC50 VA: 0x180B3D650
	public ERRoad CreateRoad(string roadName, ERRoadType roadType) { }

	// RVA: 0xB3DA20 Offset: 0xB3C020 VA: 0x180B3DA20
	public ERRoad CreateRoad(string roadName, ERRoadType roadType, Vector3[] markers) { }

	// RVA: 0xB3FD80 Offset: 0xB3E380 VA: 0x180B3FD80
	public ERModularRoad InitRoad(string roadName, ERRoadType roadType, Material roadMaterial) { }

	// RVA: 0xB3B9C0 Offset: 0xB39FC0 VA: 0x180B3B9C0
	public void AddInititialMarkers(ERRoad road, Vector3[] markers) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void AddIntersection(ERCrossingPrefabs crossing, GameObject crossingPrefab) { }

	// RVA: 0xB3BBC0 Offset: 0xB3A1C0 VA: 0x180B3BBC0
	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail, ERRoad[] roads) { }

	// RVA: 0xB3BB70 Offset: 0xB3A170 VA: 0x180B3BB70
	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail) { }

	// RVA: 0xB3BB20 Offset: 0xB3A120 VA: 0x180B3BB20
	public void BuildRoadNetwork() { }

	// RVA: 0xB3E0A0 Offset: 0xB3C6A0 VA: 0x180B3E0A0
	public void DoBuildRoadNetwork() { }

	// RVA: 0xB40F50 Offset: 0xB3F550 VA: 0x180B40F50
	public void RestoreRoadNetwork() { }

	// RVA: 0xB3F8B0 Offset: 0xB3DEB0 VA: 0x180B3F8B0
	public ERRoadType[] GetRoadTypes() { }

	// RVA: 0xB3F890 Offset: 0xB3DE90 VA: 0x180B3F890
	public ERRoadType GetRoadTypeByName(string name) { }

	// RVA: 0xB3FA30 Offset: 0xB3E030 VA: 0x180B3FA30
	public SideObject GetSideObjectByName(string name) { }

	// RVA: 0xB3BB10 Offset: 0xB3A110 VA: 0x180B3BB10
	public ERRoadType AddRoadType() { }

	// RVA: 0xB3FD50 Offset: 0xB3E350 VA: 0x180B3FD50
	public void HideWhiteSurfaces(bool flag) { }

	// RVA: 0xB3F480 Offset: 0xB3DA80 VA: 0x180B3F480
	public ERConnection[] GetConnections() { }

	// RVA: 0xB3F060 Offset: 0xB3D660 VA: 0x180B3F060
	public ERConnection GetConnectionByName(string name) { }

	// RVA: 0xB40750 Offset: 0xB3ED50 VA: 0x180B40750
	public ERConnection[] LoadConnections() { }

	[ObsoleteAttribute] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	// RVA: 0xB3FA50 Offset: 0xB3E050 VA: 0x180B3FA50
	public ERConnection GetSourceConnectionByName(string name) { }

	// RVA: 0xB3F1E0 Offset: 0xB3D7E0 VA: 0x180B3F1E0
	public ERConnection GetConnectionPrefabByName(string name) { }

	// RVA: 0xB403B0 Offset: 0xB3E9B0 VA: 0x180B403B0
	public ERConnection InstantiateConnection(ERConnection OQQCOQOCDO, string name, Vector3 position, Vector3 euler) { }

	// RVA: 0xB40F90 Offset: 0xB3F590 VA: 0x180B40F90
	public void SetRaiseOffset(float value) { }

	// RVA: 0xB40A40 Offset: 0xB3F040 VA: 0x180B40A40
	public ERRoad OODOOOQQCO(ERRoad road) { }

	// RVA: 0xB3F5F0 Offset: 0xB3DBF0 VA: 0x180B3F5F0
	public float GetRaiseOffset() { }

	// RVA: 0xB3CA50 Offset: 0xB3B050 VA: 0x180B3CA50
	public void ClampUVs(bool clamp) { }

	// RVA: 0xB3CDE0 Offset: 0xB3B3E0 VA: 0x180B3CDE0
	public ERRoad ConnectRoads(ERRoad road1, ERRoad road2) { }

	// RVA: 0xB3CA70 Offset: 0xB3B070 VA: 0x180B3CA70
	public ERRoad ConnectRoads(ERRoad road1, int marker1, ERRoad road2, int marker2) { }

	// RVA: 0xB3C930 Offset: 0xB3AF30 VA: 0x180B3C930
	private bool CheckRoads(ERRoad road1, ERRoad road2, ref string str) { }

	// RVA: 0xB411C0 Offset: 0xB3F7C0 VA: 0x180B411C0
	public static void SetTerrainNormals(Mesh m, GameObject go) { }

	// RVA: 0xB40F40 Offset: 0xB3F540 VA: 0x180B40F40
	public void Refresh() { }

	// RVA: 0xB3F000 Offset: 0xB3D600 VA: 0x180B3F000
	public void FinalizeObjects() { }

}

public sealed class ERRoadNetwork.RoadUpdateCallback : MulticastDelegate // TypeDefIndex: 7274
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A3B0 Offset: 0x4989B0 VA: 0x18049A3B0 Slot: 12
	public virtual void Invoke(ERRoad road) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(ERRoad road, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ERRoadNetwork.BuildModeCallback : MulticastDelegate // TypeDefIndex: 7275
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A1D0 Offset: 0x4987D0 VA: 0x18049A1D0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ERRoadNetwork.EditModeCallback : MulticastDelegate // TypeDefIndex: 7276
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A1D0 Offset: 0x4987D0 VA: 0x18049A1D0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

