public class ERRoadNetwork // TypeDefIndex: 7273
{	// Fields
	public ERModularBase roadNetwork; // 0x10
	public bool isInBuildMode; // 0x18
	public string str; // 0x20
	public static ERRoadNetwork.RoadUpdateCallback onRoadUpdate; // 0x0
	public static ERRoadNetwork.BuildModeCallback onBuildModeEnter; // 0x8
	public static ERRoadNetwork.EditModeCallback onEditModeEnter; // 0x10

	// Methods

	// RVA: 0xB40DF0 Offset: 0xB3F3F0 VA: 0x180B40DF0
	public static void OnBuildModeEnter() { }

	// RVA: 0xB40FD0 Offset: 0xB3F5D0 VA: 0x180B40FD0
	public static void OnEditModeEnter() { }

	// RVA: 0xB411B0 Offset: 0xB3F7B0 VA: 0x180B411B0
	public static void OnRoadUpdated(ERRoad road) { }

	// RVA: 0xB419F0 Offset: 0xB3FFF0 VA: 0x180B419F0
	public void .ctor() { }

	// RVA: 0xB3FFB0 Offset: 0xB3E5B0 VA: 0x180B3FFB0
	public void GetTerrainData() { }

	// RVA: 0xB3FFE0 Offset: 0xB3E5E0 VA: 0x180B3FFE0
	public ERTrafficDirection GetTrafficDirection() { }

	// RVA: 0xB41610 Offset: 0xB3FC10 VA: 0x180B41610
	public void Translate(Vector3 pos) { }

	// RVA: 0xB3C020 Offset: 0xB3A620 VA: 0x180B3C020
	public void CenterPivotPoints() { }

	// RVA: 0xB3FB90 Offset: 0xB3E190 VA: 0x180B3FB90
	public ERRoad[] GetRoads() { }

	// RVA: 0xB3FA10 Offset: 0xB3E010 VA: 0x180B3FA10
	public ERRoad GetRoadByName(string name) { }

	// RVA: 0xB3F8D0 Offset: 0xB3DED0 VA: 0x180B3F8D0
	public ERRoad GetRoadByGameObject(GameObject go) { }

	// RVA: 0xB3E270 Offset: 0xB3C870 VA: 0x180B3E270
	public ERRoad CreateRoad(string roadName) { }

	// RVA: 0xB3D7D0 Offset: 0xB3BDD0 VA: 0x180B3D7D0
	public ERRoad CreateRoad(string roadName, Vector3[] markers) { }

	// RVA: 0xB3D910 Offset: 0xB3BF10 VA: 0x180B3D910
	public ERRoad CreateRoad(string roadName, ERRoadType roadType) { }

	// RVA: 0xB3DCE0 Offset: 0xB3C2E0 VA: 0x180B3DCE0
	public ERRoad CreateRoad(string roadName, ERRoadType roadType, Vector3[] markers) { }

	// RVA: 0xB40040 Offset: 0xB3E640 VA: 0x180B40040
	public ERModularRoad InitRoad(string roadName, ERRoadType roadType, Material roadMaterial) { }

	// RVA: 0xB3BC80 Offset: 0xB3A280 VA: 0x180B3BC80
	public void AddInititialMarkers(ERRoad road, Vector3[] markers) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void AddIntersection(ERCrossingPrefabs crossing, GameObject crossingPrefab) { }

	// RVA: 0xB3BE80 Offset: 0xB3A480 VA: 0x180B3BE80
	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail, ERRoad[] roads) { }

	// RVA: 0xB3BE30 Offset: 0xB3A430 VA: 0x180B3BE30
	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail) { }

	// RVA: 0xB3BDE0 Offset: 0xB3A3E0 VA: 0x180B3BDE0
	public void BuildRoadNetwork() { }

	// RVA: 0xB3E360 Offset: 0xB3C960 VA: 0x180B3E360
	public void DoBuildRoadNetwork() { }

	// RVA: 0xB41210 Offset: 0xB3F810 VA: 0x180B41210
	public void RestoreRoadNetwork() { }

	// RVA: 0xB3FB70 Offset: 0xB3E170 VA: 0x180B3FB70
	public ERRoadType[] GetRoadTypes() { }

	// RVA: 0xB3FB50 Offset: 0xB3E150 VA: 0x180B3FB50
	public ERRoadType GetRoadTypeByName(string name) { }

	// RVA: 0xB3FCF0 Offset: 0xB3E2F0 VA: 0x180B3FCF0
	public SideObject GetSideObjectByName(string name) { }

	// RVA: 0xB3BDD0 Offset: 0xB3A3D0 VA: 0x180B3BDD0
	public ERRoadType AddRoadType() { }

	// RVA: 0xB40010 Offset: 0xB3E610 VA: 0x180B40010
	public void HideWhiteSurfaces(bool flag) { }

	// RVA: 0xB3F740 Offset: 0xB3DD40 VA: 0x180B3F740
	public ERConnection[] GetConnections() { }

	// RVA: 0xB3F320 Offset: 0xB3D920 VA: 0x180B3F320
	public ERConnection GetConnectionByName(string name) { }

	// RVA: 0xB40A10 Offset: 0xB3F010 VA: 0x180B40A10
	public ERConnection[] LoadConnections() { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB3FD10 Offset: 0xB3E310 VA: 0x180B3FD10
	public ERConnection GetSourceConnectionByName(string name) { }

	// RVA: 0xB3F4A0 Offset: 0xB3DAA0 VA: 0x180B3F4A0
	public ERConnection GetConnectionPrefabByName(string name) { }

	// RVA: 0xB40670 Offset: 0xB3EC70 VA: 0x180B40670
	public ERConnection InstantiateConnection(ERConnection OQQCOQOCDO, string name, Vector3 position, Vector3 euler) { }

	// RVA: 0xB41250 Offset: 0xB3F850 VA: 0x180B41250
	public void SetRaiseOffset(float value) { }

	// RVA: 0xB40D00 Offset: 0xB3F300 VA: 0x180B40D00
	public ERRoad OODOOOQQCO(ERRoad road) { }

	// RVA: 0xB3F8B0 Offset: 0xB3DEB0 VA: 0x180B3F8B0
	public float GetRaiseOffset() { }

	// RVA: 0xB3CD10 Offset: 0xB3B310 VA: 0x180B3CD10
	public void ClampUVs(bool clamp) { }

	// RVA: 0xB3D0A0 Offset: 0xB3B6A0 VA: 0x180B3D0A0
	public ERRoad ConnectRoads(ERRoad road1, ERRoad road2) { }

	// RVA: 0xB3CD30 Offset: 0xB3B330 VA: 0x180B3CD30
	public ERRoad ConnectRoads(ERRoad road1, int marker1, ERRoad road2, int marker2) { }

	// RVA: 0xB3CBF0 Offset: 0xB3B1F0 VA: 0x180B3CBF0
	private bool CheckRoads(ERRoad road1, ERRoad road2, ref string str) { }

	// RVA: 0xB41480 Offset: 0xB3FA80 VA: 0x180B41480
	public static void SetTerrainNormals(Mesh m, GameObject go) { }

	// RVA: 0xB41200 Offset: 0xB3F800 VA: 0x180B41200
	public void Refresh() { }

	// RVA: 0xB3F2C0 Offset: 0xB3D8C0 VA: 0x180B3F2C0
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

