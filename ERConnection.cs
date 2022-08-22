public class ERConnection // TypeDefIndex: 7257
{	// Fields
	public string name; // 0x10
	public ERCrossingPrefabs prefabScript; // 0x18
	public GameObject gameObject; // 0x20
	public ERConnectionData[] connectionData; // 0x28
	public static string str; // 0x0

	// Methods

	// RVA: 0xB81490 Offset: 0xB7FA90 VA: 0x180B81490
	public void .ctor(GameObject go, string g_name) { }

	// RVA: 0xB7EBC0 Offset: 0xB7D1C0 VA: 0x180B7EBC0
	public static ERConnection Create(GameObject go) { }

	// RVA: 0xB80AC0 Offset: 0xB7F0C0 VA: 0x180B80AC0
	public void SetPosition(Vector3 pos) { }

	// RVA: 0xB80220 Offset: 0xB7E820 VA: 0x180B80220
	public string GetName() { }

	// RVA: 0xB80A30 Offset: 0xB7F030 VA: 0x180B80A30
	public void SetName(string name) { }

	// RVA: 0xB80D80 Offset: 0xB7F380 VA: 0x180B80D80
	public void SetRotation(Vector3 euler) { }

	// RVA: 0xB7ECE0 Offset: 0xB7D2E0 VA: 0x180B7ECE0
	public void Destroy() { }

	// RVA: 0xB812B0 Offset: 0xB7F8B0 VA: 0x180B812B0
	public void UnConnect(int connectionIndex) { }

	// RVA: 0xB7F330 Offset: 0xB7D930 VA: 0x180B7F330
	public ERConnectionData[] GetConnectionData() { }

	// RVA: 0xB7FDD0 Offset: 0xB7E3D0 VA: 0x180B7FDD0
	public Vector3 GetLocalConnectionPosition(int connectionIndex) { }

	// RVA: 0xB7FFD0 Offset: 0xB7E5D0 VA: 0x180B7FFD0
	public Vector3[] GetLocalConnectionPositions() { }

	// RVA: 0xB7F740 Offset: 0xB7DD40 VA: 0x180B7F740
	public Vector3[] GetConnectionWorldPositions() { }

	// RVA: 0xB7F600 Offset: 0xB7DC00 VA: 0x180B7F600
	public Vector3 GetConnectionWorldPosition(int connectionIndex) { }

	// RVA: 0xB7EDD0 Offset: 0xB7D3D0 VA: 0x180B7EDD0
	public int FindNearestConnectionIndex(Vector3 position) { }

	// RVA: 0xB81040 Offset: 0xB7F640 VA: 0x180B81040
	public bool SwapTurn() { }

	// RVA: 0xB80910 Offset: 0xB7EF10 VA: 0x180B80910
	public bool RotateConnections() { }

	// RVA: 0xB7EF10 Offset: 0xB7D510 VA: 0x180B7EF10
	public ERRoad GetConnectedRoad(int index, out ConnectedTo connectedTo) { }

	// RVA: 0xB7F980 Offset: 0xB7DF80 VA: 0x180B7F980
	public ERLaneConnector[] GetLaneData(int connectionIndex) { }

	// RVA: 0xB7FA70 Offset: 0xB7E070 VA: 0x180B7FA70
	public ERLaneConnector[] GetLaneData(int connectionIndex, int lane) { }

	// RVA: 0xB7F2E0 Offset: 0xB7D8E0 VA: 0x180B7F2E0
	public int GetConnectionCount() { }

	// RVA: 0xB7EBA0 Offset: 0xB7D1A0 VA: 0x180B7EBA0
	public void AverageNormals(bool flag) { }

	// RVA: 0xB80470 Offset: 0xB7EA70 VA: 0x180B80470
	public bool RecalculateNormals() { }

	// RVA: 0xB80570 Offset: 0xB7EB70 VA: 0x180B80570
	public bool RecalculateTangents() { }

	// RVA: 0xB80670 Offset: 0xB7EC70 VA: 0x180B80670
	public void Refresh() { }

	// RVA: 0xB802B0 Offset: 0xB7E8B0 VA: 0x180B802B0
	public bool IsFlexConnector() { }

	// RVA: 0xB81450 Offset: 0xB7FA50 VA: 0x180B81450
	private static void .cctor() { }

}

