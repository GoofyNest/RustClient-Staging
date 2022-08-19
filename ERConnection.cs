public class ERConnection // TypeDefIndex: 7257
{	// Fields
	public string name; // 0x10
	public ERCrossingPrefabs prefabScript; // 0x18
	public GameObject gameObject; // 0x20
	public ERConnectionData[] connectionData; // 0x28
	public static string str; // 0x0

	// Methods

	// RVA: 0xB80D00 Offset: 0xB7F300 VA: 0x180B80D00
	public void .ctor(GameObject go, string g_name) { }

	// RVA: 0xB7E430 Offset: 0xB7CA30 VA: 0x180B7E430
	public static ERConnection Create(GameObject go) { }

	// RVA: 0xB80330 Offset: 0xB7E930 VA: 0x180B80330
	public void SetPosition(Vector3 pos) { }

	// RVA: 0xB7FA90 Offset: 0xB7E090 VA: 0x180B7FA90
	public string GetName() { }

	// RVA: 0xB802A0 Offset: 0xB7E8A0 VA: 0x180B802A0
	public void SetName(string name) { }

	// RVA: 0xB805F0 Offset: 0xB7EBF0 VA: 0x180B805F0
	public void SetRotation(Vector3 euler) { }

	// RVA: 0xB7E550 Offset: 0xB7CB50 VA: 0x180B7E550
	public void Destroy() { }

	// RVA: 0xB80B20 Offset: 0xB7F120 VA: 0x180B80B20
	public void UnConnect(int connectionIndex) { }

	// RVA: 0xB7EBA0 Offset: 0xB7D1A0 VA: 0x180B7EBA0
	public ERConnectionData[] GetConnectionData() { }

	// RVA: 0xB7F640 Offset: 0xB7DC40 VA: 0x180B7F640
	public Vector3 GetLocalConnectionPosition(int connectionIndex) { }

	// RVA: 0xB7F840 Offset: 0xB7DE40 VA: 0x180B7F840
	public Vector3[] GetLocalConnectionPositions() { }

	// RVA: 0xB7EFB0 Offset: 0xB7D5B0 VA: 0x180B7EFB0
	public Vector3[] GetConnectionWorldPositions() { }

	// RVA: 0xB7EE70 Offset: 0xB7D470 VA: 0x180B7EE70
	public Vector3 GetConnectionWorldPosition(int connectionIndex) { }

	// RVA: 0xB7E640 Offset: 0xB7CC40 VA: 0x180B7E640
	public int FindNearestConnectionIndex(Vector3 position) { }

	// RVA: 0xB808B0 Offset: 0xB7EEB0 VA: 0x180B808B0
	public bool SwapTurn() { }

	// RVA: 0xB80180 Offset: 0xB7E780 VA: 0x180B80180
	public bool RotateConnections() { }

	// RVA: 0xB7E780 Offset: 0xB7CD80 VA: 0x180B7E780
	public ERRoad GetConnectedRoad(int index, out ConnectedTo connectedTo) { }

	// RVA: 0xB7F1F0 Offset: 0xB7D7F0 VA: 0x180B7F1F0
	public ERLaneConnector[] GetLaneData(int connectionIndex) { }

	// RVA: 0xB7F2E0 Offset: 0xB7D8E0 VA: 0x180B7F2E0
	public ERLaneConnector[] GetLaneData(int connectionIndex, int lane) { }

	// RVA: 0xB7EB50 Offset: 0xB7D150 VA: 0x180B7EB50
	public int GetConnectionCount() { }

	// RVA: 0xB7E410 Offset: 0xB7CA10 VA: 0x180B7E410
	public void AverageNormals(bool flag) { }

	// RVA: 0xB7FCE0 Offset: 0xB7E2E0 VA: 0x180B7FCE0
	public bool RecalculateNormals() { }

	// RVA: 0xB7FDE0 Offset: 0xB7E3E0 VA: 0x180B7FDE0
	public bool RecalculateTangents() { }

	// RVA: 0xB7FEE0 Offset: 0xB7E4E0 VA: 0x180B7FEE0
	public void Refresh() { }

	// RVA: 0xB7FB20 Offset: 0xB7E120 VA: 0x180B7FB20
	public bool IsFlexConnector() { }

	// RVA: 0xB80CC0 Offset: 0xB7F2C0 VA: 0x180B80CC0
	private static void .cctor() { }

}

