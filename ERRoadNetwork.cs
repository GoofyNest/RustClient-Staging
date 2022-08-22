public class ERRoadNetwork // TypeDefIndex: 7273
{	// Fields
	public ERModularBase roadNetwork; // 0x10
	public bool isInBuildMode; // 0x18
	public string str; // 0x20
	public static ERRoadNetwork.RoadUpdateCallback onRoadUpdate; // 0x0
	public static ERRoadNetwork.BuildModeCallback onBuildModeEnter; // 0x8
	public static ERRoadNetwork.EditModeCallback onEditModeEnter; // 0x10

	// Methods

	// RVA: 0xB412C0 Offset: 0xB3F8C0 VA: 0x180B412C0
	public static void OnBuildModeEnter() { }

	// RVA: 0xB414A0 Offset: 0xB3FAA0 VA: 0x180B414A0
	public static void OnEditModeEnter() { }

	// RVA: 0xB41680 Offset: 0xB3FC80 VA: 0x180B41680
	public static void OnRoadUpdated(ERRoad road) { }

	// RVA: 0xB41EC0 Offset: 0xB404C0 VA: 0x180B41EC0
	public void .ctor() { }

	// RVA: 0xB40480 Offset: 0xB3EA80 VA: 0x180B40480
	public void GetTerrainData() { }

	// RVA: 0xB404B0 Offset: 0xB3EAB0 VA: 0x180B404B0
	public ERTrafficDirection GetTrafficDirection() { }

	// RVA: 0xB41AE0 Offset: 0xB400E0 VA: 0x180B41AE0
	public void Translate(Vector3 pos) { }

	// RVA: 0xB3C4F0 Offset: 0xB3AAF0 VA: 0x180B3C4F0
	public void CenterPivotPoints() { }

	// RVA: 0xB40060 Offset: 0xB3E660 VA: 0x180B40060
	public ERRoad[] GetRoads() { }

	// RVA: 0xB3FEE0 Offset: 0xB3E4E0 VA: 0x180B3FEE0
	public ERRoad GetRoadByName(string name) { }

	// RVA: 0xB3FDA0 Offset: 0xB3E3A0 VA: 0x180B3FDA0
	public ERRoad GetRoadByGameObject(GameObject go) { }

	// RVA: 0xB3E740 Offset: 0xB3CD40 VA: 0x180B3E740
	public ERRoad CreateRoad(string roadName) { }

	// RVA: 0xB3DCA0 Offset: 0xB3C2A0 VA: 0x180B3DCA0
	public ERRoad CreateRoad(string roadName, Vector3[] markers) { }

	// RVA: 0xB3DDE0 Offset: 0xB3C3E0 VA: 0x180B3DDE0
	public ERRoad CreateRoad(string roadName, ERRoadType roadType) { }

	// RVA: 0xB3E1B0 Offset: 0xB3C7B0 VA: 0x180B3E1B0
	public ERRoad CreateRoad(string roadName, ERRoadType roadType, Vector3[] markers) { }

	// RVA: 0xB40510 Offset: 0xB3EB10 VA: 0x180B40510
	public ERModularRoad InitRoad(string roadName, ERRoadType roadType, Material roadMaterial) { }

	// RVA: 0xB3C150 Offset: 0xB3A750 VA: 0x180B3C150
	public void AddInititialMarkers(ERRoad road, Vector3[] markers) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void AddIntersection(ERCrossingPrefabs crossing, GameObject crossingPrefab) { }

	// RVA: 0xB3C350 Offset: 0xB3A950 VA: 0x180B3C350
	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail, ERRoad[] roads) { }

	// RVA: 0xB3C300 Offset: 0xB3A900 VA: 0x180B3C300
	public void BuildRoadNetwork(bool splatmaps, bool trees, bool detail) { }

	// RVA: 0xB3C2B0 Offset: 0xB3A8B0 VA: 0x180B3C2B0
	public void BuildRoadNetwork() { }

	// RVA: 0xB3E830 Offset: 0xB3CE30 VA: 0x180B3E830
	public void DoBuildRoadNetwork() { }

	// RVA: 0xB416E0 Offset: 0xB3FCE0 VA: 0x180B416E0
	public void RestoreRoadNetwork() { }

	// RVA: 0xB40040 Offset: 0xB3E640 VA: 0x180B40040
	public ERRoadType[] GetRoadTypes() { }

	// RVA: 0xB40020 Offset: 0xB3E620 VA: 0x180B40020
	public ERRoadType GetRoadTypeByName(string name) { }

	// RVA: 0xB401C0 Offset: 0xB3E7C0 VA: 0x180B401C0
	public SideObject GetSideObjectByName(string name) { }

	// RVA: 0xB3C2A0 Offset: 0xB3A8A0 VA: 0x180B3C2A0
	public ERRoadType AddRoadType() { }

	// RVA: 0xB404E0 Offset: 0xB3EAE0 VA: 0x180B404E0
	public void HideWhiteSurfaces(bool flag) { }

	// RVA: 0xB3FC10 Offset: 0xB3E210 VA: 0x180B3FC10
	public ERConnection[] GetConnections() { }

	// RVA: 0xB3F7F0 Offset: 0xB3DDF0 VA: 0x180B3F7F0
	public ERConnection GetConnectionByName(string name) { }

	// RVA: 0xB40EE0 Offset: 0xB3F4E0 VA: 0x180B40EE0
	public ERConnection[] LoadConnections() { }

	[ObsoleteAttribute] // RVA: 0x894F0 Offset: 0x888F0 VA: 0x1800894F0
	// RVA: 0xB401E0 Offset: 0xB3E7E0 VA: 0x180B401E0
	public ERConnection GetSourceConnectionByName(string name) { }

	// RVA: 0xB3F970 Offset: 0xB3DF70 VA: 0x180B3F970
	public ERConnection GetConnectionPrefabByName(string name) { }

	// RVA: 0xB40B40 Offset: 0xB3F140 VA: 0x180B40B40
	public ERConnection InstantiateConnection(ERConnection OQQCOQOCDO, string name, Vector3 position, Vector3 euler) { }

	// RVA: 0xB41720 Offset: 0xB3FD20 VA: 0x180B41720
	public void SetRaiseOffset(float value) { }

	// RVA: 0xB411D0 Offset: 0xB3F7D0 VA: 0x180B411D0
	public ERRoad OODOOOQQCO(ERRoad road) { }

	// RVA: 0xB3FD80 Offset: 0xB3E380 VA: 0x180B3FD80
	public float GetRaiseOffset() { }

	// RVA: 0xB3D1E0 Offset: 0xB3B7E0 VA: 0x180B3D1E0
	public void ClampUVs(bool clamp) { }

	// RVA: 0xB3D570 Offset: 0xB3BB70 VA: 0x180B3D570
	public ERRoad ConnectRoads(ERRoad road1, ERRoad road2) { }

	// RVA: 0xB3D200 Offset: 0xB3B800 VA: 0x180B3D200
	public ERRoad ConnectRoads(ERRoad road1, int marker1, ERRoad road2, int marker2) { }

	// RVA: 0xB3D0C0 Offset: 0xB3B6C0 VA: 0x180B3D0C0
	private bool CheckRoads(ERRoad road1, ERRoad road2, ref string str) { }

	// RVA: 0xB41950 Offset: 0xB3FF50 VA: 0x180B41950
	public static void SetTerrainNormals(Mesh m, GameObject go) { }

	// RVA: 0xB416D0 Offset: 0xB3FCD0 VA: 0x180B416D0
	public void Refresh() { }

	// RVA: 0xB3F790 Offset: 0xB3DD90 VA: 0x180B3F790
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

